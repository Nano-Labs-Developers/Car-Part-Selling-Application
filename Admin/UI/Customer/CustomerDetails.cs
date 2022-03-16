using Admin.Class.FuncDB;

namespace Admin.UI.Customer
{
    public partial class CustomerDetails : UserControl
    {
        static int _id = 0;
        static string _name = String.Empty;
        static string _mobile = String.Empty;
        static string _home = String.Empty;
        static string _address = String.Empty;
        static string _datetime = String.Empty;

        public CustomerDetails()
        {
            InitializeComponent();
        }
          
        private void LoadData(int id, string name, string mobile, string home, string address, string datetime)
        {
            _id = id;
            _name = name;
            _mobile = mobile;
            _home = home;
            _address = address;
            _datetime = datetime;

            CreatedDateTime_lbl.Text = _datetime;
            CustomerName_lbl.Text = _name;
            Mobile_txt.Text = _mobile;
            Home_txt.Text = _home;
            Address_txt.Text = _address;
        }

        private void Timeout_btn_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement();
            cm.TimeOutCustomer(_id);
        }

        private void Ban_btn_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement();
            cm.BanCustomer(_id);
        }

        public delegate void OnClickUpdateCustomer(int id, string name, string mobile, string home, string address, string datetime);
        public event OnClickUpdateCustomer ClickUpdateCustomer;

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (ClickUpdateCustomer != null)
            {
                ClickUpdateCustomer(_id, _name, _mobile, _home, _address, _datetime);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement();
            cm.DeleteCustomer(_id);
        }
    }
}
