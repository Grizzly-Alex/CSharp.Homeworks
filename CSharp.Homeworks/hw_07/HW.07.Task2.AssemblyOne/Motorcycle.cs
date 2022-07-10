using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._07.Task2.AssemblyOne
{
    public class Motorcycle
    {
        public const ushort MaxSpeed = 300;
        protected ushort maxTankVolume = 25;
        protected internal ushort maxWeight = 435;

        public string color = "black";
        private string description = "This is motorcycle";
        internal bool gasolineEngine = true;


        protected void StartMotorcycle()
        {
         
        }

        private void Drive()
        {
           
        }

        protected internal void Brake()
        {
           
        }

        private protected void StopMotorcycle()
        {
           
        }

    }
}
