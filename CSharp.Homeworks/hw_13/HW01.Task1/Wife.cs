using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Task1
{
    internal sealed class Wife
    {
        private static Wife instance;
        public string Name { get; set; }    
        private Wife() { }


        public static Wife GetInstance()
        {
            if (instance is null)
            {
                instance = new Wife();
            }
            return instance;
        }

        public override string ToString()
        {
            return $"My name is {Name}";
        }
    }
}
