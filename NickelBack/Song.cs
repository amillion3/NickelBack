namespace NickelBack
{
    class Song
    {
        protected readonly string _artist;
        protected readonly string _name;

        public string GetArtistName {
            get { return _artist; }
        }

        public string GetSongName
        {
            get { return _name; }
        }

        public Song(string artist, string name)
        {
            _artist = artist;
            _name = name;
        }

    }
}
