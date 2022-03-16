using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Class
{
    internal class Database
    {
        private Database() { }

        private static readonly string Server = "localhost";
        private static readonly string DatabaseName = "abccar";
        private static readonly string UserName = "root";
        private static readonly string Password = "";
        private static readonly string Port = "80";
        private static readonly string connstring = string.Format("Server={0}; database={1}; UserID={2}; password={3};convert zero datetime=True;SSL Mode=None", Server, DatabaseName, UserName, Password);

        internal MySqlConnection Connection { get; private set; }

        private static Database _instance = null;

        internal static Database Instance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }

        private bool IsConnected()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(Server))
                {
                    return false;
                }
                if (String.IsNullOrEmpty(DatabaseName))
                {
                    return false;
                }
                if (String.IsNullOrEmpty(UserName))
                {
                    return false;
                }
                if (String.IsNullOrEmpty(Port))
                {
                    return false;
                }

                try
                {
                    Connection = new MySqlConnection(connstring);
                    if (Connection.State == System.Data.ConnectionState.Closed)
                    {
                        Connection.Open();
                    }
                }
                catch (Exception ex)
                {
                    // This for show user
                    MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: 0x1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.ToString());

                    return false;
                }
            }
            return true;
        }

        internal bool IsConnect()
        {
            if (IsConnected())
            {
                return true;
            }
            return false;
        }

        // Open db connection
        internal void Open()
        {
            try
            {
                if (Connection.State == System.Data.ConnectionState.Closed)
                {
                    Connection.Open();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: 0x2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Restart();
                Environment.Exit(1);

            }

        }

        // Close db connection
        internal void Close()
        {
            try
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("The sytem cannot find valied connection" + "\nError Code: 0x3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Restart();
                Environment.Exit(1);

            }

        }
    }
}
