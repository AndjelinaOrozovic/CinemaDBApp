
namespace CinemaDBApp.View.ViewMenadzer
{
    partial class FormUgovori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUgovori));
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.IdAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetakRadnogOdnosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrekidUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMenadzera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdZaposlenog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.gbNewUgovor = new System.Windows.Forms.GroupBox();
            this.lblMenadzer = new System.Windows.Forms.Label();
            this.cmbBoxZaposleni = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIstekUgovora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPocetakRadnogOdnosa = new System.Windows.Forms.DateTimePicker();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblZaposleni = new System.Windows.Forms.Label();
            this.lblIstekUgovora = new System.Windows.Forms.Label();
            this.lblPocetakRadnogOdnosa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            this.gbNewUgovor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvUgovori, "dgvUgovori");
            this.dgvUgovori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAdresa,
            this.PocetakRadnogOdnosa,
            this.PrekidUgovora,
            this.IdMenadzera,
            this.IdZaposlenog});
            this.dgvUgovori.MultiSelect = false;
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.ReadOnly = true;
            this.dgvUgovori.RowHeadersVisible = false;
            this.dgvUgovori.RowTemplate.Height = 24;
            this.dgvUgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovori.TabStop = false;
            this.dgvUgovori.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvUgovori_UserDeletedRow);
            this.dgvUgovori.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvUgovori_MouseClick);
            // 
            // IdAdresa
            // 
            resources.ApplyResources(this.IdAdresa, "IdAdresa");
            this.IdAdresa.Name = "IdAdresa";
            this.IdAdresa.ReadOnly = true;
            // 
            // PocetakRadnogOdnosa
            // 
            resources.ApplyResources(this.PocetakRadnogOdnosa, "PocetakRadnogOdnosa");
            this.PocetakRadnogOdnosa.Name = "PocetakRadnogOdnosa";
            this.PocetakRadnogOdnosa.ReadOnly = true;
            // 
            // PrekidUgovora
            // 
            resources.ApplyResources(this.PrekidUgovora, "PrekidUgovora");
            this.PrekidUgovora.Name = "PrekidUgovora";
            this.PrekidUgovora.ReadOnly = true;
            // 
            // IdMenadzera
            // 
            resources.ApplyResources(this.IdMenadzera, "IdMenadzera");
            this.IdMenadzera.Name = "IdMenadzera";
            this.IdMenadzera.ReadOnly = true;
            // 
            // IdZaposlenog
            // 
            resources.ApplyResources(this.IdZaposlenog, "IdZaposlenog");
            this.IdZaposlenog.Name = "IdZaposlenog";
            this.IdZaposlenog.ReadOnly = true;
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
            // gbNewUgovor
            // 
            resources.ApplyResources(this.gbNewUgovor, "gbNewUgovor");
            this.gbNewUgovor.Controls.Add(this.lblMenadzer);
            this.gbNewUgovor.Controls.Add(this.cmbBoxZaposleni);
            this.gbNewUgovor.Controls.Add(this.dateTimePickerIstekUgovora);
            this.gbNewUgovor.Controls.Add(this.dateTimePickerPocetakRadnogOdnosa);
            this.gbNewUgovor.Controls.Add(this.btnOcisti);
            this.gbNewUgovor.Controls.Add(this.btnUredi);
            this.gbNewUgovor.Controls.Add(this.btnDodaj);
            this.gbNewUgovor.Controls.Add(this.lblZaposleni);
            this.gbNewUgovor.Controls.Add(this.lblIstekUgovora);
            this.gbNewUgovor.Controls.Add(this.lblPocetakRadnogOdnosa);
            this.gbNewUgovor.Name = "gbNewUgovor";
            this.gbNewUgovor.TabStop = false;
            // 
            // lblMenadzer
            // 
            resources.ApplyResources(this.lblMenadzer, "lblMenadzer");
            this.lblMenadzer.Name = "lblMenadzer";
            // 
            // cmbBoxZaposleni
            // 
            this.cmbBoxZaposleni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxZaposleni.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBoxZaposleni, "cmbBoxZaposleni");
            this.cmbBoxZaposleni.Name = "cmbBoxZaposleni";
            // 
            // dateTimePickerIstekUgovora
            // 
            resources.ApplyResources(this.dateTimePickerIstekUgovora, "dateTimePickerIstekUgovora");
            this.dateTimePickerIstekUgovora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIstekUgovora.Name = "dateTimePickerIstekUgovora";
            // 
            // dateTimePickerPocetakRadnogOdnosa
            // 
            resources.ApplyResources(this.dateTimePickerPocetakRadnogOdnosa, "dateTimePickerPocetakRadnogOdnosa");
            this.dateTimePickerPocetakRadnogOdnosa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPocetakRadnogOdnosa.Name = "dateTimePickerPocetakRadnogOdnosa";
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
            // lblZaposleni
            // 
            resources.ApplyResources(this.lblZaposleni, "lblZaposleni");
            this.lblZaposleni.Name = "lblZaposleni";
            // 
            // lblIstekUgovora
            // 
            resources.ApplyResources(this.lblIstekUgovora, "lblIstekUgovora");
            this.lblIstekUgovora.Name = "lblIstekUgovora";
            // 
            // lblPocetakRadnogOdnosa
            // 
            resources.ApplyResources(this.lblPocetakRadnogOdnosa, "lblPocetakRadnogOdnosa");
            this.lblPocetakRadnogOdnosa.Name = "lblPocetakRadnogOdnosa";
            // 
            // FormUgovori
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNewUgovor);
            this.Controls.Add(this.dgvUgovori);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "FormUgovori";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            this.gbNewUgovor.ResumeLayout(false);
            this.gbNewUgovor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.GroupBox gbNewUgovor;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblZaposleni;
        private System.Windows.Forms.Label lblIstekUgovora;
        private System.Windows.Forms.Label lblPocetakRadnogOdnosa;
        private System.Windows.Forms.DateTimePicker dateTimePickerPocetakRadnogOdnosa;
        private System.Windows.Forms.DateTimePicker dateTimePickerIstekUgovora;
        private System.Windows.Forms.ComboBox cmbBoxZaposleni;
        private System.Windows.Forms.Label lblMenadzer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetakRadnogOdnosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrekidUgovora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMenadzera;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdZaposlenog;
    }
}