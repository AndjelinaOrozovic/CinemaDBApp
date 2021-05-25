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
    public partial class FormKartaIzvjestaj : Form
    {
        ResourceManager rm;
        public FormKartaIzvjestaj()
        {
            rm = new ResourceManager("CinemaDBApp.Resources.Resource", Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGrid();
        }

        void FillGrid()
        {
            dgvKarte.Rows.Clear();
            foreach (var p in MySQLKarta.GetKarte(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvKarte, p.IdKarta, p.DatumIVrijemeIzdavanja, p.RECEPCIONER_ZAPOSLENI_IdZaposleni, p.PROJEKCIJA_SALA_IdSala, p.PROJEKCIJA_FILM_IdFilm, p.PROJEKCIJA_DatumIVrijemePrikazivanja, p.SJEDISTE_BrojeSjedista, p.SJEDISTE_RED_IdRed, p.Cijena);
                dgvKarte.Rows.Add(row);
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dgvKarte_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Karta k = (Karta)e.Row.Tag;
            var result = MessageBox.Show(rm.GetString("PotvrdaBrisanjaPitanje"), rm.GetString("PotvrdaBrisanja"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    MySQLKarta.DeleteKartaById(k.IdKarta);
                }
                catch { MessageBox.Show(rm.GetString("KartaNeBrisi"), rm.GetString("Greska"), MessageBoxButtons.OK, MessageBoxIcon.Error); FillGrid(); };
                FillGrid();
            }
            else
            {
                FillGrid();
            }
        }
    }
}
