using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec02
{
    public class Lamp : IDevice
    {
        public State State { get; set;} = State.Off;

        public void Press()
        {
            throw new NotImplementedException();
        }

        public void Operate()
        {
            State = State == State.On ? State.Off : State.On;
            Console.WriteLine($"Lâmpada está agora {State}.");
        }
    }
}
