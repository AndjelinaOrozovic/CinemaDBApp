
namespace CinemaDBApp.View.ViewRecepcioner
{
    partial class FormLica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLica));
            this.Lice = new System.Windows.Forms.GroupBox();
            this.listBoxVrstaAngazmana = new System.Windows.Forms.ListBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.lblVrstaAngazmana = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.dgvLica = new System.Windows.Forms.DataGridView();
            this.IdAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta_angazmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.Lice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLica)).BeginInit();
            this.SuspendLayout();
            // 
            // Lice
            // 
            resources.ApplyResources(this.Lice, "Lice");
            this.Lice.Controls.Add(this.listBoxVrstaAngazmana);
            this.Lice.Controls.Add(this.btnOcisti);
            this.Lice.Controls.Add(this.btnUredi);
            this.Lice.Controls.Add(this.lblVrstaAngazmana);
            this.Lice.Controls.Add(this.btnDodaj);
            this.Lice.Controls.Add(this.lblPrezime);
            this.Lice.Controls.Add(this.tbPrezime);
            this.Lice.Controls.Add(this.tbIme);
            this.Lice.Controls.Add(this.lblIme);
            this.Lice.Name = "Lice";
            this.Lice.TabStop = false;
            // 
            // listBoxVrstaAngazmana
            // 
            this.listBoxVrstaAngazmana.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxVrstaAngazmana, "listBoxVrstaAngazmana");
            this.listBoxVrstaAngazmana.Name = "listBoxVrstaAngazmana";
            this.listBoxVrstaAngazmana.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
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
            // lblVrstaAngazmana
            // 
            resources.ApplyResources(this.lblVrstaAngazmana, "lblVrstaAngazmana");
            this.lblVrstaAngazmana.Name = "lblVrstaAngazmana";
            // 
            // btnDodaj
            // 
            resources.ApplyResources(this.btnDodaj, "btnDodaj");
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblPrezime
            // 
            resources.ApplyResources(this.lblPrezime, "lblPrezime");
            this.lblPrezime.Name = "lblPrezime";
            // 
            // tbPrezime
            // 
            resources.ApplyResources(this.tbPrezime, "tbPrezime");
            this.tbPrezime.Name = "tbPrezime";
            // 
            // tbIme
            // 
            resources.ApplyResources(this.tbIme, "tbIme");
            this.tbIme.Name = "tbIme";
            // 
            // lblIme
            // 
            resources.ApplyResources(this.lblIme, "lblIme");
            this.lblIme.Name = "lblIme";
            // 
            // dgvLica
            // 
            this.dgvLica.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvLica, "dgvLica");
            this.dgvLica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAdresa,
            this.Ime,
            this.Prezime,
            this.Vrsta_angazmana});
            this.dgvLica.MultiSelect = false;
            this.dgvLica.Name = "dgvLica";
            this.dgvLica.ReadOnly = true;
            this.dgvLica.RowHeadersVisible = false;
            this.dgvLica.RowTemplate.Height = 24;
            this.dgvLica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLica.TabStop = false;
            this.dgvLica.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvLica_UserDeletedRow);
            this.dgvLica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLica_MouseClick);
            // 
            // IdAdresa
            // 
            resources.ApplyResources(this.IdAdresa, "IdAdresa");
            this.IdAdresa.Name = "IdAdresa";
            this.IdAdresa.ReadOnly = true;
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
            // Vrsta_angazmana
            // 
            resources.ApplyResources(this.Vrsta_angazmana, "Vrsta_angazmana");
            this.Vrsta_angazmana.Name = "Vrsta_angazmana";
            this.Vrsta_angazmana.ReadOnly = true;
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
            // FormLica
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lice);
            this.Controls.Add(this.dgvLica);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "FormLica";
            this.Lice.ResumeLayout(false);
            this.Lice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Lice;
        private System.Windows.Forms.ListBox listBoxVrstaAngazmana;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label lblVrstaAngazmana;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.DataGridView dgvLica;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta_angazmana;
    }
}