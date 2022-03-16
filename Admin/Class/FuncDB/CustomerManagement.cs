using Client.Class;
using MySql.Data.MySqlClient;
using System.Data;

namespace Admin.Class.FuncDB
{
    internal class CustomerManagement
    {
        public DataTable LookupCustomer()
        {
            var dbCon = Database.Instance();
            const string query = "SELECT `user_ID`, `user_Name`, `user_Username`, `user_Email`, `user_Role` FROM `user` WHERE `user_Role` = @Role";
            DataTable result = new DataTable();

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@Role", MySqlDbType.Int32).Value = 95489357;

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            result.Load(dr);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong loading data.\nError Code: 02x03", this.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            return result;
        }

        internal void UpdateCustomer()
        {
            var dbCon = Database.Instance();
            const string query = "";

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        //cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer details update sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D1x02", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        internal void DeleteCustomer(int id)
        {
            var dbCon = Database.Instance();
            const string query = "";

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer removed sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D1x03", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        internal void TimeOutCustomer(int id)
        {
            var dbCon = Database.Instance();
            const string query = "";

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        //cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer timeout sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D1x02", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        internal void BanCustomer(int id)
        {
            var dbCon = Database.Instance();
            const string query = "";

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        //cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer banned.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D1x02", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
