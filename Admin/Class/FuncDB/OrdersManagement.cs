using Client.Class;
using MySql.Data.MySqlClient;
using System.Data;

namespace Admin.Class.FuncDB
{
    internal class OrdersManagement
    {
        internal DataTable LookupOrders()
        {
            var dbCon = Database.Instance();
            const string query = "SELECT * FROM ((`orders` INNER JOIN customers ON orders.order_UserID = customers.customer_UID) INNER JOIN `user` ON orders.order_UserID = user.user_ID)";
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

        internal DataTable LoadDataGrid()
        {
            DataTable orders = LookupOrders();

            string[] selectedColumns = new[] { "order_ID", "customer_ID", "order_CarID", "order_PartID", "customer_Mobile", "order_Note" };
            DataTable dt = new DataView(orders).ToTable(false, selectedColumns);

            return dt;
        }

        // This is for more data
        internal DataTable LookupOrdersDetails(int id)
        {
            var dbCon = Database.Instance();
            const string query = "SELECT * FROM ((`orders` INNER JOIN customers ON orders.order_UserID = customers.customer_UID) INNER JOIN `user` ON orders.order_UserID = user.user_ID) WHERE orders.order_ID = @ID";
            DataTable result = new DataTable();

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

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

        internal DataTable LookupCarID(int id)
        {
            var dbCon = Database.Instance();
            const string query = "SELECT * FROM `car` WHERE car_ID = @ID";
            DataTable result = new DataTable();

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

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

        internal DataTable LookupCarPartsID(int id)
        {
            var dbCon = Database.Instance();
            const string query = "SELECT * FROM `parts` WHERE part_ID = @ID";
            DataTable result = new DataTable();

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

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

        internal void UpdateOrder(int id, int status)
        {
            var dbCon = Database.Instance();
            const string query = "UPDATE `orders` SET `order_Status` = @Status WHERE `order_ID` = @ID";

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
                        cmd.Parameters.Add("@Status", MySqlDbType.Int32).Value = status;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order status update sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D1x02", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
