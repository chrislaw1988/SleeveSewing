using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;

using Gore.Generic;
using Gore.RecipeManager;


namespace SleeveSewing
{
    public class Recipe : RecipeBase
    {
        bool? _EnableBarcode = null;
        string _Barcode = null;
        string _ItemNumber = null;
        string _NeedlePlate = null;
        string _LeftDeploymentLineFiberType = null;
        string _RightDeploymentLineFiberType = null;
        bool _IsDualLine = false;
        string _Tension = null;
        string _StartPosition = null;
        string _MiddleGap = null;
        string _TraverseFeedrate = null;
        string _LeftHeadDeploymentLineLength = null;
        string _RightHeadDeployemtnLineLength = null;
        string _LeftHeadFiberTension = null;
        string _RightHeadFiberTension = null;
        string _LeftHeadSewingSpeed = null;
        string _RightHeadSewingSpeed = null;
        string _LeftHeadMinSewnLength = null;
        string _RightHeadMinSewnLength = null;
        string _LeftHeadStitchDensity = null;
        string _RightHeadStitchDensity = null;
        string _LeftHeadSlowStitchTimeSlice = null;
        string _RightHeadSlowStitchTimeSlice = null;
        string _LeftHeadSlowStitchCount = null;
        string _RightHeadSlowStitchCount = null;
        string _LeftHeadSlowStitchRampCount = null;
        string _RightHeadSlowStitchRampCount = null;
        string _LeftHeadSlowStitchTension = null;
        string _RightHeadSlowStitchTension = null;
        bool? _LeftHeadUseAltTensionForSlowStitches = null;
        bool? _RightHeadUseAltTensionForSlowStitches = null;
        bool? _LeftHeadIsLowStitchDensity = null;
        bool? _RightHeadIsLowStitchDensity = null;

        public Recipe()
        {
        }
        public string NeedlePlate { get { return _NeedlePlate; } set { SetProperty(ref _NeedlePlate, value, nameof(NeedlePlate)); } }
        public string LeftDeploymentLineFiberType { get { return _LeftDeploymentLineFiberType; } set { SetProperty(ref _LeftDeploymentLineFiberType, value, nameof(LeftDeploymentLineFiberType)); } }
        public string RightDeploymentLineFiberType { get { return _RightDeploymentLineFiberType; } set { SetProperty(ref _RightDeploymentLineFiberType, value, nameof(RightDeploymentLineFiberType)); } }

        public string ItemNumber { get { return _ItemNumber; } set { SetProperty(ref _ItemNumber, value, nameof(ItemNumber)); } }
        public string Tension { get { return _Tension; } set { SetProperty(ref _Tension, value, nameof(Tension)); } }
        public string StartPosition { get { return _StartPosition; } set { SetProperty(ref _StartPosition, value, nameof(StartPosition)); } }

        public string MiddleGap { get { return _MiddleGap; } set { SetProperty(ref _MiddleGap, value, nameof(MiddleGap)); } }
        public string TraverseFeedrate { get { return _TraverseFeedrate; } set { SetProperty(ref _TraverseFeedrate, value, nameof(TraverseFeedrate)); } }
        public string LeftHeadDeploymentLineLength { get { return _LeftHeadDeploymentLineLength; } set { SetProperty(ref _LeftHeadDeploymentLineLength, value, nameof(LeftHeadDeploymentLineLength)); } }

        public string RightHeadDeployemtnLineLength { get { return _RightHeadDeployemtnLineLength; } set { SetProperty(ref _RightHeadDeployemtnLineLength, value, nameof(RightHeadDeployemtnLineLength)); } }
        public string LeftHeadFiberTension { get { return _LeftHeadFiberTension; } set { SetProperty(ref _LeftHeadFiberTension, value, nameof(LeftHeadFiberTension)); } }
        public string RightHeadFiberTension { get { return _RightHeadFiberTension; } set { SetProperty(ref _RightHeadFiberTension, value, nameof(RightHeadFiberTension)); } }

        public string LeftHeadSewingSpeed { get { return _LeftHeadSewingSpeed; } set { SetProperty(ref _LeftHeadSewingSpeed, value, nameof(LeftHeadSewingSpeed)); } }
        public string RightHeadSewingSpeed { get { return _RightHeadSewingSpeed; } set { SetProperty(ref _RightHeadSewingSpeed, value, nameof(RightHeadSewingSpeed)); } }
        public string LeftHeadMinSewnLength { get { return _LeftHeadMinSewnLength; } set { SetProperty(ref _LeftHeadMinSewnLength, value, nameof(LeftHeadMinSewnLength)); } }

