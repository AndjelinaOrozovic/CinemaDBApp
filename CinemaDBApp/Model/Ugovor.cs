using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class Ugovor
    {
        public int IdUgovor { get; set; }

        public DateTime PocetakRadnogOdnosa { get; set; }

        public  DateTime PrekidUgovora { get; set; }

        public Menadzer Menadzer { get; set; }

        public Zaposleni Zaposleni { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Ugovor ugovor &&
                   IdUgovor == ugovor.IdUgovor;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdUgovor.GetHashCode();
        }

        public override string ToString()
        {
            return "Zaposleni:" + Zaposleni.ToString() + "Početak radnog odnosa:" + PocetakRadnogOdnosa + ", Kraj radnog odnosa:" + PrekidUgovora;
        }
    }
}

