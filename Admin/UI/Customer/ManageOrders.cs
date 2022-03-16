using Admin.Class.FuncDB;

namespace Admin.Customer
{
    public partial class ManageOrders : UserControl
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            //LoadCarDetails();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            OrdersManagement om = new OrdersManagement();
            dataGridView.DataSource = om.LoadDataGrid();
            dataGridView.Refresh();
        }

        internal void LoadCarDetails()
        {
            OrdersManagement om = new OrdersManagement();
            dataGridView.DataSource = om.LoadDataGrid();
            dataGridView.Refresh();
        }

        public delegate void OnClickDataEvent(int id);
        public event OnClickDataEvent ClickDataTransfer;

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridView.CurrentRow.Cells[0].Value.ToString(); // order id

            if (ClickDataTransfer != null)
            {
                ClickDataTransfer(Convert.ToInt32(id));
            }
        }
    }
}
