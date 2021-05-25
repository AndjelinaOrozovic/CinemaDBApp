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

namespace CinemaDBApp.View.ViewMenadzer
{
    public partial class FormUgovori : Form
    {

        ResourceManager rm;
        public FormUgovori(string name)
        {

            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGrid();
            FillComboBoxZaposleni();
            setName(name);
            btnUredi.Enabled = false;
        }

        void setName(string name)
        {
            if (name.EndsWith("$"))
            {
                Text = name.Substring(0, name.Length - 1);
                cmbBoxZaposleni.SelectedItem = MySQLZaposleni.GetZaposlenogById(MySQLZaposleni.MaxIdZaposlenog().ToString());
            }
            else
            {
                Text = name;
            }
        }
        void FillGrid()
        {
            dgvUgovori.Rows.Clear();
            foreach (var p in MySQLUgovori.GetUgovore(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvUgovori, p.IdUgovor, p.PocetakRadnogOdnosa, p.PrekidUgovora, p.Menadzer.Zaposleni.IdZaposleni, p.Zaposleni.IdZaposleni);   
                dgvUgovori.Rows.Add(row);
            }
        }

        void FillComboBoxZaposleni()
        {
            cmbBoxZaposleni.DataSource = MySQLHelper.MySQLZaposleni.GetZaposlene("");
            cmbBoxZaposleni.SelectedIndex = -1;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbBoxZaposleni.SelectedItem != null)
            {
                KorisnickiNalog kn = MySQLKorisnickiNalogMenadzer.GetKorisnickiNalogByUsername(Text);
                Menadzer m = MySQLMenadzer.GetMenadzer(kn.Zaposleni.IdZaposleni.ToString()); //dohvati samo id
                Zaposleni z = (Zaposleni)cmbBoxZaposleni.SelectedItem;
                if (m.Zaposleni.IdZaposleni != z.IdZaposleni)
                {
                    var ugovor = new Ugovor()
                    {
                        PocetakRadnogOdnosa = Convert.ToDateTime(dateTimePickerPocetakRadnogOdnosa.Value),
                        PrekidUgovora = Convert.ToDateTime(dateTimePickerIstekUgovora.Value),
                        Menadzer = m,
                        Zaposleni = z
                    };
                    MySQLUgovori.InsertUgovore(ugovor);
                    Zaposleni za = new Zaposleni();
                    za = MySQLZaposleni.GetZaposlenogById(ugovor.Menadzer.Zaposleni.IdZaposleni.ToString());
                    FillGrid();
                    cmbBoxZaposleni.SelectedIndex = -1;
                    lblMenadzer.Text = rm.GetString("Menadzer") + $"({za.Ime + " " + za.Prezime})";
                }
                else { MessageBox.Show(rm.GetString("NeUgovor"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUgovori_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            var result = MessageBox.Show(rm.GetString("PotvrdaBrisanjaPitanje"), rm.GetString("PotvrdaBrisanja"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    Ugovor u = (Ugovor)e.Row.Tag;
                    MySQLUgovori.DeleteUgovorById(u.IdUgovor);
                    cmbBoxZaposleni.SelectedIndex = -1;
                }
                catch { MessageBox.Show(rm.GetString("AdresaNeBrisi"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); };
            }
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void dgvUgovori_MouseClick(object sender, MouseEventArgs e)
        {
            dateTimePickerPocetakRadnogOdnosa.Text = dgvUgovori.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePickerIstekUgovora.Text = dgvUgovori.SelectedRows[0].Cells[2].Value.ToString();
            cmbBoxZaposleni.SelectedItem = MySQLZaposleni.GetZaposlenogById(dgvUgovori.SelectedRows[0].Cells[4].Value.ToString());
            lblMenadzer.Text = rm.GetString("Menadzer") + " " + Convert.ToString(MySQLZaposleni.GetZaposlenogById(dgvUgovori.SelectedRows[0].Cells[3].Value.ToString()));
            btnDodaj.Enabled = false;
            btnUredi.Enabled = true;
            btnOcisti.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {

            if (cmbBoxZaposleni.SelectedItem != null)
            {
                KorisnickiNalog kn = MySQLKorisnickiNalogMenadzer.GetKorisnickiNalogByUsername(Text);
                Menadzer m = MySQLMenadzer.GetMenadzer(kn.Zaposleni.IdZaposleni.ToString()); //dohvati samo id
                Zaposleni z = (Zaposleni)cmbBoxZaposleni.SelectedItem;
                String selected = dgvUgovori.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                var ugovor = new Ugovor()
                {
                    IdUgovor = id,
                    PocetakRadnogOdnosa = Convert.ToDateTime(dateTimePickerPocetakRadnogOdnosa.Value),
                    PrekidUgovora = Convert.ToDateTime(dateTimePickerIstekUgovora.Value),
                    Menadzer = m,
                    Zaposleni = z
                };
                MySQLUgovori.UpdateUgovor(ugovor);
                FillGrid();
                cmbBoxZaposleni.SelectedIndex = -1;
                btnUredi.Enabled = false;
                btnOcisti.Enabled = true;
                btnDodaj.Enabled = true;
            }
            else
            {
                MessageBox.Show(rm.GetString("NeispravanUnos"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBoxZaposleni.SelectedIndex = -1;
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {

            cmbBoxZaposleni.SelectedIndex = -1;
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;

        }
    }
}
