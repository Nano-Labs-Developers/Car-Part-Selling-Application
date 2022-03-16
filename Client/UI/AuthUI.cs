namespace ACBCar
{
    public partial class AuthUI : Form
    {
        public AuthUI()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            login_UC.ButtonClick += new EventHandler(LoginUC_ButtonClick);
            register_UC.ButtonClick += new EventHandler(RegisterUC_ButtonClick);
            login_UC.Visible = true;
            register_UC.Visible = false;
        }

        protected void LoginUC_ButtonClick(object sender, EventArgs e)
        {
            login_UC.Visible = false;
            register_UC.Visible = true;
        }

        protected void RegisterUC_ButtonClick(object sender, EventArgs e)
        {
            register_UC.Visible = false;
            login_UC.Visible = true;
        }
    }
}