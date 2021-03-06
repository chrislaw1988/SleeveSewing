using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Collections.ObjectModel;

using Gore.MainProcess;
using Gore.MessageBox;
using Gore.UserAccess;
using Gore.Generic;
using Gore.FaultHandling;
using Gore.ProcessControlBase;
using Gore.Motor;
using Gore.ProcessFlowRFID;
using Gore.MachineManager;
using Gore.Config.ViewModels;
using Gore.RecipeManager;
using System.Security.Cryptography.X509Certificates;

namespace SleeveSewing
{
    class ProcessControl : ProcessControlBase
    {
        public Recipe Recipe = null; 
        public SewingProcess _sewProcess = new SewingProcess();
        public int step;
        public bool isLoaded;
        public bool backButtonPressed;
        public bool cycleCompleted;
        public bool cycleAborted;


        MachineParameters settings = new MachineParameters();
        

        MotionController _motionController = Globals.MotionController;
        SewingStateBase _sewingStateBase;

        protected override void ValidateMachineParametersForMachineReset()
        {
            // Do nothing until we have Machine Parameters that are used in the reset.
        }

        protected override void MachineResetStarted(ref bool Abort)
        {
            Exception ex = null;

            // Stop Alarm monitoring.
            FaultHandling.Globals.StopAlarmMonitoring();

            MainProcess.ThrowExceptionIfAborted_E(ref Abort);
            MainProcess.Status.ProcessStatus = "Connecting to Database...";
            try
            {
                Globals.ProcessControl.ConnectToDatabase(Globals.MachineParameters.DCLocation);
            }
            catch (Exception e) { if (ex == null) ex = e; }

            MainProcess.ThrowExceptionIfAborted_E(ref Abort);
            MainProcess.Status.ProcessStatus = "Connecting to Motion Controller...";

            bool lo = false;
            try
            {
                Globals.MotionController.Connect(0);
                lo=Globals.MotionController.Initialize();

            }
            catch (Exception e) { if (ex == null) ex = e; }

            if (!lo) { MainProcess.Status.ProcessStatus = "Failed to initialize..."; }

            MainProcess.Status.ProcessStatus = "Downloading Machine Parameters...";

            MotionController.Instance.DownLoadSettings(settings);

            MainProcess.ThrowExceptionIfAborted_E(ref Abort);
            MainProcess.Status.ProcessStatus = "Connecting to RFID Controller...";
            try
            {
                try
                {
                    SgmsRfid.Disconnect();
                }
                catch { }

                Application.Current.Dispatcher.Invoke(() =>
                {
                    if (!ProcessFlowRFID.Simulation.RFID_Controller.IsSimulating)
                    {
                        SgmsRfid.Connect(Globals.MachineParameters.MaxHeadCount, Globals.MachineParameters.RfidIpAddress, true);
                    }
                });
            }
            catch (Exception e) { if (ex == null) ex = e; }

            MainProcess.ThrowExceptionIfAborted_E(ref Abort);
            /*
            MainProcess.Status.ProcessStatus = "Connecting to Barcode Reader...";
            try
            {
                try
                {
                    Globals.DataManReader.Disconnect();
                }
                catch { }
                Globals.DataManReader.Connect("10.10.10.11");
            }
            catch (Exception e) { if (ex == null) ex = e; }

            if (ex != null) { throw ex; }
            */

            FaultHandling.Globals.StartAlarmMonitoring();

            MachineManager.Bindings.IsUnlocked = false;
        }

        protected override void ValidateMachineParametersForHome()
        {
            // Validate Machine Velocity since it's passed down to the controller.
            Globals.MachineParameters.ValidateMachineVelocity_E();
        }

        protected override void HomeStarted(ref bool Abort)
        {
            Globals.Messages.AddMessage("Homing...");
            bool res = MotionController.Instance.DoHome();
        }

        protected override bool CanStartCycle()
        {
            Globals.ProcessControl.cycleCompleted = false;
            Globals.ProcessControl.cycleAborted = false;
            return true;
        }

