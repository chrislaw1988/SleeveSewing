using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

using Gore.Generic;
using Gore.MachineManager;
using Gore.ProcessFlowRFID;
using PCOMMSERVERLib;
using Gore.Cognex;
using Gore.ESig.ViewModels;
using Gore.IO;

namespace SleeveSewing
{
    static public class Globals
    {
        static internal MainWindowViewModel MainWindowViewModel = new MainWindowViewModel();
        static internal MachineParameters MachineParameters = new MachineParameters();
        static internal ProcessControl ProcessControl = new ProcessControl();
        static internal ObservableCollectionMessages Messages = new ObservableCollectionMessages();
        static internal DataManFixedMountReader DataManReader = new DataManFixedMountReader();
        static internal MotionController MotionController = new MotionController();
        static internal ControllerError ControllerError = new ControllerError();
    }

    public class MachineParameters : MachineParameterBase
    {
        RangeCheck RangeCheck = new RangeCheck("Machine Parameters Error.");

        public MachineParameters()
        {
        }


        ActiveDirectorySettingsViewModel _ActiveDirectorySettingsViewModel = new ActiveDirectorySettingsViewModel();


        
        double _LeftNeedleHomeOffset = double.NaN;
        double _RightNeedleHomeOffset = double.NaN;
        double _LooperHomeOffset = double.NaN;
        double _TraverseHomeOffset = double.NaN;
        bool _ReverseLooperInstalled = false;
        double _PayoutFiberTension = double.NaN;

        string _MachineName;
        string _RfidIpAddress;
        int _MaxHeadCount;
        string _DCLocation;

        bool _VisualInspection;
        string _EndpointName;
        string _MachineType;
        bool _RejectCodePrompt;


        
       
        
        [XmlAttribute]
        public double LeftNeedleHomeOffset { get { return _LeftNeedleHomeOffset; } set { SetProperty(ref _LeftNeedleHomeOffset, value, nameof(LeftNeedleHomeOffset)); } }
        [XmlAttribute]
        public double RightNeedleHomeOffset { get { return _RightNeedleHomeOffset; } set { SetProperty(ref _RightNeedleHomeOffset, value, nameof(RightNeedleHomeOffset)); } }
        [XmlAttribute]
        public double LooperHomeOffset { get { return _LooperHomeOffset; } set { SetProperty(ref _LooperHomeOffset, value, nameof(LooperHomeOffset)); } }
        [XmlAttribute]
        public double TraverseHomeOffset { get { return _TraverseHomeOffset; } set { SetProperty(ref _TraverseHomeOffset, value, nameof(TraverseHomeOffset)); } }
        [XmlAttribute]
        public bool ReverseLooperInstalled { get { return _ReverseLooperInstalled; } set { SetProperty(ref _ReverseLooperInstalled, value, nameof(ReverseLooperInstalled)); } }
        [XmlAttribute]
        public double PayoutFiberTension { get { return _PayoutFiberTension; } set { SetProperty(ref _PayoutFiberTension, value, nameof(PayoutFiberTension)); } }



        public ActiveDirectorySettingsViewModel ActiveDirectorySettingsViewModel { get { return _ActiveDirectorySettingsViewModel; } set { SetProperty(ref _ActiveDirectorySettingsViewModel, value, nameof(ActiveDirectorySettingsViewModel)); } }

        public string MachineName { get { return _MachineName; } set { SetProperty(ref _MachineName, value, nameof(MachineName)); } }
        public string RfidIpAddress { get { return _RfidIpAddress; } set { SetProperty(ref _RfidIpAddress, value, nameof(RfidIpAddress)); } }
        public int MaxHeadCount { get { return _MaxHeadCount; } set { SetProperty(ref _MaxHeadCount, value, nameof(MaxHeadCount)); } }
        public string DCLocation { get { return _DCLocation; } set { SetProperty(ref _DCLocation, value, nameof(DCLocation)); } }
        
        public bool VisualInspection { get { return _VisualInspection; } set { SetProperty(ref _VisualInspection, value, nameof(VisualInspection)); } }
        public string EndpointName { get { return _EndpointName; } set { SetProperty(ref _EndpointName, value, nameof(EndpointName)); } }
        public string MachineType { get { return _MachineType; } set { SetProperty(ref _MachineType, value, nameof(MachineType)); } }
        public bool RejectCodePrompt { get { return _RejectCodePrompt; } set { SetProperty(ref _RejectCodePrompt, value, nameof(RejectCodePrompt)); } }

        

        /////////////////////////////////////////////////////////////////////
        // Validate
        /////////////////////////////////////////////////////////////////////
        override public void Validate()
        {
            
            RangeCheck.DoubleGreaterThanZero_E(LeftNeedleHomeOffset, nameof(LeftNeedleHomeOffset));
            RangeCheck.DoubleGreaterThanZero_E(RightNeedleHomeOffset, nameof(RightNeedleHomeOffset));
            //RangeCheck.DoubleGreaterThanZero_E(LooperHomeOffset, nameof(LooperHomeOffset));
            RangeCheck.DoubleGreaterThanZero_E(TraverseHomeOffset, nameof(TraverseHomeOffset));
           
            //RFID.Validate();
        }


