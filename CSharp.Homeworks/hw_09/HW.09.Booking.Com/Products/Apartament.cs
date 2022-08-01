using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Products
{
    enum TypeApartament
    {
        Hostel = 1,
        Hotel = 2,
    }

    enum LocationApartament
    {
        Warsaw = 1,
        Berlin = 2,
        Paris = 3,
    }

    internal class Apartament
    {
        public string Name { get; set; }
        public LocationApartament Location { get; set; }    
        public TypeApartament Type { get; set; }     
        public double Price { get; set; }  
        
        public Apartament(string name, LocationApartament location, double price)
        {
            Name = name;
            Location = location;
            Price = price;
        }

        public virtual void ViewInformation()
        {
            Console.WriteLine("Information:");
        }
    }
}
