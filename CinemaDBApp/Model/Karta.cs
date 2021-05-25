using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.Model
{
    public class Karta
    {
        public int IdKarta { get; set; }
        public DateTime DatumIVrijemeIzdavanja { get; set; }
        public int RECEPCIONER_ZAPOSLENI_IdZaposleni { get; set; }
        public int PROJEKCIJA_SALA_IdSala { get; set; }
        public int PROJEKCIJA_FILM_IdFilm { get; set; }
        public DateTime PROJEKCIJA_DatumIVrijemePrikazivanja { get; set; }
        public int SJEDISTE_BrojeSjedista { get; set; }
        public int SJEDISTE_RED_IdRed { get; set; }

        public decimal Cijena { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Karta karta &&
                   IdKarta == karta.IdKarta;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdKarta.GetHashCode();
        }

        public override string ToString()
        {
            return IdKarta + DatumIVrijemeIzdavanja.ToString();
        }
    }
}