        /////////////////////////////////////////////////////////////////////
        // ValidateMachineVelocity_E
        /////////////////////////////////////////////////////////////////////
        public void ValidateMachineVelocity_E()
        {
            
        }


        /////////////////////////////////////////////////////////////////////
        // ValidateLoadPosition_E
        /////////////////////////////////////////////////////////////////////
        public void ValidateLoadPosition_E()
        {
        }

    }


    static public class ProgramVariables
    {
        static public double MoveThetaVelocity_Deg_Sec = 30.0;
        static public String RecipeDataError = "Recipe Data Error.";
        static public double MaxTension_Grams = 500.0;
    }


    static public class Motors
    {
    }

    static public class DO
    {
        
        //static internal bool RightThreadClamp = MotionControllerConst.DigitalOutputs.RightThreadClamp;
        static internal DeltaTauDigitalOutput RightThreadClamp = new DeltaTauDigitalOutput("Right Thread Clamp (Turn On)", true, MVars.RightThreadClamp, Globals.MotionController, 1, 1);
        static internal DeltaTauDigitalOutput LeftThreadClamp = new DeltaTauDigitalOutput("Left Thread Clamp (Turn On)", true, MVars.LeftThreadClamp, Globals.MotionController, 1, 2);
        static internal DeltaTauDigitalOutput LeftSleeveClamp = new DeltaTauDigitalOutput("Left Sleeve Clamp (Turn On)", true, MVars.LeftSleeveClamp, Globals.MotionController, 1, 3);
        static internal DeltaTauDigitalOutput RightSleeveClamp = new DeltaTauDigitalOutput("Right Sleeve Clamp (Turn On)", true, MVars.RightSleeveClamp, Globals.MotionController, 1, 4);
        static internal DeltaTauDigitalOutput NeedleBlock = new DeltaTauDigitalOutput("Needle Block (Turn On)", true, MVars.NeedleBlock, Globals.MotionController, 1, 5);
        static internal DeltaTauDigitalOutput TailStockAdjust = new DeltaTauDigitalOutput("Tail Stock Adjust (Turn On)", true, MVars.TailStockAdjust, Globals.MotionController, 1, 6);
        static internal DeltaTauDigitalOutput SleeveTension = new DeltaTauDigitalOutput("Sleeve Tension (Turn On)", true, MVars.SleeveTension, Globals.MotionController, 1, 7);

    }

    static public class DI
    {
        static internal DeltaTauDigitalInput MachineEstopped = new DeltaTauDigitalInput("Machine Estopped", MVars.MachineEstopped, Globals.MotionController, 1, 1, true);
    }

    
    static public class AI
    {
        static internal DeltaTauAnalogInput SleeveTension = new DeltaTauAnalogInput("Sleeve Tension", MVars.SleeveTension1, Globals.MotionController, "Grams", "Volts", 0, 65535, 0, 10, 0, ProgramVariables.MaxTension_Grams, BoardNumber: 1, ChannelNumber: 1);
        static internal DeltaTauAnalogInput LeftThreadBrake = new DeltaTauAnalogInput("Left Thread Brake", MVars.LeftThreadBrake, Globals.MotionController, "Grams", "Volts", 0, 65535, 0, 10, 0, ProgramVariables.MaxTension_Grams, BoardNumber: 1, ChannelNumber: 2);
        static internal DeltaTauAnalogInput RightThreadBrake = new DeltaTauAnalogInput("Right Thread Brake", MVars.RightThreadBrake, Globals.MotionController, "Grams", "Volts", 0, 65535, 0, 10, 0, ProgramVariables.MaxTension_Grams, BoardNumber: 1, ChannelNumber: 3);
        
    }
    

    public enum CoordinateSystem
    {
        X_Y_Z_Theta_Spindle = 1,
    }

    static public class PVars
    {
        //Error Logging Vars for the SetErrorWord PLC
        static public PVar pUmacError = new PVar(1);
        static public PVar pSlotAvailable = new PVar(2);
        static public PVar pErrorSet = new PVar(3);
        static public PVar pErrorChckIndex = new PVar(4);
        static public PVar pErrorLogged = new PVar(5);
        static public PVar pErrorIndex = new PVar(6);//Indexer used to cycle between 7510 -> 7514
        static public PVar pErrorStartLoc = new PVar(7);//This Gets set to 7510 mSystemError0 m7510

        //Error Logging Vars For the AxisErros plc
        static public PVar pAxisErrored = new PVar(8);
        static public PVar pAxisEnableCount = new PVar(9);

