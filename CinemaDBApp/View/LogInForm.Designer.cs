
namespace CinemaDBApp
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLogInText = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.btnSrp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Name = "lblWelcome";
            // 
            // lblLogInText
            // 
            resources.ApplyResources(this.lblLogInText, "lblLogInText");
            this.lblLogInText.BackColor = System.Drawing.Color.Transparent;
            this.lblLogInText.Name = "lblLogInText";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Name = "lblUsername";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Name = "lblPassword";
            // 
            // txtBoxUsername
            // 
            resources.ApplyResources(this.txtBoxUsername, "txtBoxUsername");
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUsername.Name = "txtBoxUsername";
            // 
            // txtBoxPassword
            // 
            resources.ApplyResources(this.txtBoxPassword, "txtBoxPassword");
            this.txtBoxPassword.Name = "txtBoxPassword";
            // 
            // btnLogIn
            // 
            resources.ApplyResources(this.btnLogIn, "btnLogIn");
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnEng
            // 
            resources.ApplyResources(this.btnEng, "btnEng");
            this.btnEng.BackColor = System.Drawing.Color.Transparent;
            this.btnEng.BackgroundImage = global::CinemaDBApp.Properties.Resources.depositphotos_25587499_stock_photo_flag_of_uk;
            this.btnEng.Name = "btnEng";
            this.btnEng.UseVisualStyleBackColor = false;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnSrp
            // 
            resources.ApplyResources(this.btnSrp, "btnSrp");
            this.btnSrp.BackColor = System.Drawing.Color.Transparent;
            this.btnSrp.BackgroundImage = global::CinemaDBApp.Properties.Resources.serbia_flag_png_large;
            this.btnSrp.Name = "btnSrp";
            this.btnSrp.UseVisualStyleBackColor = false;
            this.btnSrp.Click += new System.EventHandler(this.btnSrp_Click);
            // 
            // FormLogIn
            // 
            this.AcceptButton = this.btnLogIn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnSrp);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLogInText);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLogInText;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnEng;
        private System.Windows.Forms.Button btnSrp;
    }
}

