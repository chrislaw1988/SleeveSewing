using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;
using System.Runtime.InteropServices;

namespace SleeveSewing
{
    public class SewingProcess : INotifyPropertyChanged
    {


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        internal StateIdle IdleState { get; set; }
        internal StateLoad LoadState { get; set; }
        internal StateSewLeftSide SewLeftSideState { get; set; }
        internal StateSewRightSide SewRightSideState { get; set; }
        internal StatePayoutLeftDeploymentLine PayoutLeftDeploymnetLineState { get; set; }
        internal StatePayoutRightDeploymentLine PayoutRightDeploymentLineState { get; set; }
        internal StateLoopOutLastStitch LoopOutLastStitchState { get; set; }
        internal StateRemoveDevice RemoveDeviceState { get; set; }
        internal StateReturnToStart ReturnToStartState { get; set; }

        public static bool IsErrored { get; set; }

        


        //The Current Sewing State
        private SewingStateBase _sewingState;
      

        #endregion ~Instance Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction

        public SewingProcess()
        {
            IdleState = new StateIdle(this, "Idle");
            LoadState = new StateLoad(this,"Load");
            SewLeftSideState = new StateSewLeftSide(this, "Sewing Left Stitch");
            SewRightSideState = new StateSewRightSide(this, "Sewing Right Stitch");
            PayoutLeftDeploymnetLineState = new StatePayoutLeftDeploymentLine(this, "Payout Left Deployment Line");
            PayoutRightDeploymentLineState = new StatePayoutRightDeploymentLine(this, "Payout Right Deployment Line");
            LoopOutLastStitchState = new StateLoopOutLastStitch(this, "Loop Out");
            RemoveDeviceState = new StateRemoveDevice(this, "Remove Device");
            ReturnToStartState = new StateReturnToStart(this, "Return To Start Position");

            State = IdleState;

            //Hook Up the Event handlers
            MotionController.Instance.MotionTaskComplete += new MotionController.MotionTaskEventHandler(MotionController_MotionTaskComplete);
            MotionController.Instance.MotionErrorComplete += new MotionController.MotionErrorEventHandler(MotionController_MotionErrorComplete);
        }

        #endregion ~Construction


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Propertires
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties

        public SewingStateBase State
        {
            get { return _sewingState; }
            set
            {
                _sewingState = value;
                NotifyPropertyChanged("State");
            }
        }

        public bool IsIdleState
        {
            get { return (State == IdleState);}
        }

        public bool IsLoadState
        {
            get { return (State == LoadState); }
        }
                  
        #endregion ~Properties


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Public Methods
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Public Methods

        public void Start()
        {
            if (IsErrored == true)
            {
                IsErrored = false;
            }
            ExecuteState();

        }

        public bool ExecuteState()
        {
            State.ExecuteState();
            return (true);
        }

        #endregion ~Public Methods


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Motion Controller Events
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Motion Controller Events

        private void MotionController_MotionTaskComplete(object sender, MotionTaskEventArgs args)
        {
            System.Windows.Threading.Dispatcher dispatch = Application.Current.Dispatcher;
            if (dispatch.CheckAccess())
            {
                State.SetMotionEvent(args.Result);
            }
            else
            {
                dispatch.BeginInvoke(new MotionController.MotionTaskEventHandler(MotionController_MotionTaskComplete), new object[] { this, args });
            }
        }

        private void MotionController_MotionErrorComplete(object sender, MotionErrorEventArgs args)
        {
            System.Windows.Threading.Dispatcher dispatch = Application.Current.Dispatcher;
            if (dispatch.CheckAccess())
            {
                IsErrored = true;
                State.ShowError(args.ErrorsAsString);
            }
            else
            {
                dispatch.BeginInvoke(new MotionController.MotionErrorEventHandler(MotionController_MotionErrorComplete), new object[] { this, args });
            }
        }


        #endregion ~Motion Controller Events


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
