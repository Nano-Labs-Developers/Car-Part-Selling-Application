namespace Admin
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Username_txt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reports_btn = new System.Windows.Forms.Button();
            this.CustomerOrders_btn = new System.Windows.Forms.Button();
            this.CustomerDetails_btn = new System.Windows.Forms.Button();
            this.CarParts_btn = new System.Windows.Forms.Button();
            this.CarDetails_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UCupdateCar = new Admin.UI.Car.UpdateCar();
            this.UCmanageCustomer = new Admin.Customer.ManageCustomer();
            this.UCorderDetails = new Admin.UI.Customer.OrderDetails();
            this.UCmanageOrders = new Admin.Customer.ManageOrders();
            this.UCcustomerDetails = new Admin.UI.Customer.CustomerDetails();
            this.UCcarPartDetailsList = new Admin.UI.Car.CarPartDetailsList();
            this.UCcarPartDetails = new Admin.Car.CarPartDetails();
            this.UCcarDetailsList = new Admin.UI.Car.CarDetailsList();
            this.UCcarDetails = new Admin.Car.CarDetails();
            this.UCaddParts = new Admin.UI.Car.AddParts();
            this.UCaddCar = new Admin.UI.Car.AddCar();
            this.UCreport = new Admin.UI.Report.Report();
            this.UCupdateParts = new Admin.UI.Car.UpdateParts();
            this.Headpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Headpanel
            // 
            this.Headpanel.Controls.Add(this.pictureBox2);
            this.Headpanel.Controls.Add(this.Username_txt);
            this.Headpanel.Controls.Add(this.pictureBox1);
            this.Headpanel.Controls.Add(this.label1);
            this.Headpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headpanel.Location = new System.Drawing.Point(0, 0);
            this.Headpanel.Name = "Headpanel";
            this.Headpanel.Size = new System.Drawing.Size(1582, 64);
            this.Headpanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Admin.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(1527, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Username_txt
            // 
            this.Username_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Username_txt.BackColor = System.Drawing.Color.Transparent;
            this.Username_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username_txt.Location = new System.Drawing.Point(1409, 24);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(58, 23);
            this.Username_txt.TabIndex = 0;
            this.Username_txt.Text = "Pasan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Admin.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(1473, 12);
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
            this.Sidepanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Reports_btn);
            this.panel1.Controls.Add(this.CustomerOrders_btn);
            this.panel1.Controls.Add(this.CustomerDetails_btn);
            this.panel1.Controls.Add(this.CarParts_btn);
            this.panel1.Controls.Add(this.CarDetails_btn);
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 277);
            this.panel1.TabIndex = 0;
            // 
            // Reports_btn
            // 
            this.Reports_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reports_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reports_btn.Location = new System.Drawing.Point(0, 220);
            this.Reports_btn.Name = "Reports_btn";
            this.Reports_btn.Size = new System.Drawing.Size(241, 55);
            this.Reports_btn.TabIndex = 4;
            this.Reports_btn.Text = "Reports";
            this.Reports_btn.UseVisualStyleBackColor = true;
            this.Reports_btn.Click += new System.EventHandler(this.Reports_btn_Click);
            // 
            // CustomerOrders_btn
            // 
            this.CustomerOrders_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerOrders_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerOrders_btn.Location = new System.Drawing.Point(0, 165);
            this.CustomerOrders_btn.Name = "CustomerOrders_btn";
            this.CustomerOrders_btn.Size = new System.Drawing.Size(241, 55);
            this.CustomerOrders_btn.TabIndex = 3;
            this.CustomerOrders_btn.Text = "Customer Orders";
            this.CustomerOrders_btn.UseVisualStyleBackColor = true;
            this.CustomerOrders_btn.Click += new System.EventHandler(this.CustomerOrders_btn_Click);
            // 
            // CustomerDetails_btn
            // 
            this.CustomerDetails_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerDetails_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerDetails_btn.Location = new System.Drawing.Point(0, 110);
            this.CustomerDetails_btn.Name = "CustomerDetails_btn";
            this.CustomerDetails_btn.Size = new System.Drawing.Size(241, 55);
            this.CustomerDetails_btn.TabIndex = 2;
            this.CustomerDetails_btn.Text = "Customer Details";
            this.CustomerDetails_btn.UseVisualStyleBackColor = true;
            this.CustomerDetails_btn.Click += new System.EventHandler(this.CustomerDetails_btn_Click);
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
            this.CarParts_btn.Click += new System.EventHandler(this.CarParts_btn_Click);
            // 
            // CarDetails_btn
            // 
            this.CarDetails_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarDetails_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarDetails_btn.Location = new System.Drawing.Point(0, 0);
            this.CarDetails_btn.Name = "CarDetails_btn";
            this.CarDetails_btn.Size = new System.Drawing.Size(241, 55);
            this.CarDetails_btn.TabIndex = 0;
            this.CarDetails_btn.Text = "Car Details";
            this.CarDetails_btn.UseVisualStyleBackColor = true;
            this.CarDetails_btn.Click += new System.EventHandler(this.CarDetails_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UCupdateParts);
            this.panel3.Controls.Add(this.UCupdateCar);
            this.panel3.Controls.Add(this.UCmanageCustomer);
            this.panel3.Controls.Add(this.UCorderDetails);
            this.panel3.Controls.Add(this.UCmanageOrders);
            this.panel3.Controls.Add(this.UCcustomerDetails);
            this.panel3.Controls.Add(this.UCcarPartDetailsList);
            this.panel3.Controls.Add(this.UCcarPartDetails);
            this.panel3.Controls.Add(this.UCcarDetailsList);
            this.panel3.Controls.Add(this.UCcarDetails);
            this.panel3.Controls.Add(this.UCaddParts);
            this.panel3.Controls.Add(this.UCaddCar);
            this.panel3.Controls.Add(this.UCreport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(241, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1341, 797);
            this.panel3.TabIndex = 2;
            // 
            // UCupdateCar
            // 
            this.UCupdateCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCupdateCar.Enabled = false;
            this.UCupdateCar.Location = new System.Drawing.Point(0, 0);
            this.UCupdateCar.Name = "UCupdateCar";
            this.UCupdateCar.Size = new System.Drawing.Size(1341, 797);
            this.UCupdateCar.TabIndex = 3;
            this.UCupdateCar.Visible = false;
            // 
            // UCmanageCustomer
            // 
            this.UCmanageCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCmanageCustomer.Enabled = false;
            this.UCmanageCustomer.Location = new System.Drawing.Point(0, 0);
            this.UCmanageCustomer.Name = "UCmanageCustomer";
            this.UCmanageCustomer.Size = new System.Drawing.Size(1341, 797);
            this.UCmanageCustomer.TabIndex = 1;
            this.UCmanageCustomer.Visible = false;
            // 
            // UCorderDetails
            // 
            this.UCorderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCorderDetails.Enabled = false;
            this.UCorderDetails.Location = new System.Drawing.Point(0, 0);
            this.UCorderDetails.Name = "UCorderDetails";
            this.UCorderDetails.Size = new System.Drawing.Size(1341, 797);
            this.UCorderDetails.TabIndex = 1;
            this.UCorderDetails.Visible = false;
            // 
            // UCmanageOrders
            // 
            this.UCmanageOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCmanageOrders.Enabled = false;
            this.UCmanageOrders.Location = new System.Drawing.Point(0, 0);
            this.UCmanageOrders.Name = "UCmanageOrders";
            this.UCmanageOrders.Size = new System.Drawing.Size(1341, 797);
            this.UCmanageOrders.TabIndex = 8;
            this.UCmanageOrders.Visible = false;
            // 
            // UCcustomerDetails
            // 
            this.UCcustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCcustomerDetails.Enabled = false;
            this.UCcustomerDetails.Location = new System.Drawing.Point(0, 0);
            this.UCcustomerDetails.Name = "UCcustomerDetails";
            this.UCcustomerDetails.Size = new System.Drawing.Size(1341, 797);
            this.UCcustomerDetails.TabIndex = 7;
            this.UCcustomerDetails.Visible = false;
            // 
            // UCcarPartDetailsList
            // 
            this.UCcarPartDetailsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCcarPartDetailsList.Enabled = false;
            this.UCcarPartDetailsList.Location = new System.Drawing.Point(0, 0);
            this.UCcarPartDetailsList.Name = "UCcarPartDetailsList";
            this.UCcarPartDetailsList.Size = new System.Drawing.Size(1341, 797);
            this.UCcarPartDetailsList.TabIndex = 6;
            this.UCcarPartDetailsList.Visible = false;
            // 
            // UCcarPartDetails
            // 
            this.UCcarPartDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCcarPartDetails.Enabled = false;
            this.UCcarPartDetails.Location = new System.Drawing.Point(0, 0);
            this.UCcarPartDetails.Name = "UCcarPartDetails";
            this.UCcarPartDetails.Size = new System.Drawing.Size(1341, 797);
            this.UCcarPartDetails.TabIndex = 5;
            this.UCcarPartDetails.Visible = false;
            // 
            // UCcarDetailsList
            // 
            this.UCcarDetailsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCcarDetailsList.Enabled = false;
            this.UCcarDetailsList.Location = new System.Drawing.Point(0, 0);
            this.UCcarDetailsList.Name = "UCcarDetailsList";
            this.UCcarDetailsList.Size = new System.Drawing.Size(1341, 797);
            this.UCcarDetailsList.TabIndex = 4;
            this.UCcarDetailsList.Visible = false;
            // 
            // UCcarDetails
            // 
            this.UCcarDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCcarDetails.Enabled = false;
            this.UCcarDetails.Location = new System.Drawing.Point(0, 0);
            this.UCcarDetails.Name = "UCcarDetails";
            this.UCcarDetails.Size = new System.Drawing.Size(1341, 797);
            this.UCcarDetails.TabIndex = 3;
            this.UCcarDetails.Visible = false;
            // 
            // UCaddParts
            // 
            this.UCaddParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCaddParts.Enabled = false;
            this.UCaddParts.Location = new System.Drawing.Point(0, 0);
            this.UCaddParts.Name = "UCaddParts";
            this.UCaddParts.Size = new System.Drawing.Size(1341, 797);
            this.UCaddParts.TabIndex = 2;
            this.UCaddParts.Visible = false;
            // 
            // UCaddCar
            // 
            this.UCaddCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCaddCar.Location = new System.Drawing.Point(0, 0);
            this.UCaddCar.Name = "UCaddCar";
            this.UCaddCar.Size = new System.Drawing.Size(1341, 797);
            this.UCaddCar.TabIndex = 1;
            // 
            // UCreport
            // 
            this.UCreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCreport.Enabled = false;
            this.UCreport.Location = new System.Drawing.Point(0, 0);
            this.UCreport.Name = "UCreport";
            this.UCreport.Size = new System.Drawing.Size(1341, 797);
            this.UCreport.TabIndex = 0;
            this.UCreport.Visible = false;
            // 
            // UCupdateParts
            // 
            this.UCupdateParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCupdateParts.Enabled = false;
            this.UCupdateParts.Location = new System.Drawing.Point(0, 0);
            this.UCupdateParts.Name = "UCupdateParts";
            this.UCupdateParts.Size = new System.Drawing.Size(1341, 797);
            this.UCupdateParts.TabIndex = 3;
            this.UCupdateParts.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 861);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Sidepanel);
            this.Controls.Add(this.Headpanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Headpanel.ResumeLayout(false);
            this.Headpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Sidepanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Headpanel;
        private Panel Sidepanel;
        private Panel panel3;
        private Label label1;
        private Label Username_txt;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button CarDetails_btn;
        private Button CarParts_btn;
        private Button CustomerDetails_btn;
        private Button CustomerOrders_btn;
        private Button Reports_btn;
        private PictureBox pictureBox2;
        private UI.Report.Report UCreport;
        private UI.Car.AddCar UCaddCar;
        private UI.Car.AddParts UCaddParts;
        private Car.CarDetails UCcarDetails;
        private UI.Car.CarDetailsList UCcarDetailsList;
        private Car.CarPartDetails UCcarPartDetails;
        private UI.Car.CarPartDetailsList UCcarPartDetailsList;
        private UI.Customer.CustomerDetails UCcustomerDetails;
        private Customer.ManageOrders UCmanageOrders;
        private UI.Customer.OrderDetails UCorderDetails;
        private Customer.ManageCustomer UCmanageCustomer;
        private UI.Car.UpdateCar UCupdateCar;
        private UI.Car.UpdateParts UCupdateParts;
    }
}