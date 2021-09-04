using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class MotionTaskEventArgs : EventArgs
    {

        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        private string _message = string.Empty;
        private bool _result = false;

        #endregion ~Instance Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction

        public MotionTaskEventArgs(bool result, string message)
        {

            _message = message;
            _result = result;
        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Properties
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties

        public string Message
        {
            get { return _message; }
        }

        public bool Result
        {
            get { return _result; }
        }

        #endregion ~Properties



    }
}
