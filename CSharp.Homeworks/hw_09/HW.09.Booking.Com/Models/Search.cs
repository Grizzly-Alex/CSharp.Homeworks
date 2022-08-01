using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW._09.Booking.Com.Products;

namespace HW._09.Booking.Com.Models
{
    internal class Search
    {
        public void SerchApartament()
        {
            Book book = new();
            List<Apartament> apartaments = new (book.GetApartaments()); 

            for (int i = 0; i < apartaments.Count; i++)
            {
                Console.WriteLine($"\n *** Apartament {i} ***");
                apartaments[i].ViewInformation();
            }


        }

        public void SerchApartament(TypeApartament type, LocationApartament lokation)
        {
            Book book = new();

            List<Apartament> apartaments = new(book.GetApartaments());


            for (int i = 0; i < apartaments.Count; i++)
            {
                if (apartaments[i].Type.Equals(type) && apartaments[i].Location.Equals(lokation))
                {
                    Console.WriteLine($"\n *** Apartament {i} ***");
                    apartaments[i].ViewInformation();
                }
            }

        }


    }
}