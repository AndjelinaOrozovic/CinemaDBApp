namespace CinemaDBApp.Model
{
    public class Kino
    {
        public int IdKino { get; set; }
        public string Naziv { get; set; }
        public Adresa Adresa { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Kino kino &&
                   IdKino == kino.IdKino;
        }

        public override int GetHashCode()
        {
            return -1255590651 + IdKino.GetHashCode();
        }

        public override string ToString()
        {
            return Naziv;
        }

    }
}