
namespace CinemaDBApp.View
{
    partial class FormAdrese
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdrese));
            this.lblFilter = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.dgvAdrese = new System.Windows.Forms.DataGridView();
            this.IdAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostanskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNewAdresa = new System.Windows.Forms.GroupBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblPostanskiBroj = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblUlica = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.tbPostanskiBroj = new System.Windows.Forms.TextBox();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.tbUlica = new System.Windows.Forms.TextBox();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.tbDrzava = new System.Windows.Forms.TextBox();
            this.lblDrzava = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdrese)).BeginInit();
            this.gbNewAdresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            resources.ApplyResources(this.lblFilter, "lblFilter");
            this.lblFilter.Name = "lblFilter";
            // 
            // tbFilter
            // 
            resources.ApplyResources(this.tbFilter, "tbFilter");
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // dgvAdrese
            // 
            this.dgvAdrese.AllowUserToAddRows = false;
            resources.ApplyResources(this.dgvAdrese, "dgvAdrese");
            this.dgvAdrese.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdrese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdrese.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAdresa,
            this.Drzava,
            this.Grad,
            this.PostanskiBroj,
            this.Ulica,
            this.Broj});
            this.dgvAdrese.MultiSelect = false;
            this.dgvAdrese.Name = "dgvAdrese";
            this.dgvAdrese.ReadOnly = true;
            this.dgvAdrese.RowHeadersVisible = false;
            this.dgvAdrese.RowTemplate.Height = 24;
            this.dgvAdrese.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdrese.TabStop = false;
            this.dgvAdrese.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAdrese_UserDeletedRow);
            this.dgvAdrese.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAdrese_MouseClick);
            // 
            // IdAdresa
            // 
            resources.ApplyResources(this.IdAdresa, "IdAdresa");
            this.IdAdresa.Name = "IdAdresa";
            this.IdAdresa.ReadOnly = true;
            // 
            // Drzava
            // 
            resources.ApplyResources(this.Drzava, "Drzava");
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            // 
            // Grad
            // 
            resources.ApplyResources(this.Grad, "Grad");
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // PostanskiBroj
            // 
            resources.ApplyResources(this.PostanskiBroj, "PostanskiBroj");
            this.PostanskiBroj.Name = "PostanskiBroj";
            this.PostanskiBroj.ReadOnly = true;
            // 
            // Ulica
            // 
            resources.ApplyResources(this.Ulica, "Ulica");
            this.Ulica.Name = "Ulica";
            this.Ulica.ReadOnly = true;
            // 
            // Broj
            // 
            resources.ApplyResources(this.Broj, "Broj");
            this.Broj.Name = "Broj";
            this.Broj.ReadOnly = true;
            // 
            // gbNewAdresa
            // 
            resources.ApplyResources(this.gbNewAdresa, "gbNewAdresa");
            this.gbNewAdresa.Controls.Add(this.btnOcisti);
            this.gbNewAdresa.Controls.Add(this.btnUredi);
            this.gbNewAdresa.Controls.Add(this.btnDodaj);
            this.gbNewAdresa.Controls.Add(this.lblPostanskiBroj);
            this.gbNewAdresa.Controls.Add(this.lblBroj);
            this.gbNewAdresa.Controls.Add(this.lblUlica);
            this.gbNewAdresa.Controls.Add(this.lblGrad);
            this.gbNewAdresa.Controls.Add(this.tbPostanskiBroj);
            this.gbNewAdresa.Controls.Add(this.tbBroj);
            this.gbNewAdresa.Controls.Add(this.tbUlica);
            this.gbNewAdresa.Controls.Add(this.tbGrad);
            this.gbNewAdresa.Controls.Add(this.tbDrzava);
            this.gbNewAdresa.Controls.Add(this.lblDrzava);
            this.gbNewAdresa.Name = "gbNewAdresa";
            this.gbNewAdresa.TabStop = false;
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
            // lblPostanskiBroj
            // 
            resources.ApplyResources(this.lblPostanskiBroj, "lblPostanskiBroj");
            this.lblPostanskiBroj.Name = "lblPostanskiBroj";
            // 
            // lblBroj
            // 
            resources.ApplyResources(this.lblBroj, "lblBroj");
            this.lblBroj.Name = "lblBroj";
            // 
            // lblUlica
            // 
            resources.ApplyResources(this.lblUlica, "lblUlica");
            this.lblUlica.Name = "lblUlica";
            // 
            // lblGrad
            // 
            resources.ApplyResources(this.lblGrad, "lblGrad");
            this.lblGrad.Name = "lblGrad";
            // 
            // tbPostanskiBroj
            // 
            resources.ApplyResources(this.tbPostanskiBroj, "tbPostanskiBroj");
            this.tbPostanskiBroj.Name = "tbPostanskiBroj";
            // 
            // tbBroj
            // 
            resources.ApplyResources(this.tbBroj, "tbBroj");
            this.tbBroj.Name = "tbBroj";
            // 
            // tbUlica
            // 
            resources.ApplyResources(this.tbUlica, "tbUlica");
            this.tbUlica.Name = "tbUlica";
            // 
            // tbGrad
            // 
            resources.ApplyResources(this.tbGrad, "tbGrad");
            this.tbGrad.Name = "tbGrad";
            // 
            // tbDrzava
            // 
            resources.ApplyResources(this.tbDrzava, "tbDrzava");
            this.tbDrzava.Name = "tbDrzava";
            // 
            // lblDrzava
            // 
            resources.ApplyResources(this.lblDrzava, "lblDrzava");
            this.lblDrzava.Name = "lblDrzava";
            // 
            // FormAdrese
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNewAdresa);
            this.Controls.Add(this.dgvAdrese);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "FormAdrese";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdrese)).EndInit();
            this.gbNewAdresa.ResumeLayout(false);
            this.gbNewAdresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.DataGridView dgvAdrese;
        private System.Windows.Forms.GroupBox gbNewAdresa;
        private System.Windows.Forms.TextBox tbDrzava;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Label lblPostanskiBroj;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox tbPostanskiBroj;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.TextBox tbUlica;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostanskiBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj;
    }
}