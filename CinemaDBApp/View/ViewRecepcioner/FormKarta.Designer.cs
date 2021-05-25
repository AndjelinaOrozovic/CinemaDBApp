
namespace CinemaDBApp.View.ViewRecepcioner
{
    partial class FormKarta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKarta));
            this.lbllDatumIVrijemeIzdavanja = new System.Windows.Forms.Label();
            this.lblRecepcioner = new System.Windows.Forms.Label();
            this.lblPocetakProjekcije = new System.Windows.Forms.Label();
            this.lblProjekcija = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblSjediste = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.comboBoxRed = new System.Windows.Forms.ComboBox();
            this.comboBoxSjediste = new System.Windows.Forms.ComboBox();
            this.btnIzdaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllDatumIVrijemeIzdavanja
            // 
            resources.ApplyResources(this.lbllDatumIVrijemeIzdavanja, "lbllDatumIVrijemeIzdavanja");
            this.lbllDatumIVrijemeIzdavanja.Name = "lbllDatumIVrijemeIzdavanja";
            // 
            // lblRecepcioner
            // 
            resources.ApplyResources(this.lblRecepcioner, "lblRecepcioner");
            this.lblRecepcioner.Name = "lblRecepcioner";
            // 
            // lblPocetakProjekcije
            // 
            resources.ApplyResources(this.lblPocetakProjekcije, "lblPocetakProjekcije");
            this.lblPocetakProjekcije.Name = "lblPocetakProjekcije";
            // 
            // lblProjekcija
            // 
            resources.ApplyResources(this.lblProjekcija, "lblProjekcija");
            this.lblProjekcija.Name = "lblProjekcija";
            // 
            // lblSala
            // 
            resources.ApplyResources(this.lblSala, "lblSala");
            this.lblSala.Name = "lblSala";
            // 
            // lblSjediste
            // 
            resources.ApplyResources(this.lblSjediste, "lblSjediste");
            this.lblSjediste.Name = "lblSjediste";
            // 
            // lblRed
            // 
            resources.ApplyResources(this.lblRed, "lblRed");
            this.lblRed.Name = "lblRed";
            // 
            // comboBoxRed
            // 
            this.comboBoxRed.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxRed, "comboBoxRed");
            this.comboBoxRed.Name = "comboBoxRed";
            this.comboBoxRed.SelectedIndexChanged += new System.EventHandler(this.comboBoxRed_SelectedIndexChanged);
            // 
            // comboBoxSjediste
            // 
            this.comboBoxSjediste.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSjediste, "comboBoxSjediste");
            this.comboBoxSjediste.Name = "comboBoxSjediste";
            this.comboBoxSjediste.SelectedIndexChanged += new System.EventHandler(this.comboBoxSjediste_SelectedIndexChanged);
            // 
            // btnIzdaj
            // 
            resources.ApplyResources(this.btnIzdaj, "btnIzdaj");
            this.btnIzdaj.Name = "btnIzdaj";
            this.btnIzdaj.UseVisualStyleBackColor = true;
            this.btnIzdaj.Click += new System.EventHandler(this.BtnIzdaj_Click);
            // 
            // FormKarta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzdaj);
            this.Controls.Add(this.comboBoxSjediste);
            this.Controls.Add(this.comboBoxRed);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblSjediste);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblProjekcija);
            this.Controls.Add(this.lblPocetakProjekcije);
            this.Controls.Add(this.lblRecepcioner);
            this.Controls.Add(this.lbllDatumIVrijemeIzdavanja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormKarta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllDatumIVrijemeIzdavanja;
        private System.Windows.Forms.Label lblRecepcioner;
        private System.Windows.Forms.Label lblPocetakProjekcije;
        private System.Windows.Forms.Label lblProjekcija;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblSjediste;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.ComboBox comboBoxRed;
        private System.Windows.Forms.ComboBox comboBoxSjediste;
        private System.Windows.Forms.Button btnIzdaj;
    }
}