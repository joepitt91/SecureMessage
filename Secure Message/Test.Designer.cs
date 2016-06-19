namespace Secure_Message
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.tabsTests = new System.Windows.Forms.TabControl();
            this.tabAES = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.Plain = new System.Windows.Forms.TextBox();
            this.btnAESDecrypt = new System.Windows.Forms.Button();
            this.Cipher = new System.Windows.Forms.TextBox();
            this.btnAESEncrypt = new System.Windows.Forms.Button();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnAESNewIV = new System.Windows.Forms.Button();
            this.IV = new System.Windows.Forms.TextBox();
            this.btnAESNewKey = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.TextBox();
            this.tabRSA = new System.Windows.Forms.TabPage();
            this.btnRSADecrypt = new System.Windows.Forms.Button();
            this.btnRSAEncrypt = new System.Windows.Forms.Button();
            this.txtRSACipher = new System.Windows.Forms.TextBox();
            this.txtRSAPlain = new System.Windows.Forms.TextBox();
            this.btnNewRSA = new System.Windows.Forms.Button();
            this.txtPrivate = new System.Windows.Forms.TextBox();
            this.txtPublic = new System.Windows.Forms.TextBox();
            this.tabDigiCert = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabTextSign = new System.Windows.Forms.TabPage();
            this.txtSigSig = new System.Windows.Forms.TextBox();
            this.btnSigVfy = new System.Windows.Forms.Button();
            this.txtSigMessage = new System.Windows.Forms.TextBox();
            this.btnSigSign = new System.Windows.Forms.Button();
            this.tabFileSign = new System.Windows.Forms.TabPage();
            this.btnVerifyFile = new System.Windows.Forms.Button();
            this.btnSignFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabDeriveKey = new System.Windows.Forms.TabPage();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSalt = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.btnGenerateSalt = new System.Windows.Forms.Button();
            this.btnDeriveKey = new System.Windows.Forms.Button();
            this.txtDerivedKey = new System.Windows.Forms.TextBox();
            this.lblDerivedKey = new System.Windows.Forms.Label();
            this.tabsTests.SuspendLayout();
            this.tabAES.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.tabRSA.SuspendLayout();
            this.tabDigiCert.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabTextSign.SuspendLayout();
            this.tabFileSign.SuspendLayout();
            this.tabDeriveKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsTests
            // 
            this.tabsTests.Controls.Add(this.tabAES);
            this.tabsTests.Controls.Add(this.tabRSA);
            this.tabsTests.Controls.Add(this.tabDigiCert);
            this.tabsTests.Controls.Add(this.tabDeriveKey);
            this.tabsTests.Location = new System.Drawing.Point(12, 12);
            this.tabsTests.Name = "tabsTests";
            this.tabsTests.SelectedIndex = 0;
            this.tabsTests.Size = new System.Drawing.Size(580, 578);
            this.tabsTests.TabIndex = 0;
            // 
            // tabAES
            // 
            this.tabAES.Controls.Add(this.tabControl1);
            this.tabAES.Controls.Add(this.btnAESNewIV);
            this.tabAES.Controls.Add(this.IV);
            this.tabAES.Controls.Add(this.btnAESNewKey);
            this.tabAES.Controls.Add(this.Key);
            this.tabAES.Location = new System.Drawing.Point(4, 22);
            this.tabAES.Name = "tabAES";
            this.tabAES.Padding = new System.Windows.Forms.Padding(3);
            this.tabAES.Size = new System.Drawing.Size(572, 552);
            this.tabAES.TabIndex = 0;
            this.tabAES.Text = "AES Tests";
            this.tabAES.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabText);
            this.tabControl1.Controls.Add(this.tabFile);
            this.tabControl1.Location = new System.Drawing.Point(6, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 513);
            this.tabControl1.TabIndex = 8;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.Plain);
            this.tabText.Controls.Add(this.btnAESDecrypt);
            this.tabText.Controls.Add(this.Cipher);
            this.tabText.Controls.Add(this.btnAESEncrypt);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(551, 487);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // Plain
            // 
            this.Plain.AccessibleName = "AES Plain Text (Not Shared)";
            this.Plain.BackColor = System.Drawing.Color.IndianRed;
            this.Plain.ForeColor = System.Drawing.Color.White;
            this.Plain.Location = new System.Drawing.Point(6, 6);
            this.Plain.Multiline = true;
            this.Plain.Name = "Plain";
            this.Plain.Size = new System.Drawing.Size(238, 446);
            this.Plain.TabIndex = 4;
            // 
            // btnAESDecrypt
            // 
            this.btnAESDecrypt.Location = new System.Drawing.Point(286, 458);
            this.btnAESDecrypt.Name = "btnAESDecrypt";
            this.btnAESDecrypt.Size = new System.Drawing.Size(52, 23);
            this.btnAESDecrypt.TabIndex = 7;
            this.btnAESDecrypt.Text = "Decrypt";
            this.btnAESDecrypt.UseVisualStyleBackColor = true;
            this.btnAESDecrypt.Click += new System.EventHandler(this.btnAESDecrypt_Click);
            // 
            // Cipher
            // 
            this.Cipher.AccessibleName = "AES Cipher Text (Shared)";
            this.Cipher.BackColor = System.Drawing.Color.LawnGreen;
            this.Cipher.Location = new System.Drawing.Point(286, 6);
            this.Cipher.Multiline = true;
            this.Cipher.Name = "Cipher";
            this.Cipher.Size = new System.Drawing.Size(259, 446);
            this.Cipher.TabIndex = 6;
            // 
            // btnAESEncrypt
            // 
            this.btnAESEncrypt.Location = new System.Drawing.Point(187, 458);
            this.btnAESEncrypt.Name = "btnAESEncrypt";
            this.btnAESEncrypt.Size = new System.Drawing.Size(57, 23);
            this.btnAESEncrypt.TabIndex = 5;
            this.btnAESEncrypt.Text = "Encrypt";
            this.btnAESEncrypt.UseVisualStyleBackColor = true;
            this.btnAESEncrypt.Click += new System.EventHandler(this.btnAESEncrypt_Click);
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.btnDecryptFile);
            this.tabFile.Controls.Add(this.btnEncryptFile);
            this.tabFile.Location = new System.Drawing.Point(4, 22);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(551, 487);
            this.tabFile.TabIndex = 1;
            this.tabFile.Text = "File";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(6, 35);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptFile.TabIndex = 1;
            this.btnDecryptFile.Text = "Decrypt";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Location = new System.Drawing.Point(6, 6);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptFile.TabIndex = 0;
            this.btnEncryptFile.Text = "Encrypt";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // btnAESNewIV
            // 
            this.btnAESNewIV.Location = new System.Drawing.Point(491, 4);
            this.btnAESNewIV.Name = "btnAESNewIV";
            this.btnAESNewIV.Size = new System.Drawing.Size(75, 23);
            this.btnAESNewIV.TabIndex = 3;
            this.btnAESNewIV.Text = "New &IV";
            this.btnAESNewIV.UseVisualStyleBackColor = true;
            this.btnAESNewIV.Click += new System.EventHandler(this.btnAESNewIV_Click);
            // 
            // IV
            // 
            this.IV.AccessibleDescription = "";
            this.IV.AccessibleName = "AES IV (Shared)";
            this.IV.BackColor = System.Drawing.Color.LawnGreen;
            this.IV.Location = new System.Drawing.Point(307, 6);
            this.IV.Name = "IV";
            this.IV.Size = new System.Drawing.Size(178, 20);
            this.IV.TabIndex = 2;
            // 
            // btnAESNewKey
            // 
            this.btnAESNewKey.Location = new System.Drawing.Point(190, 4);
            this.btnAESNewKey.Name = "btnAESNewKey";
            this.btnAESNewKey.Size = new System.Drawing.Size(75, 23);
            this.btnAESNewKey.TabIndex = 1;
            this.btnAESNewKey.Text = "New &Key";
            this.btnAESNewKey.UseVisualStyleBackColor = true;
            this.btnAESNewKey.Click += new System.EventHandler(this.btnAESNewKey_Click);
            // 
            // Key
            // 
            this.Key.AccessibleDescription = "";
            this.Key.AccessibleName = "AES Key (Not Shared)";
            this.Key.BackColor = System.Drawing.Color.IndianRed;
            this.Key.ForeColor = System.Drawing.Color.White;
            this.Key.Location = new System.Drawing.Point(6, 6);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(178, 20);
            this.Key.TabIndex = 0;
            // 
            // tabRSA
            // 
            this.tabRSA.Controls.Add(this.btnRSADecrypt);
            this.tabRSA.Controls.Add(this.btnRSAEncrypt);
            this.tabRSA.Controls.Add(this.txtRSACipher);
            this.tabRSA.Controls.Add(this.txtRSAPlain);
            this.tabRSA.Controls.Add(this.btnNewRSA);
            this.tabRSA.Controls.Add(this.txtPrivate);
            this.tabRSA.Controls.Add(this.txtPublic);
            this.tabRSA.Location = new System.Drawing.Point(4, 22);
            this.tabRSA.Name = "tabRSA";
            this.tabRSA.Padding = new System.Windows.Forms.Padding(3);
            this.tabRSA.Size = new System.Drawing.Size(572, 552);
            this.tabRSA.TabIndex = 1;
            this.tabRSA.Text = "RSA Tests";
            this.tabRSA.UseVisualStyleBackColor = true;
            // 
            // btnRSADecrypt
            // 
            this.btnRSADecrypt.Location = new System.Drawing.Point(6, 324);
            this.btnRSADecrypt.Name = "btnRSADecrypt";
            this.btnRSADecrypt.Size = new System.Drawing.Size(560, 23);
            this.btnRSADecrypt.TabIndex = 6;
            this.btnRSADecrypt.Text = "&Decrypt";
            this.btnRSADecrypt.UseVisualStyleBackColor = true;
            this.btnRSADecrypt.Click += new System.EventHandler(this.btnRSADecrypt_Click);
            // 
            // btnRSAEncrypt
            // 
            this.btnRSAEncrypt.Location = new System.Drawing.Point(6, 269);
            this.btnRSAEncrypt.Name = "btnRSAEncrypt";
            this.btnRSAEncrypt.Size = new System.Drawing.Size(560, 23);
            this.btnRSAEncrypt.TabIndex = 4;
            this.btnRSAEncrypt.Text = "&Encrypt";
            this.btnRSAEncrypt.UseVisualStyleBackColor = true;
            this.btnRSAEncrypt.Click += new System.EventHandler(this.btnRSAEncrypt_Click);
            // 
            // txtRSACipher
            // 
            this.txtRSACipher.AccessibleName = "RSA Cipher Text (Shared)";
            this.txtRSACipher.BackColor = System.Drawing.Color.LawnGreen;
            this.txtRSACipher.Location = new System.Drawing.Point(6, 298);
            this.txtRSACipher.Name = "txtRSACipher";
            this.txtRSACipher.Size = new System.Drawing.Size(560, 20);
            this.txtRSACipher.TabIndex = 5;
            // 
            // txtRSAPlain
            // 
            this.txtRSAPlain.AccessibleName = "RSA Plain Text (Not Shared)";
            this.txtRSAPlain.BackColor = System.Drawing.Color.IndianRed;
            this.txtRSAPlain.ForeColor = System.Drawing.Color.White;
            this.txtRSAPlain.Location = new System.Drawing.Point(6, 243);
            this.txtRSAPlain.MaxLength = 512;
            this.txtRSAPlain.Name = "txtRSAPlain";
            this.txtRSAPlain.Size = new System.Drawing.Size(560, 20);
            this.txtRSAPlain.TabIndex = 3;
            // 
            // btnNewRSA
            // 
            this.btnNewRSA.Location = new System.Drawing.Point(6, 214);
            this.btnNewRSA.Name = "btnNewRSA";
            this.btnNewRSA.Size = new System.Drawing.Size(560, 23);
            this.btnNewRSA.TabIndex = 2;
            this.btnNewRSA.Text = "New &Key";
            this.btnNewRSA.UseVisualStyleBackColor = true;
            this.btnNewRSA.Click += new System.EventHandler(this.btnNewRSA_Click);
            // 
            // txtPrivate
            // 
            this.txtPrivate.AccessibleDescription = "";
            this.txtPrivate.AccessibleName = "RSA Private Key (Not Shared)";
            this.txtPrivate.BackColor = System.Drawing.Color.IndianRed;
            this.txtPrivate.ForeColor = System.Drawing.Color.White;
            this.txtPrivate.Location = new System.Drawing.Point(6, 110);
            this.txtPrivate.Multiline = true;
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivate.Size = new System.Drawing.Size(560, 98);
            this.txtPrivate.TabIndex = 1;
            // 
            // txtPublic
            // 
            this.txtPublic.AccessibleDescription = "";
            this.txtPublic.AccessibleName = "RSA Public Key Shared)";
            this.txtPublic.BackColor = System.Drawing.Color.LawnGreen;
            this.txtPublic.Location = new System.Drawing.Point(6, 6);
            this.txtPublic.Multiline = true;
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublic.Size = new System.Drawing.Size(560, 98);
            this.txtPublic.TabIndex = 0;
            // 
            // tabDigiCert
            // 
            this.tabDigiCert.Controls.Add(this.tabControl2);
            this.tabDigiCert.Location = new System.Drawing.Point(4, 22);
            this.tabDigiCert.Name = "tabDigiCert";
            this.tabDigiCert.Size = new System.Drawing.Size(572, 552);
            this.tabDigiCert.TabIndex = 2;
            this.tabDigiCert.Text = "Digital Signatures";
            this.tabDigiCert.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabTextSign);
            this.tabControl2.Controls.Add(this.tabFileSign);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(566, 546);
            this.tabControl2.TabIndex = 16;
            // 
            // tabTextSign
            // 
            this.tabTextSign.Controls.Add(this.txtSigSig);
            this.tabTextSign.Controls.Add(this.btnSigVfy);
            this.tabTextSign.Controls.Add(this.txtSigMessage);
            this.tabTextSign.Controls.Add(this.btnSigSign);
            this.tabTextSign.Location = new System.Drawing.Point(4, 22);
            this.tabTextSign.Name = "tabTextSign";
            this.tabTextSign.Padding = new System.Windows.Forms.Padding(3);
            this.tabTextSign.Size = new System.Drawing.Size(558, 520);
            this.tabTextSign.TabIndex = 0;
            this.tabTextSign.Text = "Text";
            this.tabTextSign.UseVisualStyleBackColor = true;
            // 
            // txtSigSig
            // 
            this.txtSigSig.AccessibleDescription = "";
            this.txtSigSig.AccessibleName = "RSA Signature (Shared)";
            this.txtSigSig.BackColor = System.Drawing.Color.LawnGreen;
            this.txtSigSig.Location = new System.Drawing.Point(6, 6);
            this.txtSigSig.Name = "txtSigSig";
            this.txtSigSig.Size = new System.Drawing.Size(546, 20);
            this.txtSigSig.TabIndex = 8;
            // 
            // btnSigVfy
            // 
            this.btnSigVfy.Location = new System.Drawing.Point(78, 491);
            this.btnSigVfy.Name = "btnSigVfy";
            this.btnSigVfy.Size = new System.Drawing.Size(58, 23);
            this.btnSigVfy.TabIndex = 15;
            this.btnSigVfy.Text = "Verify";
            this.btnSigVfy.UseVisualStyleBackColor = true;
            this.btnSigVfy.Click += new System.EventHandler(this.btnSigVfy_Click);
            // 
            // txtSigMessage
            // 
            this.txtSigMessage.AccessibleName = "Plain Text (Not Shared)";
            this.txtSigMessage.BackColor = System.Drawing.Color.IndianRed;
            this.txtSigMessage.ForeColor = System.Drawing.Color.White;
            this.txtSigMessage.Location = new System.Drawing.Point(6, 32);
            this.txtSigMessage.Multiline = true;
            this.txtSigMessage.Name = "txtSigMessage";
            this.txtSigMessage.Size = new System.Drawing.Size(546, 454);
            this.txtSigMessage.TabIndex = 12;
            // 
            // btnSigSign
            // 
            this.btnSigSign.Location = new System.Drawing.Point(6, 491);
            this.btnSigSign.Name = "btnSigSign";
            this.btnSigSign.Size = new System.Drawing.Size(66, 23);
            this.btnSigSign.TabIndex = 13;
            this.btnSigSign.Text = "Sign";
            this.btnSigSign.UseVisualStyleBackColor = true;
            this.btnSigSign.Click += new System.EventHandler(this.btnSigSign_Click);
            // 
            // tabFileSign
            // 
            this.tabFileSign.Controls.Add(this.btnVerifyFile);
            this.tabFileSign.Controls.Add(this.btnSignFile);
            this.tabFileSign.Location = new System.Drawing.Point(4, 22);
            this.tabFileSign.Name = "tabFileSign";
            this.tabFileSign.Padding = new System.Windows.Forms.Padding(3);
            this.tabFileSign.Size = new System.Drawing.Size(558, 520);
            this.tabFileSign.TabIndex = 1;
            this.tabFileSign.Text = "File";
            this.tabFileSign.UseVisualStyleBackColor = true;
            // 
            // btnVerifyFile
            // 
            this.btnVerifyFile.Location = new System.Drawing.Point(7, 37);
            this.btnVerifyFile.Name = "btnVerifyFile";
            this.btnVerifyFile.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyFile.TabIndex = 1;
            this.btnVerifyFile.Text = "Verify";
            this.btnVerifyFile.UseVisualStyleBackColor = true;
            this.btnVerifyFile.Click += new System.EventHandler(this.btnVerifyFile_Click);
            // 
            // btnSignFile
            // 
            this.btnSignFile.Location = new System.Drawing.Point(7, 7);
            this.btnSignFile.Name = "btnSignFile";
            this.btnSignFile.Size = new System.Drawing.Size(75, 23);
            this.btnSignFile.TabIndex = 0;
            this.btnSignFile.Text = "Sign";
            this.btnSignFile.UseVisualStyleBackColor = true;
            this.btnSignFile.Click += new System.EventHandler(this.btnSignFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(552, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabDeriveKey
            // 
            this.tabDeriveKey.Controls.Add(this.lblDerivedKey);
            this.tabDeriveKey.Controls.Add(this.txtDerivedKey);
            this.tabDeriveKey.Controls.Add(this.btnDeriveKey);
            this.tabDeriveKey.Controls.Add(this.btnGenerateSalt);
            this.tabDeriveKey.Controls.Add(this.txtSalt);
            this.tabDeriveKey.Controls.Add(this.lblSalt);
            this.tabDeriveKey.Controls.Add(this.txtPassword);
            this.tabDeriveKey.Controls.Add(this.lblPassword);
            this.tabDeriveKey.Location = new System.Drawing.Point(4, 22);
            this.tabDeriveKey.Name = "tabDeriveKey";
            this.tabDeriveKey.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeriveKey.Size = new System.Drawing.Size(572, 552);
            this.tabDeriveKey.TabIndex = 3;
            this.tabDeriveKey.Text = "Derive Key";
            this.tabDeriveKey.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 3);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.IndianRed;
            this.txtPassword.Location = new System.Drawing.Point(6, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(560, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(6, 42);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(25, 13);
            this.lblSalt.TabIndex = 2;
            this.lblSalt.Text = "Salt";
            // 
            // txtSalt
            // 
            this.txtSalt.BackColor = System.Drawing.Color.IndianRed;
            this.txtSalt.Location = new System.Drawing.Point(6, 58);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(479, 20);
            this.txtSalt.TabIndex = 3;
            // 
            // btnGenerateSalt
            // 
            this.btnGenerateSalt.Location = new System.Drawing.Point(491, 56);
            this.btnGenerateSalt.Name = "btnGenerateSalt";
            this.btnGenerateSalt.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateSalt.TabIndex = 4;
            this.btnGenerateSalt.Text = "Generate ";
            this.btnGenerateSalt.UseVisualStyleBackColor = true;
            this.btnGenerateSalt.Click += new System.EventHandler(this.btnGenerateSalt_Click);
            // 
            // btnDeriveKey
            // 
            this.btnDeriveKey.Location = new System.Drawing.Point(6, 84);
            this.btnDeriveKey.Name = "btnDeriveKey";
            this.btnDeriveKey.Size = new System.Drawing.Size(560, 23);
            this.btnDeriveKey.TabIndex = 5;
            this.btnDeriveKey.Text = "Derive Key";
            this.btnDeriveKey.UseVisualStyleBackColor = true;
            this.btnDeriveKey.Click += new System.EventHandler(this.btnDeriveKey_Click);
            // 
            // txtDerivedKey
            // 
            this.txtDerivedKey.BackColor = System.Drawing.Color.IndianRed;
            this.txtDerivedKey.Location = new System.Drawing.Point(6, 126);
            this.txtDerivedKey.Name = "txtDerivedKey";
            this.txtDerivedKey.Size = new System.Drawing.Size(560, 20);
            this.txtDerivedKey.TabIndex = 6;
            // 
            // lblDerivedKey
            // 
            this.lblDerivedKey.AutoSize = true;
            this.lblDerivedKey.Location = new System.Drawing.Point(6, 110);
            this.lblDerivedKey.Name = "lblDerivedKey";
            this.lblDerivedKey.Size = new System.Drawing.Size(65, 13);
            this.lblDerivedKey.TabIndex = 7;
            this.lblDerivedKey.Text = "Derived Key";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(608, 606);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabsTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.tabsTests.ResumeLayout(false);
            this.tabAES.ResumeLayout(false);
            this.tabAES.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabFile.ResumeLayout(false);
            this.tabRSA.ResumeLayout(false);
            this.tabRSA.PerformLayout();
            this.tabDigiCert.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabTextSign.ResumeLayout(false);
            this.tabTextSign.PerformLayout();
            this.tabFileSign.ResumeLayout(false);
            this.tabDeriveKey.ResumeLayout(false);
            this.tabDeriveKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsTests;
        private System.Windows.Forms.TabPage tabAES;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAESDecrypt;
        private System.Windows.Forms.Button btnAESEncrypt;
        private System.Windows.Forms.TextBox Cipher;
        private System.Windows.Forms.TextBox Plain;
        private System.Windows.Forms.Button btnAESNewIV;
        private System.Windows.Forms.TextBox IV;
        private System.Windows.Forms.Button btnAESNewKey;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.TabPage tabRSA;
        private System.Windows.Forms.Button btnNewRSA;
        private System.Windows.Forms.TextBox txtPrivate;
        private System.Windows.Forms.TextBox txtPublic;
        private System.Windows.Forms.Button btnRSADecrypt;
        private System.Windows.Forms.Button btnRSAEncrypt;
        private System.Windows.Forms.TextBox txtRSACipher;
        private System.Windows.Forms.TextBox txtRSAPlain;
        private System.Windows.Forms.TabPage tabDigiCert;
        private System.Windows.Forms.Button btnSigVfy;
        private System.Windows.Forms.Button btnSigSign;
        private System.Windows.Forms.TextBox txtSigMessage;
        private System.Windows.Forms.TextBox txtSigSig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabTextSign;
        private System.Windows.Forms.TabPage tabFileSign;
        private System.Windows.Forms.Button btnVerifyFile;
        private System.Windows.Forms.Button btnSignFile;
        private System.Windows.Forms.TabPage tabDeriveKey;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDerivedKey;
        private System.Windows.Forms.TextBox txtDerivedKey;
        private System.Windows.Forms.Button btnDeriveKey;
        private System.Windows.Forms.Button btnGenerateSalt;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.TextBox txtPassword;
    }
}