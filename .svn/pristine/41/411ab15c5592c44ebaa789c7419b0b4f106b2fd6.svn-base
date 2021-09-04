using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class StateReturnToStart : SewingStateBase
    {
       
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction
        public StateReturnToStart(SewingProcess sewProcess, string stateDescription)
            :base(sewProcess, stateDescription)
        {
           
        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          SewStateBase Overrides
        //////////////////////////////////////////////////////////////////////////////////////////b
        #region StateBase Overrides


        

        public override void ExecuteState()
        {
            //Don't execute return to start
            /*
            bool val = MotionController.Instance.DoReturnToStart();
            if (val == false)
            {
                ShowError("Failed to Start the Return To Load Position Process");
            }
            */
        }

        public override void SetMotionEvent(bool success)
        {
            //WaitForOperatorTaskAcknowledge("Press Continue to finish the cycle", "Ready to payout", "Running payout", true);
            SewProcess.State = SewProcess.IdleState;
        }

        protected override void CycleStarted(ref bool Abort, ref bool Stop, out bool ReachedPointOfNoReturn)
        {
            ReachedPointOfNoReturn = true;
        }

        #endregion ~StateBase Overrides

    }
}
