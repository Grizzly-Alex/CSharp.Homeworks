using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HW13.Task2
{
    [Flags]
    enum Genre
    {
        Other = 0,
        Post = 1,   
        Metal = 2,
        Punk = 4,
        Rock = 8                 
    }

    internal sealed class Song
    {
        private int year;
        private Genre genre;
        public string Name { get; }
        public string Author { get; }
        public TimeSpan Minutes { get; }
       
        public int Year
        { 
            get
            {
                return year;
            }
            private set
            {
                if (value <= DateOnly.MaxValue.Year && value >= DateOnly.MinValue.Year)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Year", "The value must be Range 0 and 9999");
                }
            }
        }
        
        public Genre Genre
        {
            get
            {
                return genre;
            }
            private set
            {
                genre = value;
                
                if ((int)value > 15)
                {
                    genre = Genre.Other;
                }
                else if ((int)value < 0)
                {
                    genre = Genre.Other;
                }
                else
                {
                    genre = value;
                }                               
            }
        }

        public Song(string name, string author,TimeSpan minutes, int year, Genre genre)
        {
            Name = name;
            Author = author;
            Minutes = minutes;
            Year = year;    
            Genre = genre;
        }

        public Song(string name, string author, TimeSpan minutes, int year, int genre)
        {
            Name = name;
            Author = author;
            Minutes = minutes;
            Year = year;
            Genre = (Genre)genre;
        }
    }
}