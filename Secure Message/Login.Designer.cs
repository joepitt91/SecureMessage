namespace Secure_Message
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.imgDisplayPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.prgDerivation = new System.Windows.Forms.ProgressBar();
            this.lnkCreate = new System.Windows.Forms.LinkLabel();
            this.lnkImport = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplayPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDisplayPicture
            // 
            this.imgDisplayPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgDisplayPicture.Image = global::Secure_Message.Properties.Resources.NoDisplayImage;
            this.imgDisplayPicture.Location = new System.Drawing.Point(12, 12);
            this.imgDisplayPicture.Name = "imgDisplayPicture";
            this.imgDisplayPicture.Size = new System.Drawing.Size(150, 150);
            this.imgDisplayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDisplayPicture.TabIndex = 0;
            this.imgDisplayPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(168, 29);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(254, 21);
            this.cmbUsername.TabIndex = 1;
            this.cmbUsername.SelectedIndexChanged += new System.EventHandler(this.cmbUsername_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(169, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(168, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(254, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // prgDerivation
            // 
            this.prgDerivation.Location = new System.Drawing.Point(168, 113);
            this.prgDerivation.MarqueeAnimationSpeed = 10;
            this.prgDerivation.Name = "prgDerivation";
            this.prgDerivation.Size = new System.Drawing.Size(254, 23);
            this.prgDerivation.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgDerivation.TabIndex = 7;
            this.prgDerivation.Visible = false;
            // 
            // lnkCreate
            // 
            this.lnkCreate.AutoSize = true;
            this.lnkCreate.Location = new System.Drawing.Point(169, 97);
            this.lnkCreate.Name = "lnkCreate";
            this.lnkCreate.Size = new System.Drawing.Size(106, 13);
            this.lnkCreate.TabIndex = 5;
            this.lnkCreate.TabStop = true;
            this.lnkCreate.Text = "Create New Account";
            this.lnkCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreate_LinkClicked);
            // 
            // lnkImport
            // 
            this.lnkImport.AutoSize = true;
            this.lnkImport.Location = new System.Drawing.Point(343, 97);
            this.lnkImport.Name = "lnkImport";
            this.lnkImport.Size = new System.Drawing.Size(79, 13);
            this.lnkImport.TabIndex = 6;
            this.lnkImport.TabStop = true;
            this.lnkImport.Text = "Import Account";
            this.lnkImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImport_LinkClicked);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 175);
            this.Controls.Add(this.lnkImport);
            this.Controls.Add(this.lnkCreate);
            this.Controls.Add(this.prgDerivation);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgDisplayPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplayPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDisplayPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ProgressBar prgDerivation;
        private System.Windows.Forms.LinkLabel lnkCreate;
        private System.Windows.Forms.LinkLabel lnkImport;
    }
}