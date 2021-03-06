using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class StateRemoveDevice : SewingStateBase
    {
       
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction
        public StateRemoveDevice(SewingProcess sewProcess, string stateDescription)
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
            //Don't reset the I/O to false yet, meaning, don't do the unclamping yet
            //MotionController.Instance.ClearIOForDeviceLoad();


            if (SewingProcess.IsErrored == true)
            {
                SewingProcess.IsErrored = false;
                return;
            }

            SewProcess.State = SewProcess.ReturnToStartState;
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
