using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    internal class ComputerProgram : Item
    {
        public ComputerProgram(string name, uint size, string code) : base(name, size, code)
        {
            category = "programs";
        }
    }
}
