
namespace CinemaDBApp.View.ViewRecepcioner
{
    partial class FormFilmovi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilmovi));
            this.gbNewFilm = new System.Windows.Forms.GroupBox();
            this.listBoxZanr = new System.Windows.Forms.ListBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.lblZanr = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblKratakOpis = new System.Windows.Forms.Label();
            this.tbTrajanje = new System.Windows.Forms.TextBox();
            this.tbKratakOpis = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.IdAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KratakOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Žanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.gbNewFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewFilm
            // 
            resources.ApplyResources(this.gbNewFilm, "gbNewFilm");
            this.gbNewFilm.Controls.Add(this.listBoxZanr);
            this.gbNewFilm.Controls.Add(this.btnOcisti);
            this.gbNewFilm.Controls.Add(this.btnUredi);
            this.gbNewFilm.Controls.Add(this.lblZanr);
            this.gbNewFilm.Controls.Add(this.btnDodaj);
            this.gbNewFilm.Controls.Add(this.lblTrajanje);
            this.gbNewFilm.Controls.Add(this.lblKratakOpis);
            this.gbNewFilm.Controls.Add(this.tbTrajanje);
            this.gbNewFilm.Controls.Add(this.tbKratakOpis);
            this.gbNewFilm.Controls.Add(this.tbNaziv);
            this.gbNewFilm.Controls.Add(this.lblNaziv);
            this.gbNewFilm.Name = "gbNewFilm";
            this.gbNewFilm.TabStop = false;
            // 
            // listBoxZanr
            // 
            this.listBoxZanr.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxZanr, "listBoxZanr");
            this.listBoxZanr.Name = "listBoxZanr";
            this.listBoxZanr.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // btnOcisti
            // 
            resources.ApplyResources(this.btnOcisti, "btnOcisti");
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // btnUredi
            // 
            resources.ApplyResources(this.btnUredi, "btnUredi");
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // lblZanr
            // 
            resources.ApplyResources(this.lblZanr, "lblZanr");
            this.lblZanr.Name = "lblZanr";
            // 
            // btnDodaj
            // 
            resources.ApplyResources(this.btnDodaj, "btnDodaj");
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblTrajanje
            // 
            resources.ApplyResources(this.lblTrajanje, "lblTrajanje");
            this.lblTrajanje.Name = "lblTrajanje";
            // 
            // lblKratakOpis
            // 
            resources.ApplyResources(this.lblKratakOpis, "lblKratakOpis");
            this.lblKratakOpis.Name = "lblKratakOpis";
            // 
            // tbTrajanje
            // 
            resources.ApplyResources(this.tbTrajanje, "tbTrajanje");
            this.tbTrajanje.Name = "tbTrajanje";
            this.tbTrajanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTrajanje_KeyPress);
            // 
            // tbKratakOpis
            // 
            resources.ApplyResources(this.tbKratakOpis, "tbKratakOpis");
            this.tbKratakOpis.Name = "tbKratakOpis";
            // 
            // tbNaziv
            // 
            resources.ApplyResources(this.tbNaziv, "tbNaziv");
            this.tbNaziv.Name = "tbNaziv";
            // 
            // lblNaziv
            // 
            resources.ApplyResources(this.lblNaziv, "lblNaziv");
            this.lblNaziv.Name = "lblNaziv";
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvFilmovi, "dgvFilmovi");
            this.dgvFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAdresa,
            this.Naziv,
            this.KratakOpis,
            this.Trajanje,
            this.Žanr});
            this.dgvFilmovi.MultiSelect = false;
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.ReadOnly = true;
            this.dgvFilmovi.RowHeadersVisible = false;
            this.dgvFilmovi.RowTemplate.Height = 24;
            this.dgvFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmovi.TabStop = false;
            this.dgvFilmovi.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvFilmovi_UserDeletedRow);
            this.dgvFilmovi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFilmovi_MouseClick);
            // 
            // IdAdresa
            // 
            resources.ApplyResources(this.IdAdresa, "IdAdresa");
            this.IdAdresa.Name = "IdAdresa";
            this.IdAdresa.ReadOnly = true;
            // 
            // Naziv
            // 
            resources.ApplyResources(this.Naziv, "Naziv");
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // KratakOpis
            // 
            resources.ApplyResources(this.KratakOpis, "KratakOpis");
            this.KratakOpis.Name = "KratakOpis";
            this.KratakOpis.ReadOnly = true;
            // 
            // Trajanje
            // 
            resources.ApplyResources(this.Trajanje, "Trajanje");
            this.Trajanje.Name = "Trajanje";
            this.Trajanje.ReadOnly = true;
            // 
            // Žanr
            // 
            resources.ApplyResources(this.Žanr, "Žanr");
            this.Žanr.Name = "Žanr";
            this.Žanr.ReadOnly = true;
            // 
            // tbFilter
            // 
            resources.ApplyResources(this.tbFilter, "tbFilter");
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // lblFilter
            // 
            resources.ApplyResources(this.lblFilter, "lblFilter");
            this.lblFilter.Name = "lblFilter";
            // 
            // FormFilmovi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNewFilm);
            this.Controls.Add(this.dgvFilmovi);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "FormFilmovi";
            this.gbNewFilm.ResumeLayout(false);
            this.gbNewFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewFilm;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblKratakOpis;
        private System.Windows.Forms.TextBox tbTrajanje;
        private System.Windows.Forms.TextBox tbKratakOpis;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ListBox listBoxZanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KratakOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trajanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Žanr;
    }
}