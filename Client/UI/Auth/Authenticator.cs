using Client.Class;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

// Error Code: 02x
namespace Client.UI.Auth
{
    internal class Authenticator
    {
        private static readonly int _wait = 46479794; // User
        private static readonly int _user = 95489357; // User
        private static readonly int _admin = 35849258; // Admin
        private static readonly int _time = 54654665; // Time Out
        private static readonly int _banned = 86287569; // Banned

        private static string UserID = String.Empty;
        internal static string AUTH = String.Empty;
        internal static string User_Name = String.Empty;
        internal static byte[] User_PERMISSIONS;

        /// <summary>
        /// 1 - Key for the crypto provider
        /// 2 - Initialization vector for the crypto provider
        /// </summary>
        private static readonly byte[] _key = { 0xA1, 0xF1, 0xA6, 0xBB, 0xA2, 0x5A, 0x37, 0x6F, 0x81, 0x2E, 0x17, 0x41, 0x72, 0x2C, 0x43, 0x27 };
        private static readonly byte[] _initVector = { 0xE1, 0xF1, 0xA6, 0xBB, 0xA9, 0x5B, 0x31, 0x2F, 0x81, 0x2E, 0x17, 0x4C, 0xA2, 0x81, 0x53, 0x61 };


        internal void SignIn(string username, string password)
        {
            try
            {
                using (DataTable dt = LookupUser(username))
                {
                    User_Name = dt.Rows[0]["user_Name"].ToString();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid username or password.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string appPassword = Encrypt(password);
                        UserID = Convert.ToString(dt.Rows[0]["user_ID"]);
                        string dbPassword = Convert.ToString(dt.Rows[0]["user_Password"]);
                        string dbRole = Convert.ToString(dt.Rows[0]["user_Role"]);

                        if (string.Compare(dbPassword, appPassword) == 0)
                        {
                            if (dbRole == _wait.ToString() | dbRole == _banned.ToString() | dbRole == _time.ToString()) // non approve | banned
                            {
                                if (dbRole == _wait.ToString()) // non approve
                                {
                                    MessageBox.Show("Wait for approve your account.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (dbRole == _time.ToString()) // timeout
                                {
                                    MessageBox.Show("User account has been timeouted.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (dbRole == _user.ToString()) // Invalid uname or pass
                                {
                                    MessageBox.Show("Invalid username or password.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else // banned
                                {
                                    MessageBox.Show("User account has been suspended.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else if (dbRole == _user.ToString() | dbRole == _admin.ToString())
                            {
                                if (dbRole == _user.ToString()) // front officer
                                {
                                    byte[] Value = Encoding.UTF8.GetBytes(dbRole);
                                    User_PERMISSIONS = Value;
                                }
                                else if (dbRole == _admin.ToString()) // Doctor
                                {
                                    byte[] Value = Encoding.UTF8.GetBytes(dbRole);
                                    User_PERMISSIONS = Value;
                                }

                                //Logged in
                                GenerateAUTH();
                                ClearTextbox();
                                UpdateAUTH();

                                // Launch app
                                ACBCar.AuthUI auth = new ACBCar.AuthUI();
                                Dashboard dashboard = new Dashboard();
                                auth.Close();
                                dashboard.Show();
                            }
                            else // not difined roles
                            {
                                MessageBox.Show("Invalid username or password", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User validation failed" + "\nError Code: 02x01", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        internal void Register(string name, string username, string email, string password)
        {
            var dbCon = Database.Instance();
            string encPassword = Encrypt(password);
            const string query = "INSERT INTO `user`(`user_Name`, `user_UserName`, `user_Email`, `user_Password`, `user_Role`) VALUES (@Name, @UserName, @Email, @Password, @Role)";

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = username;
                        cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = encPassword;
                        cmd.Parameters.Add("@Role", MySqlDbType.Int32).Value = _user;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registation sucessfull. Wait for approvel.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: 02x02", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        internal static DataTable LookupUser(string Username)
        {
            var dbCon = Database.Instance();
            const string query = "SELECT user_ID, user_Name, user_Password, user_Role FROM user WHERE user_Username = @UserName";
            DataTable result = new DataTable();

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = Username;

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            result.Load(dr);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong." + "\nError Code: 02x03", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            return result;
        }

        internal static string Encrypt(string Password)
        {
            if (string.IsNullOrEmpty(Password))
            {
                return string.Empty;
            }

            byte[] Value = Encoding.UTF8.GetBytes(Password);
            SymmetricAlgorithm mCSP = new RijndaelManaged();
            mCSP.Key = _key;
            mCSP.IV = _initVector;

            using (ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                    {
                        cs.Write(Value, 0, Value.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        private void UpdateAUTH()
        {
            var dbCon = Database.Instance();
            const string query = "UPDATE `user` SET `user_AUTH` = @AUTH WHERE user_ID = @userID";

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@userID", MySqlDbType.VarChar).Value = UserID;
                        cmd.Parameters.Add("@AUTH", MySqlDbType.VarChar).Value = AUTH;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong." + "\nError Code: 02x04", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void GenerateAUTH()
        {
            try
            {
                var authBuilder = new StringBuilder();
                authBuilder.Append(RandomString(4, true));
                authBuilder.Append(RandomNumber(1000, 9999));
                authBuilder.Append(RandomString(2));

                AUTH = authBuilder.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Authentication request failed" + "\nError Code: 02x05", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextbox()
        {
            Register register = new Register();

            try
            {
                register.Name_txt.Clear();
                register.Username_txt.Clear();
                register.Email_txt.Clear();
                register.Password_txt.Clear();
                register.ConPassword_txt.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong." + "\nError Code: 02x06", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Instantiate random number generator.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        // Generates a random string with a given size.    
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
    }
}
