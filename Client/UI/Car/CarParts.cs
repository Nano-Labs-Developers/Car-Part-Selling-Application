using Client.Class;
using System.Data;

namespace Client.UI.Car
{
    public partial class CarParts : UserControl
    {
        DataTable carPatsData = new DataTable();

        public CarParts()
        {
            InitializeComponent();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            LoadData();
            ComboBoxHandler();
        }

        private void LoadData()
        {
            CarPartsDataHandler cpd = new CarPartsDataHandler();
            carPatsData = cpd.LoadCarData();
            dataGridView.DataSource = carPatsData;
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID_lbl.Text = dataGridView.CurrentRow.Cells[0].Value.ToString(); // id
            CarName_lbl.Text = dataGridView.CurrentRow.Cells[1].Value.ToString(); // name
            ModelName_lbl.Text = dataGridView.CurrentRow.Cells[2].Value.ToString(); // model
            Year_lbl.Text = dataGridView.CurrentRow.Cells[3].Value.ToString(); // year
            Car_picBox.Load(dataGridView.CurrentRow.Cells[4].Value.ToString()); // image
            Price_lbl.Text = "$ " + dataGridView.CurrentRow.Cells[5].Value.ToString(); // price
            Details_txt.Text = dataGridView.CurrentRow.Cells[6].Value.ToString(); // details
        }

        internal void ComboBoxHandler()
        {
            foreach (DataRow row in carPatsData.Rows)
            {
                string carname = string.Format("{0}", row.ItemArray[1]);
                string carmodel = string.Format("{0}", row.ItemArray[2]);

                CarName_CBox.Items.Add(carname);
                CarModel_CBox.Items.Add(carmodel);
            }
        }
    }
}