        protected override void CycleStarted(ref bool Abort, ref bool Stop, out bool ReachedPointOfNoReturn)
        {
            ReachedPointOfNoReturn = false;
            if (!Globals.ProcessControl.cycleCompleted && !Globals.ProcessControl.cycleAborted)
            {
                
                Globals.ProcessControl.step = 0;
                Globals.ProcessControl.isLoaded = false;

                while (!Globals.ProcessControl.isLoaded && !Globals.ProcessControl.cycleAborted)
                {
                    if (Globals.ProcessControl.step == 0 && !Globals.ProcessControl.cycleAborted)
                    {
                        // Prompt to load fiber into head, please press continue
                        PromptLoadFiberToHead(ref Abort);
                        Globals.ProcessControl.cycleAborted = Abort;

                        if (!Globals.ProcessControl.backButtonPressed)
                        {
                            Globals.ProcessControl.step++;
                        }

                        Globals.ProcessControl.backButtonPressed = false;
                    }


                    if (Globals.ProcessControl.step == 1 && !Globals.ProcessControl.cycleAborted)
                    {
                        //Left Sleeve Clamp Off, for backing rerun
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.LeftSleeveClamp, false);

                        //Prompt to place sleeve to the left clamp, please press continue
                        PromptPlaceSleeveToLeftClamp(ref Abort);
                        Globals.ProcessControl.cycleAborted = Abort;

                        if (!Globals.ProcessControl.backButtonPressed)
                        {
                            Globals.ProcessControl.step++;
                        }

                        Globals.ProcessControl.backButtonPressed = false;
                    }

                    if (Globals.ProcessControl.step == 2 && !Globals.ProcessControl.cycleAborted)
                    {
                        //For backing rerun
                        //UnLock The Slide
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.TailStockAdjust, false);

                        //UnClamp the Sleeve
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.RightSleeveClamp, false);

                        //Remove Tension The Sleeve
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.SleeveTension, false);
                        MotionController.Instance.SetDac(MotionControllerConst.DACSignals.SleeveTension, 0);

                        //Left Sleeve Clamp On
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.LeftSleeveClamp, true);

                        //Prompt to place sleeve to the right clamp, please press continue
                        PromptPlaceSleeveToRightClamp(ref Abort);
                        Globals.ProcessControl.cycleAborted = Abort;

                        if (!Globals.ProcessControl.backButtonPressed)
                        {
                            Globals.ProcessControl.step++;
                        }

