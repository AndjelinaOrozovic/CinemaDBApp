using CinemaDBApp.MySQLHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace CinemaDBApp.View.ViewMenadzer
{
    public partial class MainWindowMenadzer : Form
    {
        readonly ResourceManager rm;
        public MainWindowMenadzer(string name)
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            Text = name;
        }

        private void adreseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdrese fm = new FormAdrese();
            fm.ShowDialog();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZaposleni fz = new FormZaposleni(Text);
            fz.ShowDialog();
        }

        private void ugovoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUgovori fu = new FormUgovori(Text);
            fu.ShowDialog();
        }

        private void oKinuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string infoKino = MySQLKinoInfo.GetKinoInfo()[0].ToString();
            if(Thread.CurrentThread.CurrentCulture.Name.Equals("en"))
            {
                infoKino = infoKino.Replace("Naziv:", "Name:");
                infoKino = infoKino.Replace("Telefoni:", "Telephone:");
                infoKino = infoKino.Replace("Adresa:", "Address:");
            }
            MessageBox.Show(infoKino, rm.GetString("InfoKino"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
