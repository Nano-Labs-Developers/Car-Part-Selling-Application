using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UI.Auth
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private string _password = string.Empty;
        private string _conpassword = string.Empty;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        private void Login_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // solution url
            // https://stackoverflow.com/questions/7880850/how-do-i-make-an-event-in-the-usercontrol-and-have-it-handled-in-the-main-form
            // bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void Password_txt_TextChanged(object sender, EventArgs e)
        {
            _password = Password_txt.Text;
            if (_password != _conpassword)
            {
                ConPassword_lbl.Text = "Confirm Password - Password not match";
            }
            else
            {
                ConPassword_lbl.Text = "Confirm Password";
            }
        }

        private void ConPassword_txt_TextChanged(object sender, EventArgs e)
        {
            _conpassword = ConPassword_txt.Text;
            if (_password != _conpassword)
            {
                ConPassword_lbl.Text = "Confirm Password - Password not match";
            }
            else
            {
                ConPassword_lbl.Text = "Confirm Password";
            }
        }

        private void Email_txt_TextChanged(object sender, EventArgs e)
        {
            bool isvalied = IsValidEmail(Email_txt.Text);
            if (!isvalied)
            {
                Email_lbl.Text = "Email - Invalid Email Format";
            }
            else
            {
                Email_lbl.Text = "Email";
            }
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (Validator() == false)
            {
                MessageBox.Show(this, "Something went wrong.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Authenticator authenticator = new Authenticator();
            authenticator.Register(Name_txt.Text, Username_txt.Text, Email_txt.Text, Password_txt.Text);
        }

        private bool Validator()
        {
            if (String.IsNullOrEmpty(Name_txt.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(Username_txt.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(Email_txt.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(Password_txt.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(ConPassword_txt.Text))
            {
                return false;
            }
            else if (IsValidEmail(Email_txt.Text) == false)
            {
                return false;
            }
            else if (ConPassword_txt.Text != Password_txt.Text)
            {
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
