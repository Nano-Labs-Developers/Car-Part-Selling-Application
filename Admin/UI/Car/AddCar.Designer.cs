namespace Admin.UI.Car
{
    partial class AddCar
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
            this.GoBack_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Model_txt = new System.Windows.Forms.TextBox();
            this.Year_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Image_txt = new System.Windows.Forms.TextBox();
            this.Details_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoBack_btn
            // 
            this.GoBack_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoBack_btn.Location = new System.Drawing.Point(1192, 18);
            this.GoBack_btn.Name = "GoBack_btn";
            this.GoBack_btn.Size = new System.Drawing.Size(123, 32);
            this.GoBack_btn.TabIndex = 10;
            this.GoBack_btn.Text = "Go back";
            this.GoBack_btn.UseVisualStyleBackColor = true;
            this.GoBack_btn.Click += new System.EventHandler(this.GoBack_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Price_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Details_txt);
            this.panel1.Controls.Add(this.Image_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Year_txt);
            this.panel1.Controls.Add(this.Model_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Name_txt);
            this.panel1.Location = new System.Drawing.Point(36, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 647);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add New Car";
            // 
            // Name_txt
            // 
            this.Name_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_txt.Location = new System.Drawing.Point(119, 45);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(678, 27);
            this.Name_txt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            // 
            // Model_txt
            // 
            this.Model_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Model_txt.Location = new System.Drawing.Point(119, 88);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(678, 27);
            this.Model_txt.TabIndex = 4;
            // 
            // Year_txt
            // 
            this.Year_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Year_txt.Location = new System.Drawing.Point(119, 133);
            this.Year_txt.Name = "Year_txt";
            this.Year_txt.Size = new System.Drawing.Size(678, 27);
            this.Year_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Image URL:";
            // 
            // Image_txt
            // 
            this.Image_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Image_txt.Location = new System.Drawing.Point(119, 179);
            this.Image_txt.Name = "Image_txt";
            this.Image_txt.Size = new System.Drawing.Size(678, 27);
            this.Image_txt.TabIndex = 7;
            // 
            // Details_txt
            // 
            this.Details_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Details_txt.Location = new System.Drawing.Point(119, 271);
            this.Details_txt.Multiline = true;
            this.Details_txt.Name = "Details_txt";
            this.Details_txt.Size = new System.Drawing.Size(678, 343);
            this.Details_txt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Details:";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel_btn.Location = new System.Drawing.Point(897, 707);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(418, 58);
            this.Cancel_btn.TabIndex = 13;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear_btn.Location = new System.Drawing.Point(897, 643);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(418, 58);
            this.Clear_btn.TabIndex = 14;
            this.Clear_btn.Text = "Clear Data";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_btn.Location = new System.Drawing.Point(897, 579);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(418, 58);
            this.Save_btn.TabIndex = 15;
            this.Save_btn.Text = "Save Data";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Price_txt
            // 
            this.Price_txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_txt.Location = new System.Drawing.Point(119, 224);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(678, 27);
            this.Price_txt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Price:";
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GoBack_btn);
            this.Name = "AddCar";
            this.Size = new System.Drawing.Size(1341, 797);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GoBack_btn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox Name_txt;
        private Label label3;
        private Label label4;
        private TextBox Year_txt;
        private TextBox Model_txt;
        private Label label5;
        private TextBox Image_txt;
        private TextBox Details_txt;
        private Label label6;
        private Button Cancel_btn;
        private Button Clear_btn;
        private Button Save_btn;
        private TextBox Price_txt;
        private Label label7;
    }
}
