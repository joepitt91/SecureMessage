using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Secure_Message
{
    public partial class Login : Form
    {
        BackgroundWorker doLogin = new BackgroundWorker();
        int FailedLogins = 0;
        string Username = "";
        bool Authenticated = false;

        public Login()
        {
            InitializeComponent();
            FormClosing += Login_FormClosing;
            doLogin.DoWork += DoLogin_DoWork;
            doLogin.RunWorkerCompleted += DoLogin_RunWorkerCompleted;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (doLogin.IsBusy)
            {
                e.Cancel = true;
            }
            else if (Authenticated)
            {
                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            imgDisplayPicture.Image = Properties.Resources.NoDisplayImage;
            cmbUsername.Items.Clear();
            txtPassword.Text = "";

            foreach (string Account in Database.GetAccountNames())
            {
                cmbUsername.Items.Add(Account);
            }
            if (cmbUsername.Items.Count == 0)
            {
                txtPassword.Enabled = false;
                btnLogin.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true;
                btnLogin.Enabled = true;
                cmbUsername.SelectedIndex = 0;
            }
            Application.DoEvents();
            txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Invoke Worker to do login without blocking UI for ~ 10 seconds.
            doLogin.RunWorkerAsync();
        }

        private void DoLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                cmbUsername.Enabled = false;
                txtPassword.Enabled = false;
                lnkCreate.Enabled = false;
                lnkImport.Enabled = false;
                btnLogin.Enabled = false;
                prgDerivation.Visible = true;
            });

            byte[] DerivedKey = Keys.DeriveKey(txtPassword.Text, Database.GetSalt(Username));
            if (Database.VerifyAccount(Username, DerivedKey))
            {
                Invoke((MethodInvoker)delegate
                {
                    Program.CurrentAcount = Database.GetAccount(Username);
                    Program.CurrentAcount.DerivedKey = DerivedKey;
                    Authenticated = true;
                });
            }
            else
            {
                FailedLogins++;
                int Lockout = FailedLogins * 5000;
                Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("Login Failed! Wait " + (Lockout / 1000) + " seconds to try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prgDerivation.Style = ProgressBarStyle.Blocks;
                    prgDerivation.Maximum = Lockout;
                    prgDerivation.Value = 0;
                });
                TimeSpan LockedSpan = new TimeSpan(0, 0, 0, 0, Lockout);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                while (sw.Elapsed < LockedSpan)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        prgDerivation.Value = (int)sw.Elapsed.TotalMilliseconds;
                    });
                }
                sw.Stop();
                Invoke((MethodInvoker)delegate
                {
                    prgDerivation.Style = ProgressBarStyle.Marquee;
                });
            }

            Invoke((MethodInvoker)delegate
            {
                prgDerivation.Visible = false;
                cmbUsername.Enabled = true;
                txtPassword.Enabled = true;
                lnkCreate.Enabled = true;
                lnkImport.Enabled = true;
                btnLogin.Enabled = true;
            });
        }

        private void DoLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Authenticated)
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            Username = cmbUsername.SelectedItem.ToString();
            Username = Username.Substring(Username.LastIndexOf("(") + 1);
            Username = Username.Substring(0, Username.Length - 1);
            MemoryStream ImageReader = new MemoryStream(Database.GetDisplayImageBytes(Username));
            imgDisplayPicture.Image = Image.FromStream(ImageReader);
            ImageReader.Dispose();
            txtPassword.Enabled = true;
            btnLogin.Enabled = true;
            txtPassword.Focus();
        }

        private void lnkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.Text = "";
            cmbUsername.Items.Clear();
            imgDisplayPicture.Image = Properties.Resources.NoDisplayImage;
            txtPassword.Enabled = false;
            btnLogin.Enabled = false;
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
            Login_Load(this, new EventArgs());
        }

        private void lnkImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.Text = "";
            cmbUsername.Items.Clear();
            imgDisplayPicture.Image = Properties.Resources.NoDisplayImage;
            txtPassword.Enabled = false;
            btnLogin.Enabled = false;
            GC.Collect();

            OpenFileDialog Import = new OpenFileDialog();
            Import.Filter = "Secure Meesage Database (*.sm)|*.sm";
            Import.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (Import.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Import.FileName))
                {
                    string Username = Database.GetUsername(Import.FileName);
                    if (Username == "")
                    {
                        return;
                    }
                    string Destination = Application.UserAppDataPath + "\\" + Username + ".sm";
                    if (File.Exists(Destination))
                    {
                        if (MessageBox.Show("This Username already exists, Delete it and Import this one?" + Environment.NewLine + Environment.NewLine + "YOU WILL LOOSE ALL MESSAGES AND KEYS ASSOCIATED WITH THE OLD ACCOUNT. THIS CANNOT BE UNDONE!", "Duplicate Username", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            File.Delete(Destination);
                        }
                        else
                        {
                            return;
                        }
                    }
                    File.Copy(Import.FileName, Destination);
                }
            }

            Login_Load(this, new EventArgs());
        }
    }
}
