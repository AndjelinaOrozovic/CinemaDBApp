using CinemaDBApp.Model;
using CinemaDBApp.MySQLHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDBApp.View.ViewRecepcioner
{
    public partial class FormKarta : Form
    {
        Projekcija pr;
        ResourceManager rm;
        public FormKarta(string name, Projekcija projekcija)
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            Text = name;
            findRecepcioner();
            setLabels(projekcija);
            pr = projekcija;
            comboBoxRed.SelectedIndex = -1;
            comboBoxSjediste.SelectedIndex = -1;
            metodaRedovi();
            //metodaSjedista(1);
            comboBoxSjediste.Enabled = false;
            btnIzdaj.Enabled = false;
        }

        void metodaRedovi()
        {
            comboBoxRed.Items.Clear();
            var redovi = MySQLRed.GetRedove(pr.Sala.Naziv);
            foreach (var r in redovi)
            {
                comboBoxRed.Items.Add(r.BrojReda);
            }
        }
        
        int brSjedista(int brReda)
        {
            var sjedista = MySQLSjediste.GetSjedista(brReda.ToString());
            return sjedista.Count();
        }

        void metodaSjedista(int brReda)
        {
            comboBoxSjediste.Items.Clear();
                var sjedista = MySQLSjediste.GetSjedista(brReda.ToString());
                foreach(var s in sjedista)
                {
                    var zauzeto = MySQLKarta.Izdata(new Karta() {
                        //DatumIVrijemeIzdavanja = DateTime.Now,
                       // RECEPCIONER_ZAPOSLENI_IdZaposleni = findRecepcioner().IdZaposleni,
                        PROJEKCIJA_SALA_IdSala = pr.Sala.IdSala,
                        PROJEKCIJA_FILM_IdFilm = pr.Film.IdFilm,
                        PROJEKCIJA_DatumIVrijemePrikazivanja = pr.DatumIVrijemePrikazivanja,
                        SJEDISTE_BrojeSjedista = s.BrojSjedista,
                        SJEDISTE_RED_IdRed = brReda
                    });
                    if (zauzeto == 0)
                    {
                        comboBoxSjediste.Items.Add(s.BrojSjedista);
                    }
                }
        }


        public FormKarta(string name, Projekcija projekcija, CultureInfo culture)
        {

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            _ = new ResourceManager("CinemaDBApp.View.ViewRecepcioner.FormKarta", System.Reflection.Assembly.GetExecutingAssembly());
            InitializeComponent();

            Text = name;
            findRecepcioner();
            setLabels(projekcija);
            pr = projekcija;
        }


        public Zaposleni findRecepcioner()
        {
            KorisnickiNalog kn = MySQLKorisnickiNalogRecepcioner.GetKorisnickiNalogByUsername(Text);
            Recepcioner r = MySQLRecepcioner.GetRecepcioner(kn.Zaposleni.IdZaposleni.ToString()); //dohvati samo id
            Zaposleni za = new Zaposleni();
            za = MySQLZaposleni.GetZaposlenogById(r.Zaposleni.IdZaposleni.ToString());
            return za;
        }

        public void setLabels(Projekcija projekcija)
        {
            lbllDatumIVrijemeIzdavanja.Text += " " + DateTime.Now;
            lblRecepcioner.Text += $" ({findRecepcioner().Ime + " " + findRecepcioner().Prezime})";
            lblPocetakProjekcije.Text += " " + projekcija.DatumIVrijemePrikazivanja;
            lblProjekcija.Text += " " + projekcija.Film.Naziv;
            lblSala.Text += " " + projekcija.Sala.Naziv;
            //comboBoxRed.DataSource = MySQLRed.GetRedove(projekcija.Sala.Naziv.ToString());
            //comboBoxSjediste.SelectedIndex = -1;
        }

        private void comboBoxRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodaSjedista((int)comboBoxRed.SelectedItem);
            comboBoxSjediste.Enabled = true;
            /*
            comboBoxSjediste.Items.Clear();
            List<Sjediste> sjedista = new List<Sjediste>(MySQLSjediste.GetSjedista(comboBoxRed.SelectedItem.ToString()));
            foreach (var sjediste in sjedista)
            {

                comboBoxSjediste.Items.Add(sjediste);
            }
            //comboBoxSjediste.Items.AddRange(sjedista);
            //omboBoxSjediste.DataSource = sjedista;
            comboBoxSjediste.SelectedIndex = -1;*/
        }

        private void BtnIzdaj_Click(object sender, EventArgs e)
        {
            if (comboBoxRed.SelectedItem != null && comboBoxSjediste.SelectedItem != null)
            {
                Karta k = new Karta()
                {
                    DatumIVrijemeIzdavanja = DateTime.Now,
                    RECEPCIONER_ZAPOSLENI_IdZaposleni = findRecepcioner().IdZaposleni,
                    PROJEKCIJA_SALA_IdSala = pr.Sala.IdSala,
                    PROJEKCIJA_FILM_IdFilm = pr.Film.IdFilm,
                    PROJEKCIJA_DatumIVrijemePrikazivanja = pr.DatumIVrijemePrikazivanja,
                    SJEDISTE_BrojeSjedista = Convert.ToInt32(comboBoxSjediste.SelectedItem.ToString()),
                    SJEDISTE_RED_IdRed = Convert.ToInt32(comboBoxRed.SelectedItem.ToString())
                };
                if (MySQLKarta.Izdata(k) == 0)
                {
                    //comboBoxSjediste.Items.Remove(comboBoxSjediste.SelectedItem);
                    MySQLKarta.InsertKarta(k);
                    metodaSjedista((int)comboBoxRed.SelectedItem);
                    MessageBox.Show(rm.GetString("KartaUspjesna"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show(rm.GetString("Mjesto"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxSjediste_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIzdaj.Enabled = true;
        }
    }
}
