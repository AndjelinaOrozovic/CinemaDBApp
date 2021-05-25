using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class Angazman
    {

        public int LICE_IdLica { get; set; }
        public int VRSTA_ANGAZMANA_IdVrstaAngazmana { get; set; }
        public int FILM_IdFilm { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Angazman angazman &&
                   LICE_IdLica == angazman.LICE_IdLica &&
                   VRSTA_ANGAZMANA_IdVrstaAngazmana == angazman.VRSTA_ANGAZMANA_IdVrstaAngazmana &&
                   FILM_IdFilm == angazman.FILM_IdFilm;
        }

        public override int GetHashCode()
        {
            return -1255590651 + LICE_IdLica.GetHashCode() + VRSTA_ANGAZMANA_IdVrstaAngazmana.GetHashCode() + FILM_IdFilm.GetHashCode();
        }

        public override string ToString()
        {
            return LICE_IdLica.ToString() + ", " + VRSTA_ANGAZMANA_IdVrstaAngazmana.ToString() + ", " + FILM_IdFilm.ToString();
        }

    }
}
