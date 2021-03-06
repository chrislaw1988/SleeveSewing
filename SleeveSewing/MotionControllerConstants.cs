using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gore.MessageBox;
using Gore.Generic;
using Gore.MainProcess;
using System.Diagnostics;

namespace SleeveSewing
{
 
    abstract class MotionControllerConst
    {


        ///////////////////////////////////////////////////////////////////////////////////////////
        //        Machine Homed State enum
        //////////////////////////////////////////////////////////////////////////////////////////
        #region HomedState

        public enum HomedState
        {
            [VariableNameAttribute("Machine Not Homed")]
            MachineNotHomed = 1,
            [VariableNameAttribute("Machine Homing")]
            MachineHoming,
            [VariableNameAttribute("Machine Homed")]
            MachineHomed
        }

        #endregion ~HomedState


        ///////////////////////////////////////////////////////////////////////////////////////////
        //        Machine Process State enum
        //////////////////////////////////////////////////////////////////////////////////////////
        #region ProcessState

        //public enum ProcessState
        //{
        //    Idle = 1,
        //    Load,
        //    SewLeftStitch,
        //    PayoutLeftDeploymentLine,
        //    SewRightStitch,
        //    PayoutRightDeploymentLine,
        //    RemoveDevice,
        //    ReturnToStart,
        //    UserAbortIng,
        //    Error
        //}

        #endregion ~ProcessState


        ///////////////////////////////////////////////////////////////////////////////////////////
        //        Digital Inputs
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Digital Inputs


        public enum DigitalInputs
        {
            [VariableNameAttribute("M1")]
            MachineEstopped
        }
        

#warning UMAC CONFIG
        //public enum DigitalInputs
        //{
        //    [VariableNameAttribute("M7000")]
        //    MachineEstopped
        //}

        #endregion ~Digital Inputs


        ///////////////////////////////////////////////////////////////////////////////////////////
        //        Digital Outputs
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Digital Outputs


        public enum DigitalOutputs
        {
            [VariableNameAttribute("M33")]
            RightThreadClamp,
            [VariableNameAttribute("M34")]
            LeftThreadClamp,
            [VariableNameAttribute("M35")]
            LeftSleeveClamp,
            [VariableNameAttribute("M36")]
            RightSleeveClamp,
            [VariableNameAttribute("M37")]
            NeedleBlock,
            [VariableNameAttribute("M38")]
            TailStockAdjust,
            [VariableNameAttribute("M39")]
            SleeveTension
        }
         

#warning UMAC CONFIG
        /*
        public enum DigitalOutputs
        {
            [VariableNameAttribute("M7024")]
            RegulatorOn,
            [VariableNameAttribute("M7025")]
            LeftThreadClamp,
            [VariableNameAttribute("M7026")]
            RightThreadClamp,
            [VariableNameAttribute("M7027")]
            LeftSleeveClamp,
            [VariableNameAttribute("M7028")]
            RightSleeveClamp,
            [VariableNameAttribute("M7029")]
            NeedleBlock,
            [VariableNameAttribute("M7030")]
            TailStockAdjust,
            [VariableNameAttribute("M7031")]
            SleeveTension
        }
         * */

        #endregion ~Digital Outputs


        ///////////////////////////////////////////////////////////////////////////////////////////
        //        Dac Signals
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Dac Signals


        public enum DACSignals
        {
             [VariableNameAttribute("M502")]
            SleeveTension,
            [VariableNameAttribute("M602")]
            LeftThreadBrake,
            [VariableNameAttribute("M702")]
            RightThreadBrake
           
        }
        

#warning UMAC CONFIG
        //public enum DACSignals
        //{
        //    [VariableNameAttribute("M6001")]
        //    LeftThreadBrake,
        //    [VariableNameAttribute("M6002")]
        //    RightThreadBrake,
        //    [VariableNameAttribute("M6003")]
        //    SleeveTension
        //}

        #endregion ~Dac Signals


