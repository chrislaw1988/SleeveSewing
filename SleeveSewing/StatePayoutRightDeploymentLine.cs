using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class StatePayoutRightDeploymentLine : SewingStateBase
    {
       
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction
        public StatePayoutRightDeploymentLine(SewingProcess sewProcess, string stateDescription)
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
            bool showForLeftSide = false;
            //winPayoutDeploymentLine win = new winPayoutDeploymentLine(showForLeftSide);
            //win.ShowDialog();

            if (SewingProcess.IsErrored == true)
            {
                SewingProcess.IsErrored = false;
                return;
            }

            if (Globals.MachineParameters.ReverseLooperInstalled == true)
            {
                SewProcess.State = SewProcess.LoopOutLastStitchState;
            }
            else
            {
                SewProcess.State = SewProcess.SewLeftSideState;
            }

            SewProcess.ExecuteState();
        }

        public override void SetMotionEvent(bool success)
        {
            
        }

        protected override void CycleStarted(ref bool Abort, ref bool Stop, out bool ReachedPointOfNoReturn)
        {
            ReachedPointOfNoReturn = true;
        }

        #endregion ~StateBase Overrides

    }
}
