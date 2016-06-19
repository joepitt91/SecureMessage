using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System;

namespace Secure_Message
{
    class Database
    {
        // Account Table.

        /// <summary>
        /// Creates a new database for the supplied Account.
        /// </summary>
        /// <param name="NewAccount">A completed account which needs a database.</param>
        /// <returns>If the Database was made successfuly.</returns>
        public static bool CreateAccount(Account NewAccount)
        {
            string UserFile = Application.UserAppDataPath + "\\" + NewAccount.Username + ".sm";
            SQLiteConnection connect = new SQLiteConnection("Data Source=" + UserFile + ";Version=3;");
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(connect);
            command = new SQLiteCommand(Properties.Resources.SecureMessage, connect);
            command.ExecuteNonQuery();

            // Add Account.
            command.CommandText = "INSERT INTO [Account] ([Username],[AccountID],[DisplayName],[DisplayImage],[Email],[Salt],[IV],[CheckValue]) " +
                "VALUES (@Username,@AccountID,@DisplayName,@DisplayImage,@Email,@Salt,@IV,@CheckValue);";
            command.Parameters.Add(new SQLiteParameter("@Username", NewAccount.Username));
            command.Parameters.Add(new SQLiteParameter("@AccountID", NewAccount.AccountID));
            command.Parameters.Add(new SQLiteParameter("@DisplayName", NewAccount.DisplayName));
            command.Parameters.Add(new SQLiteParameter("@DisplayImage", Account.SaveDisplayImage(NewAccount.DisplayImage)));
            command.Parameters.Add(new SQLiteParameter("@Email", NewAccount.Email));
            command.Parameters.Add(new SQLiteParameter("@Salt", NewAccount.Salt));
            command.Parameters.Add(new SQLiteParameter("@IV", NewAccount.IV));
            command.Parameters.Add(new SQLiteParameter("@CheckValue", NewAccount.CheckValue));
            command.ExecuteNonQuery();
            connect.Dispose();
            return true;
        }