        ///////////////////////////////////////////////////////////////////////////////////////////
        //        P-Variables See Mapping within PVars.h Header File 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region P-Variables

        public enum PVariables
        {
            [VariableNameAttribute("P24")]
            StartPosition,
            [VariableNameAttribute("P25")]
            MiddleGap,
            [VariableNameAttribute("P26")]
            LeftHeadFiberTension,
            [VariableNameAttribute("P27")]
            LeftHeadStitchCount,
            [VariableNameAttribute("P28")]
            LeftHeadStitchTimeSlice,
            [VariableNameAttribute("P29")]
            LeftHeadStitchLength,
            [VariableNameAttribute("P30")]
            LeftHeadSlowStitchTimeSlice,
            [VariableNameAttribute("P31")]
            LeftHeadSlowStitchCount,
            [VariableNameAttribute("P32")]
            LeftHeadSlowStitchRampCount,
            [VariableNameAttribute("P33")]
            LeftHeadSlowStitchTension,
            [VariableNameAttribute("P34")]
            LeftHeadUseAltStartTension,
            [VariableNameAttribute("P35")]
            LeftHeadSewLowStitchDensity,

            [VariableNameAttribute("P36")]
            RightHeadFiberTension,
            [VariableNameAttribute("P37")]
            RightHeadStitchCount,
            [VariableNameAttribute("P38")]
            RightHeadStitchTimeSlice,
            [VariableNameAttribute("P39")]
            RightHeadStitchLength,
            [VariableNameAttribute("P40")]
            RightHeadSlowStitchTimeSlice,
            [VariableNameAttribute("P41")]
            RightHeadSlowStitchCount,
            [VariableNameAttribute("P42")]
            RightHeadSlowStitchRampCount,
            [VariableNameAttribute("P43")]
            RightHeadSlowStitchTension,
            [VariableNameAttribute("P44")]
            RightHeadUseAltStartTension,
            [VariableNameAttribute("P45")]
            RightHeadSewLowStitchDensity,


            [VariableNameAttribute("P50")]
            LeftNeedleHomeOffset,
            [VariableNameAttribute("P51")]
            RightNeedleHomeOffset,
            [VariableNameAttribute("P52")]
            LooperHomeOffset,
            [VariableNameAttribute("P53")]
            TraverseHomeOffset,
            [VariableNameAttribute("P54")]
            ReverseLooperInstalled,
            [VariableNameAttribute("P72")]
            XAxisTraverseFeedRate,
        }

        #endregion ~P-Variables


        ///////////////////////////////////////////////////////////////////////////////////////////
        //        Control Bits mapped to M7500
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Control Bits

        protected const int MACH_CONTROL_0_M7500_ADDR = 0X450 * 4;

        protected enum ControlBits
        {
            DoHome = 1,
            SewLeftHead,
            SewRightHead,
            MoveToStart,
            DoErrorReset,
            DoAbort,
            DoInit,
            DoLoopOut
        }

        #endregion ~Control Bits


        ///////////////////////////////////////////////////////////////////////////////////////////
        //        Status Bits within M7505
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Status Bits

        public const int MACHINE_STATUS_0_M7505_ADDR = 0x455 * 4;

        public enum StatusBits
        {
            HomeDone = 1,
            SewLeftDone,
            SewRightDone,
            MoveToStartDone,
            ErrorResetDone,
            AbortDone,
            InitDone,
            LoopOutDone
        }

        #endregion ~Status Bits


        ///////////////////////////////////////////////////////////////////////////////////////////
        //        Error Words
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Error Words

        public const int SYS_ERROR_0_M7510_ADDR = 0X460 * 4;
        public const int SYS_ERROR_1_M7511_ADDR = 0X461 * 4;
        public const int SYS_ERROR_2_M7512_ADDR = 0X462 * 4;
        public const int SYS_ERROR_3_M7513_ADDR = 0X463 * 4;
        public const int SYS_ERROR_4_M7514_ADDR = 0X464 * 4;


        #endregion ~Error Words

        
    }
}
