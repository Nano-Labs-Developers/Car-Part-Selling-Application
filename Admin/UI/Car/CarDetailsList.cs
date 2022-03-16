using Admin.Class;
using Client.Class;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;

namespace Admin.UI.Car
{
    public partial class CarDetailsList : UserControl
    {
        DataTable dt;

        public CarDetailsList()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        private void CarDetailsList_Load(object sender, EventArgs e)
        {
            //LoadCarDetails();
        }

        private void AddCar_btn_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            CarManagement cm = new CarManagement();
            dataGridView.DataSource = cm.LookupCars();
            dataGridView.Refresh();
        }

        internal void LoadCarDetails()
        {
            CarManagement cm = new CarManagement();
            dataGridView.DataSource = cm.LookupCars();
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
