

namespace SpotiflyApp
{
    internal class Song:Spotifly
    {
        public DateOnly ReleaseDate {  get; set; }
        public TimeOnly SongLength { get; set; }
        public string Genre { get; set;}
        public string Title { get; set; }
        //list <artist>
    }
}
