using MySql.Data.MySqlClient;
using System.Data;

namespace Client.Class
{
    internal class CarDataHandler
    {
        internal DataTable LoadCarData()
        {
            var dbCon = Database.Instance();
            const string query = "SELECT * FROM `car`";
            DataTable result = new DataTable();

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
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

        internal void SearchHandler()
        {

        }
    }
}
