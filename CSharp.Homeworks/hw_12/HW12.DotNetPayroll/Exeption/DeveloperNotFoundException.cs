using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.DotNetPayroll.Exeption
{
    internal class DeveloperNotFoundException : Exception
    {
        public DeveloperNotFoundException(){}
        public DeveloperNotFoundException(string message) : base(message) {}
        public DeveloperNotFoundException(string message, Exception innerException) : base(message, innerException) {}
    }
}
