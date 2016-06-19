using System.Security.Cryptography;

namespace Secure_Message
{
    /// <summary>
    /// Methods related to key management.
    /// </summary>
    public class Keys
    {
        /// <summary>
        /// Generates a 256-bit Salt for Key Derivation.
        /// </summary>
        /// <returns>The 256-bit salt value.</returns>
        static public byte[] NewSalt()
        {
            RandomNumberGenerator Gen = RandomNumberGenerator.Create();
            byte[] Salt = new byte[32];
            Gen.GetBytes(Salt);
            return Salt;
        }

        /// <summary>
        /// Uses PBKDF2 to derive a key from a given password and salt, using 10,000 iterations.
        /// </summary>
        /// <param name="Password">The User Defined Password.</param>
        /// <param name="Salt">The per user system generated salt.</param>
        /// <returns>A 256-bit Key, derived from the Password and Salt.</returns>
        static public byte[] DeriveKey(string Password, byte[] Salt)
        {
            Rfc2898DeriveBytes SafeKey = new Rfc2898DeriveBytes(Password, Salt, 500000);
            return SafeKey.GetBytes(32);
        }

        /// <summary>
        /// Generates a new 256-bit AES Key.
        /// </summary>
        /// <returns>The 256-bit AES Key.</returns>
        static public byte[] AESKey()
        {
            RandomNumberGenerator Gen = RandomNumberGenerator.Create();
            byte[] Key = new byte[32];
            Gen.GetBytes(Key);
            return Key;
        }

        /// <summary>
        /// Generates a new 128-bit Initialization Vector (IV).
        /// </summary>
        /// <returns>The Initialization Vector.</returns>
        static public byte[] AESIV()
        {
            RandomNumberGenerator Gen = RandomNumberGenerator.Create();
            byte[] IV = new byte[16];
            Gen.GetBytes(IV);
            return IV;
        }

        /// <summary>
        /// Generates a new 4096-bit RSA Key Pair.
        /// </summary>
        /// <returns>The RSA Key Pair.</returns>
        static public RSAParameters RSAKey()
        {
            RSACryptoServiceProvider RSAProv = new RSACryptoServiceProvider(4096);
            RSAParameters RSAKeyInfo = RSAProv.ExportParameters(true);
            return RSAKeyInfo;
        }
    }
}
