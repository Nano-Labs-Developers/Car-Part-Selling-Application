namespace Admin.Car
{
    partial class CarDetails
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
            this.Car_picbox = new System.Windows.Forms.PictureBox();
            this.CarName_lbl = new System.Windows.Forms.Label();
            this.Details_txt = new System.Windows.Forms.TextBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.ModelName_lbl = new System.Windows.Forms.Label();
            this.Year_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoBack_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.ID_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Car_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Car_picbox
            // 
            this.Car_picbox.Location = new System.Drawing.Point(34, 28);
            this.Car_picbox.Name = "Car_picbox";
            this.Car_picbox.Size = new System.Drawing.Size(299, 237);
            this.Car_picbox.TabIndex = 0;
            this.Car_picbox.TabStop = false;
            // 
            // CarName_lbl
            // 
            this.CarName_lbl.AutoSize = true;
            this.CarName_lbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarName_lbl.Location = new System.Drawing.Point(368, 51);
            this.CarName_lbl.Name = "CarName_lbl";
            this.CarName_lbl.Size = new System.Drawing.Size(164, 30);
            this.CarName_lbl.TabIndex = 1;
            this.CarName_lbl.Text = "Long Car Name";
            // 
            // Details_txt
            // 
            this.Details_txt.Location = new System.Drawing.Point(34, 283);
            this.Details_txt.Multiline = true;
            this.Details_txt.Name = "Details_txt";
            this.Details_txt.ReadOnly = true;
            this.Details_txt.Size = new System.Drawing.Size(812, 484);
            this.Details_txt.TabIndex = 2;
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Update_btn.Location = new System.Drawing.Point(877, 705);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(205, 62);
            this.Update_btn.TabIndex = 3;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete_btn.Location = new System.Drawing.Point(1106, 705);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(205, 62);
            this.Delete_btn.TabIndex = 4;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // ModelName_lbl
            // 
            this.ModelName_lbl.AutoSize = true;
            this.ModelName_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelName_lbl.Location = new System.Drawing.Point(425, 94);
            this.ModelName_lbl.Name = "ModelName_lbl";
            this.ModelName_lbl.Size = new System.Drawing.Size(123, 19);
            this.ModelName_lbl.TabIndex = 5;
            this.ModelName_lbl.Text = "Long Model Name";
            // 
            // Year_lbl
            // 
            this.Year_lbl.AutoSize = true;
            this.Year_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Year_lbl.Location = new System.Drawing.Point(425, 125);
            this.Year_lbl.Name = "Year_lbl";
            this.Year_lbl.Size = new System.Drawing.Size(41, 19);
            this.Year_lbl.TabIndex = 6;
            this.Year_lbl.Text = "2022";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(368, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(368, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Year:";
            // 
            // GoBack_btn
            // 
            this.GoBack_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoBack_btn.Location = new System.Drawing.Point(1201, 13);
            this.GoBack_btn.Name = "GoBack_btn";
            this.GoBack_btn.Size = new System.Drawing.Size(123, 32);
            this.GoBack_btn.TabIndex = 9;
            this.GoBack_btn.Text = "Go back";
            this.GoBack_btn.UseVisualStyleBackColor = true;
            this.GoBack_btn.Click += new System.EventHandler(this.GoBack_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price:";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_lbl.Location = new System.Drawing.Point(425, 162);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(76, 19);
            this.Price_lbl.TabIndex = 10;
            this.Price_lbl.Text = "$ 000, 000";
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID_lbl.Location = new System.Drawing.Point(368, 28);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(23, 19);
            this.ID_lbl.TabIndex = 12;
            this.ID_lbl.Text = "ID";
            this.ID_lbl.Visible = false;
            // 
            // CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.GoBack_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Year_lbl);
            this.Controls.Add(this.ModelName_lbl);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Details_txt);
            this.Controls.Add(this.CarName_lbl);
            this.Controls.Add(this.Car_picbox);
            this.Name = "CarDetails";
            this.Size = new System.Drawing.Size(1341, 797);
            this.Load += new System.EventHandler(this.CarDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Car_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Car_picbox;
        private Label CarName_lbl;
        private TextBox Details_txt;
        private Button Update_btn;
        private Button Delete_btn;
        private Label ModelName_lbl;
        private Label Year_lbl;
        private Label label1;
        private Label label2;
        private Button GoBack_btn;
        private Label label3;
        private Label Price_lbl;
        private Label ID_lbl;
    }
}
