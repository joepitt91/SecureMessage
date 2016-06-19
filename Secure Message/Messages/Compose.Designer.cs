namespace Secure_Message
{
    partial class Compose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compose));
            this.grpMeta = new System.Windows.Forms.GroupBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblExpires = new System.Windows.Forms.Label();
            this.cmbExpires = new System.Windows.Forms.DateTimePicker();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.grpAttachments = new System.Windows.Forms.GroupBox();
            this.prgAttaching = new System.Windows.Forms.ProgressBar();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.prgSending = new System.Windows.Forms.ProgressBar();
            this.grpMeta.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.grpAttachments.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMeta
            // 
            this.grpMeta.Controls.Add(this.cmbTo);
            this.grpMeta.Controls.Add(this.txtFrom);
            this.grpMeta.Controls.Add(this.lblExpires);
            this.grpMeta.Controls.Add(this.cmbExpires);
            this.grpMeta.Controls.Add(this.lblSubject);
            this.grpMeta.Controls.Add(this.txtSubject);
            this.grpMeta.Controls.Add(this.lblTo);
            this.grpMeta.Controls.Add(this.btnSearch);
            this.grpMeta.Controls.Add(this.lblFrom);
            this.grpMeta.Location = new System.Drawing.Point(12, 42);
            this.grpMeta.Name = "grpMeta";
            this.grpMeta.Size = new System.Drawing.Size(460, 129);
            this.grpMeta.TabIndex = 0;
            this.grpMeta.TabStop = false;
            this.grpMeta.Text = "Message Details";
            // 
            // cmbTo
            // 
            this.cmbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(99, 45);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(273, 21);
            this.cmbTo.TabIndex = 3;
            this.cmbTo.SelectedIndexChanged += new System.EventHandler(this.cmbTo_SelectedIndexChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(99, 19);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(273, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.Location = new System.Drawing.Point(6, 104);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(87, 13);
            this.lblExpires.TabIndex = 7;
            this.lblExpires.Text = "Message Expires";
            // 
            // cmbExpires
            // 
            this.cmbExpires.AccessibleName = "Message Expires";
            this.cmbExpires.Checked = false;
            this.cmbExpires.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.cmbExpires.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbExpires.Location = new System.Drawing.Point(99, 98);
            this.cmbExpires.Name = "cmbExpires";
            this.cmbExpires.ShowCheckBox = true;
            this.cmbExpires.Size = new System.Drawing.Size(273, 20);
            this.cmbExpires.TabIndex = 8;
            this.cmbExpires.ValueChanged += new System.EventHandler(this.cmbExpires_ValueChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(6, 75);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(99, 72);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(273, 20);
            this.txtSubject.TabIndex = 6;
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(6, 48);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(378, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(6, 22);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // grpContent
            // 
            this.grpContent.Controls.Add(this.txtBody);
            this.grpContent.Location = new System.Drawing.Point(12, 177);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(460, 385);
            this.grpContent.TabIndex = 1;
            this.grpContent.TabStop = false;
            this.grpContent.Text = "Message Body";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(6, 19);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(448, 355);
            this.txtBody.TabIndex = 0;
            this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
            // 
            // grpAttachments
            // 
            this.grpAttachments.Controls.Add(this.prgAttaching);
            this.grpAttachments.Controls.Add(this.btnRemove);
            this.grpAttachments.Controls.Add(this.btnAdd);
            this.grpAttachments.Controls.Add(this.lstAttachments);
            this.grpAttachments.Location = new System.Drawing.Point(12, 568);
            this.grpAttachments.Name = "grpAttachments";
            this.grpAttachments.Size = new System.Drawing.Size(460, 111);
            this.grpAttachments.TabIndex = 2;
            this.grpAttachments.TabStop = false;
            this.grpAttachments.Text = "Attachments";
            // 
            // prgAttaching
            // 
            this.prgAttaching.Location = new System.Drawing.Point(168, 82);
            this.prgAttaching.MarqueeAnimationSpeed = 20;
            this.prgAttaching.Name = "prgAttaching";
            this.prgAttaching.Size = new System.Drawing.Size(286, 23);
            this.prgAttaching.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgAttaching.TabIndex = 3;
            this.prgAttaching.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(87, 82);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstAttachments
            // 
            this.lstAttachments.ColumnWidth = 145;
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.Location = new System.Drawing.Point(7, 20);
            this.lstAttachments.MultiColumn = true;
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(447, 56);
            this.lstAttachments.Sorted = true;
            this.lstAttachments.TabIndex = 0;
            this.lstAttachments.SelectedIndexChanged += new System.EventHandler(this.lstAttachments_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiscard.Location = new System.Drawing.Point(93, 12);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnDiscard.TabIndex = 4;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // prgSending
            // 
            this.prgSending.Location = new System.Drawing.Point(174, 12);
            this.prgSending.MarqueeAnimationSpeed = 20;
            this.prgSending.Name = "prgSending";
            this.prgSending.Size = new System.Drawing.Size(298, 23);
            this.prgSending.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgSending.TabIndex = 5;
            this.prgSending.Visible = false;
            // 
            // Compose
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnDiscard;
            this.ClientSize = new System.Drawing.Size(484, 691);
            this.Controls.Add(this.prgSending);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpAttachments);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.grpMeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Compose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Message";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMeta.ResumeLayout(false);
            this.grpMeta.PerformLayout();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.grpAttachments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMeta;
        private System.Windows.Forms.Label lblExpires;
        private System.Windows.Forms.DateTimePicker cmbExpires;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.GroupBox grpAttachments;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.ProgressBar prgAttaching;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.ProgressBar prgSending;
    }
}

