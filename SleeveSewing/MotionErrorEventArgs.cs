using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class MotionErrorEventArgs
    {

        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        List<ControllerError> _errorList = new List<ControllerError>();

        #endregion ~Instance Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction
        public MotionErrorEventArgs(List<ControllerError> errorList)
        {
            _errorList = errorList.ToList();
        }


        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Properties
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties

        public List<ControllerError> Errors
        {
            get
            {
                return _errorList.ToList();
            }
        }

        public string ErrorsAsString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (ControllerError ce in Errors)
                {
                    sb.AppendLine(ce.Description);
                }
                return(sb.ToString());
            }
        }


        #endregion  ~Properties


    }
}
