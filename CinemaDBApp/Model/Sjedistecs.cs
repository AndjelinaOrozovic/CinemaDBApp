using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class Sjediste
    {
        public int BrojSjedista;

        public Red Red;

        public Sala Sala;

        public override bool Equals(object obj)
        {
            return obj is Sjediste sjediste &&
                   BrojSjedista == sjediste.BrojSjedista;
        }

        public override int GetHashCode()
        {
            return -1255590651 + BrojSjedista.GetHashCode();
        }

        public override string ToString()
        {
            return BrojSjedista.ToString();
        }
    }
}
