using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Secure_Message
{
    public partial class Compose : Form
    {
        Message ThisMessage = new Message();
        List<Attachment> TheseAttachments = new List<Attachment>();
        BackgroundWorker AttachFile = new BackgroundWorker();

        public Compose()
        {
            InitializeComponent();
            FormClosing += Compose_FormClosing;
            AttachFile.DoWork += AttachFile_DoWork;
            AttachFile.RunWorkerCompleted += AttachFile_RunWorkerCompleted;
        }

        private void Compose_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show("Are you sure? This message will not be sent or saved.", "Discard Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void AttachFile_DoWork(object sender, DoWorkEventArgs e)
        {
            string Filename = "" ;
            byte[] FileContents = new byte[0];

            OpenFileDialog Attach = new OpenFileDialog();
            Attach.Filter = "All Files (*.*)|*.*";
            Attach.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Attach.Title = "Attach File...";

            Invoke((MethodInvoker)delegate
            {
                if (Attach.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(Attach.FileName))
                    {
                        Filename = Attach.FileName.Substring(Attach.FileName.LastIndexOf("\\") + 1);
                        FileContents = File.ReadAllBytes(Attach.FileName);
                        int i = 0;
                        foreach (Attachment Attached in TheseAttachments)
                        {
                            string Extension = Filename.Substring(Filename.LastIndexOf("."));
                            if (Attached.Filename == Filename)
                            {
                                i++;
                                Filename = Filename = Attach.FileName.Substring(Attach.FileName.LastIndexOf("\\") + 1);
                                Filename = Filename.Substring(0, Filename.LastIndexOf("."));
                                Filename = Filename + "_" + i + Extension;
                            }
                        }
                    }
                }
                prgAttaching.Visible = true;
            });
            Attachment NewAttachment = new Attachment(Filename, FileContents);
            TheseAttachments.Add(NewAttachment);
        }

        private void AttachFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnAdd.Enabled = true;
            lstAttachments.Enabled = true;
            prgAttaching.Visible = false;
            RefreshAttachments();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Text = "Compose - " + Program.CurrentAcount.DisplayName + " - Secure Message";
            txtFrom.Text = Program.CurrentAcount.DisplayName;
            cmbExpires.MinDate = DateTime.Now;
            cmbExpires.Value = DateTime.Now.AddDays(7);
            RefreshAttachments();
            ThisMessage.FromDisplayName = txtFrom.Text;
        }

        private void RefreshAttachments()
        {
            lstAttachments.Items.Clear();
            foreach (Attachment File in TheseAttachments)
            {
                lstAttachments.Items.Add(File.Filename);
            }
        }

        private void cmbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThisMessage.ToDisplayName = (string)cmbTo.SelectedItem;
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            ThisMessage.Subject = txtSubject.Text;
        }

        private void cmbExpires_ValueChanged(object sender, EventArgs e)
        {
            ThisMessage.Expires = cmbExpires.Checked;
            ThisMessage.ExpiryDate = cmbExpires.Value;
        }

        private void txtBody_TextChanged(object sender, EventArgs e)
        {
            ThisMessage.Body = txtBody.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            lstAttachments.Enabled = false;
            AttachFile.RunWorkerAsync();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string Filename = (string)lstAttachments.SelectedItem;
            foreach (Attachment Attached in TheseAttachments)
            {
                if (Attached.Filename == Filename)
                {
                    TheseAttachments.Remove(Attached);
                    break;
                }
            }
            RefreshAttachments();
        }

        private void lstAttachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAttachments.SelectedIndex > -1)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Enabled = false;
            prgSending.Visible = true;
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
