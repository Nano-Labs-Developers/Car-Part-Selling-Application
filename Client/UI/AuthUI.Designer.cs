namespace ACBCar
{
    partial class AuthUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackPanel = new System.Windows.Forms.Panel();
            this.register_UC = new Client.UI.Auth.Register();
            this.login_UC = new Client.UI.Auth.Login();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.register_UC);
            this.BackPanel.Controls.Add(this.login_UC);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(460, 555);
            this.BackPanel.TabIndex = 0;
            // 
            // register_UC
            // 
            this.register_UC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.register_UC.Location = new System.Drawing.Point(0, 0);
            this.register_UC.Name = "register_UC";
            this.register_UC.Size = new System.Drawing.Size(460, 555);
            this.register_UC.TabIndex = 0;
            // 
            // login_UC
            // 
            this.login_UC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_UC.Location = new System.Drawing.Point(0, 0);
            this.login_UC.Name = "login_UC";
            this.login_UC.Size = new System.Drawing.Size(460, 555);
            this.login_UC.TabIndex = 1;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 555);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Car";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BackPanel;
        private Client.UI.Auth.Login login_UC;
        private Client.UI.Auth.Register register_UC;
    }
}