        ////////////////////////////////////////////////////////////////////////
        //			SEWING PVARS  p20-p50
        ////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Rev 2 Definitions
        static public PVar pSewingEnabled = new PVar(20);
        static public PVar pStitchIdx = new PVar(21);//Indexer for Stitch Counting
        static public PVar pStitchRampRate = new PVar(22);// Calculated ramping rate  = ((pSlowStichTimeSlice - pStitchTimeSlice) / pSlowStitchRampCount) Used by Left And Right Head
        static public PVar pRampStitchIdx = new PVar(23);//Indexer for ramping the stitch rate Used By Left And Right Head

        //Sleeve Variables
        static public PVar pStartPosition_mm = new PVar(24);//The Start Position to Begin the Stitch
        static public PVar pMiddleGap_mm = new PVar(25);//The Gap between Twin Stitch Sleeves in mm

        //Left Head Deployment Line Variables
        static public PVar pLHeadFiberTension_cnts = new PVar(26);//Fiber Tension left Head
        static public PVar pLHeadStitchCnt = new PVar(27);//The Total Stitch Count For the Left Head (calculated within HMI)
        static public PVar pLHeadStitchTimeSlice = new PVar(28);//Calculated Time Slice for PVT Moves with Left head (Calculated within HMI)
        static public PVar pLHeadStitchLength_mm = new PVar(29);//The Stitch Length in mm for the Left Head (Calculated within HMI)
        static public PVar pLHeadSlowStitchTimeSlice = new PVar(30);//Time Slice used during slow stitches
        static public PVar pLHeadSlowStitchCount = new PVar(31);//The Number of stitches to hold the thread clamp for
        static public PVar pLHeadSlowStitchRampCount = new PVar(32);//The Number of Stitches to Ramp from slow speed to Production Speed 	
        static public PVar pLHeadSlowStitchTension = new PVar(33);//Fiber tension used during slow and ramp stitches
        static public PVar pLHeadUseAltStartTension = new PVar(34);//Boolean to use Alt Tension at for slow and ramp stitches see LSD Sewing PMC's	
        static public PVar pLHeadSewLowStitchDensity = new PVar(35);//Boolean value used by messageHandler PMC to Pick correct Sewing Program either HSD or LSD


        // Right Head Deployment Line Variables See Left Head Section for Definitions as these are the same but for the Right Head
        static public PVar pRHeadFiberTension_cnts = new PVar(36);
        static public PVar pRHeadStitchCnt = new PVar(37);
        static public PVar pRHeadStitchTimeSlice = new PVar(38);
        static public PVar pRHeadStitchLength_mm = new PVar(39);
        static public PVar pRHeadSlowStitchTimeSlice = new PVar(40);
        static public PVar pRHeadSlowStitchCount = new PVar(41);
        static public PVar pRHeadSlowStitchRampCount = new PVar(42);
        static public PVar pRHeadSlowStitchTension = new PVar(43);
        static public PVar pRHeadUseAltStartTension = new PVar(44);
        static public PVar pRHeadSewLowStitchDensity = new PVar(45);

        ////////////////////////////////////////////////////////////////////////
        //			Home Offset PVars P50-P60
        ////////////////////////////////////////////////////////////////////////
        static public PVar pLNeedleHomeOffset = new PVar(50);
        static public PVar pRNeedleHomeOffset = new PVar(51);
        static public PVar pLooperHomeOffset = new PVar(52);
        static public PVar pTraverseHomeOffset = new PVar(53);
        static public PVar pReverseLooperInstalled = new PVar(54);

        ////////////////////////////////////////////////////////////////////////
        //			Following Error Varaibles P60-P70
        ////////////////////////////////////////////////////////////////////////
        static public PVar pLNeedleHomeFFE = new PVar(60);
        static public PVar pRNeedleHomeFFE = new PVar(61);
        static public PVar pLooperHomeFFE = new PVar(62);
        static public PVar pXAxisHomeFFE = new PVar(63);
        static public PVar pLNeedleFFE = new PVar(64);
        static public PVar pRNeedleFFE = new PVar(65);
        static public PVar pLooperFFE = new PVar(66);




        ////////////////////////////////////////////////////////////////////////
        //		X- Axis move to position Var used to calculate the middle gap distance for twin stitch sleeves
        ////////////////////////////////////////////////////////////////////////
        static public PVar pXAxisMoveToPosition = new PVar(70);
        static public PVar pLooperDegTo0 = new PVar(71);
        static public PVar pXAxisFeedRate_mm_Sec = new PVar(72);


    }

    static public class MVars
    {
        
        static public MVar RightThreadClamp = new MVar(33);
        static public MVar LeftThreadClamp = new MVar(34);
        static public MVar LeftSleeveClamp = new MVar(35);
        static public MVar RightSleeveClamp = new MVar(36);
        static public MVar NeedleBlock = new MVar(37);
        static public MVar TailStockAdjust = new MVar(38);
        static public MVar SleeveTension = new MVar(39);

        static public MVar MachineEstopped = new MVar(1);

        static public MVar SleeveTension1 = new MVar(502);
        static public MVar LeftThreadBrake = new MVar(602);
        static public MVar RightThreadBrake = new MVar(702);
    }

    
}
