using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace SleeveSewing
{
    public class LoadPrompts : INotifyPropertyChanged
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        private string _step1Instructions = string.Empty;
        private string _step2Instructions = string.Empty;
        private string _step3Instructions = string.Empty;
        private string _step4Instructions = string.Empty;
        private string _step5Instructions = string.Empty;

        #endregion ~Instance Members


          ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction

        public LoadPrompts()
        {

        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Properties 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties

        public string Step1Instructions
        {
            get { return _step1Instructions; }
            set
            {
                _step1Instructions = value;
                NotifyPropertyChanged("Step1Instructions");
            }
        }

        public string Step2Instructions
        {
            get { return _step2Instructions; }
            set
            {
                _step2Instructions = value;
                NotifyPropertyChanged("Step2Instructions");
            }
        }

        public string Step3Instructions
        {
            get { return _step3Instructions; }
            set
            {
                _step3Instructions = value;
                NotifyPropertyChanged("Step3Instructions");
            }
        }

        public string Step4Instructions
        {
            get { return _step4Instructions; }
            set
            {
                _step4Instructions = value;
                NotifyPropertyChanged("Step4Instructions");
            }
        }

        public string Step5Instructions
        {
            get { return _step5Instructions; }
            set
            {
                _step5Instructions = value;
                NotifyPropertyChanged("Step5Instructions");
            }
        }

        #endregion ~Properties

        ///////////////////////////////////////////////////////////////////////////////////////////
        //          INotifyPropertyChanged Interface Support
        //////////////////////////////////////////////////////////////////////////////////////////
        #region INotifyPropertyChanged

        //Property Changed Event
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// <para>Raises the Property Changed Event Passing the source property that is updating</para>
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion ~INotifyPropertyChanged

    }
}
