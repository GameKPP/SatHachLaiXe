using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DTO;
namespace SatHachBangLaiXe
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            //Khởi tạo giao diện metro
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            if (Properties.Settings.Default.RememberMe)//True
            {
                //đặt giá trị username & mật khẩu
                txtUsername.Text = Properties.Settings.Default.TaiKhoan;
                txtPassword.Text = Properties.Settings.Default.MatKhau;
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Kiểm tra null or empty
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng điền tên đăng nhập", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    //Excute sql query, then map data return from sql to User class
                    User obj = db.Query<User>($"select * from TTDangNhap where TaiKhoan ='{txtUsername.Text}'", commandType: CommandType.Text).SingleOrDefault();
                    if (obj != null)
                    {
                        if (obj.MatKhau == txtPassword.Text)//True
                        {
                            using (NavigateForm frm = new NavigateForm())//Open main form and hide login form
                            {
                                this.Hide();
                                frm.ShowDialog();
                            }
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Sai Tài Khoản Hoặc Mật Khẩu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Sai Tài Khoản Hoặc Mật Khẩu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDangNhap.Checked)//Set value to user settings
            {
                Properties.Settings.Default.TaiKhoan = txtUsername.Text;
                Properties.Settings.Default.MatKhau = txtPassword.Text;
            }
            else
            {
                Properties.Settings.Default.TaiKhoan = null;
                Properties.Settings.Default.MatKhau = null;
            }
            Properties.Settings.Default.RememberMe = checkBoxDangNhap.Checked;
            Properties.Settings.Default.Save();//Save data to user settings
        }
    }
}
