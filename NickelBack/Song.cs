using System;
using System.Collections.Generic;
using System.Text;

namespace NickelBack
{
    class Song
    {
        private readonly string _artist;
        private readonly string _name;

        public Song(string artist, string name)
        {
            _artist = artist;
            _name = name;
        }
    }
}
