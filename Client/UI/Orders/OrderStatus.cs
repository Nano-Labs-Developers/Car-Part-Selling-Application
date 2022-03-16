using Client.Class;
using System.Data;

namespace Client.UI.Orders
{
    public partial class OrderStatus : UserControl
    {
        DataTable orderData = new DataTable();

        public OrderStatus()
        {
            InitializeComponent();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            OrderDataHandler cd = new OrderDataHandler();
            orderData = cd.LoadCarData();
            dataGridView.DataSource = orderData;
        }
    }
}