                        Globals.ProcessControl.backButtonPressed = false;
                    }

                    if (Globals.ProcessControl.step == 3 && !Globals.ProcessControl.cycleAborted)
                    {
                        //For backing rerun

                        //Right Thread Clamp Off
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.RightThreadClamp, false);
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.LeftThreadClamp, false);

                        //Lock The Slide
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.TailStockAdjust, true);

                        //Clamp the Sleeve
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.RightSleeveClamp, true);

                        //Tension The Sleeve
                        int t = Int16.Parse(Recipe.Tension);
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.SleeveTension, true);
                        MotionController.Instance.SetDac(MotionControllerConst.DACSignals.SleeveTension, t);

                        //Prompt to thread fiber to clamp, please press continue
                        ThreadFiberToClamp(ref Abort);
                        Globals.ProcessControl.cycleAborted = Abort;
                        if (!Globals.ProcessControl.backButtonPressed)
                        {
                            Globals.ProcessControl.step++;
                        }

                        Globals.ProcessControl.backButtonPressed = false;
                    }

                    if (Globals.ProcessControl.step == 4 && !Globals.ProcessControl.cycleAborted)
                    {
                        //Right Thread Clamp On
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.RightThreadClamp, true);
                        MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.LeftThreadClamp, true);

                        //Prompt to start sewing, please press continue
                        PromptStartSewing(ref Abort);
                        Globals.ProcessControl.cycleAborted = Abort;

                        if (!Globals.ProcessControl.backButtonPressed)
                        {
                            Globals.ProcessControl.step++;
                        }

                        Globals.ProcessControl.backButtonPressed = false;

                    }

                    if (Globals.ProcessControl.step == 5 && !Globals.ProcessControl.cycleAborted)
                    {
                        Globals.ProcessControl.isLoaded = true;
                        Globals.ProcessControl.step = 0;
                    }

                }

                if (Recipe != null && !Globals.ProcessControl.cycleAborted)
                {

                    //DownLoad the Recipe
                    bool lo = MotionController.Instance.DownloadRecipe(Recipe);

                    //CL: For debug only!! Remove comment after debugging
                    /*
                    if (lo == false)
                    {
                        Globals.Messages.AddMessage("Recipe \"" + Recipe.Name + "\"error.");
                        return;
                    }
                    */

                    // Recipe Running.
                    Globals.Messages.AddMessage("Recipe \"" + Recipe.Name + "\" Running.");

                    ReachedPointOfNoReturn = true;

                }

                if (!Globals.ProcessControl.cycleAborted)
                {
                    // Recipe Running.
                    Globals.Messages.AddMessage("Recipe \"" + Recipe.Name + "\" Running.");

                    _sewProcess.Start();

                    
                    while (_sewProcess.State != _sewProcess.ReturnToStartState)
                    {
                        //wait for sewprocess to finish the cycle

                    }
                    
                    

                    //Prompt to payout deployment line, please press continue
                    PromptPayoutFiber(ref Abort);
                    Globals.ProcessControl.cycleAborted = Abort;

                    bool val = MotionController.Instance.DoReturnToStart();
                    if (val == false)
                    {

                    }

                    //On one of the machines 0v left ~40mv on the dac signal DT said it was in spec, I decided to drive it -1v for 0 
                    //This signal is the presssure regulator and 40mv is enough for it to try and control pressure
                    MotionController.Instance.SetDac(MotionControllerConst.DACSignals.SleeveTension, -81);

                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.SleeveTension, false);
                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.RightSleeveClamp, false);
                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.LeftSleeveClamp, false);

                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.RightThreadClamp, false);
                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.LeftThreadClamp, false);
                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.TailStockAdjust, false);

                    


                    Globals.Messages.AddMessage("Recipe \"" + Recipe.Name + "\" Complete.");

                    Globals.ProcessControl.cycleCompleted = true;
                }
                else
                {
                    //On one of the machines 0v left ~40mv on the dac signal DT said it was in spec, I decided to drive it -1v for 0 
                    //This signal is the presssure regulator and 40mv is enough for it to try and control pressure
                    MotionController.Instance.SetDac(MotionControllerConst.DACSignals.SleeveTension, -81);

                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.SleeveTension, false);
                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.RightSleeveClamp, false);
                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.LeftSleeveClamp, false);

                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.RightThreadClamp, false);
                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.LeftThreadClamp, false);
                    MotionController.Instance.SetDigitalOutput(MotionControllerConst.DigitalOutputs.TailStockAdjust, false);
                }

            }
            
        }

        protected override void CleanupCycle(ProcessResult_Enum ProcessResult)
        {
            Exception CleanupException = null;

            if(ProcessResult != ProcessResult_Enum.Normal)
            {
                Globals.Messages.AddMessage($"Recipe \"{Recipe.Name}\" {ProcessResult.ToString()}.");
            }

            //CycleCleanup(CleanupException);

            if (CleanupException != null)
            {
                throw CleanupException;
            }
        }

         
        protected override void MoveToUnloadAndUnlock(ref bool Abort, ProcessResult_Enum ProcessResult)
        {
            // If something not normal happens, make sure to prompt to cut film so we can move to an unload position.
            if (ProcessResult != ProcessResult_Enum.Normal)
            {
                try
                {
                    //PromptCutFilm_E(ref Abort);
                }
                catch { }
            }

            try
            {
                // Try to move back to the start position for tact time, otherwise, just move home.
                MainProcess.Status.ProcessStatus = "Moving to Unload Position.";

                // Move home.
                //Globals.MotionController.DoHome();
                
            }
            catch (Exception ex)
            {
                try
                {
                    // Abort motion.  Leave motors enabled.
                    //Globals.MotionController.DoAbort();
                }
                catch { }

                MessageBoxEx.ShowError(ex, "Failed to move to the unload position.");
            }

            // Turn off abort since we passed the moves.
            MainProcess.Status.AbortButton_IsEnabled = false;

        }
       

        
        /////////////////////////////////////////////////////////////////////
        // CycleCleanup
        /////////////////////////////////////////////////////////////////////
        void CycleCleanup(Exception CleanupException)
        {
            // Try catch everything seperately so we make sure we perform each cleanup task.

            // Stop any motion programs (including the wrap).
            try
            {
               // Globals.MotionController.DoAbort();
            }
            catch (Exception ex) { if (CleanupException == null) { CleanupException = ex; } }

            // Kill all motors so they are not enabled.
            try
            {
                Globals.MotionController.CloseController();
            }
            catch (Exception ex) { if (CleanupException == null) { CleanupException = ex; } }

            // Kill Wrap PLC.
            try
            {
                
            }
            catch (Exception ex) { if (CleanupException == null) { CleanupException = ex; } }
        }

    
        /////////////////////////////////////////////////////////////////////
        // CheckForHomeError_E
        /////////////////////////////////////////////////////////////////////
        void CheckForHomeError_E()
        {

            if (_motionController.HomeState.Equals(1))
            {
                _sewingStateBase.ShowError("Machine is not able to be homed");
            }
            

            
        }


        /////////////////////////////////////////////////////////////////////
        // AbortAxes
        /////////////////////////////////////////////////////////////////////
        void AbortAxes(Exception CleanupException)
        {
            try
            {
                // Abort Coordinate System motion, then wait for the PLC to finish.
               // _motionController.DoAbort();
                
            }
            catch (Exception ex) { if (CleanupException == null) { CleanupException = ex; } }
        }

        public void AbortProcess()
        {
            MainProcess.AbortProcess();
        }


        /////////////////////////////////////////////////////////////////////
        // PromptLoadRFID
        /////////////////////////////////////////////////////////////////////
        void PromptLoadRFID(ref bool Aborted)
        {
            // Prompt.
            WaitForOperatorTaskAcknowledge("Please insert RFID...", "Insert RFID", "Loading RFID", true);
        }

        /////////////////////////////////////////////////////////////////////
        // PromptLoadFiberToHead
        /////////////////////////////////////////////////////////////////////
        void PromptLoadFiberToHead(ref bool Aborted)
        {
            MainProcess.StartNeedsAttention("Thread fiber into head, needle if neccesary.\nPress Continue when complete.", MainProcess.ProcessStatusColor_Enum.NeedsAttention);

            //show continue button
            MainProcess.Status.WaitingForOperatorTaskAck = true;
            
            
            Wait.WaitWhileCondition(() => { return MainProcess.Status.WaitingForOperatorTaskAck && !Globals.ProcessControl.backButtonPressed; }, true, ref Aborted);

            MainProcess.Status.WaitingForOperatorTaskAck = false;
            MainProcess.StopNeedsAttention();

            // Prompt.
            //WaitForOperatorTaskAcknowledge("Thread fiber into head, needle if neccesary.\nPress Continue when complete.", "Load Fiber to Head", "Running Fiber to Head", true);
        }

        /////////////////////////////////////////////////////////////////////
        // PromptPlaceSleeveToLeftClamp
        /////////////////////////////////////////////////////////////////////
        void PromptPlaceSleeveToLeftClamp(ref bool Aborted)
        {
            MainProcess.StartNeedsAttention("Place non-angle sleeve end into the left clamp.\nPress Continue when complete.", MainProcess.ProcessStatusColor_Enum.NeedsAttention);

            //show continue button
            MainProcess.Status.WaitingForOperatorTaskAck = true;


            Wait.WaitWhileCondition(() => { return MainProcess.Status.WaitingForOperatorTaskAck && !Globals.ProcessControl.backButtonPressed; }, true, ref Aborted);

            MainProcess.Status.WaitingForOperatorTaskAck = false;
            MainProcess.StopNeedsAttention();
            // Prompt.
            //WaitForOperatorTaskAcknowledge("Place non-angle sleeve end into the left clamp.\nPress Continue when complete.", "Load sleeve to clamp", "Running sleeve to clamp", true);
        }

        /////////////////////////////////////////////////////////////////////
        // PromptPlaceSleeveToRightClamp
        /////////////////////////////////////////////////////////////////////
        void PromptPlaceSleeveToRightClamp(ref bool Aborted)
        {
            MainProcess.StartNeedsAttention("Place angled sleeve end into the right clamp.\nPress Continue when complete.", MainProcess.ProcessStatusColor_Enum.NeedsAttention);

            //show continue button
            MainProcess.Status.WaitingForOperatorTaskAck = true;


            Wait.WaitWhileCondition(() => { return MainProcess.Status.WaitingForOperatorTaskAck && !Globals.ProcessControl.backButtonPressed; }, true, ref Aborted);

            MainProcess.Status.WaitingForOperatorTaskAck = false;
            MainProcess.StopNeedsAttention();

            // Prompt.
            //WaitForOperatorTaskAcknowledge("Place angled sleeve end into the right clamp.\nPress Continue when complete.", "Load sleeve to clamp", "Running sleeve to clamp", true);
        }

        /////////////////////////////////////////////////////////////////////
        // ThreadFiberToClamp
        /////////////////////////////////////////////////////////////////////
        void ThreadFiberToClamp(ref bool Aborted)
        {

            MainProcess.StartNeedsAttention("Thread fiber into clamp.\nPress Continue when complete.", MainProcess.ProcessStatusColor_Enum.NeedsAttention);

            //show continue button
            MainProcess.Status.WaitingForOperatorTaskAck = true;


            Wait.WaitWhileCondition(() => { return MainProcess.Status.WaitingForOperatorTaskAck && !Globals.ProcessControl.backButtonPressed; }, true, ref Aborted);

            MainProcess.Status.WaitingForOperatorTaskAck = false;
            MainProcess.StopNeedsAttention();
            // Prompt.
            //WaitForOperatorTaskAcknowledge("Thread fiber into clamp.\nPress Continue when complete.", "Load fiber to clamp", "Running fiber to clamp", true);
        }

        /////////////////////////////////////////////////////////////////////
        // PromptStartSewing
        /////////////////////////////////////////////////////////////////////
        void PromptStartSewing(ref bool Aborted)
        {
            MainProcess.StartNeedsAttention("Press Continue to start sewing.", MainProcess.ProcessStatusColor_Enum.NeedsAttention);

            //show continue button
            MainProcess.Status.WaitingForOperatorTaskAck = true;


            Wait.WaitWhileCondition(() => { return MainProcess.Status.WaitingForOperatorTaskAck && !Globals.ProcessControl.backButtonPressed; }, true, ref Aborted);

            MainProcess.Status.WaitingForOperatorTaskAck = false;
            MainProcess.StopNeedsAttention();

            // Prompt.
            //WaitForOperatorTaskAcknowledge("Press Continue to start sewing", "Ready to sew", "Running sewing", true);
        }

        public void PromptPayoutFiber(ref bool Aborted)
        {
            // Prompt.
            WaitForOperatorTaskAcknowledge("Payout fiber, press Continue to finish cycle", "Ready to sew", "Running sewing", true);
            Globals.ProcessControl.cycleAborted = Aborted;
        }


        /////////////////////////////////////////////////////////////////////
        // FindBarcode_E
        /////////////////////////////////////////////////////////////////////
        protected void FindBarcode_E(
            out string Barcode,
            ref bool Cancel,
            bool MoveToFoundPosition = false
            )
        {
            // Read in place (before moving).
            string FoundBarcode = Globals.DataManReader.Read_Sync(() => { return MainProcess.IsProcessAborted(); });
            if (!String.IsNullOrEmpty(FoundBarcode))
            {
                Barcode = FoundBarcode;
                return;
            }

            try
            {
                // Start the reader continuously reading
                Globals.DataManReader.Read_Async(Gore.Cognex.DataManTriggerType.Continuous);
                
                
                // Did we read anything?
                if (!Globals.DataManReader.ResultReceived)
                {
                    throw new Exception("Cannot find barcode.");
                }

                // Get the current position and barcode
               
                Barcode = Globals.DataManReader.Result;
            }
            finally
            {
                // Always stop the rotary.
                try
                {
                   
                }
                catch { }

                // Always stop the reader.
                try
                {
                    Globals.DataManReader.ReaderOff();
                }
                catch { }
            }

        }
        

        /////////////////////////////////////////////////////////////////////
        // Overrides
        /////////////////////////////////////////////////////////////////////

        public override DataEntryObjectsViewModel GetDataEntryObjectsViewModel()
        {
            return new DataEntryObjectsViewModel()
            {
                ActiveDirectorySettingsViewModel = Globals.MachineParameters.ActiveDirectorySettingsViewModel,
                RejectCodePrompt = Globals.MachineParameters.RejectCodePrompt,
                Items = dataEntryItems?.Items
            };
        }

        protected override void GetMachineType(out string machineType)
        {
            machineType = Globals.MachineParameters.MachineType;
        }

        protected override void GetEndpointName(out string endpointName)
        {
            endpointName = Globals.MachineParameters.EndpointName;
        }
    }
}