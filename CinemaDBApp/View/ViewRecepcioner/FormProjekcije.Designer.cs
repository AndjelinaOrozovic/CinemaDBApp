
namespace CinemaDBApp.View.ViewRecepcioner
{
    partial class FormProjekcije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjekcije));
            this.gbNewProjekcije = new System.Windows.Forms.GroupBox();
            this.btnIzdajKartu = new System.Windows.Forms.Button();
            this.dateTimePickerVrijemePrikazivanja = new System.Windows.Forms.DateTimePicker();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.cmbBoxFilmovi = new System.Windows.Forms.ComboBox();
            this.cmbBoxSale = new System.Windows.Forms.ComboBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblSalaPrikazivanja = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblCijena = new System.Windows.Forms.Label();
            this.tbCijena = new System.Windows.Forms.TextBox();
            this.lblDatumIVrijemePrikazivanja = new System.Windows.Forms.Label();
            this.dgvProjekcije = new System.Windows.Forms.DataGridView();
            this.IdentifikatorSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIVrijemePrikazivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentifikatorFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.gbNewProjekcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewProjekcije
            // 
            resources.ApplyResources(this.gbNewProjekcije, "gbNewProjekcije");
            this.gbNewProjekcije.Controls.Add(this.btnIzdajKartu);
            this.gbNewProjekcije.Controls.Add(this.dateTimePickerVrijemePrikazivanja);
            this.gbNewProjekcije.Controls.Add(this.btnOcisti);
            this.gbNewProjekcije.Controls.Add(this.cmbBoxFilmovi);
            this.gbNewProjekcije.Controls.Add(this.cmbBoxSale);
            this.gbNewProjekcije.Controls.Add(this.lblFilm);
            this.gbNewProjekcije.Controls.Add(this.lblSalaPrikazivanja);
            this.gbNewProjekcije.Controls.Add(this.btnUredi);
            this.gbNewProjekcije.Controls.Add(this.btnDodaj);
            this.gbNewProjekcije.Controls.Add(this.lblCijena);
            this.gbNewProjekcije.Controls.Add(this.tbCijena);
            this.gbNewProjekcije.Controls.Add(this.lblDatumIVrijemePrikazivanja);
            this.gbNewProjekcije.Name = "gbNewProjekcije";
            this.gbNewProjekcije.TabStop = false;
            // 
            // btnIzdajKartu
            // 
            resources.ApplyResources(this.btnIzdajKartu, "btnIzdajKartu");
            this.btnIzdajKartu.Name = "btnIzdajKartu";
            this.btnIzdajKartu.UseVisualStyleBackColor = true;
            this.btnIzdajKartu.Click += new System.EventHandler(this.btnIzdajKartu_Click);
            // 
            // dateTimePickerVrijemePrikazivanja
            // 
            resources.ApplyResources(this.dateTimePickerVrijemePrikazivanja, "dateTimePickerVrijemePrikazivanja");
            this.dateTimePickerVrijemePrikazivanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVrijemePrikazivanja.Name = "dateTimePickerVrijemePrikazivanja";
            // 
            // btnOcisti
            // 
            resources.ApplyResources(this.btnOcisti, "btnOcisti");
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // cmbBoxFilmovi
            // 
            this.cmbBoxFilmovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFilmovi.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBoxFilmovi, "cmbBoxFilmovi");
            this.cmbBoxFilmovi.Name = "cmbBoxFilmovi";
            // 
            // cmbBoxSale
            // 
            this.cmbBoxSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSale.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBoxSale, "cmbBoxSale");
            this.cmbBoxSale.Name = "cmbBoxSale";
            // 
            // lblFilm
            // 
            resources.ApplyResources(this.lblFilm, "lblFilm");
            this.lblFilm.Name = "lblFilm";
            // 
            // lblSalaPrikazivanja
            // 
            resources.ApplyResources(this.lblSalaPrikazivanja, "lblSalaPrikazivanja");
            this.lblSalaPrikazivanja.Name = "lblSalaPrikazivanja";
            // 
            // btnUredi
            // 
            resources.ApplyResources(this.btnUredi, "btnUredi");
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDodaj
            // 
            resources.ApplyResources(this.btnDodaj, "btnDodaj");
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblCijena
            // 
            resources.ApplyResources(this.lblCijena, "lblCijena");
            this.lblCijena.Name = "lblCijena";
            // 
            // tbCijena
            // 
            resources.ApplyResources(this.tbCijena, "tbCijena");
            this.tbCijena.Name = "tbCijena";
            this.tbCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCijena_KeyPress);
            // 
            // lblDatumIVrijemePrikazivanja
            // 
            resources.ApplyResources(this.lblDatumIVrijemePrikazivanja, "lblDatumIVrijemePrikazivanja");
            this.lblDatumIVrijemePrikazivanja.Name = "lblDatumIVrijemePrikazivanja";
            // 
            // dgvProjekcije
            // 
            this.dgvProjekcije.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvProjekcije, "dgvProjekcije");
            this.dgvProjekcije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdentifikatorSale,
            this.NazivSale,
            this.DatumIVrijemePrikazivanja,
            this.IdentifikatorFilma,
            this.NazivFilma,
            this.Cijena});
            this.dgvProjekcije.MultiSelect = false;
            this.dgvProjekcije.Name = "dgvProjekcije";
            this.dgvProjekcije.ReadOnly = true;
            this.dgvProjekcije.RowHeadersVisible = false;
            this.dgvProjekcije.RowTemplate.Height = 24;
            this.dgvProjekcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjekcije.TabStop = false;
            this.dgvProjekcije.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvProjekcije_UserDeletedRow);
            this.dgvProjekcije.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProjekcije_MouseClick);
            // 
            // IdentifikatorSale
            // 
            resources.ApplyResources(this.IdentifikatorSale, "IdentifikatorSale");
            this.IdentifikatorSale.Name = "IdentifikatorSale";
            this.IdentifikatorSale.ReadOnly = true;
            // 
            // NazivSale
            // 
            resources.ApplyResources(this.NazivSale, "NazivSale");
            this.NazivSale.Name = "NazivSale";
            this.NazivSale.ReadOnly = true;
            // 
            // DatumIVrijemePrikazivanja
            // 
            resources.ApplyResources(this.DatumIVrijemePrikazivanja, "DatumIVrijemePrikazivanja");
            this.DatumIVrijemePrikazivanja.Name = "DatumIVrijemePrikazivanja";
            this.DatumIVrijemePrikazivanja.ReadOnly = true;
            // 
            // IdentifikatorFilma
            // 
            resources.ApplyResources(this.IdentifikatorFilma, "IdentifikatorFilma");
            this.IdentifikatorFilma.Name = "IdentifikatorFilma";
            this.IdentifikatorFilma.ReadOnly = true;
            // 
            // NazivFilma
            // 
            resources.ApplyResources(this.NazivFilma, "NazivFilma");
            this.NazivFilma.Name = "NazivFilma";
            this.NazivFilma.ReadOnly = true;
            // 
            // Cijena
            // 
            resources.ApplyResources(this.Cijena, "Cijena");
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
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
            // FormProjekcije
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNewProjekcije);
            this.Controls.Add(this.dgvProjekcije);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "FormProjekcije";
            this.gbNewProjekcije.ResumeLayout(false);
            this.gbNewProjekcije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewProjekcije;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.ComboBox cmbBoxFilmovi;
        private System.Windows.Forms.ComboBox cmbBoxSale;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblSalaPrikazivanja;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox tbCijena;
        private System.Windows.Forms.Label lblDatumIVrijemePrikazivanja;
        private System.Windows.Forms.DataGridView dgvProjekcije;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerVrijemePrikazivanja;
        private System.Windows.Forms.Button btnIzdajKartu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentifikatorSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIVrijemePrikazivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentifikatorFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}