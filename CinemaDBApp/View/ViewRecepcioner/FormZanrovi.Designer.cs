
namespace CinemaDBApp.View.ViewRecepcioner
{
    partial class FormZanrovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZanrovi));
            this.gbNewZanr = new System.Windows.Forms.GroupBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dgvZanrovi = new System.Windows.Forms.DataGridView();
            this.IdAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.gbNewZanr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewZanr
            // 
            resources.ApplyResources(this.gbNewZanr, "gbNewZanr");
            this.gbNewZanr.Controls.Add(this.btnOcisti);
            this.gbNewZanr.Controls.Add(this.btnUredi);
            this.gbNewZanr.Controls.Add(this.btnDodaj);
            this.gbNewZanr.Controls.Add(this.tbNaziv);
            this.gbNewZanr.Controls.Add(this.lblNaziv);
            this.gbNewZanr.Name = "gbNewZanr";
            this.gbNewZanr.TabStop = false;
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
            // btnDodaj
            // 
            resources.ApplyResources(this.btnDodaj, "btnDodaj");
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
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
            // dgvZanrovi
            // 
            this.dgvZanrovi.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvZanrovi, "dgvZanrovi");
            this.dgvZanrovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZanrovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanrovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAdresa,
            this.Naziv});
            this.dgvZanrovi.MultiSelect = false;
            this.dgvZanrovi.Name = "dgvZanrovi";
            this.dgvZanrovi.ReadOnly = true;
            this.dgvZanrovi.RowHeadersVisible = false;
            this.dgvZanrovi.RowTemplate.Height = 24;
            this.dgvZanrovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZanrovi.TabStop = false;
            this.dgvZanrovi.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvZanrovi_UserDeletedRow);
            this.dgvZanrovi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvZanrovi_MouseClick);
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
            // FormZanrovi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNewZanr);
            this.Controls.Add(this.dgvZanrovi);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "FormZanrovi";
            this.gbNewZanr.ResumeLayout(false);
            this.gbNewZanr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewZanr;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DataGridView dgvZanrovi;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}