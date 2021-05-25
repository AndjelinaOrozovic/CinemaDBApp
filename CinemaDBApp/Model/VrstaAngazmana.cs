using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class VrstaAngazmana
    {
        public int IdVrstaAngazmana { get; set; }
        public string Naziv { get; set; }

        public override bool Equals(object obj)
        {
            return obj is VrstaAngazmana va &&
                   IdVrstaAngazmana == va.IdVrstaAngazmana;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdVrstaAngazmana.GetHashCode();
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
