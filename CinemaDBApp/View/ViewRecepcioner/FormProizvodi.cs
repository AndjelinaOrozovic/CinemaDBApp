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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDBApp.View.ViewRecepcioner
{
    public partial class FormProizvodi : Form
    {
        ResourceManager rm;
        public FormProizvodi()
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGrid();
            FillComboBoxKategorije();
            btnUredi.Enabled = false;
        }

        void FillGrid() //popuni tabelu
        {
            dgvProizvodi.Rows.Clear();
            foreach (var p in MySQLProizvodi.GetProizvode(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvProizvodi, p.IdProizvod, p.Naziv, p.Cijena, p.Kategorija.IdKategorija);
                dgvProizvodi.Rows.Add(row);
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        void FillComboBoxKategorije()  //popuni combo box sa nazivima kina
        {
            cmbBoxKategorije.DataSource = MySQLKategorije.GetKategorija("");
            cmbBoxKategorije.SelectedIndex = -1;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text != "" && tbCijena.Text != "" && cmbBoxKategorije.SelectedItem != null)
            {
                var tralalaa = tbCijena.Text;
                var proizvod = new Proizvod()
                {
                    Naziv = tbNaziv.Text,
                    Cijena = Convert.ToDecimal(tbCijena.Text),
                    Kategorija = (Kategorija)cmbBoxKategorije.SelectedItem
                };
                MySQLProizvodi.InsertProizvod(proizvod);
                FillGrid();

                tbNaziv.Text = "";
                tbCijena.Text = "";
                cmbBoxKategorije.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProizvodi_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Proizvod p = (Proizvod)e.Row.Tag;
            try
            {
                MySQLProizvodi.DeleteProizvodById(p.IdProizvod);
            } catch { MessageBox.Show(rm.GetString("ProizvodNeBrisi"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); FillGrid(); }
            tbNaziv.Text = "";
            tbCijena.Text = "";
            cmbBoxKategorije.SelectedIndex = -1;
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void dgvProizvodi_MouseClick(object sender, MouseEventArgs e)
        {
            tbNaziv.Text = dgvProizvodi.SelectedRows[0].Cells[1].Value.ToString();
            tbCijena.Text = dgvProizvodi.SelectedRows[0].Cells[2].Value.ToString();
            cmbBoxKategorije.SelectedItem = MySQLKategorije.GetKategorijaById(dgvProizvodi.SelectedRows[0].Cells[3].Value.ToString());
            btnDodaj.Enabled = false;
            btnUredi.Enabled = true;
            btnOcisti.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text != "" && tbCijena.Text != "" && cmbBoxKategorije.SelectedItem != null)
            {
                String selected = dgvProizvodi.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                var proizvod = new Proizvod()
                {
                    IdProizvod = id,
                    Naziv = tbNaziv.Text,
                    Cijena = Convert.ToDecimal(tbCijena.Text),
                    Kategorija = (Kategorija)cmbBoxKategorije.SelectedItem
                };
                MySQLProizvodi.UpdateProizvod(proizvod);
                FillGrid();
                tbNaziv.Text = "";
                tbCijena.Text = "";
                cmbBoxKategorije.SelectedIndex = -1;
                btnUredi.Enabled = false;
                btnOcisti.Enabled = true;
                btnDodaj.Enabled = true;
            }
            else
            {
                MessageBox.Show(rm.GetString("NeispravanUnos"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                //cmbBoxKategorije.SelectedIndex = -1;
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbNaziv.Text = "";
            tbCijena.Text = "";
            cmbBoxKategorije.SelectedIndex = -1;
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void tbCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if(!char.IsControl(e.KeyChar))
            {
                var isMatch = Regex.IsMatch(tbCijena.Text + e.KeyChar, "^\\d{1,2}(\\,\\d{0,2})?$");

                if (!isMatch)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
