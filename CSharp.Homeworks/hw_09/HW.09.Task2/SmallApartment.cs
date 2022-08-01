using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    internal class SmallApartment: House
    {
        public SmallApartment()
        {
            Area = 50;
        }

        public override void ShowData()
        {
            Console.WriteLine($"I'm a small apartament, my area is {Area} m2");
        }
    }
}