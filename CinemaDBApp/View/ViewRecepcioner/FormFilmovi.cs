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
    public partial class FormFilmovi : Form
    {
        ResourceManager rm;
        public FormFilmovi()
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGrid();
            FillListBoxZnar();
            btnUredi.Enabled = false;
        }

        public FormFilmovi(CultureInfo culture)
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            _ = new ResourceManager("CinemaDBApp.View.ViewRecepcioner.FormFilmovi", System.Reflection.Assembly.GetExecutingAssembly());

            FillGrid();
            FillListBoxZnar();
            btnUredi.Enabled = false;
        }

        void FillListBoxZnar()  //popuni listBox sa zanrovima
        {
            listBoxZanr.DataSource = MySQLHelper.MySQLZanr.GetZanr("");
            listBoxZanr.SelectedIndex = -1;
        }

        void FillGrid() //popuni tabelu
        {
            dgvFilmovi.Rows.Clear();
            foreach (var p in MySQLFilm.GetFilmInfo(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvFilmovi, p.IdFilm, p.Naziv, p.KratakOpis, p.Trajanje, p.Zanr);
                dgvFilmovi.Rows.Add(row);
            }
        }

       

        private void btnOcisti_Click(object sender, EventArgs e) 
        {
            tbNaziv.Text = "";
            tbKratakOpis.Text = "";
            tbTrajanje.Text = "";
            listBoxZanr.SelectedIndex = -1;
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dgvFilmovi_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxZanr.SelectedIndex = -1;
            tbNaziv.Text = dgvFilmovi.SelectedRows[0].Cells[1].Value.ToString();
            tbKratakOpis.Text = dgvFilmovi.SelectedRows[0].Cells[2].Value.ToString();
            tbTrajanje.Text = dgvFilmovi.SelectedRows[0].Cells[3].Value.ToString();
            string zanr = dgvFilmovi.SelectedRows[0].Cells[4].Value.ToString();
            string[] subs = zanr.Split(',');
            for(int i = 0; i < listBoxZanr.Items.Count; i++)
            {
                string p = listBoxZanr.Items[i].ToString();
                for(int j = 0; j < subs.Length; j++)
                {
                    if(p == subs[j])
                    {
                        listBoxZanr.SetSelected(i, true);
                    }
                }
            }
            btnDodaj.Enabled = false;
            btnUredi.Enabled = true;
            btnOcisti.Enabled = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text != "" && tbKratakOpis.Text != "" && tbTrajanje.Text != "" && listBoxZanr.SelectedItem != null)
            {
                var film = new Film()
                {
                    Naziv = tbNaziv.Text,
                    KratakOpis = tbKratakOpis.Text,
                    Trajanje = Convert.ToInt32(tbTrajanje.Text)
                };
                MySQLFilm.InsertFilmove(film);

                int maxIdFilma = MySQLFilm.MaxIdFilma();

                StringBuilder sb = new StringBuilder();
                foreach (var item in listBoxZanr.SelectedItems)
                {
                    sb.Append(item.ToString());
                    sb.Append(",");
                }

                string rez = (sb.ToString()).Substring(0, sb.ToString().Length - 1);
                string[] subs = rez.Split(',');

                for (int j = 0; j < subs.Length; j++)
                {
                    var test = MySQLZanr.GetZanr(subs[j])[0].IdZanr;
                    Console.WriteLine(subs[j]);
                    FilmZanr fz = new FilmZanr()
                    {
                        FILM_IdFilm = maxIdFilma,
                        ZANR_IdZanr = test
                    };
                    MySQLFilmZanr.InsertFilmZanr(fz);
                }
                FillGrid();
                FormLica fl = new FormLica();
                fl.ShowDialog();
                tbNaziv.Text = "";
                tbKratakOpis.Text = "";
                tbTrajanje.Text = "";
                listBoxZanr.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFilmovi_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            FilmInfo fi = (FilmInfo)e.Row.Tag;
            var result = MessageBox.Show(rm.GetString("PotvrdaBrisanjaPitanje"), rm.GetString("PotvrdaBrisanja"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Film f = new Film()
            {
                IdFilm = fi.IdFilm,
                Naziv = fi.Naziv,
                KratakOpis = fi.KratakOpis,
                Trajanje = fi.Trajanje
            };
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    MySQLFilm.DeleteFilmById(f.IdFilm);
                }
                catch { MessageBox.Show(rm.GetString("FilmNeBrisi"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); FillGrid(); };
                tbNaziv.Text = "";
                tbKratakOpis.Text = "";
                tbTrajanje.Text = "";
                listBoxZanr.SelectedIndex = -1;
                FillGrid();
            }
            else
            {
                FillGrid();
            }
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text != "" && tbKratakOpis.Text != "" && tbTrajanje.Text != "" && listBoxZanr.SelectedItem != null)
            {
                    String selected = dgvFilmovi.SelectedRows[0].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(selected);
                    var film = new Film()
                    {
                        IdFilm = id,
                        Naziv = tbNaziv.Text,
                        KratakOpis = tbKratakOpis.Text,
                        Trajanje = Convert.ToInt32(tbTrajanje.Text)
                    };
                    MySQLFilm.UpdateFilm(film);

                    StringBuilder sb = new StringBuilder();
                    foreach (var item in listBoxZanr.SelectedItems)
                    {
                        sb.Append(item.ToString());
                        sb.Append(",");
                    }

                    string rez = (sb.ToString()).Substring(0, sb.ToString().Length - 1);
                    string[] subs = rez.Split(',');

                    for (int j = 0; j < subs.Length; j++)
                    {
                        var test = MySQLZanr.GetZanr(subs[j])[0].IdZanr;
                        Console.WriteLine(subs[j]);
                        FilmZanr fz = new FilmZanr()
                        {
                            FILM_IdFilm = id,
                            ZANR_IdZanr = test
                        };
                        MySQLFilmZanr.InsertFilmZanr(fz);
                    }
                
                    FillGrid();
                    tbNaziv.Text = "";
                    tbKratakOpis.Text = "";
                    tbTrajanje.Text = "";
                    listBoxZanr.SelectedIndex = -1;
                    btnUredi.Enabled = false;
                    btnOcisti.Enabled = true;
                    btnDodaj.Enabled = true;
            }
            else
            {
                MessageBox.Show(rm.GetString("NeispravanUnos"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxZanr.SelectedIndex = -1;
            }
        }

        private void tbTrajanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
    }
}
