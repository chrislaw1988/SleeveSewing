using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class StateSewRightSide : SewingStateBase
    {
       
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction
        public StateSewRightSide(SewingProcess sewProcess, string stateDescription)
            :base(sewProcess, stateDescription)
        {
           
        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          SewStateBase Overrides
        //////////////////////////////////////////////////////////////////////////////////////////
        #region StateBase Overrides

        public override void ExecuteState()
        {
            bool val = MotionController.Instance.DoSewRightSide();
            if (val == false)
            {
                ShowError("Failed to Start Right Stitch Sewing Process");
            }
        }

        public override void SetMotionEvent(bool success)
        {
            if (success == true)
            {
                SewProcess.State = SewProcess.PayoutRightDeploymentLineState;
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
