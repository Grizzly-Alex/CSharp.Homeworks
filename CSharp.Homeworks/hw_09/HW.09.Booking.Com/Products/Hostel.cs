using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Products
{
    internal class Hostel : Apartament
    {
        public Hostel(string name, LocationApartament location, double price) : base(name, location, price)
        {
            Type = TypeApartament.Hostel;
 
        }

        public override void ViewInformation()
        {
            base.ViewInformation();

            Console.WriteLine("-Name: "+Name);
            Console.WriteLine("-Location: "+Location);
            Console.WriteLine("-Type: "+Type);
            Console.WriteLine("-Price: "+Price);
        }
    }
}