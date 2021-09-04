using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gore.IO;

using System.Runtime.CompilerServices;

namespace SleeveSewing
{
    class DeltaTauDigitalOutput : DigitalOutputBase
    {

        MotionController Controller = null;
        MVar MVar;
        public DeltaTauDigitalOutput(string Name, bool IsEnabled, int MVar, MotionController Controller, int BoardNumber = -1, int BitNumber = -1, bool SimulationState = false)
            : this(Name, IsEnabled, new MVar(MVar), Controller, BoardNumber, BitNumber, SimulationState)
        { }

        public DeltaTauDigitalOutput(string Name, bool IsEnabled, MVar MVar, MotionController Controller, int BoardNumber = -1, int BitNumber = -1, bool SimulationState = false)
            : base(Name, BoardNumber, BitNumber, IsEnabled, SimulationState)
        {
            this.MVar = MVar;
            this.Controller = Controller;
        }

        public override string GetIOInfo()
        {
            return $"MVar: {MVar.Number}";
        }

        public bool GetOutput_E()
        {
            // Get the Live Input off the controller.
            return Controller.GetMVariable_E(MVar) != 0;
        }

        public void SetOutput_E(bool OutputValue)
        {
            // Set the Live Output on the controller.
            Controller.SetMVariable_E(MVar, OutputValue ? 1 : 0);
        }

        public override void ToggleState_E()
        {
            // Change the state.  Change the State variable immediately so the GUI LED changes right when you click on it.
            State = !State;
            SetOutput_E(State);
        }

        public override void UpdateState_E(bool FirstUpdateOnTimerTick)
        {
            State = GetOutput_E();
        }
    }

    public class MVar : VarBase
    {
        public MVar(int Number, [CallerMemberName] string Name = null) : base(Number, Name)
        {
        }
    }

    public class PVar : VarBase
    {
        public PVar(int Number, [CallerMemberName] string Name = null) : base(Number, Name)
        {
        }
    }

    public class VarBase
    {
        public int Number = -1;
        public string Name = "";

        public VarBase(int Number, string Name)
        {
            this.Number = Number;
            this.Name = Name;
        }
    }
}
