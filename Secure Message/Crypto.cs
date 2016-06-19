using System.Security.Cryptography;

namespace Secure_Message
{
    /// <summary>
    /// Methods related to Cryptographic functions.
    /// </summary>
    public class Crypto
    {
        /// <summary>
        /// Encrypts data using 256-bit AES.
        /// </summary>
        /// <param name="Key">The 256-bit AES Key.</param>
        /// <param name="IV">The Initialization Vector.</param>
        /// <param name="PlainText">The Plain Text to be encrypted.</param>
        /// <returns>The encrypted Cipher Text.</returns>
        static public byte[] AESEncrypt(byte[] Key, byte[] IV, byte[] PlainText)
        {
            //Setup Engine
            AesCryptoServiceProvider AESProv = new AesCryptoServiceProvider();
            AESProv.KeySize = 256;
            AESProv.Mode = CipherMode.CBC;
            AESProv.Padding = PaddingMode.PKCS7;
            AESProv.Key = Key;
            AESProv.IV = IV;
            ICryptoTransform AESTrans = AESProv.CreateEncryptor();
            //Encrypt PlainText
            byte[] CipherText = AESTrans.TransformFinalBlock(PlainText, 0, PlainText.Length);
            //Return CipherText
            return CipherText;
        }

        /// <summary>
        /// Decrypts Cipher Text from 256-bit AES.
        /// </summary>
        /// <param name="Key">The 256-bit AES Key.</param>
        /// <param name="IV">The Initialization Vector.</param>
        /// <param name="CipherText">The encrypted Cipher Text.</param>
        /// <returns>The decrypted Plain Text.</returns>
        static public byte[] AESDecrypt(byte[] Key, byte[] IV, byte[] CipherText)
        {
            //Setup Engine
            AesCryptoServiceProvider AESProv = new AesCryptoServiceProvider();
            AESProv.KeySize = 256;
            AESProv.Mode = CipherMode.CBC;
            AESProv.Padding = PaddingMode.PKCS7;
            AESProv.Key = Key;
            AESProv.IV = IV;
            ICryptoTransform AESTrans = AESProv.CreateDecryptor();
            //Encrypt PlainText
            byte[] PlainText = AESTrans.TransformFinalBlock(CipherText, 0, CipherText.Length);
            //Return CipherText
            return PlainText;
        }

        /// <summary>
        /// Encrypts data using RSA.
        /// </summary>
        /// <param name="RSAParams">The Public Key.</param>
        /// <param name="PlainText">The Plain Text to be encrypted.</param>
        /// <returns>The Encrypted Cipher Text.</returns>
        static public byte[] RSAEncrypt(string RSAParams, byte[] PlainText)
        {
            RSACryptoServiceProvider RSAProv = new RSACryptoServiceProvider();
            RSAProv.FromXmlString(RSAParams);
            byte[] CipherText = RSAProv.Encrypt(PlainText, true);
            return CipherText;
        }

        /// <summary>
        /// Decrypts Cipher Text from RSA.
        /// </summary>
        /// <param name="RSAParams">The Private Key.</param>
        /// <param name="CipherText">The encrypted Cipher Text.</param>
        /// <returns>The decrypted Plain Text.</returns>
        static public byte[] RSADecrypt(string RSAParams, byte[] CipherText)
        {
            RSACryptoServiceProvider RSAProv = new RSACryptoServiceProvider();
            RSAProv.FromXmlString(RSAParams);
            byte[] PlainText = RSAProv.Decrypt(CipherText, true);
            return PlainText;
        }

        /// <summary>
        /// Uses RSA to Sign a Message.
        /// </summary>
        /// <param name="Message">The Message to be signed.</param>
        /// <param name="Key">The Key to use to sign the message.</param>
        /// <returns>The Signature of the Message using the Key.</returns>
        static public byte[] RSASign(byte[] Message, string Key)
        {
        start:
            SHA256CryptoServiceProvider SHA256Provider = new SHA256CryptoServiceProvider();
            RSACryptoServiceProvider RSAProvider = new RSACryptoServiceProvider();
            RSAProvider.FromXmlString(Key);
            byte[] Signature = RSAProvider.SignData(Message, SHA256Provider);
            if (RSAProvider.VerifyData(Message, SHA256Provider, Signature))
            {
                return Signature;
            }
            else
            {
                goto start;
            }
        }

        /// <summary>
        /// Verifies an RSA Signed peice of data
        /// </summary>
        /// <param name="Message">The original message.</param>
        /// <param name="Key">The key to be used to verify the message.</param>
        /// <param name="Signature">The provided signature.</param>
        /// <returns>If the Signature if valid or not.</returns>
        static public bool RSAVerify(byte[] Message, string Key, byte[] Signature)
        {
            SHA256CryptoServiceProvider SHA256Provider = new SHA256CryptoServiceProvider();
            RSACryptoServiceProvider RSAProvider = new RSACryptoServiceProvider();
            RSAProvider.FromXmlString(Key);
            if (RSAProvider.VerifyData(Message, SHA256Provider, Signature))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