        public string RightHeadMinSewnLength { get { return _RightHeadMinSewnLength; } set { SetProperty(ref _RightHeadMinSewnLength, value, nameof(RightHeadMinSewnLength)); } }
        public string LeftHeadStitchDensity { get { return _LeftHeadStitchDensity; } set { SetProperty(ref _LeftHeadStitchDensity, value, nameof(LeftHeadStitchDensity)); } }
        public string RightHeadStitchDensity { get { return _RightHeadStitchDensity; } set { SetProperty(ref _RightHeadStitchDensity, value, nameof(RightHeadStitchDensity)); } }

        public string LeftHeadSlowStitchTimeSlice { get { return _LeftHeadSlowStitchTimeSlice; } set { SetProperty(ref _LeftHeadSlowStitchTimeSlice, value, nameof(LeftHeadSlowStitchTimeSlice)); } }
        public string RightHeadSlowStitchTimeSlice { get { return _RightHeadSlowStitchTimeSlice; } set { SetProperty(ref _RightHeadSlowStitchTimeSlice, value, nameof(RightHeadSlowStitchTimeSlice)); } }
        public string LeftHeadSlowStitchCount { get { return _LeftHeadSlowStitchCount; } set { SetProperty(ref _LeftHeadSlowStitchCount, value, nameof(LeftHeadSlowStitchCount)); } }

        public string RightHeadSlowStitchCount { get { return _RightHeadSlowStitchCount; } set { SetProperty(ref _RightHeadSlowStitchCount, value, nameof(RightHeadSlowStitchCount)); } }
        public string LeftHeadSlowStitchRampCount { get { return _LeftHeadSlowStitchRampCount; } set { SetProperty(ref _LeftHeadSlowStitchRampCount, value, nameof(LeftHeadSlowStitchRampCount)); } }
        public string RightHeadSlowStitchRampCount { get { return _RightHeadSlowStitchRampCount; } set { SetProperty(ref _RightHeadSlowStitchRampCount, value, nameof(RightHeadSlowStitchRampCount)); } }

        public string LeftHeadSlowStitchTension { get { return _LeftHeadSlowStitchTension; } set { SetProperty(ref _LeftHeadSlowStitchTension, value, nameof(LeftHeadSlowStitchTension)); } }
        public string RightHeadSlowStitchTension { get { return _RightHeadSlowStitchTension; } set { SetProperty(ref _RightHeadSlowStitchTension, value, nameof(RightHeadSlowStitchTension)); } }
        public bool? LeftHeadUseAltTensionForSlowStitches { get { return _LeftHeadUseAltTensionForSlowStitches; } set { SetProperty(ref _LeftHeadUseAltTensionForSlowStitches, value, nameof(LeftHeadUseAltTensionForSlowStitches)); } }

        public bool? EnableBarcode
        {
            get { return _EnableBarcode; }
            set { SetProperty(ref _EnableBarcode, value, nameof(EnableBarcode)); }
        }
        public bool? RightHeadUseAltTensionForSlowStitches
        {
            get { return _RightHeadUseAltTensionForSlowStitches; }
            set { SetProperty(ref _RightHeadUseAltTensionForSlowStitches, value, nameof(RightHeadUseAltTensionForSlowStitches)); }
        }
        public bool? LeftHeadIsLowStitchDensity
        {
            get { return _LeftHeadIsLowStitchDensity; }
            set { SetProperty(ref _LeftHeadIsLowStitchDensity, value, nameof(LeftHeadIsLowStitchDensity)); }
        }

        public bool? RightHeadIsLowStitchDensity
        {
            get { return _RightHeadIsLowStitchDensity; }
            set { SetProperty(ref _RightHeadIsLowStitchDensity, value, nameof(RightHeadIsLowStitchDensity)); }
        }

        public bool IsDualLine
        {
            get { return _IsDualLine; }
            set { SetProperty(ref _IsDualLine, value, nameof(IsDualLine)); }
        }

        public string Barcode
        {
            get { return _Barcode; }
            set { SetProperty(ref _Barcode, value, nameof(Barcode)); }
        }

        /////////////////////////////////////////////////////////////////////
        // Validate
        /////////////////////////////////////////////////////////////////////
        override public void Validate()
        {
            RangeCheck RangeCheck = new RangeCheck("Recipe Data Error.");

            /*
            // Barcode.
            RangeCheck.NullableBoolHasValue_E(EnableBarcode, nameof(EnableBarcode));
            if(EnableBarcode.Value)
            {
                RangeCheck.NullOrEmpty_E(Barcode, nameof(Barcode));
            }
            */
        }
    }
}
