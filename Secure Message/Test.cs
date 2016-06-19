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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // Setup AES Test Tab.
            Key.Text = Convert.ToBase64String(Keys.AESKey());
            IV.Text = Convert.ToBase64String(Keys.AESIV());

            // Setup RSA Test Tab.
            System.Security.Cryptography.RSACryptoServiceProvider RSAProv = new System.Security.Cryptography.RSACryptoServiceProvider();
            RSAProv.ImportParameters(Keys.RSAKey());
            txtPrivate.Text = RSAProv.ToXmlString(true);
            txtPublic.Text = RSAProv.ToXmlString(false);
            RSAProv.Dispose();

            // Setup Derive Key Tab.
            txtSalt.Text = Convert.ToBase64String(Keys.NewSalt());
        }

        private void btnAESNewKey_Click(object sender, EventArgs e)
        {
            Key.Text = Convert.ToBase64String(Keys.AESKey());
        }

        private void btnAESNewIV_Click(object sender, EventArgs e)
        {
            IV.Text = Convert.ToBase64String(Keys.AESIV());
        }

        private void btnAESEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Cipher.Text = Convert.ToBase64String(Crypto.AESEncrypt(Convert.FromBase64String(Key.Text), Convert.FromBase64String(IV.Text), ASCIIEncoding.Default.GetBytes(Plain.Text)));
                Plain.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Woops" + Environment.NewLine + ex.Message);
            }
        }

        private void btnAESDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Plain.Text = ASCIIEncoding.Default.GetString(Crypto.AESDecrypt(Convert.FromBase64String(Key.Text), Convert.FromBase64String(IV.Text), Convert.FromBase64String(Cipher.Text)));
                Cipher.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Woops" + Environment.NewLine + ex.Message);
            }
        }

        private void btnNewRSA_Click(object sender, EventArgs e)
        {
            System.Security.Cryptography.RSACryptoServiceProvider RSAProv = new System.Security.Cryptography.RSACryptoServiceProvider();
            RSAProv.ImportParameters(Keys.RSAKey());
            txtPrivate.Text = RSAProv.ToXmlString(true);
            txtPublic.Text = RSAProv.ToXmlString(false);
            RSAProv.Dispose();
        }

        private void btnRSAEncrypt_Click(object sender, EventArgs e)
        {
            txtRSACipher.Text = Convert.ToBase64String(Crypto.RSAEncrypt(txtPublic.Text, ASCIIEncoding.Default.GetBytes(txtRSAPlain.Text)));
            txtRSAPlain.Text = null;
        }

        private void btnRSADecrypt_Click(object sender, EventArgs e)
        {
            txtRSAPlain.Text = ASCIIEncoding.Default.GetString(Crypto.RSADecrypt(txtPrivate.Text, Convert.FromBase64String(txtRSACipher.Text)));
            txtRSACipher.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSigSign_Click(object sender, EventArgs e)
        {
            txtSigSig.Text = Convert.ToBase64String(Crypto.RSASign(ASCIIEncoding.Default.GetBytes(txtSigMessage.Text), txtPrivate.Text));
        }

        private void btnSigVfy_Click(object sender, EventArgs e)
        {
            if (Crypto.RSAVerify(ASCIIEncoding.Default.GetBytes(txtSigMessage.Text), txtPublic.Text, Convert.FromBase64String(txtSigSig.Text)))
            {
                MessageBox.Show("Signature OK");
            }
            else
            {
                MessageBox.Show("Signature Bad");
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            while (string.IsNullOrEmpty(open.FileName))
            {
                open.ShowDialog();
            }
            try
            {
                byte[] CipherText = Crypto.AESEncrypt(Convert.FromBase64String(Key.Text), Convert.FromBase64String(IV.Text), File.ReadAllBytes(open.FileName));
                File.WriteAllBytes(open.FileName + ".ENC", CipherText);
                MessageBox.Show("saved as " + open.FileName + ".ENC");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Woops" + Environment.NewLine + ex.Message);
            }
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "AES Encrypted Files(*.ENC)|*.ENC";
            while (string.IsNullOrEmpty(open.FileName))
            {
                open.ShowDialog();
            }
            try
            {
                byte[] PlainText = Crypto.AESDecrypt(Convert.FromBase64String(Key.Text), Convert.FromBase64String(IV.Text), File.ReadAllBytes(open.FileName));
                SaveFileDialog save = new SaveFileDialog();
                while (string.IsNullOrEmpty(save.FileName))
                {
                    save.ShowDialog();
                }
                File.WriteAllBytes(save.FileName, PlainText);
                MessageBox.Show("saved as " + save.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Woops" + Environment.NewLine + ex.Message);
            }
        }

        private void btnSignFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Unencrypted File to Sign";
            while (string.IsNullOrEmpty(open.FileName))
            {
                open.ShowDialog();
            }
            File.WriteAllBytes(open.FileName + ".SIG", Crypto.RSASign(File.ReadAllBytes(open.FileName), txtPrivate.Text));
            MessageBox.Show("Signature saved to " + open.FileName + ".SIG");
        }

        private void btnVerifyFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Unencrypted File to Verify";
            while (string.IsNullOrEmpty(open.FileName))
            {
                open.ShowDialog();
            }
            OpenFileDialog openSig = new OpenFileDialog();
            openSig.Title = "Signature to Verify";
            openSig.Filter = "Signature Files(*.SIG)|*.SIG";
            while (string.IsNullOrEmpty(openSig.FileName))
            {
                openSig.ShowDialog();
            }
            if (Crypto.RSAVerify(File.ReadAllBytes(open.FileName), txtPublic.Text, File.ReadAllBytes(openSig.FileName)))
            {
                MessageBox.Show("Signature OK");
            }
            else
            {
                MessageBox.Show("Signature Bad");
            }
        }

        private void btnGenerateSalt_Click(object sender, EventArgs e)
        {
            txtSalt.Text = Convert.ToBase64String(Keys.NewSalt());
        }

        private void btnDeriveKey_Click(object sender, EventArgs e)
        {
            txtDerivedKey.Text = Convert.ToBase64String(Keys.DeriveKey(txtPassword.Text, Convert.FromBase64String(txtSalt.Text)));
        }
    }
}
