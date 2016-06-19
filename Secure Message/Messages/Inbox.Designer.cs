namespace Secure_Message
{
    partial class Inbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inbox));
            this.imgDisplayImage = new System.Windows.Forms.PictureBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lstMessages = new System.Windows.Forms.ListView();
            this.Attachments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Received = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Expires = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReply = new System.Windows.Forms.Button();
            this.btmForward = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCryptoTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDisplayImage
            // 
            this.imgDisplayImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgDisplayImage.Location = new System.Drawing.Point(517, 9);
            this.imgDisplayImage.Name = "imgDisplayImage";
            this.imgDisplayImage.Size = new System.Drawing.Size(55, 55);
            this.imgDisplayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDisplayImage.TabIndex = 0;
            this.imgDisplayImage.TabStop = false;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoEllipsis = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(255, 9);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(256, 55);
            this.lblDisplayName.TabIndex = 1;
            this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstMessages
            // 
            this.lstMessages.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lstMessages.AllowColumnReorder = true;
            this.lstMessages.CheckBoxes = true;
            this.lstMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Attachments,
            this.From,
            this.Subject,
            this.Received,
            this.Expires});
            this.lstMessages.FullRowSelect = true;
            this.lstMessages.GridLines = true;
            this.lstMessages.HideSelection = false;
            this.lstMessages.Location = new System.Drawing.Point(12, 70);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(560, 250);
            this.lstMessages.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstMessages.TabIndex = 2;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            // 
            // Attachments
            // 
            this.Attachments.Text = "@";
            this.Attachments.Width = 25;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 125;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 175;
            // 
            // Received
            // 
            this.Received.Text = "Sent";
            this.Received.Width = 100;
            // 
            // Expires
            // 
            this.Expires.Text = "Expires";
            this.Expires.Width = 100;
            // 
            // btnReply
            // 
            this.btnReply.Location = new System.Drawing.Point(12, 326);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(75, 23);
            this.btnReply.TabIndex = 3;
            this.btnReply.Text = "&Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            // 
            // btmForward
            // 
            this.btmForward.Location = new System.Drawing.Point(93, 326);
            this.btmForward.Name = "btmForward";
            this.btmForward.Size = new System.Drawing.Size(75, 23);
            this.btmForward.TabIndex = 4;
            this.btmForward.Text = "&Forward";
            this.btmForward.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(93, 9);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(75, 23);
            this.btnContacts.TabIndex = 7;
            this.btnContacts.Text = "&Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(174, 9);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "&Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnCryptoTest
            // 
            this.btnCryptoTest.Location = new System.Drawing.Point(12, 38);
            this.btnCryptoTest.Name = "btnCryptoTest";
            this.btnCryptoTest.Size = new System.Drawing.Size(237, 23);
            this.btnCryptoTest.TabIndex = 10;
            this.btnCryptoTest.Text = "&Launch Crypto Test";
            this.btnCryptoTest.UseVisualStyleBackColor = true;
            this.btnCryptoTest.Click += new System.EventHandler(this.btnCryptoTest_Click);
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnCryptoTest);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btmForward);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.imgDisplayImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inbox - - Secure Message";
            this.Load += new System.EventHandler(this.Inbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplayImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDisplayImage;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.ListView lstMessages;
        private System.Windows.Forms.ColumnHeader Attachments;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Received;
        private System.Windows.Forms.ColumnHeader Expires;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Button btmForward;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCryptoTest;
    }
}