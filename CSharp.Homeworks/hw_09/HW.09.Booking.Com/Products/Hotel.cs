using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Products
{
    internal class Hotel : Apartament
    {
        public int Bed { get; set; }  
        public int Room { get; set; }   

        public Hotel(string name, LocationApartament location, int bed, int room, double price) : base(name, location, price)
        {
            Type = TypeApartament.Hotel;           
            Bed = bed;
            Room = room;
        }

        public override void ViewInformation()
        {
            base.ViewInformation();

            Console.WriteLine("-Name: " + Name);
            Console.WriteLine("-Location: " + Location);
            Console.WriteLine("-Type: " + Type);           
            Console.WriteLine("-Rooms: " + Room);
            Console.WriteLine("-Beds: " + Bed);
            Console.WriteLine("-Price: " + Price);
        }
    }
}