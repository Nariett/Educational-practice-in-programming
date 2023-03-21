using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part60
{
    internal class Film
    {
        public string film { get; set; }
        public int sessions { get; set; }
        public string language { get; set; }
        public string genre { get; set; }
        public Film (string Film,int Sessions, string Language,string Genre)
        {
            this.film = Film;
            this.sessions = Sessions;
            this.language = Language;
            this.genre = Genre;
        }
        public Film() { }
        public override string ToString()
        {
            return $"Название фильма: {film}\nКол-во сеансов: {sessions}\nЯзык фильма: {language}\nЖанр фильма: {genre}";
        }
    }
}
