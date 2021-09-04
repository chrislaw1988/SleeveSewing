using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace SleeveSewing
{
    public class Setup : INotifyPropertyChanged
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        private double _leftNeedleHomeOffset = 0.0;
        private double _rightNeedleHomeOffset = 0.0;
        private double _looperHomeOffset = 0.0;
        private double _traverseHomeOffset = 0.0;
        private bool _reverseLooperInstalled = false;
        private int _payoutFiberTension = 0;
       

        //Load Sleeve Setup Screen Programmable Comments
        
        
        #endregion ~Instance Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction

        public Setup()
        {

        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Properties 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties

        public double LeftNeedleHomeOffset
        {
            get { return _leftNeedleHomeOffset; }
            set
            {
                _leftNeedleHomeOffset = value;
                NotifyPropertyChanged("LeftNeedleHomeOffset");
            }
        }

        public double RightNeedleHomeOffset
        {
            get { return _rightNeedleHomeOffset; }
            set
            {
                _rightNeedleHomeOffset = value;
                NotifyPropertyChanged("RightNeedleHomeOffset");
            }
        }

        public double LooperHomeOffset
        {
            get { return _looperHomeOffset; }
            set
            {
                _looperHomeOffset = value;
                NotifyPropertyChanged("LooperHomeOffset");
            }
        }

                                                                                                                                                              
        public double TraverseHomeOffset
        {
            get { return _traverseHomeOffset; }
            set
            {
                _traverseHomeOffset = value;
                NotifyPropertyChanged("TraverseHomeOffset");
            }
        }


        public bool ReverselooperInstalled
        {
            get { return _reverseLooperInstalled; }
            set 
            {
                _reverseLooperInstalled = value;
                NotifyPropertyChanged("ReverseLooperInstalled");
            }
        }

        public int PayoutFiberTension
        {
            get { return _payoutFiberTension; }
            set
            {
                _payoutFiberTension = value;
                NotifyPropertyChanged("PayoutFiberTension");
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
