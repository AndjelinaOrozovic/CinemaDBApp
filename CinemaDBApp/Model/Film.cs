using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    public class Film
    {
        public int IdFilm { get; set; }
        public string Naziv { get; set; }
        public string KratakOpis { get; set; }
        public int Trajanje { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Film film &&
                   IdFilm == film.IdFilm;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdFilm.GetHashCode();
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
