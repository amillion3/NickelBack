using System;
using System.Collections.Generic;
using System.Text;

namespace NickelBack
{
    class Song
    {
        protected readonly string _artist;
        protected readonly string _name;

        public Song(string artist, string name)
        {
            _artist = artist;
            _name = name;
        }

        public string GetArtistName() {
            return _artist;
        }
    }
}
