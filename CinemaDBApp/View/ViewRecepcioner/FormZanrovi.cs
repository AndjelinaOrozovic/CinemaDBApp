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
    public partial class FormZanrovi : Form
    {
        ResourceManager rm;
        public FormZanrovi()
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGrid();
            btnUredi.Enabled = false;
        }

        void FillGrid()
        {
            dgvZanrovi.Rows.Clear();
            foreach (var p in MySQLZanr.GetZanr(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvZanrovi, p.IdZanr, p.Naziv);
                dgvZanrovi.Rows.Add(row);
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text != "")
            {
                var zanr = new Zanr()
                {
                    Naziv = tbNaziv.Text
                };
                MySQLZanr.InsertZanrove(zanr);
                FillGrid();
                tbNaziv.Text = "";
            }
            else
            {
                MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvZanrovi_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Zanr z = (Zanr)e.Row.Tag;
            try
            {
                MySQLZanr.DeleteZanrById(z.IdZanr);
            }
            catch { MessageBox.Show(rm.GetString("ZanrNeBrisi"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); };
            FillGrid();
            tbNaziv.Text = "";
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void dgvZanrovi_MouseClick(object sender, MouseEventArgs e)
        {
            tbNaziv.Text = dgvZanrovi.SelectedRows[0].Cells[1].Value.ToString();
            btnDodaj.Enabled = false;
            btnUredi.Enabled = true;
            btnOcisti.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text != "")
            {
                String selected = dgvZanrovi.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                var z = new Zanr()
                {
                    IdZanr = id,
                    Naziv = tbNaziv.Text
                };
                MySQLZanr.UpdateZanrove(z);
                FillGrid();
                tbNaziv.Text = "";
                btnUredi.Enabled = false;
                btnOcisti.Enabled = true;
                btnDodaj.Enabled = true;
            }
            else
            {
                MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbNaziv.Text = "";
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }
    }
}
