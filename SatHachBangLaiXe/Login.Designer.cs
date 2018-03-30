namespace SatHachBangLaiXe
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.checkBoxDangNhap = new MetroFramework.Controls.MetroCheckBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Lines = new string[] {
        "Nhập Tên Tài Khoản"};
            this.txtUsername.Location = new System.Drawing.Point(241, 82);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(248, 23);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Nhập Tên Tài Khoản";
            this.txtUsername.UseSelectable = true;
            // 
            // txtPassword
            // 
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[] {
        "Nhập Mật Khẩu"};
            this.txtPassword.Location = new System.Drawing.Point(241, 127);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(248, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Nhập Mật Khẩu";
            this.txtPassword.UseSelectable = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(403, 184);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 39);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBoxDangNhap
            // 
            this.checkBoxDangNhap.AutoSize = true;
            this.checkBoxDangNhap.Checked = true;
            this.checkBoxDangNhap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDangNhap.Location = new System.Drawing.Point(241, 165);
            this.checkBoxDangNhap.Name = "checkBoxDangNhap";
            this.checkBoxDangNhap.Size = new System.Drawing.Size(103, 15);
            this.checkBoxDangNhap.TabIndex = 4;
            this.checkBoxDangNhap.Text = "Lưu đăng nhập";
            this.checkBoxDangNhap.UseSelectable = true;
            this.checkBoxDangNhap.CheckedChanged += new System.EventHandler(this.checkBoxDangNhap_CheckedChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 257);
            this.Controls.Add(this.checkBoxDangNhap);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroCheckBox checkBoxDangNhap;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}