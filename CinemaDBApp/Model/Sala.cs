using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    public class Sala
    {
        public int IdSala { get; set; }

        public string Naziv { get; set; }

        public string Tip { get; set; }

        public Kino Kino { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Sala sala &&
                   IdSala == sala.IdSala;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdSala.GetHashCode();
        }

        public override string ToString()
        {
            return "Sala: " + Naziv + ", tip: " + Tip;
        }
    }
}
