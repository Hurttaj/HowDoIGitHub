using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd1 = new CD();
            cd1.Name = "Endless Forms Most Beautiful";
            cd1.Artist = "Nightwish";

            Song song1 = new Song();
            song1.SongName = "Shudder Before the Beautiful";
            song1.Length = 6.29;
            cd1.AddSong(song1);
            Song song2 = new Song();
            song2.SongName = "Nyt loppu tää Nightwish pelleily";
            song2.Length = 7.11;
            cd1.AddSong(song2);

            cd1.PrintData();
            cd1.PrintCollection();
            

        }
    }
}
