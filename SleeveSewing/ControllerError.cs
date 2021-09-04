using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleeveSewing
{
    class ControllerError
    {

        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        int _errorCode = -1;
        string _errorDescription = string.Empty;

        #endregion ~Instance Members

        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction

        public ControllerError()
        {

        }

        public ControllerError(int code, string description)
        {
            _errorCode = code;
            _errorDescription = description;
        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Properties 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties

        public int Code
        {
            get { return _errorCode; }
            set { _errorCode = value;}
        }

        public string Description
        {
            get { return _errorDescription; }
            set { _errorDescription = value; }
        }

        #endregion ~Properties


    }
}
