using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Secure_Message
{
    class Account
    {
        internal string Username;
        internal string AccountID;
        internal string DisplayName;
        internal string Email;
        internal Image DisplayImage;
        internal byte[] DerivedKey;
        internal byte[] IV;
        internal int KeyID;
        internal string KeyType;
        internal string PublicKey;
        internal byte[] Salt;
        internal byte[] CheckValue;

        /// <summary>
        /// Creates an Account.
        /// </summary>
        /// <param name="_Username">The new Username.</param>
        /// <param name="_DisplayName">The new Display Name.</param>
        /// <param name="_Email">The new E-mail Address.</param>
        /// <param name="_DisplayImage">The new Image.</param>
        /// <param name="_DerivedKey">The new Derived Key.</param>
        /// <param name="_Salt">The New Salt</param>
        /// <returns>If creation was successful.</returns>
        public bool CreateAccount(string _Username, string _DisplayName, string _Email, Image _DisplayImage, byte[] _DerivedKey, byte[] _Salt)
        {
            Username = _Username;
            AccountID = Username + "_" + Guid.NewGuid();
            DisplayName = _DisplayName;
            Email = _Email;
            DisplayImage = _DisplayImage;
            DerivedKey = _DerivedKey;
            Salt = _Salt;
            IV = Keys.AESIV();
            CheckValue = Crypto.AESEncrypt(DerivedKey, IV, ASCIIEncoding.ASCII.GetBytes("SecureMessage_2ceb8a18-5da6-4977-a3b2-ee387782af68" + Salt));
            
            if (!Database.CreateAccount(this))
            {
                return false;
            }

            RSAParameters RSA = Keys.RSAKey();
            RSACryptoServiceProvider RSAProv = new RSACryptoServiceProvider(4096);
            RSAProv.ImportParameters(RSA);
            string PublicKey = RSAProv.ToXmlString(false);
            string PrivateKey = RSAProv.ToXmlString(true);
            RSAProv.Dispose();
            byte[] KeyIV = Keys.AESIV();
            byte[] PrivateCrypt = Crypto.AESEncrypt(DerivedKey, KeyIV, ASCIIEncoding.ASCII.GetBytes(PrivateKey));
            Database.SaveKey(Username, "RSA", PublicKey, KeyIV, PrivateCrypt);

            // Send welcome e-mail

            return true;
        }

        /// <summary>
        /// Converts a System.Drawing.Image to a Byte[]
        /// </summary>
        /// <param name="DisplayImage">The image to be converted.</param>
        /// <returns>A Byte[] of the image.</returns>
        public static byte[] SaveDisplayImage(Image DisplayImage)
        {
            MemoryStream ImageReader = new MemoryStream();
            DisplayImage.Save(ImageReader, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ImageReader.ToArray();
        }

        /// <summary>
        /// Converts a Byte[] to a System.Drawing.Image.
        /// </summary>
        /// <param name="DisplayImageBytes">The Byte[] of an image.</param>
        /// <returns>The Image in the Byte[].</returns>
        public static Image LoadDisplayImage(byte[] DisplayImageBytes)
        {
            MemoryStream ImageReader = new MemoryStream(DisplayImageBytes);
            Image DisplayImage = Image.FromStream(ImageReader);
            return DisplayImage;
        }
    }
}
