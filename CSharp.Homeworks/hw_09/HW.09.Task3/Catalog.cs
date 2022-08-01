using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    
    internal class Catalog
    {
        public Music[] Music { get; set; }
        public Film[] Films { get; set; }
        public ComputerProgram[] ComputerPrograms { get; set; }

        public Catalog(int countMusic, int countFilms, int countPrograms)
        {
            Music = new Music[countMusic];
            Films = new Film[countFilms];
            ComputerPrograms = new ComputerProgram[countPrograms];
        }

        public void Play(params Music[] songs)
        {
            Console.WriteLine("\n *** Songs are playing now: *** ");

            foreach (var song in songs)
            {
                song.RetrieveInformation();
            }
        }

        public void Play(params Film[] films)
        {
            Console.WriteLine("\n *** Films are playing now: *** ");

            foreach (var film in films)
            {
                film.RetrieveInformation();
            }
        }
    }

}