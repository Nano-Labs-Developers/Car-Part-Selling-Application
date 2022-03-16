using Client.Class;
using MySql.Data.MySqlClient;
using System.Data;

// Error Code: D1x
namespace Admin.Class
{
    internal class CarManagement
    {
        public DataTable LookupCars()
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

        internal void AddCar(string name, string model, string year, string img, double price, string details)
        {
            var dbCon = Database.Instance();
            const string query = "INSERT INTO `car`(`car_Name`, `car_Model`, `car_Year`, `car_Image`, `car_Price`, `car_Details`) VALUES (@Name, @Model, @Year, @Image, @Price, @Details)";

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@Model", MySqlDbType.VarChar).Value = model;
                        cmd.Parameters.Add("@Year", MySqlDbType.VarChar).Value = year;
                        cmd.Parameters.Add("@Image", MySqlDbType.VarChar).Value = img;
                        cmd.Parameters.Add("@Price", MySqlDbType.Double).Value = price;
                        cmd.Parameters.Add("@Details", MySqlDbType.LongText).Value = details;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Car part added sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D1x01", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        internal void UpdateCar(int id, string name, string model, string year, string img, double price, string details)
        {
            var dbCon = Database.Instance();
            const string query = "UPDATE `car` SET `car_Name` = @Name, `car_Model` = @Model, `car_Year` = @Year, `car_Image` = @Image, `car_Price` = @Price, `car_Details` = @Details WHERE `car_ID`= @ID";

            try
            {
                if (dbCon.IsConnect())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection))
                    {
                        cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
                        cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@Model", MySqlDbType.VarChar).Value = model;
                        cmd.Parameters.Add("@Year", MySqlDbType.VarChar).Value = year;
                        cmd.Parameters.Add("@Image", MySqlDbType.VarChar).Value = img;
                        cmd.Parameters.Add("@Price", MySqlDbType.Double).Value = price;
                        cmd.Parameters.Add("@Details", MySqlDbType.LongText).Value = details;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Car part details update sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D1x02", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        internal void DeleteCar(int id)
        {
            var dbCon = Database.Instance();
            const string query = "DELETE FROM `car` WHERE `car_ID` = @ID";

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

                MessageBox.Show("Car part removed sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D1x03", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
