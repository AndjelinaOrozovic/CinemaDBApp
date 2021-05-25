using CinemaDBApp.MySQLHelper;
using CinemaDBApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace CinemaDBApp.View
{
    public partial class FormAdrese : Form
    {
        ResourceManager rm;
        public FormAdrese()
        {
            InitializeComponent();
            FillGrid();
            btnUredi.Enabled = false;
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
        }

        void FillGrid()
        {
            dgvAdrese.Rows.Clear();
            foreach (var p in MySQLAdrese.GetAdrese(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvAdrese, p.IdAdresa, p.Drzava, p.Grad, p.PostanskiBroj, p.Ulica, p.Broj);
                dgvAdrese.Rows.Add(row);
            }

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (tbDrzava.Text != "" && tbGrad.Text != "" && tbUlica.Text != "" && tbPostanskiBroj.Text != "" && tbBroj.Text != "")
            {
                var adresa = new Adresa()
                {
                    Drzava = tbDrzava.Text,
                    Grad = tbGrad.Text,
                    Ulica = tbUlica.Text,
                    PostanskiBroj = tbPostanskiBroj.Text,
                    Broj = tbBroj.Text
                };
                MySQLAdrese.InsertAdresa(adresa);
                FillGrid();
                tbDrzava.Text = "";
                tbGrad.Text = "";
                tbUlica.Text = "";
                tbPostanskiBroj.Text = "";
                tbBroj.Text = "";
            }
            else
            {
                MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAdrese_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Adresa a = (Adresa)e.Row.Tag;
            var result = MessageBox.Show(rm.GetString("PotvrdaBrisanjaPitanje"), rm.GetString("PotvrdaBrisanja"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    MySQLAdrese.DeleteAdresaById(a.IdAdresa);
                }
                catch { MessageBox.Show(rm.GetString("AdresaNeBrisi"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); };
            } 
            FillGrid();
            tbDrzava.Text = "";
            tbGrad.Text = "";
            tbUlica.Text = "";
            tbPostanskiBroj.Text = "";
            tbBroj.Text = "";
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
                
        }


        private void dgvAdrese_MouseClick(object sender, MouseEventArgs e)
        {
            tbDrzava.Text = dgvAdrese.SelectedRows[0].Cells[1].Value.ToString();
            tbGrad.Text = dgvAdrese.SelectedRows[0].Cells[2].Value.ToString();
            tbPostanskiBroj.Text = dgvAdrese.SelectedRows[0].Cells[3].Value.ToString();
            tbUlica.Text = dgvAdrese.SelectedRows[0].Cells[4].Value.ToString();
            tbBroj.Text = dgvAdrese.SelectedRows[0].Cells[5].Value.ToString();
            btnDodaj.Enabled = false;
            btnUredi.Enabled = true;
            btnOcisti.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {

            if (tbDrzava.Text != "" && tbGrad.Text != "" && tbUlica.Text != "" && tbPostanskiBroj.Text != "" && tbBroj.Text != "")
            { 
                String selected = dgvAdrese.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                var a = new Adresa()
                {
                    IdAdresa = id,
                    Drzava = tbDrzava.Text,
                    Grad = tbGrad.Text,
                    PostanskiBroj = tbPostanskiBroj.Text,
                    Ulica = tbUlica.Text,
                    Broj = tbBroj.Text
                };
                MySQLAdrese.UpdateAdresa(a);
                FillGrid();
                tbDrzava.Text = "";
                tbGrad.Text = "";
                tbUlica.Text = "";
                tbPostanskiBroj.Text = "";
                tbBroj.Text = "";
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
            tbDrzava.Text = "";
            tbGrad.Text = "";
            tbUlica.Text = "";
            tbPostanskiBroj.Text = "";
            tbBroj.Text = "";
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

    }

}