        /// <summary>
        /// Generates a list of all available accounts for the logon screen.
        /// </summary>
        /// <returns>A list of accounts in the format "Display Name (Username)"</returns>
        public static List<string> GetAccountNames()
        {
            List<string> Users = new List<string>();
            foreach (string Account in Directory.GetFiles(Application.UserAppDataPath, "*.sm"))
            {
                SQLiteConnection connect = new SQLiteConnection("Data Source=" + Account + ";Version=3;");
                connect.Open();
                SQLiteCommand command = new SQLiteCommand(connect);
                command.CommandText = "SELECT [DisplayName],[Username] FROM [Account]";
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Users.Add(reader.GetString(0) + " (" + reader.GetString(1) + ")");
                    }
                    reader.Close();
                    connect.Dispose();
                }
                catch { }
            }
            return Users;
        }

        /// <summary>
        /// Returns the Username of the specified database.
        /// </summary>
        /// <param name="UseFile">The database file to be inspected.</param>
        /// <returns>The Username, or "" if not a Secure Message Database.</returns>
        public static string GetUsername(string UseFile)
        {
            string Username = "";
            try
            {
                SQLiteConnection connect = new SQLiteConnection("Data Source=" + UseFile + ";Version=3;");
                connect.Open();
                SQLiteCommand command = new SQLiteCommand(connect);
                command.CommandText = "SELECT [Username] FROM [Account]";
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Username = reader.GetString(0);
                }
                reader.Close();
                connect.Dispose();
            }
            catch
            {
                MessageBox.Show("The file you tried to import was not recognised as Secure Message Database file, please check and try again.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Username;
        }

        /// <summary>
        /// Returns a byte[] of the Display Image.
        /// </summary>
        /// <param name="Username">The Username of the account to retrive.</param>
        /// <returns>A byte[] of the iamge.</returns>
        public static byte[] GetDisplayImageBytes(string Username)
        {
            byte[] DisplayImageBytes = new byte[0];
            string UserFile = Application.UserAppDataPath + "\\" + Username + ".sm";
            SQLiteConnection connect = new SQLiteConnection("Data Source=" + UserFile + ";Version=3;");
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(connect);
            command.CommandText = "SELECT length([DisplayImage]),[DisplayImage] FROM [Account]";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DisplayImageBytes = new byte[reader.GetInt32(0)];
                reader.GetBytes(1, 0, DisplayImageBytes, 0, reader.GetInt32(0));
            }
            reader.Close();
            connect.Dispose();
            return DisplayImageBytes;
        }

        /// <summary>
        /// Gets a completed Account.
        /// </summary>
        /// <param name="Username">The username of the account to retreive.</param>
        /// <returns>The completed Account.</returns>
        public static Account GetAccount(string Username)
        {
            Account ThisAccount = new Account();
            string AccountFile = Application.UserAppDataPath + "\\" + Username + ".sm";
            SQLiteConnection connect = new SQLiteConnection("Data Source=" + AccountFile + ";Version=3;");
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(connect);
            command.CommandText = "SELECT [AccountID],[DisplayName],[Email],length([DisplayImage]),[DisplayImage],[IV] FROM [Account]";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ThisAccount.Username = Username;
                ThisAccount.AccountID = reader.GetString(0);
                ThisAccount.DisplayName = reader.GetString(1);
                ThisAccount.Email = reader.GetString(2);
                byte[] DisplayImageBytes = new byte[reader.GetInt32(3)];
                reader.GetBytes(4, 0, DisplayImageBytes, 0, reader.GetInt32(3));
                ThisAccount.DisplayImage = Account.LoadDisplayImage(DisplayImageBytes);
                byte[] IV = new byte[16];
                reader.GetBytes(5, 0, IV, 0, 16);
                ThisAccount.IV = IV;
            }
            reader.Close();

            command.CommandText = "SELECT [KeyType],[PublicKey],[IV] FROM [KEY] WHERE [Revoked] IS NULL";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ThisAccount.KeyType = reader.GetString(0);
                ThisAccount.PublicKey = reader.GetString(1);
                byte[] IV = new byte[16];
                reader.GetBytes(2, 0, IV, 0, 16);
                ThisAccount.IV = IV;
            }
            reader.Close();
            connect.Dispose();
            return ThisAccount;
        }

        /// <summary>
        /// Gets the Derived Key Salt for logging in.
        /// </summary>
        /// <param name="Username">The Account username for which it get the salt.</param>
        /// <returns>The Salt value.</returns>
        public static byte[] GetSalt(string Username)
        {
            byte[] Salt = new byte[32];
            string UserFile = Application.UserAppDataPath + "\\" + Username + ".sm";
            SQLiteConnection connect = new SQLiteConnection("Data Source=" + UserFile + ";Version=3;");
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(connect);
            // Get Salt.
            command.CommandText = "SELECT [Salt] FROM [Account]";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                reader.GetBytes(0, 0, Salt, 0, 32);
            }
            reader.Close();
            connect.Dispose();
            return Salt;
        }

        /// <summary>
        /// Decrypts the CheckValue to confirm the Derived Key is correct.
        /// </summary>
        /// <param name="Username">The Username of the account being logged into.</param>
        /// <param name="DerivedKey">The Key Derived from the provided password and stored salt.</param>
        /// <returns>If the Derived Key is correct.</returns>
        public static bool VerifyAccount(string Username, byte[] DerivedKey)
        {
            byte[] IV = new byte[16];
            byte[] CheckValue = new byte[0];
            byte[] Salt = new byte[32];
            string UserFile = Application.UserAppDataPath + "\\" + Username + ".sm";
            SQLiteConnection connect = new SQLiteConnection("Data Source=" + UserFile + ";Version=3;");
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(connect);
            // Get IV and Check Value.
            command.CommandText = "SELECT [IV],length([CheckValue]),[CheckValue],[Salt] FROM [Account]";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                reader.GetBytes(0, 0, IV, 0, 16);
                CheckValue = new byte[reader.GetInt32(1)];
                reader.GetBytes(2, 0, CheckValue, 0, reader.GetInt32(1));
                reader.GetBytes(3, 0, Salt, 0, 32);
            }
            reader.Close();
            connect.Dispose();
            string Decrypted = "";
            try
            {
                Decrypted = ASCIIEncoding.ASCII.GetString(Crypto.AESDecrypt(DerivedKey, IV, CheckValue));
            }
            catch
            {
                return false;
            }
            if (Decrypted == "SecureMessage_2ceb8a18-5da6-4977-a3b2-ee387782af68" + Salt)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Keys Table.
        /// <summary>
        /// Saves the provided key pair to the Key table.
        /// </summary>
        /// <param name="KeyType">The Algorithm the key is for, e.g. RSA.</param>
        /// <param name="PublicKey">The unencrypted Public Key.</param>
        /// <param name="IV">The IV used for encrypting the Private Key.</param>
        /// <param name="PrivateCrypt">The Encrypted Private Key.</param>
        public static void SaveKey(string Username, string KeyType, string PublicKey, byte[] IV, byte[] PrivateCrypt)
        {
            string UserFile = Application.UserAppDataPath + "\\" + Username + ".sm";
            SQLiteConnection connect = new SQLiteConnection("Data Source=" + UserFile + ";Version=3;");
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(connect);
            // Add Key.
            command.CommandText = "INSERT INTO [Key] ([KeyType],[PublicKey],[IV],[PrivateCrypt],[Created]) " +
                "VALUES (@KeyType,@PublicKey,@IV,@PrivateCrypt,@Created);";
            command.Parameters.Add(new SQLiteParameter("@KeyType", KeyType));
            command.Parameters.Add(new SQLiteParameter("@PublicKey", PublicKey));
            command.Parameters.Add(new SQLiteParameter("@IV", IV));
            command.Parameters.Add(new SQLiteParameter("@PrivateCrypt", PrivateCrypt));
            command.Parameters.Add(new SQLiteParameter("@Created", DateTime.UtcNow.ToString("MM/dd/yyyy H:mm:ss")));
            command.ExecuteNonQuery();
        }

        public static byte[] GetPrivateCrypt(int KeyID)
        {
            byte[] PrivateCrypt = new byte[0];
            string UserFile = Application.UserAppDataPath + "\\" + Program.CurrentAcount.Username + ".sm";
            SQLiteConnection connect = new SQLiteConnection("Data Source=" + UserFile + ";Version=3;");
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(connect);
            command.CommandText = "SELECT length([PrivateCrypt]),[PrivateCrypt] FROM [KEY] WHERE [KeyID] = @KeyID";
            command.Parameters.Add(new SQLiteParameter("@KeyID", KeyID));
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PrivateCrypt = new byte[reader.GetInt32(0)];
                reader.GetBytes(1, 0, PrivateCrypt, 0, reader.GetInt32(0));
            }
            reader.Close();
            connect.Dispose();
            return PrivateCrypt;
        }

        public static byte[] GetPrivateCryptIV(int KeyID)
        {
            byte[] IV = new byte[0];
            string UserFile = Application.UserAppDataPath + "\\" + Program.CurrentAcount.Username + ".sm";
            SQLiteConnection connect = new SQLiteConnection("Data Source=" + UserFile + ";Version=3;");
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(connect);
            command.CommandText = "SELECT [IV] FROM [KEY] WHERE [KeyID] = @KeyID";
            command.Parameters.Add(new SQLiteParameter("@KeyID", KeyID));
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                IV = new byte[16];
                reader.GetBytes(0, 0, IV, 0, 16);
            }
            reader.Close();
            connect.Dispose();
            return IV;
        }

        // Inbox table.
        public static List<Message> GetInbox()
        {

            return new List<Message>();
        }
    }
}