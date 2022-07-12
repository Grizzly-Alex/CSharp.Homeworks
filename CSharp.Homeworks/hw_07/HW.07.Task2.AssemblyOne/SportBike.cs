using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._07.Task2.AssemblyOne
{
    internal class SportBike : Motorcycle
    {
            
        public void FastDrive()
        {        
            ushort maxTankVolumeSport = maxTankVolume;//protected
            ushort maxWeightSport = maxWeight;//protected internal

            StartMotorcycle();//protected
            Brake();//protected internal
            StopMotorcycle();//private protected

            string description = GetDescription();
            Console.WriteLine(description);
        }    
    }
}