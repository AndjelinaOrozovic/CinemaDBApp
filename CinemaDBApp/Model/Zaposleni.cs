namespace CinemaDBApp.Model
{
    public class Zaposleni
    {
        public int IdZaposleni { get; set; }

        public string Jmb { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string Email { get; set; }

        public decimal Plata { get; set; }

        public Kino Kino { get; set; }

        public Adresa Adresa { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Zaposleni zaposleni &&
                   IdZaposleni == zaposleni.IdZaposleni;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdZaposleni.GetHashCode();
        }

        public override string ToString()
        {
            return Prezime + ", " + Ime;
        }
    }
}