using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    public class Projekcija
    {
        public Sala Sala { get; set; }

        public DateTime DatumIVrijemePrikazivanja { get; set; }

        public Film Film { get; set; }

        public decimal Cijena { get; set; }
        public override bool Equals(object obj)
        {
            return obj is Projekcija projekcija &&
                   Sala.IdSala == projekcija.Sala.IdSala &&
                   Film.IdFilm == projekcija.Film.IdFilm &&
                   DatumIVrijemePrikazivanja == projekcija.DatumIVrijemePrikazivanja;
        }

        public override int GetHashCode()
        {
            return -1255590651 + Sala.IdSala.GetHashCode() + Film.IdFilm.GetHashCode() + DatumIVrijemePrikazivanja.GetHashCode();
        }

        public override string ToString()
        {
            return "Projekcija filma: " + Film + ", u sali: " + Sala + ", vrijeme prikazivanja: " +  DatumIVrijemePrikazivanja;
        }
    }
}
