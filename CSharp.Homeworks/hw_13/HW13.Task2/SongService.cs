using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW13.Task2
{
    internal class SongService : ISongService
    {
        public static List<Song> SongsList = new();

        public void AddSongsInList(params Song[] songs)
        {
            foreach (var song in songs)
            {
                SongsList.Add(song);
            }
        }

        public object GetSongsData(Song song)
        {
            return new
            {
                Title = $"{song.Name} - {song.Author}",
                Minutes = $"{song.Minutes.Minutes}:{song.Minutes.Seconds}",
                AlbumYear = song.Year,
                Genre = song.Genre.ToString() 
            };
        }

        public void SearchSongByGenre(string generStr)
        {
            Genre gen;

            if (Enum.TryParse(generStr, out Genre genere))
            {
                gen = genere;
            }
            else
            {
                gen = Genre.Other;
            }

            foreach (var song in SongsList)
            {
                if (song.Genre.Equals(gen))
                {
                    Console.WriteLine(GetSongsData(song));
                }
            }
        }
    }
}