using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Secure_Message
{
    public partial class MondifyAccount : Form
    {
        private BackgroundWorker DeriveKey = new BackgroundWorker();
        private byte[] Salt;
        private byte[] DerivedKey;

        public MondifyAccount()
        {
            InitializeComponent();
            DeriveKey.DoWork += DeriveKey_DoWork;
            DeriveKey.RunWorkerCompleted += DeriveKey_RunWorkerCompleted;
        }

        private void MondifyAccount_Load(object sender, EventArgs e)
        {

        }

        private void DeriveKey_DoWork(object sender, DoWorkEventArgs e)
        {
            Salt = Keys.NewSalt();
            DerivedKey = Keys.DeriveKey(txtPassword.Text, Salt);
        }

        private void DeriveKey_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (new Account().CreateAccount(txtUsername.Text, txtDisplayName.Text, txtEmail.Text, imgDisplayImage.Image, DerivedKey, Salt))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Something went wrong creating your account, Plese try again.", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.No;
                Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            imgDisplayImage.Image = Properties.Resources.NoDisplayImage;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadDisplayImage = new OpenFileDialog();
            loadDisplayImage.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;*.png";
            loadDisplayImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            loadDisplayImage.Title = "Select Display Picture";
            if (loadDisplayImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgDisplayImage.Image = Image.FromFile(loadDisplayImage.FileName);
                }
                catch
                {
                    MessageBox.Show("Failed to Load Image, please again.", "Display Image Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate Username.
            if (txtUsername.TextLength < 3)
            {
                MessageBox.Show("Username must be 3 or more characters long.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblUsername.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblUsername.ForeColor = Color.Black;
            }

            if (File.Exists(Application.UserAppDataPath + "\\" + txtUsername.Text + ".sm"))
            {
                if (MessageBox.Show(txtUsername.Text + " already Exists, Delete it and Recreate?" + Environment.NewLine + Environment.NewLine + "YOU WILL LOOSE ALL MESSAGES AND KEYS ASSOCIATED WITH THE OLD ACCOUNT. THIS CANNOT BE UNDONE!", "Duplicate Username", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(Application.UserAppDataPath + "\\" + txtUsername.Text + ".sm");
                }
                else
                {
                    return;
                }
            }

            // Validate Display Name.
            if (txtDisplayName.TextLength < 3)
            {
                MessageBox.Show("Display Name must be 3 or more characters long.", "Invalid Display Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDisplayName.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblDisplayName.ForeColor = Color.Black;
            }

            // Validate E-mail, if provided.
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                try
                {
                    new System.Net.Mail.MailAddress(txtEmail.Text);
                    lblEmail.ForeColor = Color.Black;
                }
                catch
                {
                    MessageBox.Show("E-mail Address is not valid.", "Invalid E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblEmail.ForeColor = Color.Red;
                    return;
                }
            }
            else
            {
                lblEmail.ForeColor = Color.Black;
            }

            // Validate Password.
            if (txtPassword.TextLength < 8)
            {
                MessageBox.Show("Password must be 8 or more characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPassword.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblPassword.ForeColor = Color.Black;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passowrd and Confirm Password do not match.", "Mismatch Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConfirmPassword.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblConfirmPassword.ForeColor = Color.Black;
            }

            // Create Account.
            prgCreating.Visible = true;
            Enabled = false;
            DeriveKey.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}