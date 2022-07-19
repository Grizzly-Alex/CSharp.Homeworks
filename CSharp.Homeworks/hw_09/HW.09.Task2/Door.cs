using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    internal class Door
    {
        protected string Color { get; set; }

        public Door()
        {
            Color = "white";
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a door, my color is {Color}");
        }
    }
}