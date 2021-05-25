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

namespace CinemaDBApp.View.ViewMenadzer
{
    public partial class FormZaposleni : Form
    {
        ResourceManager rm;
        public FormZaposleni(string name)
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGrid();
            FillComboBoxIdKina();
            FillComboBoxIdAdrese();
            setName(name);
            btnUredi.Enabled = false;
        }

        void setName(string name)
        {
            Text = name;
        }

        void FillGrid() //popuni tabelu
        {
            dgvZaposleni.Rows.Clear();
            foreach (var p in MySQLZaposleni.GetZaposlene(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvZaposleni, p.IdZaposleni, p.Jmb, p.Ime, p.Prezime, p.Email, p.Plata, p.Kino.IdKino, p.Adresa.IdAdresa);
                dgvZaposleni.Rows.Add(row);
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)  //filtriraj po unesenom tekstu
        {
            FillGrid();
        }

        void FillComboBoxIdKina()  //popuni combo box sa nazivima kina
        {
            cmbBoxIdKina.DataSource = MySQLHelper.MySQLKina.GetKina("");
            cmbBoxIdKina.SelectedIndex = -1;
        }

        void FillComboBoxIdAdrese()   //popuni combo box sa informacijama o adresama
        {
            cmbBoxIdAdrese.DataSource = MySQLHelper.MySQLAdrese.GetAdrese("");
            cmbBoxIdAdrese.SelectedIndex = -1;
        }

        private void btnDodaj_Click(object sender, EventArgs e)  //dodaj novog zaposlenog
        {
            if (tbJMB.Text != "" && tbIme.Text != "" && tbPrezime.Text != "" && tbEmail.Text != "" && tbPlata.Text != "" && cmbBoxIdKina.SelectedItem != null && cmbBoxIdAdrese.SelectedItem != null )
            {
                if (tbJMB.Text.Length == 13)
                {
                    var postojiJmb = false;
                    foreach(var jmb in MySQLZaposleni.GetJmb())
                    {
                        if(jmb.Jmb == tbJMB.Text)
                        {
                            postojiJmb = true;
                        }
                    }
                    if (!postojiJmb)
                    {

                        var zaposleni = new Zaposleni()
                        {
                            Jmb = tbJMB.Text,
                            Ime = tbIme.Text,
                            Prezime = tbPrezime.Text,
                            Email = tbEmail.Text,
                            Plata = Convert.ToDecimal(tbPlata.Text),
                            Kino = (Kino)cmbBoxIdKina.SelectedItem,
                            Adresa = (Adresa)cmbBoxIdAdrese.SelectedItem
                        };
                        MySQLZaposleni.InsertZaposleni(zaposleni);
                        FillGrid();

                        int id = MySQLZaposleni.MaxIdZaposlenog();
                        Console.WriteLine(id);
                        KorisnickiNalog kn = MySQLKorisnickiNalogMenadzer.GetKorisnickiNalogByUsername(Text);
                        FormUgovori fu = new FormUgovori(kn.KorisnickoIme + "$");
                        fu.ShowDialog();

                        tbJMB.Text = "";
                        tbIme.Text = "";
                        tbPrezime.Text = "";
                        tbEmail.Text = "";
                        tbPlata.Text = "";
                        cmbBoxIdKina.SelectedIndex = -1;
                        cmbBoxIdAdrese.SelectedIndex = -1;
                    } else { MessageBox.Show(rm.GetString("IstiJMB"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); }
                } else { MessageBox.Show(rm.GetString("IspravanJMB"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); };
            }
            else
            {
                MessageBox.Show(rm.GetString("NisuUneseniPodaci"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvZaposleni_UserDeletedRow(object sender, DataGridViewRowEventArgs e)  //obrisi zaposlenog
        {
            Zaposleni z = (Zaposleni)e.Row.Tag;
            var result = MessageBox.Show(rm.GetString("PotvrdaBrisanjaPitanje"), rm.GetString("PotvrdaBrisanja"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    MySQLZaposleni.DeleteZaposleniById(z.IdZaposleni);
                }
                catch { MessageBox.Show(rm.GetString("ZaposleniNeBrisi"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); FillGrid(); };
                tbJMB.Text = "";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbEmail.Text = "";
                tbPlata.Text = "";
                cmbBoxIdKina.SelectedIndex = -1;
                cmbBoxIdAdrese.SelectedIndex = -1;
            }
            else
            {
                FillGrid();
            }
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void dgvZaposleni_MouseClick(object sender, MouseEventArgs e)  //selektuj zaposlenog
        {
            tbJMB.Text = dgvZaposleni.SelectedRows[0].Cells[1].Value.ToString();
            tbIme.Text = dgvZaposleni.SelectedRows[0].Cells[2].Value.ToString();
            tbPrezime.Text = dgvZaposleni.SelectedRows[0].Cells[3].Value.ToString();
            tbEmail.Text = dgvZaposleni.SelectedRows[0].Cells[4].Value.ToString();
            tbPlata.Text = dgvZaposleni.SelectedRows[0].Cells[5].Value.ToString();
            cmbBoxIdKina.SelectedItem = MySQLKina.GetKinaById(dgvZaposleni.SelectedRows[0].Cells[6].Value.ToString());
            cmbBoxIdAdrese.SelectedItem = MySQLAdrese.GetAdreseById(dgvZaposleni.SelectedRows[0].Cells[7].Value.ToString());
            btnDodaj.Enabled = false;
            btnUredi.Enabled = true;
            btnOcisti.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)  //uredi zaposlenog, nakon promjenjenih info
        {
            
            if (tbJMB.Text != "" && tbIme.Text != "" && tbPrezime.Text != "" && tbEmail.Text != "" && tbPlata.Text != "" && cmbBoxIdKina.SelectedItem == null && cmbBoxIdAdrese.SelectedItem == null)
            {
                if (tbJMB.Text.Length == 13)
                {
                    String selected = dgvZaposleni.SelectedRows[0].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(selected);
                    var zaposleni = new Zaposleni()
                    {
                        IdZaposleni = id,
                        Jmb = tbJMB.Text,
                        Ime = tbIme.Text,
                        Prezime = tbPrezime.Text,
                        Email = tbEmail.Text,
                        Plata = Convert.ToDecimal(tbPlata.Text),
                        Kino = (Kino)cmbBoxIdKina.SelectedItem,
                        Adresa = (Adresa)cmbBoxIdAdrese.SelectedItem
                    };
                    MySQLZaposleni.UpdateZaposleni(zaposleni);
                    FillGrid();
                    tbJMB.Text = "";
                    tbIme.Text = "";
                    tbPrezime.Text = "";
                    tbEmail.Text = "";
                    tbPlata.Text = "";
                    cmbBoxIdKina.SelectedIndex = -1;
                    cmbBoxIdAdrese.SelectedIndex = -1;
                    btnUredi.Enabled = false;
                    btnOcisti.Enabled = true;
                    btnDodaj.Enabled = true;

                } else { MessageBox.Show(rm.GetString("NeispravanUnos"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Neispravan unos!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBoxIdKina.SelectedIndex = -1;
                cmbBoxIdAdrese.SelectedIndex = -1;
            }
             
        }

        private void btnOcisti_Click(object sender, EventArgs e)  //ocisti sva polja
        {
            tbJMB.Text = "";
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbEmail.Text = "";
            tbPlata.Text = "";

            cmbBoxIdKina.SelectedIndex = -1;
            cmbBoxIdAdrese.SelectedIndex = -1;
            btnDodaj.Enabled = true;
            btnUredi.Enabled = false;
        }

        private void bttnAddAdresa_Click(object sender, EventArgs e)   //dodaj novu adresu
        {
            int id = MySQLAdrese.GetAdreseByMaxId().IdAdresa;
            Console.WriteLine(id);
            FormAdrese fm = new FormAdrese();
            fm.ShowDialog();
            cmbBoxIdAdrese.DataSource = MySQLHelper.MySQLAdrese.GetAdrese("");
            if (id != MySQLAdrese.GetAdreseByMaxId().IdAdresa)
            {
                cmbBoxIdAdrese.SelectedItem = MySQLAdrese.GetAdreseById(MySQLAdrese.GetAdreseByMaxId().IdAdresa.ToString());
                Console.WriteLine(MySQLAdrese.GetAdreseByMaxId().IdAdresa);
            }
        }

        private void tbJMB_KeyPress(object sender, KeyPressEventArgs e)   //omoguci unosenje samo brojeva
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void SetTitleLabel()  //naziv labele JMB i koliko je preostalo znakova
        {
            lblJMB.Text = $"JMB ({tbJMB.Text.Length}/{tbJMB.MaxLength}):";
        }

        private void tbJMB_TextChanged(object sender, EventArgs e)  //postavi naziv labele
        {
            SetTitleLabel();
        }

        private void tbPlata_KeyPress(object sender, KeyPressEventArgs e) //omoguci decimalni unos plate
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {
                var isMatch = Regex.IsMatch(tbPlata.Text + e.KeyChar, "^\\d{1,4}(\\,\\d{0,2})?$");

                if(!isMatch)
                {
                    e.Handled = true;
                }
            }

        }

    }
}
