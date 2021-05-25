using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class Recepcioner
    {
        public Zaposleni Zaposleni { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Menadzer menadzer &&
                   Zaposleni.IdZaposleni == menadzer.Zaposleni.IdZaposleni;
        }

        public override int GetHashCode()
        {
            return -1255590651 + Zaposleni.IdZaposleni.GetHashCode();
        }

        public override string ToString()
        {
            return Zaposleni.ToString();
        }
    }
}
