using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    internal class Person
    {
        protected string Name { get; set; }
        protected House House { get; set; }

        public Person(string name, House house)
        {
            Name = name;
            House = house;
        }

        public void ShowData()
        {
            Console.WriteLine($"My name is {Name}.");
            House.ShowData();
            House.GetDoor().ShowData();
        }

    }
}