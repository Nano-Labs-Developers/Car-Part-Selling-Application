using Client.Class;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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

        private void Login_Load(object sender, EventArgs e)
        {
            // UI
            Username_txt.AutoSize = false;
            Password_txt.AutoSize = false;
            Username_txt.Size = new System.Drawing.Size(287, 35);
            Password_txt.Size = new System.Drawing.Size(287, 35);
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Validation();

            try
            {
                using (DataTable dt = LookupUser(Username_txt.Text))
                {
                    User_Name = dt.Rows[0]["user_Name"].ToString();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid username or password.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string appPassword = Encrypt(Password_txt.Text);
                        UserID = Convert.ToString(dt.Rows[0]["user_ID"]);
                        string dbPassword = Convert.ToString(dt.Rows[0]["user_Password"]);
                        string dbRole = Convert.ToString(dt.Rows[0]["user_role"]);

                        if (string.Compare(dbPassword, appPassword) == 0)
                        {
                            if (dbRole == _banned.ToString() | dbRole == _time.ToString()) // non approve | banned
                            {
                                if (dbRole == _time.ToString()) // timeout
                                {
                                    MessageBox.Show("User account has been timeouted.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else // banned
                                {
                                    MessageBox.Show("User account has been suspended.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else if (dbRole == _admin.ToString())
                            {
                                //Logged in
                                GenerateAUTH();
                                UpdateAUTH();

                                // Launch app
                                Dashboard dashboard = new Dashboard();
                                this.Hide();
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
                MessageBox.Show("User validation failed" + "\nError Code: 01x01", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Something went wrong." + "\nError Code: 01x06", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool Validation()
        {
            if (String.IsNullOrEmpty(Username_txt.Text))
            {
                return false;
                throw new Exception("Username is empty");
            }
            else if (String.IsNullOrEmpty(Password_txt.Text))
            {
                return false;
                throw new Exception("Password is empty");
            }
            return true;
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
                MessageBox.Show("Something went wrong." + "\nError Code: 01x07", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void GenerateAUTH()
        {
            try
            {
                //RandomNumberGenerator generator = new RandomNumberGenerator();
                //AUTH = RandomNumberGenerator.RandomString(20, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Authentication request failed" + "\nError Code: 01x04", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}