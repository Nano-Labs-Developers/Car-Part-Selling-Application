using Admin.Class.FuncDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.UI.Car
{
    public partial class UpdateParts : UserControl
    {
        public UpdateParts()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        internal void LoadData(int id, string name, string model, string year, string image, string price, string details)
        {
            ID_lbl.Text = id.ToString();
            Name_txt.Text = name;
            Model_txt.Text = model;
            Year_txt.Text = year;
            Image_txt.Text = image;
            Price_txt.Text = price;
            Details_txt.Text = details;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            CarPartsManagement cpm = new CarPartsManagement();
            cpm.UpdateCarParts(Convert.ToInt32(ID_lbl.Text), Name_txt.Text, Model_txt.Text, Year_txt.Text, Image_txt.Text, Convert.ToDouble(Price_txt.Text), Details_txt.Text);
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Name_txt.Clear();
            Model_txt.Clear();
            Year_txt.Clear();
            Image_txt.Clear();
            Price_txt.Clear();
            Details_txt.Clear();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
