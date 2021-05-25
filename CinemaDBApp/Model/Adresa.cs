namespace CinemaDBApp.Model
{
    public class Adresa
    {

        public int IdAdresa { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string PostanskiBroj { get; set; }
        public string Ulica { get; set; }
        public string Broj { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Adresa adresa &&
                   IdAdresa == adresa.IdAdresa;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdAdresa.GetHashCode();
        }

        public override string ToString()
        {
            return Ulica + ", " + Broj + ", " + Grad + ", " + PostanskiBroj + ", " + Drzava ;
        }

    }
}