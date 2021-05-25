using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    class Red
    {
        public int BrojReda { get; set; }

        public Sala Sala { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Red red &&
                   BrojReda == red.BrojReda;

        }

        public override int GetHashCode()
        {
            return -1255590651 + BrojReda.GetHashCode();
        }

        public override string ToString()
        {
            return BrojReda.ToString();
        }
    }
}
