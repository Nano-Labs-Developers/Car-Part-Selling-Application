﻿namespace Admin.UI.Car
{
    partial class CarPartDetailsList
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
            this.AddCarPart_btn = new System.Windows.Forms.Button();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCarPart_btn
            // 
            this.AddCarPart_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCarPart_btn.Location = new System.Drawing.Point(950, 18);
            this.AddCarPart_btn.Name = "AddCarPart_btn";
            this.AddCarPart_btn.Size = new System.Drawing.Size(206, 49);
            this.AddCarPart_btn.TabIndex = 5;
            this.AddCarPart_btn.Text = "Add New Car Part";
            this.AddCarPart_btn.UseVisualStyleBackColor = true;
            this.AddCarPart_btn.Click += new System.EventHandler(this.AddCarPart_btn_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Refresh_btn.Location = new System.Drawing.Point(1162, 18);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(161, 49);
            this.Refresh_btn.TabIndex = 4;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(18, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 695);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1305, 695);
            this.dataGridView.TabIndex = 0;
            // 
            // CarPartDetailsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddCarPart_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.panel1);
            this.Name = "CarPartDetailsList";
            this.Size = new System.Drawing.Size(1341, 797);
            this.Load += new System.EventHandler(this.CarPartDetailsList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddCarPart_btn;
        private Button Refresh_btn;
        private Panel panel1;
        private DataGridView dataGridView;
    }
}
