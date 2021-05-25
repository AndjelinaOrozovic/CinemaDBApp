using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class FilmZanr
    {
        public int ZANR_IdZanr { get; set; }
        public int FILM_IdFilm { get; set; }

        public override bool Equals(object obj)
        {
            return obj is FilmZanr fz &&
                   ZANR_IdZanr == fz.ZANR_IdZanr &&
                   FILM_IdFilm == fz.FILM_IdFilm;
        }

        public override int GetHashCode()
        {
            return -1255590651 + ZANR_IdZanr.GetHashCode() + FILM_IdFilm.GetHashCode();
        }

        public override string ToString()
        {
            return ZANR_IdZanr.ToString() + ", " + FILM_IdFilm.ToString();
        }
    }
}
