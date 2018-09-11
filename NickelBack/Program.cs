using System;
using System.Collections.Generic;

namespace NickelBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            HashSet<Song> allSongs = new HashSet<Song>();
            allSongs.Add(new Song("Blink 182", "All The Small Things"));
            allSongs.Add(new Song("Nickelback", "Home"));
            allSongs.Add(new Song("Smashing Pumpkins", "Tonight, Tonight"));
            allSongs.Add(new Song("Nickelback", "After the Rain"));
            allSongs.Add(new Song("Red Hot Chili Peppers", "Californication"));
            allSongs.Add(new Song("Nickelback", "Feed The Machine"));
            allSongs.Add(new Song("Alice in Chains", "Would"));

            // Iterate over allSongs and save non-Nickelback to a new HashSet
            foreach (Song i in allSongs)
            {
                if (i.GetArtistName != "Nickelback")
                {
                    goodSongs.Add(new Song(i.GetArtistName, i.GetSongName));
                }
            }

            // Print out non-Nickelback songs
            foreach (Song j in goodSongs)
            {
                Console.WriteLine($"{j.GetArtistName} - {j.GetSongName}");
            }

            Console.ReadLine();
        }
    }
}
