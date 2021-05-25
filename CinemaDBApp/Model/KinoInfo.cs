using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class KinoInfo
    {

        public int Idkino { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Kino kino &&
                   Idkino == kino.IdKino;
        }

        public override int GetHashCode()
        {
            return -1255590651 + Idkino.GetHashCode();
        }

        public override string ToString()
        {
            return "Naziv: " + Naziv + "\nTelefoni: " + Telefon + "\nAdresa: " + Adresa;
        }

    }
}
