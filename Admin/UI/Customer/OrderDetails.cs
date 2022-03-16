using Admin.Class.FuncDB;
using System.Data;

namespace Admin.UI.Customer
{
    public partial class OrderDetails : UserControl
    {
        static int _id; // order id
        DataTable _orderDetails;

        public OrderDetails()
        {
            InitializeComponent();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {

        }

        internal void LoadData(int id)
        {
            _id = id; // order id
            OrdersManagement om = new OrdersManagement();
            _orderDetails = om.LookupOrdersDetails(_id);

            LoadDataToTextBox();
        }

        internal void LoadDataToTextBox()
        {
            OrdersManagement om = new OrdersManagement();

            Order_lbl.Text = "Customer Order - #" + _orderDetails.Rows[0]["order_ID"].ToString();
            CusName_txt.Text = _orderDetails.Rows[0]["user_Name"].ToString();
            CusAddress_txt.Text = _orderDetails.Rows[0]["customer_Address"].ToString();
            CusMobile_txt.Text = _orderDetails.Rows[0]["customer_Mobile"].ToString();
            CusHome_txt.Text = _orderDetails.Rows[0]["customer_Home"].ToString();

            bool isCar;
            int carid;
            int partid;
            if (_orderDetails.Rows[0]["order_CarID"] != null)
            {
                carid = Convert.ToInt32(_orderDetails.Rows[0]["order_CarID"]);
                isCar = true;

                DataTable _carItemDetails = om.LookupCarID(carid);

                ItemID_txt.Text = _carItemDetails.Rows[0]["car_ID"].ToString();
                ItemName_txt.Text = _carItemDetails.Rows[0]["car_Name"].ToString();
                ItemModel_txt.Text = _carItemDetails.Rows[0]["car_Model"].ToString();
                ItemYear_txt.Text = _carItemDetails.Rows[0]["car_Year"].ToString();
                ItemPrice_txt.Text = _carItemDetails.Rows[0]["car_Price"].ToString();
                ItemDetails_txt.Text = _carItemDetails.Rows[0]["car_Details"].ToString();
            }
            else if (_orderDetails.Rows[0]["order_PartID"] != null)
            {
                partid = Convert.ToInt32(_orderDetails.Rows[0]["order_PartID"]);
                isCar = false;

                DataTable _carPartsItemDetails = om.LookupCarPartsID(partid);

                ItemID_txt.Text = _carPartsItemDetails.Rows[0]["part_ID"].ToString();
                ItemName_txt.Text = _carPartsItemDetails.Rows[0]["part_Name"].ToString();
                ItemModel_txt.Text = _carPartsItemDetails.Rows[0]["part_Model"].ToString();
                ItemYear_txt.Text = _carPartsItemDetails.Rows[0]["part_Year"].ToString();
                ItemPrice_txt.Text = _carPartsItemDetails.Rows[0]["part_Price"].ToString();
                ItemDetails_txt.Text = _carPartsItemDetails.Rows[0]["part_Details"].ToString();
            }
        }

        /// <summary>
        /// finished - 4464897
        /// accepted - 8791616
        /// declined - 9512592
        /// none - 2964538
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Finished_btn_Click(object sender, EventArgs e)
        {
            OrdersManagement om = new OrdersManagement();
            om.UpdateOrder(_id, 4464897);
        }

        private void Accept_btn_Click(object sender, EventArgs e)
        {
            OrdersManagement om = new OrdersManagement();
            om.UpdateOrder(_id, 8791616);
        }

        private void Decline_btn_Click(object sender, EventArgs e)
        {
            OrdersManagement om = new OrdersManagement();
            om.UpdateOrder(_id, 9512592);
        }
    }
}
