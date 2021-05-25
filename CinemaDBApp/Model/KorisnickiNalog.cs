using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class KorisnickiNalog
    {
        public int IdKorisnickiNalog { get; set; }

        public string KorisnickoIme { get; set; }

        public string Lozinka { get; set; }

        public Zaposleni Zaposleni { get; set; }

        public override bool Equals(object obj)
        {
            return obj is KorisnickiNalog korisnickiNalog &&
                   IdKorisnickiNalog == korisnickiNalog.IdKorisnickiNalog;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdKorisnickiNalog.GetHashCode();
        }

        public override string ToString()
        {
            return KorisnickoIme;
        }
    }
}
