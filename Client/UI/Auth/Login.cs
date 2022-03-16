using System.ComponentModel;

namespace Client.UI.Auth
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // UI
            Username_txt.AutoSize = false;
            Password_txt.AutoSize = false;
            Username_txt.Size = new System.Drawing.Size(287, 35);
            Password_txt.Size = new System.Drawing.Size(287, 35);
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (Validator() == false)
            {
                MessageBox.Show(this, "Something went wrong.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Authenticator authenticator = new Authenticator();
            authenticator.SignIn(Username_txt.Text, Password_txt.Text);
        }

        private bool Validator()
        {
            if (String.IsNullOrEmpty(Username_txt.Text))
            {
                return false;
                throw new Exception("Username is empty");
            }
            else if (String.IsNullOrEmpty(Password_txt.Text))
            {
                return false;
                throw new Exception("Password is empty");
            }
            return true;
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        private void Register_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // solution url
            // https://stackoverflow.com/questions/7880850/how-do-i-make-an-event-in-the-usercontrol-and-have-it-handled-in-the-main-form
            // bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
