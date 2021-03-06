using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;
using PCOMMSERVERLib;
using Gore.DeltaTau;
using Gore.MessageBox;
using Gore.Generic;
using Gore.MainProcess;



namespace SleeveSewing
{

    class MotionController: MotionControllerConst, INotifyPropertyChanged
    {
        
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Static Members 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Static Members

        //Singleton Support
        private static MotionController _motionController;
        private static Object _padlock = new Object();
        private static Object _errorLock = new Object();
        
        //NLog Support
        //private static Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        #endregion ~Static Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members
        /////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        private PCOMMSERVERLib.PmacDeviceClass _pmac = new PmacDeviceClass();
       
        private HomedState _homedState = HomedState.MachineNotHomed;

        private Dictionary<int, string> _errorLookup = new Dictionary<int, string>();

        private bool _userAborting = false;

        private Thread _errorMonitorThread;

        private bool _blockErrorThread = false;

        public Recipe _Recipe;

        protected int m_nDeviceNumber = -1;


        #endregion ~Instance Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Constants
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Constants

        private const int PMAC_DEVICE_NUM = 0;

        #endregion ~Constants


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Events
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Events

        public delegate void MotionTaskEventHandler(object sender, MotionTaskEventArgs args);
        public event MotionTaskEventHandler MotionTaskComplete;

        public delegate void MotionErrorEventHandler(object sender, MotionErrorEventArgs args);
        public event MotionErrorEventHandler MotionErrorComplete;

        #endregion ~Events


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Properties
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties

        public static MotionController Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (_motionController == null)
                    {
                        _motionController = new MotionController();
                    }

