using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class Zanr
    {
        public int IdZanr { get; set; }
        public string Naziv { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Zanr zanr &&
                   IdZanr == zanr.IdZanr;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdZanr.GetHashCode();
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
