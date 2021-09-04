using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class StateLoad: SewingStateBase
    {
       

        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction
        public StateLoad(SewingProcess sewProcess, string stateDescription)
            :base(sewProcess, stateDescription)
        {
           
        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          StateBase Overrides
        //////////////////////////////////////////////////////////////////////////////////////////
        #region StateBase Overrides

        Recipe recipe = new Recipe();
        public override void ExecuteState()
        {
            

            if (SewingProcess.IsErrored == true)
            {
                SewingProcess.IsErrored = false;
                return;
            }


            if (true)
            {
                if (Globals.MachineParameters.ReverseLooperInstalled == true)
                {
                    SewProcess.State = SewProcess.SewLeftSideState;
                }
                else
                {
                    
                    if(recipe.IsDualLine)
                    {
                        SewProcess.State = SewProcess.SewRightSideState;
                    }
                    else
                    {
                        SewProcess.State = SewProcess.SewLeftSideState;
                    }
                }

                SewProcess.ExecuteState();
            }
            else
            {
                SewProcess.State = SewProcess.IdleState;
                MotionController.Instance.ClearIOForDeviceLoad();
            }
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
