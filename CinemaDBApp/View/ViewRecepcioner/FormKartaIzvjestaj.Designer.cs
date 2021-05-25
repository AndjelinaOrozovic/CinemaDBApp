
namespace CinemaDBApp.View.ViewRecepcioner
{
    partial class FormKartaIzvjestaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKartaIzvjestaj));
            this.dgvKarte = new System.Windows.Forms.DataGridView();
            this.IdAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIVrijemeIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentifikatorRecepcionera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentifikatorSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentifikatorFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIVrijemePrikazivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojReda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKarte
            // 
            this.dgvKarte.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvKarte, "dgvKarte");
            this.dgvKarte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAdresa,
            this.DatumIVrijemeIzdavanja,
            this.IdentifikatorRecepcionera,
            this.IdentifikatorSale,
            this.IdentifikatorFilma,
            this.DatumIVrijemePrikazivanja,
            this.BrojSjedista,
            this.BrojReda,
            this.Cijena});
            this.dgvKarte.MultiSelect = false;
            this.dgvKarte.Name = "dgvKarte";
            this.dgvKarte.ReadOnly = true;
            this.dgvKarte.RowHeadersVisible = false;
            this.dgvKarte.RowTemplate.Height = 24;
            this.dgvKarte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKarte.TabStop = false;
            this.dgvKarte.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvKarte_UserDeletedRow);
            // 
            // IdAdresa
            // 
            resources.ApplyResources(this.IdAdresa, "IdAdresa");
            this.IdAdresa.Name = "IdAdresa";
            this.IdAdresa.ReadOnly = true;
            // 
            // DatumIVrijemeIzdavanja
            // 
            resources.ApplyResources(this.DatumIVrijemeIzdavanja, "DatumIVrijemeIzdavanja");
            this.DatumIVrijemeIzdavanja.Name = "DatumIVrijemeIzdavanja";
            this.DatumIVrijemeIzdavanja.ReadOnly = true;
            // 
            // IdentifikatorRecepcionera
            // 
            resources.ApplyResources(this.IdentifikatorRecepcionera, "IdentifikatorRecepcionera");
            this.IdentifikatorRecepcionera.Name = "IdentifikatorRecepcionera";
            this.IdentifikatorRecepcionera.ReadOnly = true;
            // 
            // IdentifikatorSale
            // 
            resources.ApplyResources(this.IdentifikatorSale, "IdentifikatorSale");
            this.IdentifikatorSale.Name = "IdentifikatorSale";
            this.IdentifikatorSale.ReadOnly = true;
            // 
            // IdentifikatorFilma
            // 
            resources.ApplyResources(this.IdentifikatorFilma, "IdentifikatorFilma");
            this.IdentifikatorFilma.Name = "IdentifikatorFilma";
            this.IdentifikatorFilma.ReadOnly = true;
            // 
            // DatumIVrijemePrikazivanja
            // 
            resources.ApplyResources(this.DatumIVrijemePrikazivanja, "DatumIVrijemePrikazivanja");
            this.DatumIVrijemePrikazivanja.Name = "DatumIVrijemePrikazivanja";
            this.DatumIVrijemePrikazivanja.ReadOnly = true;
            // 
            // BrojSjedista
            // 
            resources.ApplyResources(this.BrojSjedista, "BrojSjedista");
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            // 
            // BrojReda
            // 
            resources.ApplyResources(this.BrojReda, "BrojReda");
            this.BrojReda.Name = "BrojReda";
            this.BrojReda.ReadOnly = true;
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
            // FormKartaIzvjestaj
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvKarte);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "FormKartaIzvjestaj";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKarte;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIVrijemeIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentifikatorRecepcionera;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentifikatorSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentifikatorFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIVrijemePrikazivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojReda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}