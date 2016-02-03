using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        
        private List<Song> songs;

        public CD()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void PrintCollection()
        {
            Console.WriteLine("Song lists");
            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }

        public void PrintData()
        {
            Console.WriteLine("Name: " + Name + "\nArtist: " + Artist);
        }

    }
}
