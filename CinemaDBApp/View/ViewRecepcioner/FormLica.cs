using CinemaDBApp.Model;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDBApp.View.ViewRecepcioner
{
    public partial class FormLica : Form
    {
        ResourceManager rm;
        public FormLica()
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGrid();
            FillListBoxVrstaAngazmana();
            btnUredi.Enabled = false;
        }

        void FillListBoxVrstaAngazmana()  //popuni listBox sa zanrovima
        {
            listBoxVrstaAngazmana.DataSource = MySQLVrstaAngazmana.GetVrstaAngazmana("");
            listBoxVrstaAngazmana.SelectedIndex = -1;
        }

        void FillGrid() //popuni tabelu
        {
            dgvLica.Rows.Clear();
            foreach (var p in MySQLLice.GetLiceInfo(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvLica, p.IdLice, p.Ime, p.Prezime, p.VrstaAngazmana);
                dgvLica.Rows.Add(row);
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            listBoxVrstaAngazmana.SelectedIndex = -1;
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dgvLica_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxVrstaAngazmana.SelectedIndex = -1;
            tbIme.Text = dgvLica.SelectedRows[0].Cells[1].Value.ToString();
            tbPrezime.Text = dgvLica.SelectedRows[0].Cells[2].Value.ToString();
            string angazmann = dgvLica.SelectedRows[0].Cells[3].Value.ToString();
            string[] subs = angazmann.Split(',');
            for (int i = 0; i < listBoxVrstaAngazmana.Items.Count; i++)
            {
                string p = listBoxVrstaAngazmana.Items[i].ToString();
                for (int j = 0; j < subs.Length; j++)
                {
                    if (p == subs[j])
                    {
                        listBoxVrstaAngazmana.SetSelected(i, true);
                    }
                }
            }
            btnDodaj.Enabled = false;
            btnUredi.Enabled = true;
            btnOcisti.Enabled = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbIme.Text != "" && tbPrezime.Text != "" && listBoxVrstaAngazmana.SelectedItem != null)
            {
                var lice = new Lice()
                {
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text
                };
                MySQLLice.InsertLica(lice);

                int maxIdFilma = MySQLFilm.MaxIdFilma();
                int maxIdLica = MySQLLice.MaxIdLica();

                StringBuilder sb = new StringBuilder();
                foreach (var item in listBoxVrstaAngazmana.SelectedItems)
                {
                    sb.Append(item.ToString());
                    sb.Append(",");
                }

                string rez = (sb.ToString()).Substring(0, sb.ToString().Length - 1);
                string[] subs = rez.Split(',');

                for (int j = 0; j < subs.Length; j++)
                {
                    var test = MySQLVrstaAngazmana.GetVrstaAngazmana(subs[j])[0].IdVrstaAngazmana;
                    Console.WriteLine(subs[j]);
                    Angazman ag = new Angazman()
                    {
                        FILM_IdFilm = maxIdFilma,
                        LICE_IdLica = maxIdLica,
                        VRSTA_ANGAZMANA_IdVrstaAngazmana = test
                    };
                    MySQLAngazman.InsertAngazman(ag);
                }
                FillGrid();

                tbIme.Text = "";
                tbPrezime.Text = "";
                listBoxVrstaAngazmana.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLica_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            LiceInfo li = (LiceInfo)e.Row.Tag;
            var result = MessageBox.Show(rm.GetString("PotvrdaBrisanjaPitanje"), rm.GetString("PotvrdaBrisanja"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Lice l = new Lice()
            {
                IdLice = li.IdLice,
                Ime = li.Ime,
                Prezime = li.Prezime
            };
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    MySQLLice.DeleteLiceById(l.IdLice);
                }
                catch { MessageBox.Show(rm.GetString("FilmNeBrisi"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); FillGrid(); };
                tbIme.Text = "";
                tbPrezime.Text = "";
                listBoxVrstaAngazmana.SelectedIndex = -1;
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
            if (tbIme.Text != "" && tbPrezime.Text != "" &&  listBoxVrstaAngazmana.SelectedItem != null)
            {
                String selected = dgvLica.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                var lice = new Lice()
                {
                    IdLice = id,
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text
                };
                MySQLLice.UpdateLice(lice);

                StringBuilder sb = new StringBuilder();
                foreach (var item in listBoxVrstaAngazmana.SelectedItems)
                {
                    sb.Append(item.ToString());
                    sb.Append(",");
                }

                string rez = (sb.ToString()).Substring(0, sb.ToString().Length - 1);
                string[] subs = rez.Split(',');

                for (int j = 0; j < subs.Length; j++)
                {
                    var test = MySQLVrstaAngazmana.GetVrstaAngazmana(subs[j])[0].IdVrstaAngazmana;
                    Console.WriteLine(subs[j]);
                    Angazman ag = new Angazman()
                    {
                        LICE_IdLica = id,
                        FILM_IdFilm = MySQLFilm.MaxIdFilma(),
                        VRSTA_ANGAZMANA_IdVrstaAngazmana = test
                    };
                    MySQLAngazman.InsertAngazman(ag);
                }

                FillGrid();
                tbIme.Text = "";
                tbPrezime.Text = "";
                listBoxVrstaAngazmana.SelectedIndex = -1;
                btnUredi.Enabled = false;
                btnOcisti.Enabled = true;
                btnDodaj.Enabled = true;
            }
            else
            {
                MessageBox.Show(rm.GetString("NeispravanUnos"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                //listBoxVrstaAngazmana.SelectedIndex = -1;
            }
        }
    }
}
