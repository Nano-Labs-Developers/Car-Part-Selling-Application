namespace Client.UI.Auth
{
    partial class Register
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.LinkLabel();
            this.Register_btn = new System.Windows.Forms.Button();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.ConPassword_lbl = new System.Windows.Forms.Label();
            this.ConPassword_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_txt
            // 
            this.Username_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username_txt.Location = new System.Drawing.Point(91, 233);
            this.Username_txt.MaxLength = 16;
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.PlaceholderText = "Username";
            this.Username_txt.Size = new System.Drawing.Size(287, 27);
            this.Username_txt.TabIndex = 1;
            // 
            // Login_btn
            // 
            this.Login_btn.ActiveLinkColor = System.Drawing.Color.Black;
            this.Login_btn.AutoSize = true;
            this.Login_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_btn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Login_btn.LinkColor = System.Drawing.Color.Black;
            this.Login_btn.Location = new System.Drawing.Point(179, 512);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(99, 20);
            this.Login_btn.TabIndex = 7;
            this.Login_btn.TabStop = true;
            this.Login_btn.Text = "Back to Login";
            this.Login_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_btn_LinkClicked);
            // 
            // Register_btn
            // 
            this.Register_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register_btn.Location = new System.Drawing.Point(91, 458);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(287, 49);
            this.Register_btn.TabIndex = 10;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_lbl.Location = new System.Drawing.Point(91, 328);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(76, 21);
            this.Password_lbl.TabIndex = 9;
            this.Password_lbl.Text = "Password";
            // 
            // Password_txt
            // 
            this.Password_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_txt.Location = new System.Drawing.Point(91, 352);
            this.Password_txt.MaxLength = 16;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PlaceholderText = "Password";
            this.Password_txt.Size = new System.Drawing.Size(287, 27);
            this.Password_txt.TabIndex = 8;
            this.Password_txt.UseSystemPasswordChar = true;
            this.Password_txt.TextChanged += new System.EventHandler(this.Password_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // Email_txt
            // 
            this.Email_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email_txt.Location = new System.Drawing.Point(91, 294);
            this.Email_txt.MaxLength = 100;
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.PlaceholderText = "Email";
            this.Email_txt.Size = new System.Drawing.Size(287, 27);
            this.Email_txt.TabIndex = 12;
            this.Email_txt.TextChanged += new System.EventHandler(this.Email_txt_TextChanged);
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email_lbl.Location = new System.Drawing.Point(92, 271);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(46, 20);
            this.Email_lbl.TabIndex = 13;
            this.Email_lbl.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(91, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name";
            // 
            // Name_txt
            // 
            this.Name_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_txt.Location = new System.Drawing.Point(91, 174);
            this.Name_txt.MaxLength = 100;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.PlaceholderText = "Name";
            this.Name_txt.Size = new System.Drawing.Size(287, 27);
            this.Name_txt.TabIndex = 14;
            // 
            // ConPassword_lbl
            // 
            this.ConPassword_lbl.AutoSize = true;
            this.ConPassword_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConPassword_lbl.Location = new System.Drawing.Point(92, 390);
            this.ConPassword_lbl.Name = "ConPassword_lbl";
            this.ConPassword_lbl.Size = new System.Drawing.Size(137, 21);
            this.ConPassword_lbl.TabIndex = 17;
            this.ConPassword_lbl.Text = "Confirm Password";
            // 
            // ConPassword_txt
            // 
            this.ConPassword_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConPassword_txt.Location = new System.Drawing.Point(92, 414);
            this.ConPassword_txt.MaxLength = 16;
            this.ConPassword_txt.Name = "ConPassword_txt";
            this.ConPassword_txt.PlaceholderText = "Password";
            this.ConPassword_txt.Size = new System.Drawing.Size(287, 27);
            this.ConPassword_txt.TabIndex = 16;
            this.ConPassword_txt.UseSystemPasswordChar = true;
            this.ConPassword_txt.TextChanged += new System.EventHandler(this.ConPassword_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(237, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 45);
            this.label6.TabIndex = 19;
            this.label6.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.favicon;
            this.pictureBox1.Location = new System.Drawing.Point(92, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ConPassword_lbl);
            this.Controls.Add(this.ConPassword_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Username_txt);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(460, 555);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel Login_btn;
        private Button Register_btn;
        private Label Password_lbl;
        private Label label1;
        private Label Email_lbl;
        private Label label4;
        private Label ConPassword_lbl;
        private Label label6;
        private PictureBox pictureBox1;
        internal TextBox Username_txt;
        internal TextBox Password_txt;
        internal TextBox Email_txt;
        internal TextBox Name_txt;
        internal TextBox ConPassword_txt;
    }
}
