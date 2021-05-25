using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class Lice
    {
        public int IdLice { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Lice lice &&
                   IdLice == lice.IdLice;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdLice.GetHashCode();
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
