using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gore.IO;
using Gore.Generic;

using System.Runtime.CompilerServices;

namespace SleeveSewing
{
    class DeltaTauDigitalInput : DigitalInputBase
    {
        MotionController Controller = null;
        MVar MVar;

        /////////////////////////////////////////////////////////////////////
        // DeltaTauDigitalInput
        /////////////////////////////////////////////////////////////////////
        public DeltaTauDigitalInput(string Name, int MVar, MotionController Controller, int BoardNumber = -1, int BitNumber = -1, bool SimulationState = false)
            : this(Name, new MVar(MVar), Controller, BoardNumber, BitNumber, SimulationState)
        { }

        public DeltaTauDigitalInput(string Name, MVar MVar, MotionController Controller, int BoardNumber = -1, int BitNumber = -1, bool SimulationState = false)
            : base(Name, BoardNumber, BitNumber, SimulationState)
        {
            this.MVar = MVar;
            this.Controller = Controller;
        }

        /////////////////////////////////////////////////////////////////////
        // UpdateState_E
        /////////////////////////////////////////////////////////////////////
        public override void UpdateState_E(bool FirstUpdateOnTimerTick)
        {
            State = GetInput_E();
        }

        /////////////////////////////////////////////////////////////////////
        // GetInput_E
        /////////////////////////////////////////////////////////////////////
        public bool GetInput_E()
        {
            // Get the Live Input off the controller.
            return Controller.GetMVariable_E(MVar) != 0;
        }

        /////////////////////////////////////////////////////////////////////
        // Wait_E
        /////////////////////////////////////////////////////////////////////
        public void Wait_E(bool WaitState, ref bool Cancel, int SleepTime_MS, int Timeout_MS)
        {
            try
            {
                Wait.WaitWhileConditionTimeoutSleep(GetInput_E, WaitState, ref Cancel, SleepTime_MS, Timeout_MS, true);
            }
            catch (TimeoutException ex)
            {
                // Keep same type of exception.
                throw new TimeoutException(String.Format("The operation has timed out waiting for input \"{0}\" to change from ({1}) to ({2}).", Name, WaitState.ToString(), (!WaitState).ToString()), ex);
            }
        }

        /////////////////////////////////////////////////////////////////////
        // WaitWhileTrue_E
        /////////////////////////////////////////////////////////////////////
        public void WaitWhileTrue_E(ref bool Cancel, int SleepTime_MS, int Timeout_MS)
        {
            Wait_E(true, ref Cancel, SleepTime_MS, Timeout_MS);
        }

        /////////////////////////////////////////////////////////////////////
        // WaitWhileFalse_E
        /////////////////////////////////////////////////////////////////////
        public void WaitWhileFalse_E(ref bool Cancel, int SleepTime_MS, int Timeout_MS)
        {
            Wait_E(false, ref Cancel, SleepTime_MS, Timeout_MS);
        }

        /////////////////////////////////////////////////////////////////////
        // GetIOInfo
        /////////////////////////////////////////////////////////////////////
        public override string GetIOInfo()
        {
            return $"MVar: {MVar.Number}";
        }
    }
}
