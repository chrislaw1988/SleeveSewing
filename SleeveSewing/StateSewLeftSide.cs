using Gore.ProcessControlBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class StateSewLeftSide: SewingStateBase
    {
       
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction
        public StateSewLeftSide(SewingProcess sewProcess, string stateDescription)
            :base(sewProcess, stateDescription)
        {
           
        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          StateBase Overrides
        //////////////////////////////////////////////////////////////////////////////////////////
        #region StateBase Overrides


        public override void ExecuteState()
        {
            bool val = MotionController.Instance.DoSewLeftSide();
            if (val == false)
            {
                ShowError("Failed to Start Left Stitch Sewing Process");
            }
        }

        public override void SetMotionEvent(bool success)
        {
            if (success == true)
            {
                //WaitForOperatorTaskAcknowledge("Press Continue to start payout", "Ready to payout", "Running payout", true);
                SewProcess.State = SewProcess.PayoutLeftDeploymnetLineState;
                SewProcess.ExecuteState();
            }
            else
            {
                SewProcess.State = SewProcess.IdleState;
            }
        }

        protected override void CycleStarted(ref bool Abort, ref bool Stop, out bool ReachedPointOfNoReturn)
        {
            ReachedPointOfNoReturn = true;
        }

        #endregion ~StateBase Overrides

    }
}
