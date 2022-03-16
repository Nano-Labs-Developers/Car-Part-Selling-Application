using Admin.Class;

namespace Admin.Car
{
    public partial class CarDetails : UserControl
    {
        static int _id = 0;
        static string _name = String.Empty;
        static string _model = String.Empty;
        static string _year = String.Empty;
        static string _image = String.Empty;
        static string _price = String.Empty;
        static string _details = String.Empty;

        public CarDetails()
        {
            InitializeComponent();
        }

        private void CarDetails_Load(object sender, EventArgs e)
        {

        }

        internal void LoadData(int id, string name, string model, string year, string image, string price, string details)
        {
            _id = id;
            _name = name;
            _model = model;
            _year = year;
            _image = image;
            _price = price;
            _details = details;

            ID_lbl.Text = id.ToString();
            CarName_lbl.Text = name;
            ModelName_lbl.Text = model;
            Year_lbl.Text = year;
            if (!String.IsNullOrEmpty(image))
            {
                Car_picbox.Load(image);
            }
            Price_lbl.Text = "$ " + price;
            Details_txt.Text = details;
        }

        internal delegate void OnClickUpdate(int id, string name, string model, string year, string image, string price, string details);
        internal event OnClickUpdate ClickUpdateButton;

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (ClickUpdateButton != null)
            {
                ClickUpdateButton(_id, _name, _model, _year, _image, _price, _details);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are sure you want delete this?", "Delete a car", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CarManagement carManagement = new CarManagement();
                carManagement.DeleteCar(_id);

                _id = 0;
                _name = String.Empty;
                _model = String.Empty;
                _year = String.Empty;
                _image = String.Empty;
                _price = String.Empty;
                _details = String.Empty;

                if (ClickGoBackButton != null)
                {
                    ClickGoBackButton();
                }
            }
        }

        internal delegate void OnClickGoBack();
        internal event OnClickGoBack ClickGoBackButton;

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            if (ClickGoBackButton != null)
            {
                ClickGoBackButton();
            }
        }
    }
}
