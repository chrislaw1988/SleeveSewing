using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Win32;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Linq;

using Gore.UserAccess;
using Gore.MessageBox;
using Gore.Generic;
using Gore.RecipeManager;
using Gore.MachineManager;
using Gore.MainProcess;
using Gore.FaultHandling;
using Gore.ProcessFlowRFID;
using Gore.Generic.ProcessEx;
using Gore.Generic.Policies;
using Gore.MainProcess.SubProcess;
using Gore.Cognex;
using Gore.ProcessControlBase;

namespace SleeveSewing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Recipe Recipe = null;
        ProcessControl Process = new ProcessControl();

        bool ExitButtonClicked = false;
        bool RebootPCOnClosing = false;

        List<Fault> Faults = new List<Fault>();

        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        SewingProcess _sewProcess = null;
        SewingStateBase State = null;


        #endregion ~Instance Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction

        public MainWindow()
        {
            _sewProcess = new SewingProcess();
            InitializeComponent();

        }

        #endregion ~Construction

        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Properties 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties

        public SewingProcess SewProcess
        {
            get { return _sewProcess; }
        }


        #endregion Properties


        /////////////////////////////////////////////////////////////////////
        // MainWindow
        /////////////////////////////////////////////////////////////////////
        public MainWindow(App app)
        {
            try
            {
                // Window.
                app.UpdateSplashScreenStatus("Initializing MainWindow...");
                {
                    _sewProcess = new SewingProcess();
                    InitializeComponent();

                    // Increase the tooltip duration so we can read them (some are long).
                    ToolTipService.ShowDurationProperty.OverrideMetadata(typeof(DependencyObject), new FrameworkPropertyMetadata(60000));

                    // For some reason this speeds up the UI.  We are setting ItemsSource directly rather than binding to it in xaml.
                    MachineStatus_ListBox.ItemsSource = Globals.Messages;

                    // Setup the Messages List Box FIRST so it's ready for status messages.  Must happen when the list box is a window.
                    Globals.Messages.SetBindingListBox(MachineStatus_ListBox);
                }

                // Machine Parameters.
                app.UpdateSplashScreenStatus("Initializing Settings...");
                MachineManager.ParametersLoadedEvent += new MachineManager.ParametersLoadedEventHandler(OnParametersLoaded);
                MachineManager.ParametersUnlockedEvent += new MachineManager.ParametersUnlockedEventHandler(ParametersUnlocked);
                MachineManager.Initialize(Globals.MachineParameters, MachineParameters_Grid);

                // Recipe.
                app.UpdateSplashScreenStatus("Initializing Recipes...");
                RecipeManager.RecipeSelectionChangedEvent += new RecipeManager.RecipeSelectionChangedEventHandler(OnRecipeSelectionChanged);
                RecipeManager.Initialize(new Recipe(), Recipe_Grid);

                // load runtime
                Globals.MainWindowViewModel.KeyValueObjectsViewModel.LoadItem();

                // Alarms.
                app.UpdateSplashScreenStatus("Initializing Alarms...");
                FaultHandling.FaultActiveChangedEvent += new FaultHandling.FaultActiveChangedEventHandler(OnFaultActiveChanged);
                FaultHandling.AlarmMonitoringStartedEvent += new FaultHandling.AlarmMonitoringStartedEventHandler(OnAlarmMonitoringStarted);
                FaultHandling.InitializeFaults();
                FaultHandling.InitializeWarnings();
                SetupAlarms();
                

                // Process.
                app.UpdateSplashScreenStatus("Initializing Process...");
                MainProcess.Initialize(false, false, true, true, true, false);
                ProcessFlowRFID.Initialize();
                Globals.ProcessControl.Initialize(true, true, true, true, true);

                //Hook Up the Event handlers
                MotionController.Instance.MotionTaskComplete += new MotionController.MotionTaskEventHandler(MotionController_MotionTaskComplete);
                MotionController.Instance.MotionErrorComplete += new MotionController.MotionErrorEventHandler(MotionController_MotionErrorComplete);

                // Subprocess.
                //Globals.StockPumpSubProcess.Initialize(false, true);
                //Globals.LoadFilmSubProcess.Initialize(false, true);
                //SubProcess_SubProcess_UserControl.Initialize(Globals.LoadFilmSubProcess, Globals.StockPumpSubProcess);

                // Users.
                UserAccess.Initialize(true, false, false, false);

                // DeltaTau.
                app.UpdateSplashScreenStatus("Initializing Motion Controller...");
                SetupIO();

                // Barcode Reader.
                CognexDataMan.Initialize();

                // Data context.
                app.UpdateSplashScreenStatus("Initializing DataContext...");
                DataContext = new
                {
                    MachineManagerBindings = MachineManager.Bindings,
                    MainWindowViewModel = Globals.MainWindowViewModel,
                    ProcessControl = Globals.ProcessControl,
                    CurrentUser = UserAccess.CurrentUser,
                    Status = MainProcess.Status,
                    RecipeManagerVars = RecipeManager.Variables,
                    Alarms = FaultHandling.Globals,
                    RFID_Controller_Simulation = Gore.ProcessFlowRFID.ProcessFlowRFID.Simulation.RFID_Controller,
                    OverrideBackgroundColor_Simulation = Gore.Simulation.Simulation.OverrideBackgroundColor,
                    BadgeAccessLevels_Simulation = Gore.Simulation.Simulation.BadgeAccessLevels,
                };
            }
            catch (Exception ex)
            {
                MessageBoxEx.ShowError(ex, "Failed to initialize the Main Window.\n\nThe application cannot continue and will shutdown.");
                try
                {
                    FinalShutdown(false);
                }
                catch (Exception ex2)
                {
                    MessageBoxEx.ShowError(ex2, "Shutdown Failed.");
                }
            }
        }


        /////////////////////////////////////////////////////////////////////
        // RootWindow_Loaded
        /////////////////////////////////////////////////////////////////////
        private void RootWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Not sure why design mode runs this loaded event, but it does.  Kill it!
                if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                {
                    return;
                }

                Gore.Simulation.Simulation.PromptToSetSimulationFlags(true);

                UserAccess.LogIn();
            }
            catch (Exception ex)
            {
                String ErrMsg =
                                "Failed to initialize the system!" +
                                "\n\nThis is a serious Error!  DO NOT ATTEMPT TO RUN THE MACHINE." +
                                "\n\nPlease contact Maintenance or Engineering to fix the issue and verify the controller is functioning properly."
                                ;

                MessageBoxEx.ShowError(ex, ErrMsg);
            }
        }

        private void MotionController_MotionTaskComplete(object sender, MotionTaskEventArgs args)
        {
            System.Windows.Threading.Dispatcher dispatch = Application.Current.Dispatcher;
            if (dispatch.CheckAccess())
            {
                _sewProcess.State.SetMotionEvent(args.Result);
            }
            else
            {
                dispatch.BeginInvoke(new MotionController.MotionTaskEventHandler(MotionController_MotionTaskComplete), new object[] { this, args });
            }
        }

        private void MotionController_MotionErrorComplete(object sender, MotionErrorEventArgs args)
        {
            System.Windows.Threading.Dispatcher dispatch = Application.Current.Dispatcher;
            if (dispatch.CheckAccess())
            {
                //IsErrored = true;
                _sewProcess.State.ShowError(args.ErrorsAsString);
            }
            else
            {
                dispatch.BeginInvoke(new MotionController.MotionErrorEventHandler(MotionController_MotionErrorComplete), new object[] { this, args });
            }
        }

        /////////////////////////////////////////////////////////////////////
        // Window_Closing
        /////////////////////////////////////////////////////////////////////
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !ExitButtonClicked;
        }


        /////////////////////////////////////////////////////////////////////
        // OnFaultActiveChanged
        /////////////////////////////////////////////////////////////////////
        void OnFaultActiveChanged(Fault Fault)
        {
            // Is this the Main Power Error?
            if (Fault.IsMainPowerFault)
            {
                if (Fault.State)
                {
                    // Close any safety circuit initializing prompt.
                    //SafetyCircuitInitializingPrompt.ClosePrompt = true;
                }
                else
                {
                    // Prompt the user with a window that waits for the safety circuit to initialize.  This is a MODELESS dialog so control returns immediately (asynchronously).
                    //SafetyCircuitInitializingPrompt.Reset();
                    MessageBoxEx.ShowCancel(
                        "Waiting for Safety Circuit to Initialize after machine power on.",
                        "Safety Circuit Initializing",
                       null,
                        null,
                        true,
                        true
                        );
                }
            }
        }


        /////////////////////////////////////////////////////////////////////
        // OnAlarmMonitoringStarted
        /////////////////////////////////////////////////////////////////////
        void OnAlarmMonitoringStarted(ref bool Abort)
        {
           
            try
            {
                // Poll Delta Tau for alarms and warnings.
                while (!Abort)
                {

                    // Alarms.
                    //FaultHandling.Globals.FaultsActive = Globals.MotionController.GetPVariable_E(PVars.pUmacError);
                    Faults.ForEach(f => f.State = (f.ID == Globals.MotionController.GetPVariable_E(PVars.pUmacError) ? true : false));

                    // Warnings.

                    // Don't hog the processor.
                    System.Threading.Thread.Sleep(250);
                }
            }
            catch (Exception ex)
            {
                // Unable to get alarm status.
                FaultHandling.Globals.ShowAlarmStatusFailureMessage(ex);
            }
        }

        /////////////////////////////////////////////////////////////////////
        // ParametersUnlocked
        /////////////////////////////////////////////////////////////////////
        void ParametersUnlocked()
        {
            MainProcess.Status.ProcessStatus = "";
            MainProcess.Status.MachineReset = false;

            Globals.ProcessControl.SgmsRfid.Disconnect();
        }

        /////////////////////////////////////////////////////////////////////
        // OnParametersLoaded
        /////////////////////////////////////////////////////////////////////
        void OnParametersLoaded(MachineParameterBase MachineParametersBase)
        {
            Globals.MachineParameters = MachineParametersBase as MachineParameters;
        }


        /////////////////////////////////////////////////////////////////////
        // OnRecipeSelectionChanged
        /////////////////////////////////////////////////////////////////////
        void OnRecipeSelectionChanged(RecipeBase RecipeObject)
        {
            Recipe = RecipeObject as Recipe;

            // Give Process Control knowledge.
            Globals.ProcessControl.Recipe = Recipe;



            if (MainProcess.Status.MachineReset)
            {
                //if selected internally and not null, show combobox
                Globals.MainWindowViewModel.ShowRecipeComboBox = !Globals.ProcessControl.SgmsRfid.IsConnected ||
                    (Globals.ProcessControl.Recipe != null &&
                    Globals.ProcessControl.SgmsRfid.IsConnected &&
                    Globals.ProcessControl.SgmsRfid.Channels.Where(n => n.TagInRange).Count() == 0);
            }
        }


        /////////////////////////////////////////////////////////////////////
        // SetupAlarms
        /////////////////////////////////////////////////////////////////////
        void SetupAlarms()
        {
            // Faults.
            {
                FaultHandling.Globals.AddFault(new Fault("System EStopped", "System\nEStopped","",1));
                FaultHandling.Globals.AddFault(new Fault("Initialization Failed", "Initialization\nFailed","",2));
                FaultHandling.Globals.AddFault(new Fault("Home Timeout", "Home\nTimeout","",3));
                

                
                FaultHandling.Globals.AddFault(new Fault("Axis 1 Left Needle Amp Fault", "Axis\n1\nLeft\nNeedle\nAmp\nFault","",100));
                FaultHandling.Globals.AddFault(new Fault("Axis 1 Left Needle Fatal Following Error", "Axis\n1\nLeft\nNeedle\nFatal\nFollowing\nError","",101));
                FaultHandling.Globals.AddFault(new Fault("Axis 1 Left Needle Negative End Limit", "Axis\n1\nLeft\nNeedle\nNegative\nEnd\nLimit","",102));
                FaultHandling.Globals.AddFault(new Fault("Axis 1 Left needle Positive End Limit", "Axis\n1\nLeft\nneedle\nPositive\nEnd\nLimit", "",103));
                FaultHandling.Globals.AddFault(new Fault("Axis 1 Left Needle I2T Amp Fault", "Axis\n1\nLeft\nNeedle\nI2T\nAmp\nFault", "",104));
                FaultHandling.Globals.AddFault(new Fault("Axis 1 Left Needle Phasing Fault", "Axis\n1\nLeft\nNeedle\nPhasing\nFault", "",105));
                FaultHandling.Globals.AddFault(new Fault("Axis 1 Left Needle Home Failed", "Axis\n1\nLeft\nNeedle\nHome\nFailed", "",106));

                FaultHandling.Globals.AddFault(new Fault("Axis 2 Left Needle Amp Fault", "Axis\n2\nLeft\nNeedle\nAmp\nFault", "", 200));
                FaultHandling.Globals.AddFault(new Fault("Axis 2 Left Needle Fatal Following Error", "Axis\n2\nLeft\nNeedle\nFatal\nFollowing\nError", "", 201));
                FaultHandling.Globals.AddFault(new Fault("Axis 2 Left Needle Negative End Limit", "Axis\n2\nLeft\nNeedle\nNegative\nEnd\nLimit", "", 202));
                FaultHandling.Globals.AddFault(new Fault("Axis 2 Left needle Positive End Limit", "Axis\n2\nLeft\nneedle\nPositive\nEnd\nLimit", "", 203));
                FaultHandling.Globals.AddFault(new Fault("Axis 2 Left Needle I2T Amp Fault", "Axis\n2\nLeft\nNeedle\nI2T\nAmp\nFault", "", 204));
                FaultHandling.Globals.AddFault(new Fault("Axis 2 Left Needle Phasing Fault", "Axis\n2\nLeft\nNeedle\nPhasing\nFault", "", 205));
                FaultHandling.Globals.AddFault(new Fault("Axis 2 Left Needle Home Failed", "Axis\n2\nLeft\nNeedle\nHome\nFailed", "", 206));

                FaultHandling.Globals.AddFault(new Fault("Axis 3 Left Needle Amp Fault", "Axis\n3\nLeft\nNeedle\nAmp\nFault", "", 300));
                FaultHandling.Globals.AddFault(new Fault("Axis 3 Left Needle Fatal Following Error", "Axis\n3\nLeft\nNeedle\nFatal\nFollowing\nError", "", 301));
                FaultHandling.Globals.AddFault(new Fault("Axis 3 Left Needle Negative End Limit", "Axis\n3\nLeft\nNeedle\nNegative\nEnd\nLimit", "", 302));
                FaultHandling.Globals.AddFault(new Fault("Axis 3 Left needle Positive End Limit", "Axis\n3\nLeft\nneedle\nPositive\nEnd\nLimit", "", 303));
                FaultHandling.Globals.AddFault(new Fault("Axis 3 Left Needle I2T Amp Fault", "Axis\n3\nLeft\nNeedle\nI2T\nAmp\nFault", "", 304));
                FaultHandling.Globals.AddFault(new Fault("Axis 3 Left Needle Phasing Fault", "Axis\n3\nLeft\nNeedle\nPhasing\nFault", "", 305));
                FaultHandling.Globals.AddFault(new Fault("Axis 3 Left Needle Home Failed", "Axis\n3\nLeft\nNeedle\nHome\nFailed", "", 306));

                FaultHandling.Globals.AddFault(new Fault("Axis 4 Left Needle Amp Fault", "Axis\n4\nLeft\nNeedle\nAmp\nFault", "", 400));
                FaultHandling.Globals.AddFault(new Fault("Axis 4 Left Needle Fatal Following Error", "Axis\n4\nLeft\nNeedle\nFatal\nFollowing\nError", "", 401));
                FaultHandling.Globals.AddFault(new Fault("Axis 4 Left Needle Negative End Limit", "Axis\n4\nLeft\nNeedle\nNegative\nEnd\nLimit", "", 402));
                FaultHandling.Globals.AddFault(new Fault("Axis 4 Left needle Positive End Limit", "Axis\n4\nLeft\nneedle\nPositive\nEnd\nLimit", "", 403));
                FaultHandling.Globals.AddFault(new Fault("Axis 4 Left Needle I2T Amp Fault", "Axis\n4\nLeft\nNeedle\nI2T\nAmp\nFault", "", 404));
                FaultHandling.Globals.AddFault(new Fault("Axis 4 Left Needle Phasing Fault", "Axis\n4\nLeft\nNeedle\nPhasing\nFault", "", 405));
                FaultHandling.Globals.AddFault(new Fault("Axis 4 Left Needle Home Failed", "Axis\n4\nLeft\nNeedle\nHome\nFailed", "", 406));
                

            }

            // Warnings
            {
            }
        }


        /////////////////////////////////////////////////////////////////////
        // SetupIO
        /////////////////////////////////////////////////////////////////////
        void SetupIO()
        {
            // Outputs
            DigitalOutputs_UserControl.Initialize(Gore.IO.IOTypes.DO, 500, true,
                DO.RightThreadClamp,
                DO.LeftThreadClamp,
                DO.LeftSleeveClamp,
                DO.RightSleeveClamp,
                DO.NeedleBlock,
                DO.TailStockAdjust,
                DO.SleeveTension

                );

            // Inputs
            DigitalInputs_UserControl.Initialize(Gore.IO.IOTypes.DI, 500, true,
                DI.MachineEstopped

                );

            // Analog Inputs
            
            AnaglogInputs_UserControl.Initialize(Gore.IO.IOTypes.AI, 500, true,
                AI.SleeveTension,
                AI.RightThreadBrake,
                AI.LeftThreadBrake
                );
                
        }


        /////////////////////////////////////////////////////////////////////
        // File_Exit
        /////////////////////////////////////////////////////////////////////
        private void File_Exit(object sender, RoutedEventArgs e)
        {
            FinalShutdown(false);
        }


        /////////////////////////////////////////////////////////////////////
        // FinalShutdown
        /////////////////////////////////////////////////////////////////////
        private void FinalShutdown(bool RebootPC)
        {
            Globals.ProcessControl.SgmsRfid.Disconnect();

            // PRE: Cycle Threads already shutdown, Binding wouldn't allow us to get here otherwise.

            // Safe flag so our newly added closing event can see it.
            RebootPCOnClosing = RebootPC;

            // Register a closing event (should be the last in the chain to get called back) so that we can do shutdown stuff after the Recipe Manager and Machine Paramters have prompted the user.
            this.Closing -= new System.ComponentModel.CancelEventHandler(FinalShutdown_Closing);
            this.Closing += new System.ComponentModel.CancelEventHandler(FinalShutdown_Closing);

            // Close the application.  This should fire the RM and MP closing events along with our newly registered closing event.  We moved all our shutdown code to our closing event.
            ExitButtonClicked = true;
            this.Close();
        }


        /////////////////////////////////////////////////////////////////////
        // FinalShutdown_Closing
        /////////////////////////////////////////////////////////////////////
        private void FinalShutdown_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Are we closing?  Recipe Manager and/or Machine Parameters may be cancelling the close due to the user cancelling changes.
            if (e.Cancel == false)
            {
                // Force a logout.  This is a nice way to cleanup any user controls on tabs other than the main tab because they should all get the unloaded event.
                UserAccess.LogOut();

                // Stop the Alarm Monitoring Thread.
                FaultHandling.Globals.StopAlarmMonitoring();

                // Disconnect Delta Tau.
                Globals.MotionController.CloseController();

                // Shutdown DataMan Reader.
                Globals.DataManReader.Disconnect();

                // Remove Callbacks.
                RemoveCallbacks();

                // Shutdown RFID.
                ProcessFlowRFID.Disconnect();

                if (RebootPCOnClosing)
                {
                    ProcessEx.RebootPC();
                }
            }
        }


        /////////////////////////////////////////////////////////////////////
        // RemoveCallbacks
        /////////////////////////////////////////////////////////////////////
        void RemoveCallbacks()
        {
            try
            {
                MachineManager.ParametersLoadedEvent -= new MachineManager.ParametersLoadedEventHandler(OnParametersLoaded);
                MachineManager.ParametersUnlockedEvent -= new MachineManager.ParametersUnlockedEventHandler(ParametersUnlocked);
                RecipeManager.RecipeSelectionChangedEvent -= new RecipeManager.RecipeSelectionChangedEventHandler(OnRecipeSelectionChanged);
                FaultHandling.FaultActiveChangedEvent -= new FaultHandling.FaultActiveChangedEventHandler(OnFaultActiveChanged);
                FaultHandling.AlarmMonitoringStartedEvent -= new FaultHandling.AlarmMonitoringStartedEventHandler(OnAlarmMonitoringStarted);
            }
            catch { }
        }


        /////////////////////////////////////////////////////////////////////
        // Security_LogIn
        /////////////////////////////////////////////////////////////////////
        private void Security_LogIn(object sender, RoutedEventArgs e)
        {
            LoginResult Result = UserAccess.LogIn();
            if (Result == LoginResult.UserDoesNotExist)
            {
                MessageBoxEx.Show(
                    "The scanned Badge ID does not exist in the system, please ask an associate with higher access level to add you to the system.",
                    "Warning",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                    );
            }
        }


        /////////////////////////////////////////////////////////////////////
        // Security_LogOut
        /////////////////////////////////////////////////////////////////////
        private void Security_LogOut(object sender, RoutedEventArgs e)
        {
            UserAccess.LogOut();
        }


        /////////////////////////////////////////////////////////////////////
        // Security_EditUser
        /////////////////////////////////////////////////////////////////////
        private void Security_EditUser(object sender, RoutedEventArgs e)
        {
            UserAccess.ShowEditUsersDialog();
        }


        /////////////////////////////////////////////////////////////////////
        // Simulation_Click
        /////////////////////////////////////////////////////////////////////
        private void Simulation_Click(object sender, RoutedEventArgs e)
        {
            Gore.Simulation.Simulation.PromptToSetSimulationFlags(false, !MainProcess.Status.MachineReset);
        }


        /////////////////////////////////////////////////////////////////////
        // Help_About
        /////////////////////////////////////////////////////////////////////
        private void Help_About(object sender, RoutedEventArgs e)
        {
            String DeltaTauVars = "ERROR";
            String DeltaTauMain = "ERROR";
            try
            {
                if (Gore.DeltaTau.DeltaTau.Simulation)
                {
                    DeltaTauVars = "-1.03";
                    DeltaTauMain = "-1.04";
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.ShowError(ex, "Failed to get the Delta Tau versions.");
            }

            ObservableCollection<GoreVersion> Versions = new ObservableCollection<GoreVersion>();
            Versions.Add(new GoreVersion("Software Title:", App.SOFTWARE_TITLE));
            Versions.Add(new GoreVersion("Software MD:", App.SOFTWARE_MD));
            Versions.Add(new GoreVersion("Software Version:", App.SOFTWARE_VERSION));
            Versions.Add(new GoreVersion("Machine Name:", App.MACHINE_NAME));
            Versions.Add(new GoreVersion("Production Recipes:", RecipeManager.GetProductionFileNotes()));

            //Versions.Add(new GoreVersion("Delta Tau Vars:", DeltaTauVars));
            //Versions.Add(new GoreVersion("Delta Tau Main:", DeltaTauMain));

            SoftwareVersion.ShowVersionsDialog(Versions, this);
        }


        /////////////////////////////////////////////////////////////////////
        // Home_Button_Click
        /////////////////////////////////////////////////////////////////////
        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainProcess.StartHome();
            bool res = MotionController.Instance.DoHome();
            if (res == false)
            {
                string msg = "";
                try
                {
                    msg = "Failed to Start the Home Process.";
                }



                catch (Exception ex)
                {
                    MessageBoxEx.ShowError(ex, msg);

                }
            }
        }

        /////////////////////////////////////////////////////////////////////
        // Back_Button_Click
        /////////////////////////////////////////////////////////////////////
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            if(Globals.ProcessControl.step==0)
            {
                Globals.ProcessControl.step = 0;
            }
            else
            {
                Globals.ProcessControl.step --;
            }

            Globals.ProcessControl.backButtonPressed = true;
        }


        /////////////////////////////////////////////////////////////////////
        // CancelHome_Button_Click
        /////////////////////////////////////////////////////////////////////
        private void CancelHome_Button_Click(object sender, RoutedEventArgs e)
        {
            MainProcess.AbortProcess();
        }


        void Double_ValidationRule(object value, out ValidationResult ValidationResult)
        {
            try
            {
                double DoubleValue = System.Convert.ToDouble(value);
                double Min = double.Epsilon;
                double Max = 10.0;
                if ((DoubleValue < Min) || (DoubleValue > Max))
                {
                    ValidationResult = new ValidationResult(false, "Please enter a value in the range: " + Min.ToString() + " - " + Max.ToString() + ".");
                }
            }
            catch (Exception ex)
            {
                // Should never happen because there should be a double validation rule on the EditDouble text box.
                ValidationResult = new ValidationResult(false, ex.Message);
                return;
            }

            ValidationResult = new ValidationResult(true, null); //default is that it is fine 
        }

    }
    
}

