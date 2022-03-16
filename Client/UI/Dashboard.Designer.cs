namespace Client.UI
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Headpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Logout_btn = new System.Windows.Forms.PictureBox();
            this.Username_txt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Account_btn = new System.Windows.Forms.Button();
            this.Orders_btn = new System.Windows.Forms.Button();
            this.CarParts_btn = new System.Windows.Forms.Button();
            this.Cars_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderStatus1 = new Client.UI.Orders.OrderStatus();
            this.Headpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Headpanel
            // 
            this.Headpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Headpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Headpanel.Controls.Add(this.label2);
            this.Headpanel.Controls.Add(this.pictureBox3);
            this.Headpanel.Controls.Add(this.Logout_btn);
            this.Headpanel.Controls.Add(this.Username_txt);
            this.Headpanel.Controls.Add(this.pictureBox1);
            this.Headpanel.Controls.Add(this.label1);
            this.Headpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headpanel.Location = new System.Drawing.Point(0, 0);
            this.Headpanel.Name = "Headpanel";
            this.Headpanel.Size = new System.Drawing.Size(1582, 64);
            this.Headpanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1406, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasan";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Client.Properties.Resources.avatar;
            this.pictureBox3.Location = new System.Drawing.Point(1470, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.Logout_btn.Image = global::Client.Properties.Resources.logout;
            this.Logout_btn.Location = new System.Drawing.Point(1527, 12);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(48, 41);
            this.Logout_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.TabStop = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Username_txt
            // 
            this.Username_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Username_txt.BackColor = System.Drawing.Color.Transparent;
            this.Username_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username_txt.Location = new System.Drawing.Point(2789, 5);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(58, 23);
            this.Username_txt.TabIndex = 0;
            this.Username_txt.Text = "Pasan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(2853, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC CARs";
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Sidepanel.Controls.Add(this.panel1);
            this.Sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidepanel.Location = new System.Drawing.Point(0, 64);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(241, 797);
            this.Sidepanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Account_btn);
            this.panel1.Controls.Add(this.Orders_btn);
            this.panel1.Controls.Add(this.CarParts_btn);
            this.panel1.Controls.Add(this.Cars_btn);
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 277);
            this.panel1.TabIndex = 0;
            // 
            // Account_btn
            // 
            this.Account_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Account_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Account_btn.Location = new System.Drawing.Point(0, 165);
            this.Account_btn.Name = "Account_btn";
            this.Account_btn.Size = new System.Drawing.Size(241, 55);
            this.Account_btn.TabIndex = 3;
            this.Account_btn.Text = "Account";
            this.Account_btn.UseVisualStyleBackColor = true;
            // 
            // Orders_btn
            // 
            this.Orders_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Orders_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Orders_btn.Location = new System.Drawing.Point(0, 110);
            this.Orders_btn.Name = "Orders_btn";
            this.Orders_btn.Size = new System.Drawing.Size(241, 55);
            this.Orders_btn.TabIndex = 2;
            this.Orders_btn.Text = "Orders";
            this.Orders_btn.UseVisualStyleBackColor = true;
            // 
            // CarParts_btn
            // 
            this.CarParts_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarParts_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarParts_btn.Location = new System.Drawing.Point(0, 55);
            this.CarParts_btn.Name = "CarParts_btn";
            this.CarParts_btn.Size = new System.Drawing.Size(241, 55);
            this.CarParts_btn.TabIndex = 1;
            this.CarParts_btn.Text = "Car Parts";
            this.CarParts_btn.UseVisualStyleBackColor = true;
            // 
            // Cars_btn
            // 
            this.Cars_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cars_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cars_btn.Location = new System.Drawing.Point(0, 0);
            this.Cars_btn.Name = "Cars_btn";
            this.Cars_btn.Size = new System.Drawing.Size(241, 55);
            this.Cars_btn.TabIndex = 0;
            this.Cars_btn.Text = "Cars";
            this.Cars_btn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orderStatus1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(241, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1341, 797);
            this.panel2.TabIndex = 3;
            // 
            // orderStatus1
            // 
            this.orderStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderStatus1.Location = new System.Drawing.Point(0, 0);
            this.orderStatus1.Name = "orderStatus1";
            this.orderStatus1.Size = new System.Drawing.Size(1341, 797);
            this.orderStatus1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 861);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Sidepanel);
            this.Controls.Add(this.Headpanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Cars";
            this.Headpanel.ResumeLayout(false);
            this.Headpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Sidepanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Headpanel;
        private PictureBox Logout_btn;
        private Label Username_txt;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private Panel Sidepanel;
        private Panel panel1;
        private Button CarParts_btn;
        private Button Cars_btn;
        private Panel panel2;
        private Button Orders_btn;
        private Button Account_btn;
        private Orders.CarOders carOders1;
        private Orders.OrderStatus orderStatus1;
    }
}