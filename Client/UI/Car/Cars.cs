using Client.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UI.Car
{
    public partial class Cars : UserControl
    {
        DataTable carData = new DataTable();

        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            LoadData();
            ComboBoxHandler();
        }

        private void LoadData()
        {
            CarDataHandler cd = new CarDataHandler();
            carData = cd.LoadCarData();
            dataGridView.DataSource = carData;
        }

        // Load data to priview mode
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
            foreach (DataRow row in carData.Rows)
            {
                string carname = string.Format("{0}", row.ItemArray[1]);
                string carmodel = string.Format("{0}", row.ItemArray[2]);

                CarName_CBox.Items.Add(carname);
                CarModel_CBox.Items.Add(carmodel);
            }
        }

        internal void SearchHandler()
        {
            dataGridView.DataSource = carData;
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = null;
            string name = CarName_CBox.Text;
            string model = CarModel_CBox.Text;
            string year = Year_CBox.Text;

            if (!String.IsNullOrEmpty(name))
            {
                (dataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("car_Name LIKE '{0}%'", name);
            }
            
            if (!String.IsNullOrEmpty(model))
            {
                (dataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("car_Model LIKE '{0}%'", model);
            }
            
            if (!String.IsNullOrEmpty(year))
            {
                (dataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("car_Year LIKE '{0}%'", year);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
