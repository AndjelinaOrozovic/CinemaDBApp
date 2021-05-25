
namespace CinemaDBApp.View.ViewMenadzer
{
    partial class FormZaposleni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZaposleni));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvZaposleni = new System.Windows.Forms.DataGridView();
            this.IdZaposleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblJMB = new System.Windows.Forms.Label();
            this.tbJMB = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbPlata = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblPlata = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.gbNewZaposleni = new System.Windows.Forms.GroupBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.bttnAddAdresa = new System.Windows.Forms.Button();
            this.cmbBoxIdAdrese = new System.Windows.Forms.ComboBox();
            this.cmbBoxIdKina = new System.Windows.Forms.ComboBox();
            this.lblAdrese = new System.Windows.Forms.Label();
            this.lblKina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.gbNewZaposleni.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvZaposleni, "dgvZaposleni");
            this.dgvZaposleni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdZaposleni,
            this.JMB,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Plata,
            this.IdKino,
            this.IdAdresa});
            this.dgvZaposleni.MultiSelect = false;
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.ReadOnly = true;
            this.dgvZaposleni.RowHeadersVisible = false;
            this.dgvZaposleni.RowTemplate.Height = 24;
            this.dgvZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposleni.TabStop = false;
            this.dgvZaposleni.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvZaposleni_UserDeletedRow);
            this.dgvZaposleni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvZaposleni_MouseClick);
            // 
            // IdZaposleni
            // 
            resources.ApplyResources(this.IdZaposleni, "IdZaposleni");
            this.IdZaposleni.Name = "IdZaposleni";
            this.IdZaposleni.ReadOnly = true;
            // 
            // JMB
            // 
            resources.ApplyResources(this.JMB, "JMB");
            this.JMB.Name = "JMB";
            this.JMB.ReadOnly = true;
            // 
            // Ime
            // 
            resources.ApplyResources(this.Ime, "Ime");
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            resources.ApplyResources(this.Prezime, "Prezime");
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Plata
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Plata.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.Plata, "Plata");
            this.Plata.Name = "Plata";
            this.Plata.ReadOnly = true;
            // 
            // IdKino
            // 
            resources.ApplyResources(this.IdKino, "IdKino");
            this.IdKino.Name = "IdKino";
            this.IdKino.ReadOnly = true;
            // 
            // IdAdresa
            // 
            resources.ApplyResources(this.IdAdresa, "IdAdresa");
            this.IdAdresa.Name = "IdAdresa";
            this.IdAdresa.ReadOnly = true;
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
            // lblJMB
            // 
            resources.ApplyResources(this.lblJMB, "lblJMB");
            this.lblJMB.Name = "lblJMB";
            // 
            // tbJMB
            // 
            resources.ApplyResources(this.tbJMB, "tbJMB");
            this.tbJMB.Name = "tbJMB";
            this.tbJMB.TextChanged += new System.EventHandler(this.tbJMB_TextChanged);
            this.tbJMB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJMB_KeyPress);
            // 
            // tbIme
            // 
            resources.ApplyResources(this.tbIme, "tbIme");
            this.tbIme.Name = "tbIme";
            // 
            // tbPrezime
            // 
            resources.ApplyResources(this.tbPrezime, "tbPrezime");
            this.tbPrezime.Name = "tbPrezime";
            // 
            // tbPlata
            // 
            resources.ApplyResources(this.tbPlata, "tbPlata");
            this.tbPlata.Name = "tbPlata";
            this.tbPlata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlata_KeyPress);
            // 
            // tbEmail
            // 
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.Name = "tbEmail";
            // 
            // lblIme
            // 
            resources.ApplyResources(this.lblIme, "lblIme");
            this.lblIme.Name = "lblIme";
            // 
            // lblPrezime
            // 
            resources.ApplyResources(this.lblPrezime, "lblPrezime");
            this.lblPrezime.Name = "lblPrezime";
            // 
            // lblPlata
            // 
            resources.ApplyResources(this.lblPlata, "lblPlata");
            this.lblPlata.Name = "lblPlata";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // btnDodaj
            // 
            resources.ApplyResources(this.btnDodaj, "btnDodaj");
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUredi
            // 
            resources.ApplyResources(this.btnUredi, "btnUredi");
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // gbNewZaposleni
            // 
            resources.ApplyResources(this.gbNewZaposleni, "gbNewZaposleni");
            this.gbNewZaposleni.Controls.Add(this.btnOcisti);
            this.gbNewZaposleni.Controls.Add(this.bttnAddAdresa);
            this.gbNewZaposleni.Controls.Add(this.cmbBoxIdAdrese);
            this.gbNewZaposleni.Controls.Add(this.cmbBoxIdKina);
            this.gbNewZaposleni.Controls.Add(this.lblAdrese);
            this.gbNewZaposleni.Controls.Add(this.lblKina);
            this.gbNewZaposleni.Controls.Add(this.btnUredi);
            this.gbNewZaposleni.Controls.Add(this.btnDodaj);
            this.gbNewZaposleni.Controls.Add(this.lblEmail);
            this.gbNewZaposleni.Controls.Add(this.lblPlata);
            this.gbNewZaposleni.Controls.Add(this.lblPrezime);
            this.gbNewZaposleni.Controls.Add(this.lblIme);
            this.gbNewZaposleni.Controls.Add(this.tbEmail);
            this.gbNewZaposleni.Controls.Add(this.tbPlata);
            this.gbNewZaposleni.Controls.Add(this.tbPrezime);
            this.gbNewZaposleni.Controls.Add(this.tbIme);
            this.gbNewZaposleni.Controls.Add(this.tbJMB);
            this.gbNewZaposleni.Controls.Add(this.lblJMB);
            this.gbNewZaposleni.Name = "gbNewZaposleni";
            this.gbNewZaposleni.TabStop = false;
            // 
            // btnOcisti
            // 
            resources.ApplyResources(this.btnOcisti, "btnOcisti");
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // bttnAddAdresa
            // 
            this.bttnAddAdresa.BackColor = System.Drawing.Color.Transparent;
            this.bttnAddAdresa.BackgroundImage = global::CinemaDBApp.Properties.Resources._14_Add_512;
            resources.ApplyResources(this.bttnAddAdresa, "bttnAddAdresa");
            this.bttnAddAdresa.Name = "bttnAddAdresa";
            this.bttnAddAdresa.UseVisualStyleBackColor = false;
            this.bttnAddAdresa.Click += new System.EventHandler(this.bttnAddAdresa_Click);
            // 
            // cmbBoxIdAdrese
            // 
            this.cmbBoxIdAdrese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxIdAdrese.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBoxIdAdrese, "cmbBoxIdAdrese");
            this.cmbBoxIdAdrese.Name = "cmbBoxIdAdrese";
            // 
            // cmbBoxIdKina
            // 
            this.cmbBoxIdKina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxIdKina.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBoxIdKina, "cmbBoxIdKina");
            this.cmbBoxIdKina.Name = "cmbBoxIdKina";
            // 
            // lblAdrese
            // 
            resources.ApplyResources(this.lblAdrese, "lblAdrese");
            this.lblAdrese.Name = "lblAdrese";
            // 
            // lblKina
            // 
            resources.ApplyResources(this.lblKina, "lblKina");
            this.lblKina.Name = "lblKina";
            // 
            // FormZaposleni
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNewZaposleni);
            this.Controls.Add(this.dgvZaposleni);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "FormZaposleni";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.gbNewZaposleni.ResumeLayout(false);
            this.gbNewZaposleni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvZaposleni;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblJMB;
        private System.Windows.Forms.TextBox tbJMB;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbPlata;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.GroupBox gbNewZaposleni;
        private System.Windows.Forms.Label lblAdrese;
        private System.Windows.Forms.Label lblKina;
        private System.Windows.Forms.ComboBox cmbBoxIdKina;
        private System.Windows.Forms.ComboBox cmbBoxIdAdrese;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button bttnAddAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plata;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKino;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdresa;
    }
}