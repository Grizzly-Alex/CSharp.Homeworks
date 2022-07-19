using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW._09.Booking.Com.Products;

namespace HW._09.Booking.Com.Models
{
    internal class Book
    {
        #region Apartaments

        Hostel hostel1 = new(
            "Loft Car Factory",
            LocationApartament.Warsaw,
            25);

        Hostel hostel2 = new(
            "Hostel Mleczna",
            LocationApartament.Warsaw,
            18);

        Hostel hostel3 = new(
            "Fry House",
            LocationApartament.Warsaw,
            19);

        Hotel hotel1 = new(
            "Novotel Warszawa Centrum",
            LocationApartament.Warsaw,
            2,
            1,
            40);

        Hotel hotel2 = new(
            "Holiday Inn Express Warsaw",
            LocationApartament.Warsaw,
            1,
            1,
            35);

        Hotel hotel3 = new(
            "Radisson Blu Sobieski",
            LocationApartament.Warsaw,
            3,
            2,
            50);

        Hostel hostel4 = new(
            "Industriepalast Berlin",
            LocationApartament.Berlin,
            35);

        Hostel hostel5 = new(
            "Berlin Kolumbus",
            LocationApartament.Berlin,
            33);

        Hostel hostel6 = new(
            "Grand Hostel Berlin Urban",
            LocationApartament.Berlin,
            36);

        Hotel hotel4 = new(
            "Hotel Neuer Fritz",
            LocationApartament.Berlin,
            3,
            2,
            80);

        Hotel hotel5 = new(
            "City Hotel Berlin East",
            LocationApartament.Berlin,
            2,
            1,
            55);

        Hotel hotel6 = new(
            "Leonardo Hotel Berlin Mitte",
            LocationApartament.Berlin,
            5,
            3,
            110);

        Hostel hostel7 = new(
            "The People - Paris Marais",
            LocationApartament.Paris,
            45);

        Hostel hostel8 = new(
            "MIJE MARAIS",
            LocationApartament.Paris,
            38);

        Hostel hostel9 = new(
            "Generator Paris",
            LocationApartament.Paris,
            40);

        Hotel hotel7 = new(
            "Hotel Lutetia",
            LocationApartament.Paris,
            1,
            1,
            120);

        Hotel hotel8 = new(
            "Grand Hôtel Amelot",
            LocationApartament.Paris,
            2,
            2,
            55);

        Hotel hotel9 = new(
            "L'Empire Paris",
            LocationApartament.Paris,
            2,
            3,
            110);
        #endregion

        List<Apartament> apartaments = new();

        private void CreateListWithApartaments()
        {
            apartaments.Add(hostel1);
            apartaments.Add(hostel2);
            apartaments.Add(hostel3);
            apartaments.Add(hostel4);
            apartaments.Add(hostel5);
            apartaments.Add(hostel6);
            apartaments.Add(hostel7);
            apartaments.Add(hostel8);
            apartaments.Add(hostel9);
            apartaments.Add(hotel1);
            apartaments.Add(hotel2);
            apartaments.Add(hotel3);
            apartaments.Add(hotel4);
            apartaments.Add(hotel5);
            apartaments.Add(hotel6);
            apartaments.Add(hotel7);
            apartaments.Add(hotel8);
            apartaments.Add(hotel9);
        }

        public List<Apartament> GetApartaments()
        {
            CreateListWithApartaments();
            return apartaments;
        }
    } 
}