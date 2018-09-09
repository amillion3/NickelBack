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
            Song song1 = new Song("Blink 182", "All The Small Things");
            Song song2 = new Song("Nickelback", "Home");
            Song song3 = new Song("Smashing Pumpkins", "Tonight, Tonight");
            Song song4 = new Song("Nickelback", "After the Rain");
            Song song5 = new Song("Red Hot Chili Peppers", "Californication");
            Song song6 = new Song("Nickelback", "Feed The Machine");
            Song song7 = new Song("Alice in Chains", "Would");

            // Define a class called Song that has a string property Artist and a string property Name.
            // Both properties should be required(invariant) in order to construct an instance of Song
            //Define a List, named goodSongs, that will hold instances of Song.
            //Define a HashSet, named allSongs, that contains 7 instances of Song.
            //Make sure that some of the songs are from the band Nickelback. You can see a list of 
            // their greatest hits on Amazon.
            //Once the set is populated with 7 instances, iterate over the set of songs, 
            // and check if the band name is "Nickelback".
            //If the band is not Nickelback, then add it to the goodSongs list.
            //Use another foreach loop to print out all the good songs.
        }
    }
}
