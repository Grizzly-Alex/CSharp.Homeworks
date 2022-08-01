using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    internal class Person
    {
        protected int age;

        public void SetAge(ref int n)
        {
            age = n; 
        }

        public void Great()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
}