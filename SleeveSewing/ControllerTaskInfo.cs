using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class ControllerTaskInfo
    {


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        private MotionController.StatusBits _statusBitToMonitor;
        
        #endregion ~Instance Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction

        public ControllerTaskInfo(MotionController.StatusBits bitToMonitor) 
        {
            _statusBitToMonitor = bitToMonitor;
        }


        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Properties
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties


        public MotionController.StatusBits StatusBitToMonitor
        {
            get { return _statusBitToMonitor; }
        }
       

        #endregion ~Properties





    }
}
