using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Task2
{
    internal interface ISongService
    {
        void AddSongsInList(params Song[] songs);
        object GetSongsData(Song song);
        void SearchSongByGenre(string genre);
    }
}