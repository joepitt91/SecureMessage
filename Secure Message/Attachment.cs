using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Message
{
    class Attachment
    {
        internal string Filename;
        internal byte[] FileContents;
        internal byte[] DigitalSignature;

        public Attachment(string _Filename, byte[] _FileContents)
        {
            Filename = _Filename;
            FileContents = _FileContents;
            byte[] PrivateCrypt = Database.GetPrivateCrypt(1);
            byte[] PrivateCryptIV = Database.GetPrivateCryptIV(1);
            byte[] PrivateKeyBytes = Crypto.AESDecrypt(Program.CurrentAcount.DerivedKey, PrivateCryptIV, PrivateCrypt);
            DigitalSignature = Crypto.RSASign(FileContents, ASCIIEncoding.ASCII.GetString(PrivateKeyBytes));
        }
    }
}
