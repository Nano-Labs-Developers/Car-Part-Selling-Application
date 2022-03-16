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
    public partial class AddParts : UserControl
    {
        public AddParts()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        private void Save_btn_Click(object sender, EventArgs e)
        {
            CarPartsManagement cp = new CarPartsManagement();
            cp.AddCarParts(Name_txt.Text, Model_txt.Text, Year_txt.Text, Image_txt.Text, Convert.ToDouble(Price_txt.Text), Details_txt.Text);
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
