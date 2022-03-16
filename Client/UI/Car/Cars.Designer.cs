namespace Client.UI.Car
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.label1 = new System.Windows.Forms.Label();
            this.CarName_CBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Year_CBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarModel_CBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.OrderNow_btn = new System.Windows.Forms.Button();
            this.Details_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Year_lbl = new System.Windows.Forms.Label();
            this.ModelName_lbl = new System.Windows.Forms.Label();
            this.CarName_lbl = new System.Windows.Forms.Label();
            this.Car_picBox = new System.Windows.Forms.PictureBox();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Car";
            // 
            // CarName_CBox
            // 
            this.CarName_CBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarName_CBox.FormattingEnabled = true;
            this.CarName_CBox.Location = new System.Drawing.Point(139, 54);
            this.CarName_CBox.Name = "CarName_CBox";
            this.CarName_CBox.Size = new System.Drawing.Size(271, 29);
            this.CarName_CBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Year_CBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CarModel_CBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CarName_CBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 100);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1169, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(833, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year";
            // 
            // Year_CBox
            // 
            this.Year_CBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Year_CBox.FormattingEnabled = true;
            this.Year_CBox.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018"});
            this.Year_CBox.Location = new System.Drawing.Point(876, 54);
            this.Year_CBox.Name = "Year_CBox";
            this.Year_CBox.Size = new System.Drawing.Size(271, 29);
            this.Year_CBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(439, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Car Model";
            // 
            // CarModel_CBox
            // 
            this.CarModel_CBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarModel_CBox.FormattingEnabled = true;
            this.CarModel_CBox.Location = new System.Drawing.Point(523, 54);
            this.CarModel_CBox.Name = "CarModel_CBox";
            this.CarModel_CBox.Size = new System.Drawing.Size(271, 29);
            this.CarModel_CBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car Name";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView.Location = new System.Drawing.Point(23, 165);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(656, 610);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ID_lbl);
            this.panel2.Controls.Add(this.OrderNow_btn);
            this.panel2.Controls.Add(this.Details_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Price_lbl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Year_lbl);
            this.panel2.Controls.Add(this.ModelName_lbl);
            this.panel2.Controls.Add(this.CarName_lbl);
            this.panel2.Controls.Add(this.Car_picBox);
            this.panel2.Location = new System.Drawing.Point(696, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 655);
            this.panel2.TabIndex = 5;
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID_lbl.Location = new System.Drawing.Point(555, 11);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(23, 19);
            this.ID_lbl.TabIndex = 20;
            this.ID_lbl.Text = "ID";
            // 
            // OrderNow_btn
            // 
            this.OrderNow_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderNow_btn.Location = new System.Drawing.Point(478, 602);
            this.OrderNow_btn.Name = "OrderNow_btn";
            this.OrderNow_btn.Size = new System.Drawing.Size(128, 39);
            this.OrderNow_btn.TabIndex = 9;
            this.OrderNow_btn.Text = "Order Now";
            this.OrderNow_btn.UseVisualStyleBackColor = true;
            // 
            // Details_txt
            // 
            this.Details_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Details_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Details_txt.Location = new System.Drawing.Point(17, 238);
            this.Details_txt.Multiline = true;
            this.Details_txt.Name = "Details_txt";
            this.Details_txt.ReadOnly = true;
            this.Details_txt.Size = new System.Drawing.Size(589, 349);
            this.Details_txt.TabIndex = 19;
            this.Details_txt.Text = resources.GetString("Details_txt.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(266, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price:";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_lbl.Location = new System.Drawing.Point(323, 140);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(53, 19);
            this.Price_lbl.TabIndex = 17;
            this.Price_lbl.Text = "$ 2000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(266, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(266, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Model:";
            // 
            // Year_lbl
            // 
            this.Year_lbl.AutoSize = true;
            this.Year_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Year_lbl.Location = new System.Drawing.Point(323, 107);
            this.Year_lbl.Name = "Year_lbl";
            this.Year_lbl.Size = new System.Drawing.Size(41, 19);
            this.Year_lbl.TabIndex = 14;
            this.Year_lbl.Text = "2023";
            // 
            // ModelName_lbl
            // 
            this.ModelName_lbl.AutoSize = true;
            this.ModelName_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelName_lbl.Location = new System.Drawing.Point(323, 76);
            this.ModelName_lbl.Name = "ModelName_lbl";
            this.ModelName_lbl.Size = new System.Drawing.Size(69, 19);
            this.ModelName_lbl.TabIndex = 13;
            this.ModelName_lbl.Text = "A6 e-tron";
            // 
            // CarName_lbl
            // 
            this.CarName_lbl.AutoSize = true;
            this.CarName_lbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarName_lbl.Location = new System.Drawing.Point(266, 33);
            this.CarName_lbl.Name = "CarName_lbl";
            this.CarName_lbl.Size = new System.Drawing.Size(156, 30);
            this.CarName_lbl.TabIndex = 12;
            this.CarName_lbl.Text = "Audi A6 e-tron";
            // 
            // Car_picBox
            // 
            this.Car_picBox.Image = ((System.Drawing.Image)(resources.GetObject("Car_picBox.Image")));
            this.Car_picBox.Location = new System.Drawing.Point(17, 16);
            this.Car_picBox.Name = "Car_picBox";
            this.Car_picBox.Size = new System.Drawing.Size(219, 203);
            this.Car_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Car_picBox.TabIndex = 0;
            this.Car_picBox.TabStop = false;
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Refresh_btn.Location = new System.Drawing.Point(552, 120);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(127, 39);
            this.Refresh_btn.TabIndex = 9;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Cars";
            this.Size = new System.Drawing.Size(1341, 797);
            this.Load += new System.EventHandler(this.Cars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car_picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private ComboBox CarName_CBox;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private ComboBox CarModel_CBox;
        private Label label4;
        private ComboBox Year_CBox;
        private DataGridView dataGridView;
        private Panel panel2;
        private Button button1;
        private PictureBox Car_picBox;
        private Label label5;
        private Label Price_lbl;
        private Label label6;
        private Label label7;
        private Label Year_lbl;
        private Label ModelName_lbl;
        private Label CarName_lbl;
        private TextBox Details_txt;
        private Button OrderNow_btn;
        private Button Refresh_btn;
        private Label ID_lbl;
    }
}
