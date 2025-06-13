using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec02
{
    public class Switch : IDevice
    {
        public Switch(IDevice lamp)
        {
        }

        public State State => throw new NotImplementedException();

        public void Operate()
        {
            throw new NotImplementedException();
        }
    }
}
