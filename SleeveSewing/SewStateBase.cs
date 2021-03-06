using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gore.FaultHandling;
using Gore.ProcessControlBase;

namespace SleeveSewing
{
    public abstract class SewingStateBase : ProcessControlBase
    {

        public SewingProcess SewProcess{get; set;}
        public String Description { get; set; }
        public abstract void ExecuteState();
        public abstract void SetMotionEvent(bool success);
      

        protected void SetMotionError()
        {

        }
        
        public SewingStateBase(SewingProcess sewingProcess, string stateDescription)
        {
            SewProcess = sewingProcess;
            Description = stateDescription;
        }

        public void ShowError(string errorMessage)
        {

            
            FaultHandling.Globals.FaultStringMsg = errorMessage;

            MotionController.Instance.ClearIOForDeviceLoad();

            // Force a Home as we are in the middle of a process
            if (MotionController.Instance.HomeState != MotionControllerConst.HomedState.MachineNotHomed)
            {
                MotionController.Instance.HomeState = MotionControllerConst.HomedState.MachineNotHomed;
            }

            //Reset the Process State
            SewProcess.State = SewProcess.IdleState;
            MotionController.Instance.ResumeErrorMonitor();
        }   
    }
}
