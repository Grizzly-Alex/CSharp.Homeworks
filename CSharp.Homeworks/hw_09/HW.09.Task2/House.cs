using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    internal class House
    {
        protected int Area { get; set; }
        protected Door Door { get; set; }

        public House()
        {
            Area = 200;
            Door = new Door();
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"I'm a house, my area is {Area} m2");
        }

        public Door GetDoor()
        {
            return Door;    
        }
    }
}
