using Admin.Car;
using Admin.Class;
using Admin.UI.Car;

namespace Admin
{
    public partial class Dashboard : Form
    {
        // Head Panel Color Gradient
        static string color1 = "#833ab4";
        static string color2 = "#c84444";
        static string color3 = "#fcb045";
        Color _color1 = ColorTranslator.FromHtml(color1);
        Color _color2 = ColorTranslator.FromHtml(color2);
        Color _color3 = ColorTranslator.FromHtml(color3);

        public Dashboard()
        {
            InitializeComponent();
            Headpanel.BackgroundImage = PanelGradient.Gradient2D(Headpanel.ClientRectangle, _color1, _color1, _color2, _color3);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            EnableVisible();
            UCcarDetailsList.Enabled = true;
            UCcarDetailsList.Visible = true;

            // hanlder ui buttons and data transfer events
            EventHandlerCalls();
        }

        #region Event Handler

        private void EventHandlerCalls()
        {
            // UserController button outside handler
            UCaddCar.ButtonClick += new EventHandler(UCaddCarBack_ButtonClick);
            UCaddCar.ButtonClick += new EventHandler(UCupdateCarBack_ButtonClick);
            UCaddParts.ButtonClick += new EventHandler(UCaddPartsBack_ButtonClick);
            UCcarDetailsList.ButtonClick += new EventHandler(UCcarDetailsListAddCar_ButtonClick);
            UCcarPartDetailsList.ButtonClick += new EventHandler(UCcarPartDetailsListAdd_ButtonClick);
            UCcarDetails.ClickGoBackButton += new CarDetails.OnClickGoBack(CarDatailsGoBack_ButtonClick);

            // UC cell events
            UCcarDetailsList.ClickDataTransfer += new CarDetailsList.OnClickDataEvent(CarDetails_CellClick); // Car details cell click
            UCcarPartDetailsList.ClickDataTransfer += new CarPartDetailsList.OnClickDataEvent(CarPartsDetails_CellClick); // Car parts details cell click
            UCcarDetails.ClickUpdateButton += new CarDetails.OnClickUpdate(CarUpdate_ButtonClick); // Car update button click (car details ui)
        }

        #endregion

        #region Dashboard buttons

        private void CarDetails_btn_Click(object sender, EventArgs e)
        {
            EnableVisible();
            UCcarDetailsList.Enabled = true;
            UCcarDetailsList.Visible = true;
        }

        private void CarParts_btn_Click(object sender, EventArgs e)
        {
            EnableVisible();
            UCcarPartDetailsList.Enabled = true;
            UCcarPartDetailsList.Visible = true;
        }

        private void CustomerDetails_btn_Click(object sender, EventArgs e)
        {
            EnableVisible();
            UCmanageCustomer.Enabled = true;
            UCmanageCustomer.Visible = true;
        }

        private void CustomerOrders_btn_Click(object sender, EventArgs e)
        {
            EnableVisible();
            UCmanageOrders.Enabled = true;
            UCmanageOrders.Visible = true;
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            EnableVisible();
            UCreport.Enabled = true;
            UCreport.Visible = true;
        }

        #endregion

        #region User Controller buttons

        private void UCaddCarBack_ButtonClick(object sender, EventArgs e)
        {
            EnableVisible();
            UCcarDetailsList.Enabled = true;
            UCcarDetailsList.Visible = true;
        }

        private void UCupdateCarBack_ButtonClick(object sender, EventArgs e)
        {
            EnableVisible();
            UCcarDetailsList.Enabled = true;
            UCcarDetailsList.Visible = true;
        }

        private void UCaddPartsBack_ButtonClick(object sender, EventArgs e)
        {
            EnableVisible();
            UCcarPartDetailsList.Enabled = true;
            UCcarPartDetailsList.Visible = true;
        }

        private void UCcarDetailsListAddCar_ButtonClick(object sender, EventArgs e)
        {
            EnableVisible();
            UCaddCar.Enabled = true;
            UCaddCar.Visible = true;
        }

        private void UCcarPartDetailsListAdd_ButtonClick(object sender, EventArgs e)
        {
            EnableVisible();
            UCaddParts.Enabled = true;
            UCaddParts.Visible = true;
        }

        private void CarDetails_CellClick(int id, string name, string model, string year, string image, string price, string details)
        {
            UCcarDetails.LoadData(id, name, model, year, image, price, details);
            EnableVisible();
            UCcarDetails.Enabled = true;
            UCcarDetails.Visible = true;
        }

        private void CarPartsDetails_CellClick(int id, string name, string model, string year, string image, string price, string details)
        {
            UCupdateParts.LoadData(id, name, model, year, image, price, details);
            EnableVisible();
            UCupdateParts.Enabled = true;
            UCupdateParts.Visible = true;
        }

        private void CarUpdate_ButtonClick(int id, string name, string model, string year, string image, string price, string details)
        {
            UCupdateCar.LoadData(id, name, model, year, image, price, details);
            EnableVisible();
            UCupdateCar.Enabled = true;
            UCupdateCar.Visible = true;
        }

        private void CarDatailsGoBack_ButtonClick()
        {
            EnableVisible();
            UCcarDetailsList.Enabled = true;
            UCcarDetailsList.Visible = true;
        }

        #endregion

        #region Visibility Handler

        private void EnableVisible()
        {
            // Visible
            UCaddCar.Visible = false;
            UCaddParts.Visible = false;

            UCupdateCar.Visible = false;
            UCupdateParts.Visible = false;

            UCcarPartDetails.Visible = false;
            UCcarPartDetailsList.Visible = false;

            UCcarDetails.Visible = false;
            UCcarDetailsList.Visible = false;

            UCcustomerDetails.Visible = false;
            UCmanageCustomer.Visible = false;

            UCmanageOrders.Visible = false;
            UCorderDetails.Visible = false;

            // Enable
            UCaddCar.Enabled = false;
            UCaddParts.Enabled = false;

            UCupdateCar.Enabled = false;
            UCupdateParts.Enabled = false;

            UCcarPartDetails.Enabled = false;
            UCcarPartDetailsList.Enabled = false;

            UCcarDetails.Enabled = false;
            UCcarDetailsList.Enabled = false;

            UCcustomerDetails.Enabled = false;
            UCmanageCustomer.Enabled = false;

            UCmanageOrders.Enabled = false;
            UCorderDetails.Enabled = false;
        }

        #endregion

        #region Logout

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
