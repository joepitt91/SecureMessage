using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Secure_Message;
using System.Collections;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class CryptoTests
    {
        [TestMethod]
        public void TimeToDerive()
        {
            Stopwatch sw = new Stopwatch();
            string Passowrd = "SuperSecurePassword2015";
            sw.Start();
            byte[] Salt = Keys.NewSalt();
            sw.Stop();
            Console.WriteLine("Salt Generation: " + sw.Elapsed + "ms");
            sw.Reset();
            sw.Start();
            byte[] Key = Keys.DeriveKey(Passowrd, Salt);
            sw.Stop();
            Console.WriteLine("Key Derivation: " + sw.Elapsed + "ms");
            Console.WriteLine();
        }

        /// <summary>
        /// Generates 100,000 AES Keys and checks for duplicates
        /// </summary>
        [TestMethod]
        public void AESKeyUniqueness()
        {
            ArrayList Results = new ArrayList(100000);
            int i = 0;
            int fault = 0;
            while (i < 100000)
            {
                byte[] key = Keys.AESKey();
                if (Results.Contains(key))
                {
                    fault++;
                }
                else
                {
                    Results.Add(key);
                }
                i++;
            }

            Console.WriteLine(i + " Keys generated with " + fault + " faults.");
            if (fault != 0)
            {
                throw new Exception(i + " Keys generated with " + fault + " faults.");
            }
        }

        [TestMethod]
        public void AESIVUniquness()
        {
            ArrayList Results = new ArrayList(100000);
            int i = 0;
            int fault = 0;
            while (i < 100000)
            {
                byte[] key = Keys.AESIV();
                if (Results.Contains(key))
                {
                    fault++;
                }
                else
                {
                    Results.Add(key);
                }
                i++;
            }

            Console.WriteLine(i + " IVs generated with " + fault + " faults.");
            if (fault != 0)
            {
                throw new Exception(i + " IVs generated with " + fault + " faults.");
            }
        }

        /// <summary>
        /// Generates 100 RSA Key Pairs and checks for duplicates
        /// </summary>
        [TestMethod]
        public void RSAKeyUniquness()
        {
            ArrayList Results = new ArrayList(100);
            int i = 0;
            int fault = 0;
            while (i < 100)
            {
                System.Security.Cryptography.RSAParameters key = Keys.RSAKey();
                if (Results.Contains(key))
                {
                    fault++;
                }
                else
                {
                    Results.Add(key);
                }
                i++;
            }

            Console.WriteLine(i + " Key pairs generated with " + fault + " faults.");
            if (fault != 0)
            {
                throw new Exception(i + " Key pairs generated with " + fault + " faults.");
            }
        }
    }
}