                    return (_motionController);
                }
            }
        }


        public HomedState HomeState
        {
            get { return _homedState; }
            set
            {
                _homedState = value;
                NotifyPropertyChanged("HomeState");
            }
        }

        public bool UserAbort
        {
          
            get
            {
                lock (_padlock)
                {
                    return _userAborting;
                }
            }
            set
            {
                lock (_padlock)
                {
                    _userAborting = value;
                }
                NotifyPropertyChanged("UserAborting");
            }
        }

        private bool BlockErrorThread
        {
            get
            {
                lock (_errorLock)
                {
                    return (_blockErrorThread);
                }
            }

            set
            {
                lock (_errorLock)
                {
                    _blockErrorThread = value;
                }
            }
        }


        #endregion ~Properties


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Public Methods
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Public Methods

        PmacDeviceClass m_PmacDeviceInstance = new PmacDeviceClass();
        short m_shASCIIMValue = 77;
        short m_shASCIIPValue = 80;

        public void Connect(int DeviceNumber)
        {

            this.OpenPmacDevice(DeviceNumber);
        }

        protected bool OpenPmacDevice(int nDeviceNumber)
        {
            bool bStatus = false;
            try
            {
                m_PmacDeviceInstance.Open(nDeviceNumber, out bStatus);
                if (bStatus)
                {
                    m_nDeviceNumber = nDeviceNumber;

                }
            }
            catch { }

            return bStatus;
        }

        public bool Initialize()
        {
             bool success = false;
             try
             {
                 _pmac.Open(PMAC_DEVICE_NUM, out success);
             }
             catch (Exception ex)
             {
                 //_logger.ErrorException("Initialize", ex);
             }

             if (success == true)
             {
                 InitializeErrorLookup();

                 ClearErrors();

                 success = StartErrorMonitor();
             }
             else
             {
                 //_logger.Error("Failed to Open PMAC");
             }

            return (success);
        }

        public void ResumeErrorMonitor()
        {
            BlockErrorThread = false;
        }

        public void CloseController()
        {
            StopErrorMonitor();
            _pmac.Close(PMAC_DEVICE_NUM);
        }

       
        public bool DoHome()
        {
            bool res = ClearStatusBit(StatusBits.HomeDone);
            if (res == false)
            {
                return (false);
            }
            res = SetControlBit(ControlBits.DoHome);
            if (res == false)
            {
                return (false);
            }

            try
            {
                ControllerTaskInfo cTi = new ControllerTaskInfo(StatusBits.HomeDone);
                res = ThreadPool.QueueUserWorkItem(new WaitCallback(MonitorHomeTask), cTi);
                if (res == true)
                {
                    HomeState = HomedState.MachineHoming;
                }
                return (true);
            }
            catch (Exception ex)
            {
                //_logger.ErrorException("DoHome", ex);
            }

            return (false);

        }


        public bool DoSewLeftSide()
        {

            bool res = ClearStatusBit(StatusBits.SewLeftDone);
            if (res == false)
            {
                return (false);
            }
            res = SetControlBit(ControlBits.SewLeftHead);
            if (res == false)
            {
                return (false);
            }

          
            try
            {
                ControllerTaskInfo cti = new ControllerTaskInfo(StatusBits.SewLeftDone);
                res = ThreadPool.QueueUserWorkItem(new WaitCallback(MonitorControllerTask), cti);
                if (res == true)
                {
                    return (true);
                }
                
            }
            catch (Exception ex)
            {
                //_logger.ErrorException("SewLeftStitch", ex);
            }

            return (false);

        }

        public bool DoSewRightSide()
        {

            bool res = ClearStatusBit(StatusBits.SewRightDone);
            if (res == false)
            {
                return (false);
            }
            
            res = SetControlBit(ControlBits.SewRightHead);
            if (res == false)
            {
                return (false);
            }

            try
            {
                ControllerTaskInfo cti = new ControllerTaskInfo(StatusBits.SewRightDone);
                res = ThreadPool.QueueUserWorkItem(new WaitCallback(MonitorControllerTask), cti);
                if (res == true)
                {
                    return (true);
                }
               
            }
            catch (Exception ex)
            {
                //_logger.ErrorException("SewRightStitch", ex);
            }

            return (false);

        }

        public bool DoLoopOut()
        {
            bool res = ClearStatusBit(StatusBits.LoopOutDone);
            if (res == false)
            {
                return (false);
            }

            res = SetControlBit(ControlBits.DoLoopOut);
            if (res == false)
            {
                return (false);
            }

            try
            {
                ControllerTaskInfo cti = new ControllerTaskInfo(StatusBits.LoopOutDone);
                res = ThreadPool.QueueUserWorkItem(new WaitCallback(MonitorControllerTask), cti);
                if (res == true)
                {
                    return (true);
                }
            }
            catch (Exception ex)
            {
                //_logger.ErrorException("LoopOut", ex);
            }

            return (false);
        }

        public bool DoReturnToStart()
        {

            bool res = ClearStatusBit(StatusBits.MoveToStartDone);
            if (res == false)
            {
                return (false);
            }

            res = SetControlBit(ControlBits.MoveToStart);
            if (res == false)
            {
                return (false);
            }


            try
            {
                ControllerTaskInfo cti = new ControllerTaskInfo(StatusBits.MoveToStartDone);
                res = ThreadPool.QueueUserWorkItem(new WaitCallback(MonitorControllerTask), cti);
                if (res == true)
                {
                    return (true);
                }
            }
            catch (Exception ex)
            {
                //_logger.ErrorException("ReturnToStart", ex);
            }

            return (false);
        }

        public bool DoAbort()
        {
            bool res = SetControlBit(ControlBits.DoAbort);
            if(res == false)
            {
                return(false);
            }

            try
            {
                ControllerTaskInfo cti = new ControllerTaskInfo(StatusBits.AbortDone);
                res = ThreadPool.QueueUserWorkItem(new WaitCallback(MonitorControllerTask), cti);

                if(res == true)
                {
                    UserAbort = true;
                    return(true);
                }
            }
            catch(Exception ex)
            {
                //_logger.ErrorException("DoAbort", ex);
            }

            return(false);
        }


        public bool SetDac(DACSignals signal, int val)
        {
            //Build the Command String
            string mVar = signal.GetVariableName() + "=" + val.ToString();

            string response = string.Empty;
            return(PmacGetResponseEx(mVar, out response));
        }
            

        public bool SetDigitalOutput(DigitalOutputs signal, bool state)
        {
            //Build the Command String 
            string mVarCommand = signal.GetVariableName() + "=";
            if (state == true)
            {
                mVarCommand += "1";
            }
            else
            {
                mVarCommand += "0";
            }

            string response = string.Empty;
            return (PmacGetResponseEx(mVarCommand, out response));
        }


        public bool GetDigitalOutput(DigitalOutputs signal, out bool state)
        {
            //Build the Command String
            string mVarCommand = signal.GetVariableName();

            return (GetIOState(mVarCommand, out state));
        }


        public bool GetDigitalInput(DigitalInputs signal, out bool state)
        {
            //Build the Command String
            string mVarCommand = signal.GetVariableName();

            return (GetIOState(mVarCommand, out state));
        }


        public bool DownloadRecipe(Recipe recipe)
        {
            //Set the Start Position
            bool res = SetPVarDouble(PVariables.StartPosition, Convert.ToDouble(recipe.StartPosition)*10.0);
            if (res == false)
            {
                ShowRecipeDownloadError("Start Position");
                return (false);
            }

            //Set the MiddleGap
            if (Convert.ToBoolean(recipe.IsDualLine) == true)
            {
                res = SetPVarDouble(PVariables.MiddleGap, Convert.ToDouble(recipe.MiddleGap));
                if (res == false)
                {
                    ShowRecipeDownloadError("Middle Gap");
                    return (false);
                }
            }

            //Set the Traverse Feedrate
            res = SetPVarDouble(PVariables.XAxisTraverseFeedRate, Convert.ToDouble(recipe.TraverseFeedrate));
            if (res == false)
            {
                ShowRecipeDownloadError("Traverse Feedrate");
                return (false);
            }

            res = DownloadRecipeForLeftHead(recipe);
            if (res == false)
            {
                return (false);
            }

            res = DownloadRecipeForRightHead(recipe);
            if (res == false)
            {
                return (false);
            }

                      
            return (true);
        }

        public bool DownLoadSettings(MachineParameters settings)
        {
            string message = "Failed download of machine Setting: \n";

            bool res = SetPVarDouble(PVariables.LeftNeedleHomeOffset, settings.LeftNeedleHomeOffset);
            if (res == false)
            {
                ShowError( message + "Left Needle Home Offset");
                return (false);
            }

            res = SetPVarDouble(PVariables.RightNeedleHomeOffset, settings.RightNeedleHomeOffset);
            if (res == false)
            {
                ShowError( message + "Right Needle Home Offset");
                return (false);
            }

            res = SetPVarDouble(PVariables.LooperHomeOffset, settings.LooperHomeOffset);
            if (res == false)
            {
                ShowError(message + "Looper Home Offset");
                return (false);
            }

            res = SetPVarDouble(PVariables.TraverseHomeOffset, settings.TraverseHomeOffset);
            if (res == false)
            {
                ShowError(message + "Traverse Home Offset");
                return (false);
            }

            int val = 0;
            if (settings.ReverseLooperInstalled == true)
            {
                val = 1;
            }

            res = SetPVarInt(PVariables.ReverseLooperInstalled, val);
            if (res == false)
            {
                ShowError(message + "Reverse Looper Installed");
                return (false);
            }

            return (true);
        }

        public void ClearIOForDeviceLoad()
        {
            //On one of the machines 0v left ~40mv on the dac signal DT said it was in spec, I decided to drive it -1v for 0 
            //This signal is the presssure regulator and 40mv is enough for it to try and control pressure
            SetDac(DACSignals.SleeveTension, -81);
            SetDigitalOutput(DigitalOutputs.SleeveTension, false);
            SetDigitalOutput(DigitalOutputs.RightSleeveClamp, false);
            SetDigitalOutput(DigitalOutputs.LeftSleeveClamp, false);

           
            SetDigitalOutput(DigitalOutputs.LeftThreadClamp, false);
            SetDigitalOutput(DigitalOutputs.RightThreadClamp, false);
            SetDigitalOutput(DigitalOutputs.TailStockAdjust, false);
        }




        #endregion ~Public Methods


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Private Methods
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Private Methods

        private bool DownloadRecipeForLeftHead(Recipe recipe)
        {

            //Set the Left Head Fiber Tension
            bool res = SetPVarDouble(PVariables.LeftHeadFiberTension, Convert.ToDouble(recipe.LeftHeadFiberTension));
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Fiber Tension");
                return (false);
            }

            //Set the Left Head Stitch Time Slice 
            res = SetPVarDouble(PVariables.LeftHeadStitchTimeSlice, Convert.ToDouble(((60000.00 * (1.0 / (Convert.ToDouble(recipe.LeftHeadStitchDensity) / 10.0))) / (Convert.ToDouble(recipe.LeftHeadSewingSpeed) * 10)) / 3.0));
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Stitch Time Slice");
                return (false);
            }

            //Set the Left Head Stitch Count
            res = SetPVarDouble(PVariables.LeftHeadStitchCount, Convert.ToDouble(Math.Ceiling((Convert.ToDouble(recipe.LeftHeadMinSewnLength) * 10.0) / (1.0 / (Convert.ToDouble(recipe.LeftHeadStitchDensity) / 10.0))) + 1.0));
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Stitch Count");
                return (false);
            }

            //Set the left head stitch Density
            res = SetPVarDouble(PVariables.LeftHeadStitchLength, 1.0 / (Convert.ToDouble(recipe.LeftHeadStitchDensity) / 10.0));
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Stitch Length");
                return (false);
            }

            //Set the Slow Stitch Time Slice
            res = SetPVarDouble(PVariables.LeftHeadSlowStitchTimeSlice, Convert.ToDouble(recipe.LeftHeadSlowStitchTimeSlice));
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Slow Stitch Time Slice");
                return (false);
            }

            //Set the Slow Stitch Count
            res = SetPVarDouble(PVariables.LeftHeadSlowStitchCount, Convert.ToDouble(recipe.LeftHeadSlowStitchCount));
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Slow Stitch Count");
                return (false);
            }

            // Set the Slow Stitch Ramp Count
            res = SetPVarDouble(PVariables.LeftHeadSlowStitchRampCount, Convert.ToDouble(recipe.LeftHeadSlowStitchRampCount));
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Slow Stitch Ramp Count");
                return (false);
            }


            //set the slow stitch tension scale factor
            res = SetPVarDouble(PVariables.LeftHeadSlowStitchTension, Convert.ToDouble(recipe.LeftHeadSlowStitchTension));
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Slow Stitch Tension");
                return (false);
            }

            //Set the Alternative start tension boolean value
            double val = 0.0;
            if (Convert.ToBoolean(recipe.LeftHeadUseAltTensionForSlowStitches) == true)
            {
                val = 1.0;
            }
            res = SetPVarDouble(PVariables.LeftHeadUseAltStartTension, val);
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Alternate Start Tension");
                return (false);
            }

            //Set the Low Stitch Density Flag
            val = 0;
            if (Convert.ToBoolean(recipe.LeftHeadIsLowStitchDensity) == true)
            {
                val = 1;
            }
            res = SetPVarDouble(PVariables.LeftHeadSewLowStitchDensity, val);
            if (res == false)
            {
                ShowRecipeDownloadError("Left Head Sew Low Stitch Density");
                return (false);
            }

            return (true);
        }

        private bool DownloadRecipeForRightHead(Recipe recipe)
        {

            //Set the Fiber Tension
            bool res = SetPVarDouble(PVariables.RightHeadFiberTension, Convert.ToDouble(recipe.RightHeadFiberTension));
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Fiber Tension");
                return (false);
            }

            //Set the Stitch Time Slice 
            res = SetPVarDouble(PVariables.RightHeadStitchTimeSlice, Convert.ToDouble(((60000.00 * (1.0 / (Convert.ToDouble(recipe.RightHeadStitchDensity) / 10.0))) / (Convert.ToDouble(recipe.RightHeadSewingSpeed) * 10)) / 3.0));
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Stitch Time Slice");
                return (false);
            }

            //Set the Stitch Count
            res = SetPVarDouble(PVariables.RightHeadStitchCount, Convert.ToDouble(Math.Ceiling((Convert.ToDouble(recipe.RightHeadMinSewnLength) * 10.0) / (1.0 / (Convert.ToDouble(recipe.RightHeadStitchDensity) / 10.0))) + 1.0));
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Stitch Count");
                return (false);
            }

            //Set the stitch Density
            res = SetPVarDouble(PVariables.RightHeadStitchLength, 1.0 / (Convert.ToDouble(recipe.RightHeadStitchDensity) / 10.0));
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Stitch Length");
                return (false);
            }

            //Set the Slow Stitch Time Slice
            res = SetPVarDouble(PVariables.RightHeadSlowStitchTimeSlice, Convert.ToDouble(recipe.RightHeadSlowStitchTimeSlice));
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Slow Stitch Time Slice");
                return (false);
            }

            //Set the Slow Stitch Count
            res = SetPVarDouble(PVariables.RightHeadSlowStitchCount, Convert.ToDouble(recipe.RightHeadSlowStitchCount));
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Slow Stitch Count");
                return (false);
            }

            // Set the Slow Stitch Ramp Count
            res = SetPVarDouble(PVariables.RightHeadSlowStitchRampCount, Convert.ToDouble(recipe.RightHeadSlowStitchRampCount));
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Slow Stitch Ramp Count");
                return (false);
            }


            //set the slow stitch tension scale factor
            res = SetPVarDouble(PVariables.RightHeadSlowStitchTension, Convert.ToDouble(recipe.RightHeadSlowStitchTension));
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Slow Stitch Tension");
                return (false);
            }

            //Set the Alternative start tension boolean value
            double val = 0.0;
            if (Convert.ToBoolean(recipe.RightHeadUseAltTensionForSlowStitches) == true)
            {
                val = 1.0;
            }
            res = SetPVarDouble(PVariables.RightHeadUseAltStartTension, val);
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Alternate Start Tension");
                return (false);
            }

            //Set the Low Stitch Density Flag
            val = 0;
            if (Convert.ToBoolean(recipe.RightHeadIsLowStitchDensity) == true)
            {
                val = 1;
            }
            res = SetPVarDouble(PVariables.RightHeadSewLowStitchDensity, val);
            if (res == false)
            {
                ShowRecipeDownloadError("Right Head Low Stitch Density");
                return (false);
            }

            return (true);
        }

        private bool StartErrorMonitor()
        {
            if (_errorMonitorThread == null)
            {
                try
                {
                    _errorMonitorThread = new Thread(new ThreadStart(MonitorErrorThread));
                    _errorMonitorThread.Start();
                }
                catch (Exception ex)
                {
                    //_logger.ErrorException("Start Error Monitor", ex);
                    return (false);
                }
            }

            return (true);
        }

        private void StopErrorMonitor()
        {
            if (_errorMonitorThread != null)
            {
                _errorMonitorThread.Abort();
                _errorMonitorThread.Join();
                _errorMonitorThread = null;
            }
        }


        private bool SetControlBit(ControlBits bit)
        {
            return (PmacSetDPRBit(MACH_CONTROL_0_M7500_ADDR, (int)bit - 1));
        }


        private bool GetControlBit(ControlBits bit, out bool bitState)
        {
            return (PmacGetDPRBit(MACH_CONTROL_0_M7500_ADDR, (int)bit - 1, out bitState));
           
        }


        private bool ClearControlBit(ControlBits bit)
        {
           return(PmacResetDPRBit(MACH_CONTROL_0_M7500_ADDR, (int)bit-1));
        }


        private bool SetStatusBit(StatusBits bit)
        {
            return (PmacSetDPRBit(MACHINE_STATUS_0_M7505_ADDR, (int)bit - 1));
        }


        private bool GetStatusBit(StatusBits bit, out bool bitState)
        {
            return (PmacGetDPRBit(MACHINE_STATUS_0_M7505_ADDR, (int)bit - 1, out bitState));
        }


        private bool ClearStatusBit(StatusBits bit)
        {
            return (PmacResetDPRBit(MACHINE_STATUS_0_M7505_ADDR, (int)bit - 1));
        }


        private bool SetPVarInt(PVariables pvar, int val)
        {
            string message = pvar.GetVariableName() + "=" + val.ToString();

            string response = string.Empty;
            return(PmacGetResponseEx(message, out response));
        }

        private bool SetPVarDouble(PVariables pvar, double val)
        {
            string message = pvar.GetVariableName() + "=" + val.ToString();

            string response = string.Empty;
            return(PmacGetResponseEx(message, out response));
        }


        private bool GetIOState(string command, out bool state)
        {

            state = false;
            string response = string.Empty;
            bool res = PmacGetResponseEx(command, out response);
            if (res == false)
            {
                return (false);
            }

            if (response == "1")
            {
                state = true;
            }
            else
            {
                state = false;
            }

            return (true);
        }

        private bool PmacSetDPRBit(int addressOffset, int bitNumber)
        {

            bool result = false;
            try
            {
                _pmac.DPRSetDWordBit(PMAC_DEVICE_NUM, addressOffset, bitNumber, out result);
            }
            catch (Exception ex)
            {
                //_logger.ErrorException("PmacSetDPRBit", ex);
                return (false);
            }

            return (result);
        }

        private bool PmacGetDPRBit(int addressOffset, int bitNumber, out bool bitState)
        {

            bool result = false;
            bitState = false;
            try
            {
                _pmac.DPRDWordBitSet(PMAC_DEVICE_NUM, addressOffset, bitNumber, out bitState, out result);
            }
            catch (Exception ex)
            {
                //_logger.ErrorException("PmacGetDPRBit", ex);
                return (false);
            }
            return (result);
        }


        private bool PmacResetDPRBit(int addressOffset, int bitNumber)
        {

            bool bitState = false;
            bool res = PmacGetDPRBit(addressOffset, bitNumber, out bitState);
            if (res == false)
            {
                return (false);
            }

            bool result = false;
            if (bitState == true)
            {
                try
                {
                    //performs an X0R on the bit within the Word
                    _pmac.DPRResetDWordBit(PMAC_DEVICE_NUM, addressOffset, bitNumber, out result);
                }
                catch (Exception ex)
                {
                    //_logger.ErrorException("PmacResetDPRBit", ex);
                    return (false);
                }
            }
            else
            {
                return (true);
            }

            return (result);
        }

        private bool PmacGetDPRInt(int addressOffset, out int value)
        {
            bool result = false;
            value = 0;
            try
            {
                _pmac.DPRGetLong(PMAC_DEVICE_NUM, addressOffset, out value, out result);
            }
            catch (Exception ex)
            {
                //_logger.ErrorException("PmacGetDPRInt", ex);
                return (false);
            }

            return (result);
        }


        private bool PmacGetResponseEx(string message, out string response)
        {
            int status = 0;
            response = "";
            try
            {
                _pmac.GetResponseEx(PMAC_DEVICE_NUM, message, false, out response, out status);
            }
            catch (Exception ex)
            {
                //_logger.ErrorException("PmacGetResponseEx", ex);
                return (false);
            }

            //Check the Comm Return Status
            long commstatus = status & 0xF0000000;

            //Check for a valid status
            if (commstatus == 0x80000000)
            {
                response = response.Trim();
                return (true);
            }

            string errorStatus = String.Empty;
            switch (commstatus)
            {
                case 0xC0000000:
                    errorStatus = "Comm Error: TimeOut";
                    break;
                case 0xD0000000:
                    errorStatus = "Comm Error: Bad CheckSum";
                    break;
                case 0xE0000000:
                    errorStatus = "Comm Error: Unable to Communicate";
                    break;
                case 0xF0000000:
                    errorStatus = "Comm Error: Serious Failure";
                    break;
                case 0x70000000:
                    errorStatus = "Comm Error: Any Error";
                    break;
                case 0x10000000:
                    errorStatus = "Comm Error: UnSolicited";
                    break;
                default:
                    errorStatus = "Comm Error: Unknown Error";
                    break;
            }

            //_logger.Error("GetResponseEx: " + errorStatus);
            return (false);
        }


        private void ShowError(string errorMessage)
        {
            string caption = "Error";
            string buttonLabel = "STOP";
            //AlertDialog.Show(caption, errorMessage, buttonLabel);
            //_logger.Error(errorMessage);
        }

        private void ShowRecipeDownloadError(string recipeItem)
        {
            string message = "Failed download of Recipe Value: \n";
            ShowError(message + recipeItem);
        }


        private void InitializeErrorLookup()
        {

            _errorLookup.Add(1, "System Estopped");
            _errorLookup.Add(2, "Initialization Failed");
            _errorLookup.Add(3, "Home Timeout");
           
            _errorLookup.Add(100, "Axis 1 Left Needle Amp Fault");
            _errorLookup.Add(101, "Axis 1 Left Needle Fatal Following Error");
            _errorLookup.Add(102, "Axis 1 Left Needle Negative End Limit");
            _errorLookup.Add(103, "Axis 1 Left needle Positive End Limit");
            _errorLookup.Add(104, "Axis 1 Left Needle I2T Amp Fault");
            _errorLookup.Add(105, "Axis 1 Left Needle Phasing Fault");
            _errorLookup.Add(106, "Axis 1 Left Needle Home Failed");

            _errorLookup.Add(200, "Axis 2 Right Needle Amp Fault");
            _errorLookup.Add(201, "Axis 2 Right Needle Fatal Following Error");
            _errorLookup.Add(202, "Axis 2 Right Needle Negative End Limit");
            _errorLookup.Add(203, "Axis 2 Right needle Positive End Limit");
            _errorLookup.Add(204, "Axis 2 Right Needle I2T Amp Fault");
            _errorLookup.Add(205, "Axis 2 Right Needle Phasing Fault");
            _errorLookup.Add(206, "Axis 2 Right Needle Home Failed");

            _errorLookup.Add(300, "Axis 3 Looper Amp Fault");
            _errorLookup.Add(301, "Axis 3 Looper Fatal Following Error");
            _errorLookup.Add(302, "Axis 3 Looper Negative End Limit");
            _errorLookup.Add(303, "Axis 3 Looper Positive End Limit");
            _errorLookup.Add(304, "Axis 3 Looper I2T Amp Fault");
            _errorLookup.Add(305, "Axis 3 Looper Phasing Fault");
            _errorLookup.Add(306, "Axis 3 Looper Home Failed");

            _errorLookup.Add(400, "Axis 4 Traverse Amp Fault");
            _errorLookup.Add(401, "Axis 4 Traverse Fatal Following Error");
            _errorLookup.Add(402, "Axis 4 Traverse Negative End Limit");
            _errorLookup.Add(403, "Axis 4 Traverse Positive End Limit");
            _errorLookup.Add(404, "Axis 4 Traverse I2T Amp Fault");
            _errorLookup.Add(405, "Axis 4 Traverse Phasing Fault");
            _errorLookup.Add(406, "Axis 4 Traverse Home Failed");
           
        }

        private bool CheckForControllerErrors(out bool hasErrors, List<ControllerError> errorList)
        {
            int errorCode = 0;
            bool res = PmacGetDPRInt(SYS_ERROR_0_M7510_ADDR, out errorCode);
            if (res == true && errorCode != 0)
            {
                errorList.Add(GetError(errorCode));
            }

            res = PmacGetDPRInt(SYS_ERROR_1_M7511_ADDR, out errorCode);
            if (res == true && errorCode != 0)
            {
                errorList.Add(GetError(errorCode));
            }

            res = PmacGetDPRInt(SYS_ERROR_2_M7512_ADDR, out errorCode);
            if (res == true && errorCode != 0)
            {
                errorList.Add(GetError(errorCode));
            }

            res = PmacGetDPRInt(SYS_ERROR_3_M7513_ADDR, out errorCode);
            if (res == true && errorCode != 0)
            {
                errorList.Add(GetError(errorCode));
            }

            res = PmacGetDPRInt(SYS_ERROR_4_M7514_ADDR, out errorCode);
            if (res == true && errorCode != 0)
            {
                errorList.Add(GetError(errorCode));
            }

            if (errorList.Count > 0)
            {
                hasErrors = true;
            }
            else
            {
                hasErrors = false;
            }

            return (true);
        }

        private ControllerError GetError(int errorCode)
        {
            string description = String.Empty;
            bool res = _errorLookup.TryGetValue(errorCode, out description);
            if (res == true)
            {
                return new ControllerError(errorCode, description);
            }
            else
            {
                string message = "ErrorCode = " + errorCode.ToString() + " Unspecified Error";
                return new ControllerError(errorCode,message);
            }
        }

        private bool ClearErrors()
        {
            bool res = SetControlBit(ControlBits.DoErrorReset);
            return (res);    
        }

        public int GetMVariable_E(MVar MVar)
        {
            if (DeltaTau.Simulation) { return 0; }

            int nValue = 0;
            if (!this.GetMVariable(MVar.Number, out nValue))
            {
                throw new Exception();
            }

            return nValue;
        }

        public bool GetMVariable(int nMVariable, out int nValue)
        {
            if (m_nDeviceNumber == -1)
            {
                nValue = -1;
                return false;
            }

            bool bStatus;
            double dValue;
            m_PmacDeviceInstance.GetVariableDouble(m_nDeviceNumber, m_shASCIIMValue, nMVariable, 0, out dValue, out bStatus);
            nValue = Convert.ToInt32(dValue);
            return bStatus;
        }

        public void SetMVariable_E(MVar MVar, int nValue)
        {
            if (DeltaTau.Simulation) { return; }

            if (!this.SetMVariable(MVar.Number, nValue))
            {
                throw new Exception();
            }
        }

        public bool SetMVariable(int nMVariable, int nValue)
        {
            if (m_nDeviceNumber == -1)
                return false;

            bool bStatus;
            m_PmacDeviceInstance.SetVariableDouble(m_nDeviceNumber, m_shASCIIMValue, nMVariable, Convert.ToDouble(nValue), out bStatus);
            return bStatus;
        }


        /////////////////////////////////////////////////////////////////////
        // SetPVariable_E
        /////////////////////////////////////////////////////////////////////
        public void SetPVariable_E(PVar PVar, int nValue)
        {
            if (DeltaTau.Simulation) { return; }

            if (!this.SetPVariable(PVar.Number, nValue))
            {
                throw new Exception();
            }
        }


        /////////////////////////////////////////////////////////////////////
        // SetPVariableDouble_E
        /////////////////////////////////////////////////////////////////////
        public void SetPVariableDouble_E(PVar PVar, double dValue)
        {
            if (DeltaTau.Simulation) { return; }

            if (!this.SetPVariableDouble(PVar.Number, dValue))
            {
                throw new Exception();
            }
        }


        /////////////////////////////////////////////////////////////////////
        // GetPVariableDouble_E
        /////////////////////////////////////////////////////////////////////
        public double GetPVariableDouble_E(PVar PVar)
        {
            if (DeltaTau.Simulation) { return 0.0; }

            double dValue = 0.0;
            if (!this.GetPVariableDouble(PVar.Number, out dValue))
            {
                throw new Exception();
            }

            return dValue;
        }


        /////////////////////////////////////////////////////////////////////
        // GetPVariable_E
        /////////////////////////////////////////////////////////////////////
        public int GetPVariable_E(PVar PVar)
        {
            if (DeltaTau.Simulation) { return 0; }

            int nValue = 0;
            if (!this.GetPVariable(PVar.Number, out nValue))
            {
                throw new Exception();
            }

            return nValue;
        }


        /////////////////////////////////////////////////////////////////////
        // SetPVariable
        /////////////////////////////////////////////////////////////////////
        public bool SetPVariable(int nPVariable, int nValue)
        {
            if (m_nDeviceNumber == -1)
                return false;

            bool bStatus;
            m_PmacDeviceInstance.SetVariableDouble(m_nDeviceNumber, m_shASCIIPValue, nPVariable, Convert.ToDouble(nValue), out bStatus);

            return bStatus;
        }


        /////////////////////////////////////////////////////////////////////
        // SetPVariableDouble
        /////////////////////////////////////////////////////////////////////
        public bool SetPVariableDouble(int nPVariable, double dValue)
        {
            if (m_nDeviceNumber == -1)
                return false;

            bool bStatus;
            m_PmacDeviceInstance.SetVariableDouble(m_nDeviceNumber, m_shASCIIPValue, nPVariable, dValue, out bStatus);

            return bStatus;
        }


        /////////////////////////////////////////////////////////////////////
        // GetPVariableDouble
        /////////////////////////////////////////////////////////////////////
        public bool GetPVariableDouble(int nPVariable, out double dValue)
        {
            if (m_nDeviceNumber == -1)
            {
                dValue = 0;
                return false;
            }

            bool bStatus;
            m_PmacDeviceInstance.GetVariableDouble(m_nDeviceNumber, m_shASCIIPValue, nPVariable, 0, out dValue, out bStatus);

            return bStatus;
        }


        /////////////////////////////////////////////////////////////////////
        // GetPVariable
        /////////////////////////////////////////////////////////////////////
        public bool GetPVariable(int nPVariable, out int nValue)
        {
            nValue = 0;

            if (m_nDeviceNumber == -1)
            {
                return false;
            }

            bool bStatus;
            double dValue;
            m_PmacDeviceInstance.GetVariableDouble(m_nDeviceNumber, m_shASCIIPValue, nPVariable, 0, out dValue, out bStatus);
            if (bStatus)
            {
                try
                {
                    nValue = Convert.ToInt32(dValue);
                }
                catch
                {
                    bStatus = false;
                }
            }

            return bStatus;
        }


        #endregion ~Private Methods


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Threading Support
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Threading Support

        private void MonitorControllerTask(Object taskInfo)
        {
            //Grab the Controller Task Info 
            ControllerTaskInfo controllerTaskInfo = (ControllerTaskInfo)taskInfo;
            Thread.Sleep(500);

            List<ControllerError> controllerErrors = new List<ControllerError>();
            bool hasError = false;
            bool monitorBit = false;
            while (monitorBit == false && hasError == false && UserAbort == false)
            {
                //Check for the status bit
                GetStatusBit(controllerTaskInfo.StatusBitToMonitor, out monitorBit);

                //Check for Errors
                CheckForControllerErrors(out hasError, controllerErrors);

                Thread.Sleep(100);
            }

            if (UserAbort == true)
            {
                OnMotionTaskComplete(new MotionTaskEventArgs(false, controllerTaskInfo.StatusBitToMonitor.ToString()));
                UserAbort = false;
                HomeState = HomedState.MachineNotHomed;
                
            }
            else
            {
                if (hasError == true)
                {
                    OnMotionErrorComplete(new MotionErrorEventArgs(controllerErrors));
                }
                else
                {
                    if (controllerTaskInfo.StatusBitToMonitor != StatusBits.AbortDone)
                    {
                        OnMotionTaskComplete(new MotionTaskEventArgs(true, controllerTaskInfo.StatusBitToMonitor.ToString()));
                    }
                }
            }

        }

        private void MonitorHomeTask(Object taskInfo)
        {

            //Grab the Controller Task Info 
            ControllerTaskInfo controllerTaskInfo = (ControllerTaskInfo)taskInfo;
            Thread.Sleep(500);

            //Set up the Timeout As 2.0 Minutes for the Home To Finish
            DateTime timeInFuture = DateTime.Now;
            timeInFuture = timeInFuture.AddMinutes(2.0);
            ;//DateTime.Now < timeInFuture)

            bool monitorBit = false;
            List<ControllerError> controllerErrors = new List<ControllerError>();
            bool hasError = false;
            bool homeTimeout = false;
            while (monitorBit == false && hasError == false && homeTimeout == false)
            {
                //Check for the status bit
                GetStatusBit(controllerTaskInfo.StatusBitToMonitor, out monitorBit);

                //Check for Errors
                CheckForControllerErrors(out hasError, controllerErrors);

                //Check for the Home Timeout
                if (DateTime.Now > timeInFuture && monitorBit == false)
                {
                    homeTimeout = true;
                }

                Thread.Sleep(100);
            }

            //Check for the Home Timeout or Error Condition from the Controller
            if (homeTimeout == true || hasError == true)
            {
                HomeState = HomedState.MachineNotHomed;

                if (homeTimeout == true)
                {
                    //Add the HomeTimeout Error and Pump the ErrorComplete Event
                    controllerErrors.Add(GetError(3));
                    OnMotionErrorComplete(new MotionErrorEventArgs(controllerErrors));

                }
                else
                {
                    //Pump the ErrorComplete Event
                    OnMotionErrorComplete(new MotionErrorEventArgs(controllerErrors));
                }
            }
            else
            {
                //monitorBit has to be true
                HomeState = HomedState.MachineHomed;
            }
           
        }

        private void OnMotionTaskComplete(MotionTaskEventArgs args)
        {
            if (MotionTaskComplete != null)
            {
                MotionTaskComplete(this, args);
            }
        }

        private void OnMotionErrorComplete(MotionErrorEventArgs args)
        {
            if (MotionErrorComplete != null)
            {
                MotionErrorComplete(this, args);
                ClearErrors();

            }
        }


        private void MonitorErrorThread()
        {

            try
            {
                List<ControllerError> controllerErrors = new List<ControllerError>();
                bool hasError = false;

                while (true)
                {
                    if (BlockErrorThread == true)
                    {
                        Thread.Sleep(500);
                    }
                    else
                    {
                        //Check for Errors
                        CheckForControllerErrors(out hasError, controllerErrors);
                        if (hasError == true)
                        {
                            //Pump the ErrorComplete Event
                            OnMotionErrorComplete(new MotionErrorEventArgs(controllerErrors));
                            controllerErrors.Clear();
                            HomeState = HomedState.MachineNotHomed;
                            BlockErrorThread = true;
                        }
                        Thread.Sleep(200);

                    }
                }
            }
            catch (ThreadAbortException)
            {

                //_logger.Info("ErrorMonitorThread Aborted");
            }
        }



        #endregion ~Threading Support


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          INotifyPropertyChanged Interface Support
        //////////////////////////////////////////////////////////////////////////////////////////
        #region INotifyPropertyChanged

        //Property Changed Event
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// <para>Raises the Property Changed Event Passing the source property that is updating</para>
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion ~INotifyPropertyChanged   

    }
}
