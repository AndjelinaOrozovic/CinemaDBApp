using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class Proizvod
    {
        public int IdProizvod { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public Kategorija Kategorija { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Proizvod proizvod &&
                   IdProizvod == proizvod.IdProizvod;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdProizvod.GetHashCode();
        }

        public override string ToString()
        {
            return Naziv + ", " + Cijena + "KM";
        }
    }
}
