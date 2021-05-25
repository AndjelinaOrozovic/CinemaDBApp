
namespace CinemaDBApp.View.ViewRecepcioner
{
    partial class FormProizvodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProizvodi));
            this.gbNewProizvod = new System.Windows.Forms.GroupBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.cmbBoxKategorije = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblCijena = new System.Windows.Forms.Label();
            this.tbCijena = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.IdZaposleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKategorije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.gbNewProizvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewProizvod
            // 
            resources.ApplyResources(this.gbNewProizvod, "gbNewProizvod");
            this.gbNewProizvod.Controls.Add(this.btnOcisti);
            this.gbNewProizvod.Controls.Add(this.cmbBoxKategorije);
            this.gbNewProizvod.Controls.Add(this.lblKategorija);
            this.gbNewProizvod.Controls.Add(this.btnUredi);
            this.gbNewProizvod.Controls.Add(this.btnDodaj);
            this.gbNewProizvod.Controls.Add(this.lblCijena);
            this.gbNewProizvod.Controls.Add(this.tbCijena);
            this.gbNewProizvod.Controls.Add(this.tbNaziv);
            this.gbNewProizvod.Controls.Add(this.lblNaziv);
            this.gbNewProizvod.Name = "gbNewProizvod";
            this.gbNewProizvod.TabStop = false;
            // 
            // btnOcisti
            // 
            resources.ApplyResources(this.btnOcisti, "btnOcisti");
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // cmbBoxKategorije
            // 
            this.cmbBoxKategorije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxKategorije.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBoxKategorije, "cmbBoxKategorije");
            this.cmbBoxKategorije.Name = "cmbBoxKategorije";
            // 
            // lblKategorija
            // 
            resources.ApplyResources(this.lblKategorija, "lblKategorija");
            this.lblKategorija.Name = "lblKategorija";
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
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvProizvodi, "dgvProizvodi");
            this.dgvProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdZaposleni,
            this.Naziv,
            this.Cijena,
            this.IdKategorije});
            this.dgvProizvodi.MultiSelect = false;
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowHeadersVisible = false;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.TabStop = false;
            this.dgvProizvodi.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvProizvodi_UserDeletedRow);
            this.dgvProizvodi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProizvodi_MouseClick);
            // 
            // IdZaposleni
            // 
            resources.ApplyResources(this.IdZaposleni, "IdZaposleni");
            this.IdZaposleni.Name = "IdZaposleni";
            this.IdZaposleni.ReadOnly = true;
            // 
            // Naziv
            // 
            resources.ApplyResources(this.Naziv, "Naziv");
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            resources.ApplyResources(this.Cijena, "Cijena");
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // IdKategorije
            // 
            resources.ApplyResources(this.IdKategorije, "IdKategorije");
            this.IdKategorije.Name = "IdKategorije";
            this.IdKategorije.ReadOnly = true;
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
            // FormProizvodi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNewProizvod);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "FormProizvodi";
            this.gbNewProizvod.ResumeLayout(false);
            this.gbNewProizvod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewProizvod;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.ComboBox cmbBoxKategorije;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox tbCijena;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKategorije;
    }
}