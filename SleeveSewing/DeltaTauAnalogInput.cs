using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gore.IO;
using Gore.Generic;

using System.Runtime.CompilerServices;

namespace SleeveSewing
{
    class DeltaTauAnalogInput : AnalogInputBase
    {
        MotionController Controller = null;
        MVar MVar;

        /////////////////////////////////////////////////////////////////////
        // DeltaTauAnalogInput
        /////////////////////////////////////////////////////////////////////

        public DeltaTauAnalogInput(string Name, int MVar, MotionController Controller)
            : this(Name, new MVar(MVar), Controller)
        { }
        public DeltaTauAnalogInput(string Name, MVar MVar, MotionController Controller)
            : base(Name)
        {
            this.MVar = MVar;
            this.Controller = Controller;
        }

        public DeltaTauAnalogInput(string Name, int MVar, MotionController Controller, string UnitsRW, int RWDecimalPlaces = 2, int BoardNumber = -1, int ChannelNumber = -1)
            : this(Name, new MVar(MVar), Controller, UnitsRW, RWDecimalPlaces, BoardNumber, ChannelNumber)
        { }
        public DeltaTauAnalogInput(string Name, MVar MVar, MotionController Controller, string UnitsRW, int RWDecimalPlaces = 2, int BoardNumber = -1, int ChannelNumber = -1)
            : base(Name, UnitsRW, RWDecimalPlaces, BoardNumber, ChannelNumber)
        {
            this.MVar = MVar;
            this.Controller = Controller;
        }

        //device raw (V or mA) is same as controller
        public DeltaTauAnalogInput(string Name, int MVar, MotionController Controller, string UnitsRW, string UnitsRaw, double ControllerCtsMin, double ControllerCtsMax, double ControllerRawMin, double ControllerRawMax, double DeviceRWMin, double DeviceRWMax, int RWDecimalPlaces = 2, int RawDecimalPlaces = 2, int BoardNumber = -1, int ChannelNumber = -1, bool TwosComp = false)
            : this(Name, new MVar(MVar), Controller, UnitsRW, UnitsRaw, ControllerCtsMin, ControllerCtsMax, ControllerRawMin, ControllerRawMax, DeviceRWMin, DeviceRWMax, RWDecimalPlaces, RawDecimalPlaces, BoardNumber, ChannelNumber, TwosComp)
        { }
        public DeltaTauAnalogInput(string Name, MVar MVar, MotionController Controller, string UnitsRW, string UnitsRaw, double ControllerCtsMin, double ControllerCtsMax, double ControllerRawMin, double ControllerRawMax, double DeviceRWMin, double DeviceRWMax, int RWDecimalPlaces = 2, int RawDecimalPlaces = 2, int BoardNumber = -1, int ChannelNumber = -1, bool TwosComp = false)
            : base(Name, UnitsRW, UnitsRaw, ControllerCtsMin, ControllerCtsMax, ControllerRawMin, ControllerRawMax, DeviceRWMin, DeviceRWMax, RWDecimalPlaces, RawDecimalPlaces, BoardNumber, ChannelNumber, TwosComp)
        {
            this.MVar = MVar;
            this.Controller = Controller;
        }
        public DeltaTauAnalogInput(string Name, int MVar, MotionController Controller, string UnitsRW, string UnitsRaw, double ControllerCtsMin, double ControllerCtsMax, double ControllerRawMin, double ControllerRawMax, double DeviceRawMin, double DeviceRawMax, double DeviceRWMin, double DeviceRWMax, int RWDecimalPlaces = 2, int RawDecimalPlaces = 2, int BoardNumber = -1, int ChannelNumber = -1, bool TwosComp = false)
            : this(Name, new MVar(MVar), Controller, UnitsRW, UnitsRaw, ControllerCtsMin, ControllerCtsMax, ControllerRawMin, ControllerRawMax, DeviceRawMin, DeviceRawMax, DeviceRWMin, DeviceRWMax, RWDecimalPlaces, RawDecimalPlaces, BoardNumber, ChannelNumber, TwosComp)
        { }
        public DeltaTauAnalogInput(string Name, MVar MVar, MotionController Controller, string UnitsRW, string UnitsRaw, double ControllerCtsMin, double ControllerCtsMax, double ControllerRawMin, double ControllerRawMax, double DeviceRawMin, double DeviceRawMax, double DeviceRWMin, double DeviceRWMax, int RWDecimalPlaces = 2, int RawDecimalPlaces = 2, int BoardNumber = -1, int ChannelNumber = -1, bool TwosComp = false)
            : base(Name, UnitsRW, UnitsRaw, ControllerCtsMin, ControllerCtsMax, ControllerRawMin, ControllerRawMax, DeviceRawMin, DeviceRawMax, DeviceRWMin, DeviceRWMax, RWDecimalPlaces, RawDecimalPlaces, BoardNumber, ChannelNumber, TwosComp)
        {
            this.MVar = MVar;
            this.Controller = Controller;
        }

        /////////////////////////////////////////////////////////////////////
        // UpdateValue_E
        /////////////////////////////////////////////////////////////////////
        public override void UpdateValue_E(bool FirstUpdateOnTimerTick)
        {
            Value = GetInput_E();
        }

        /////////////////////////////////////////////////////////////////////
        // GetInput_E
        /////////////////////////////////////////////////////////////////////
        public Int32 GetInput_E()
        {
            // Get the Live Input off the controller.
            return Controller.GetMVariable_E(MVar);
        }

        /////////////////////////////////////////////////////////////////////
        // GetIOInfo
        /////////////////////////////////////////////////////////////////////
        public override string GetIOInfo()
        {
            return $"MVar: {MVar.Number}";
        }
    }
}
