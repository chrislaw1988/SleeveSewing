using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class StatePayoutLeftDeploymentLine : SewingStateBase
    {
       
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction
        public StatePayoutLeftDeploymentLine(SewingProcess sewProcess, string stateDescription)
            :base(sewProcess, stateDescription)
        {
           
        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          SewStateBase Overrides
        //////////////////////////////////////////////////////////////////////////////////////////
        #region StateBase Overrides

        Recipe recipe = new Recipe();
        public override void ExecuteState()
        {
            bool showForLeftSide = true;
            

            if (SewingProcess.IsErrored == true)
            {
                SewingProcess.IsErrored = false;
                return;
            }

            if (Globals.MachineParameters.ReverseLooperInstalled == true)
            {
                if (recipe.IsDualLine)
                {
                    SewProcess.State = SewProcess.SewRightSideState;
                }
                else
                {
                    SewProcess.State = SewProcess.LoopOutLastStitchState;
                }
            }
            else
            {
                SewProcess.State = SewProcess.LoopOutLastStitchState;
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
