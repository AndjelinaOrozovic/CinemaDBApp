using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
using CinemaDBApp.Model;
using CinemaDBApp.MySQLHelper;
using CinemaDBApp.View.ViewMenadzer;

namespace CinemaDBApp
{
    public partial class FormLogIn : Form
    {

        readonly ResourceManager rm;

        public FormLogIn()
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string name;
            bool success = false, recepcioner = false, menadzer = false;

            if (txtBoxUsername.Text != "" && txtBoxPassword.Text != "")
            {   
                foreach (KorisnickiNalog kn in MySQLKorisnickiNalogRecepcioner.GetKorisnickeNaloge(txtBoxUsername.Text))
                {
                    if ((txtBoxPassword.Text.Length <= 15) && (kn.Lozinka).Equals(txtBoxPassword.Text))
                    {
                        name = txtBoxUsername.Text;
                        new MainWindowRecepcioner(name).ShowDialog();
                        success = true;
                        recepcioner = true;
                        txtBoxUsername.Text = "";
                        txtBoxPassword.Text = "";
                    }
                }

                if (!success && !recepcioner)
                {
                    foreach (KorisnickiNalog kn in MySQLKorisnickiNalogMenadzer.GetKorisnickeNaloge(txtBoxUsername.Text))
                    {
                        if ((txtBoxPassword.Text.Length <= 15) && (kn.Lozinka).Equals(txtBoxPassword.Text))
                        {
                            name = txtBoxUsername.Text;
                            new MainWindowMenadzer(name).ShowDialog();
                            success = true;
                            menadzer = true;
                            txtBoxUsername.Text = "";
                            txtBoxPassword.Text = "";
                        }

                    }
                }

                if(!success && (!recepcioner || !menadzer))
                {
                    MessageBox.Show(rm.GetString("NeispravniPodaci"), rm.GetString("Upozorenje"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxUsername.Text = "";
                    txtBoxPassword.Text = "";
                }
            } 
            else
            {
                MessageBox.Show(rm.GetString("NeispravniPodaci"), rm.GetString("Upozorenje"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
            }
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            var language = ConfigurationManager.AppSettings["language"];
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            this.Hide();
            new FormLogIn().ShowDialog();
            this.Close();
        }

        private void btnSrp_Click(object sender, EventArgs e)
        {
            var language1 = ConfigurationManager.AppSettings["language1"];
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language1);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language1);
            this.Hide();
            new FormLogIn().ShowDialog();
            this.Close();
        }

    }
}
