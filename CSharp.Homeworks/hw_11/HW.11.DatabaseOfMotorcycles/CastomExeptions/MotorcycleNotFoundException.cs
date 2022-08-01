using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._11.DatabaseOfMotorcycles
{
    internal class MotorcycleNotFoundException : Exception
    {
        public MotorcycleNotFoundException() : base() { }
        public MotorcycleNotFoundException(string message) : base() { } 
    }
}
