using Client.Class;
using MySql.Data.MySqlClient;

// Error Code: D2x
namespace Admin.Class.FuncDB
{
    internal class CarPartsManagement
    {
        internal void AddCarParts(string name, string model, string year, string img, double price, string details)
        {
            var dbCon = Database.Instance();
            const string query = "INSERT INTO `parts`(`part_Name`, `part_Model`, `part_Year`, `part_Image`, `part_Price`, `part_Details`) VALUES (@Name, @Model, @Year, @Image, @Price, @Details)";

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

                MessageBox.Show("Car added sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D2x01", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        internal void UpdateCarParts(int id, string name, string model, string year, string img, double price, string details)
        {
            var dbCon = Database.Instance();
            const string query = "UPDATE `car` SET `part_Name` = @Name, `part_Model` = @Model, `part_Year` = @Year, `part_Image` = @Image, `part_Price` = @Price, `part_Details` = @Details WHERE `part_ID`= @ID";

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

                MessageBox.Show("Car details update sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D2x02", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        internal void DeleteCarParts(int id)
        {
            var dbCon = Database.Instance();
            const string query = "DELETE FROM `car` WHERE `part_ID` = @ID";

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

                MessageBox.Show("Car removed sucessfull.", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: D2x03", "ABC Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
