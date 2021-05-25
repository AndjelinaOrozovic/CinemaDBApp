namespace CinemaDBApp.Model
{
    public class Kategorija
    {
        public int IdKategorija { get; set; }
        public string Naziv { get; set; }
        public override bool Equals(object obj)
        {
            return obj is Kategorija kategorija &&
                   IdKategorija == kategorija.IdKategorija;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdKategorija.GetHashCode();
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}