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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDBApp.View.ViewRecepcioner
{
    public partial class FormProjekcije : Form
    {
        ResourceManager rm;
        public FormProjekcije(string name)
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            Text = name;
            FillGrid();
            FillComboBoxSale();
            FillComboBoxFilmovi();
            btnUredi.Enabled = false;
            btnIzdajKartu.Enabled = false;
        }

        public FormProjekcije(string name, CultureInfo culture)
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            _ = new ResourceManager("CinemaDBApp.View.ViewRecepcioner.FormProjekcije", System.Reflection.Assembly.GetExecutingAssembly());

            Text = name;
            FillGrid();
            FillComboBoxSale();
            FillComboBoxFilmovi();
            btnUredi.Enabled = false;
            btnIzdajKartu.Enabled = false;
        }

        void FillGrid() //popuni tabelu
        {
            dgvProjekcije.Rows.Clear();
            foreach (var p in MySQLProjekcija.GetProjekcija(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvProjekcije, p.Sala.IdSala, p.Sala.Naziv, p.DatumIVrijemePrikazivanja, p.Film.IdFilm, p.Film.Naziv, p.Cijena);
                dgvProjekcije.Rows.Add(row);
            }
        }

        void FillComboBoxSale()  //popuni combo box sa nazivima sala
        {
            cmbBoxSale.DataSource = MySQLSale.GetSale("");
            cmbBoxSale.SelectedIndex = -1;
        }

        void FillComboBoxFilmovi()   //popuni combo box sa informacijama o adresama
        {
            cmbBoxFilmovi.DataSource =MySQLFilm.GetFilm("");
            cmbBoxFilmovi.SelectedIndex = -1;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbCijena.Text != "" && cmbBoxSale.SelectedItem != null && cmbBoxFilmovi.SelectedItem != null)
            {

                var projekcija = new Projekcija()
                {
                    Sala = (Sala)cmbBoxSale.SelectedItem,
                    DatumIVrijemePrikazivanja = Convert.ToDateTime(dateTimePickerVrijemePrikazivanja.Value),
                    Film = (Film)cmbBoxFilmovi.SelectedItem,
                    Cijena = Convert.ToDecimal(tbCijena.Text)
                };
                MySQLProjekcija.InsertProjekcija(projekcija);
                FillGrid();

                tbCijena.Text = "";
                cmbBoxSale.SelectedIndex = -1;
                cmbBoxFilmovi.SelectedIndex = -1;
                btnIzdajKartu.Enabled = false;
            }
            else
            {
                MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProjekcije_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Projekcija p = (Projekcija)e.Row.Tag;
            var result = MessageBox.Show(rm.GetString("PotvrdaBrisanjaPitanje"), rm.GetString("PotvrdaBrisanja"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    MySQLProjekcija.DeleteProjekcija(p);
                }
                catch { MessageBox.Show(rm.GetString("ProjekcijaNeBrisi"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); }
                tbCijena.Text = "";
                cmbBoxSale.SelectedIndex = -1;
                cmbBoxFilmovi.SelectedIndex = -1;
                FillGrid();
                btnIzdajKartu.Enabled = false;
            }
            else
            {
                FillGrid();
            }
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void dgvProjekcije_MouseClick(object sender, MouseEventArgs e)
        {
            cmbBoxSale.SelectedItem = MySQLSale.GetSaleById(dgvProjekcije.SelectedRows[0].Cells[0].Value.ToString());
            dateTimePickerVrijemePrikazivanja.Text = dgvProjekcije.SelectedRows[0].Cells[2].Value.ToString();
            cmbBoxFilmovi.SelectedItem = MySQLFilm.GetFilmoveById(dgvProjekcije.SelectedRows[0].Cells[3].Value.ToString());
            tbCijena.Text = dgvProjekcije.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePickerVrijemePrikazivanja.Text = dgvProjekcije.SelectedRows[0].Cells[2].Value.ToString();
            btnDodaj.Enabled = false;
            btnUredi.Enabled = true;
            btnOcisti.Enabled = true;
            btnIzdajKartu.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (tbCijena.Text != "" && cmbBoxSale.SelectedItem != null && cmbBoxFilmovi.SelectedItem != null)
            {
                String selectedDateAndTime = dgvProjekcije.SelectedRows[0].Cells[2].Value.ToString();
                DateTime dateAndTime = Convert.ToDateTime(selectedDateAndTime);
                var projekcija = new Projekcija()
                {
                    Sala = (Sala)cmbBoxSale.SelectedItem,
                    DatumIVrijemePrikazivanja = dateAndTime,
                    Film = (Film)cmbBoxFilmovi.SelectedItem,
                    Cijena = Convert.ToDecimal(tbCijena.Text)
                };
                MySQLProjekcija.UpdateProjekcija(projekcija);
                FillGrid();
                tbCijena.Text = "";
                cmbBoxSale.SelectedIndex = -1;
                cmbBoxFilmovi.SelectedIndex = -1;
                btnUredi.Enabled = false;
                btnOcisti.Enabled = true;
                btnDodaj.Enabled = true;
                btnIzdajKartu.Enabled = false;
            }
            else
            {
                MessageBox.Show(rm.GetString("NeispravanUnos"), rm.GetString("Upozorenje"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                //cmbBoxSale.SelectedIndex = -1;
                //cmbBoxFilmovi.SelectedIndex = -1;
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbCijena.Text = "";
            cmbBoxSale.SelectedIndex = -1;
            cmbBoxFilmovi.SelectedIndex = -1;
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
            btnIzdajKartu.Enabled = false;
        }

        private void btnIzdajKartu_Click(object sender, EventArgs e)
        {
            if (tbCijena.Text != "" && cmbBoxSale.SelectedItem != null && cmbBoxFilmovi.SelectedItem != null)
            {
                var fleg = false;
                String selectedDateAndTime = dgvProjekcije.SelectedRows[0].Cells[2].Value.ToString();
                DateTime dateAndTime = Convert.ToDateTime(selectedDateAndTime);
                var projekcija = new Projekcija()
                {
                    Sala = (Sala)cmbBoxSale.SelectedItem,
                    DatumIVrijemePrikazivanja = dateAndTime,
                    Film = (Film)cmbBoxFilmovi.SelectedItem,
                    Cijena = Convert.ToDecimal(tbCijena.Text)
                };
                foreach (var p in MySQLProjekcija.GetProjekcijaFuture())
                {
                    if (projekcija.Equals(p))
                    {
                        fleg = true;
                        FormKarta fk = new FormKarta(Text, projekcija);
                        fk.ShowDialog();
                    }
                }
                if (fleg == false)
                {
                    MessageBox.Show("Zastarjela projekcija! Nije moguće izdati kartu", rm.GetString("Upozorenje"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tbCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
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
