using CinemaDBApp.MySQLHelper;
using CinemaDBApp.View;
using CinemaDBApp.View.ViewRecepcioner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Reflection;

namespace CinemaDBApp
{
    public partial class MainWindowRecepcioner : Form
    {
        ResourceManager rm;
        public MainWindowRecepcioner(string name)
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            Text = name;
        }

        public MainWindowRecepcioner(string name, CultureInfo culture)
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            _ = new ResourceManager("CinemaDBApp.View.ViewRecepcioner.MainWindowRecepcioner", System.Reflection.Assembly.GetExecutingAssembly());

            Text = name;

        }


        private void filmoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFilmovi ff = new FormFilmovi();
            ff.ShowDialog();
        }

        private void žanroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZanrovi fz = new FormZanrovi();
            fz.ShowDialog();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProizvodi fp = new FormProizvodi();
            fp.ShowDialog();

        }

        private void angažovanaLicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLica fl = new FormLica();
            fl.ShowDialog();
        }

        private void pogledajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProjekcije fp = new FormProjekcije(Text);
            fp.ShowDialog();
        }

        private void oKinuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string infoKino = MySQLKinoInfo.GetKinoInfo()[0].ToString();
            if (Thread.CurrentThread.CurrentCulture.Name.Equals("en"))
            {
                infoKino = infoKino.Replace("Naziv:", "Name:");
                infoKino = infoKino.Replace("Telefoni:", "Telephone:");
                infoKino = infoKino.Replace("Adresa:", "Address:");
            }
            MessageBox.Show(infoKino, rm.GetString("InfoKino"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void karteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKartaIzvjestaj ki = new FormKartaIzvjestaj();
            ki.ShowDialog();
        }

        private void dnevniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] izvjestaj = MySQLKarta.Izvjestaj();
            if (Thread.CurrentThread.CurrentCulture.Name.Equals("en"))
            {
                MessageBox.Show("Total tickets sold today: " + izvjestaj[0] + "\nTraffic: " + izvjestaj[1] + " BAM");
            }
            else
            {
                MessageBox.Show("Ukupno prodano karata danas: " + izvjestaj[0] + "\nPromet: " + izvjestaj[1] + " KM");
            }
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
