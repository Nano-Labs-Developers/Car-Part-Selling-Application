using Client.Class;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;

namespace Admin.UI.Car
{
    public partial class CarPartDetailsList : UserControl
    {
        public CarPartDetailsList()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        private void CarPartDetailsList_Load(object sender, EventArgs e)
        {
            //LoadCarPartsDetails();
        }

        private void AddCarPart_btn_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = LookupCarParts();
            dataGridView.Refresh();
        }

        internal void LoadCarPartsDetails()
        {
            dataGridView.DataSource = LookupCarParts();
            dataGridView.Refresh();
        }

        public DataTable LookupCarParts()
        {
            var dbCon = Database.Instance();
            const string query = "SELECT * FROM `parts`";
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

        public delegate void OnClickDataEvent(int id, string name, string model, string year, string image, string price, string details);
        public event OnClickDataEvent ClickDataTransfer;

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridView.CurrentRow.Cells[0].Value.ToString(); // id
            string name = dataGridView.CurrentRow.Cells[1].Value.ToString(); // name
            string model = dataGridView.CurrentRow.Cells[2].Value.ToString(); // model
            string year = dataGridView.CurrentRow.Cells[3].Value.ToString(); // year
            string image = dataGridView.CurrentRow.Cells[4].Value.ToString(); // image
            string price = dataGridView.CurrentRow.Cells[5].Value.ToString(); // price
            string details = dataGridView.CurrentRow.Cells[6].Value.ToString(); // details

            if (ClickDataTransfer != null)
            {
                ClickDataTransfer(Convert.ToInt32(id), name, model, year, image, price, details);
            }
        }
    }
}
