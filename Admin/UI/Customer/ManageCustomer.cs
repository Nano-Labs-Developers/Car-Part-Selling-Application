using Admin.Class.FuncDB;
using Client.Class;
using MySql.Data.MySqlClient;
using System.Data;

namespace Admin.Customer
{
    public partial class ManageCustomer : UserControl
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            //LoadCustomerDetails();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement();
            dataGridView.DataSource = cm.LookupCustomer();
            dataGridView.Refresh();
        }

        internal void LoadCustomerDetails()
        {
            CustomerManagement cm = new CustomerManagement();
            dataGridView.DataSource = cm.LookupCustomer();
            dataGridView.Refresh();
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
