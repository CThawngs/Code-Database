using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_QuanLyBanHang.BLL;
using Prj_QuanLyBanHang.GUI;

namespace Prj_QuanLyBanHang
{
    public partial class Frm_Login : Form
    {
        Users users;
        User user;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            CheckForAdminExistence();
        }
        private void CheckForAdminExistence()
        {
            users = new Users();

            if (users.Connect())
            {
                DataTable admin = users.GetAdmin();
                if (admin == null || admin.Rows.Count == 0)
                {
                    Frm_AddAdmin form = new Frm_AddAdmin();
                    form.ShowDialog();
                }
                users.Disconnect();

            }
            else
            {
                MessageBox.Show("Failed to connect to database","Notice",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            user = new User();

            if (users.Connect())
            {
                var userInfo = user.CheckUser(txt_username.Text, txt_password.Text);

                if (userInfo != null && userInfo.Count > 0)
                {
                    string userRole = userInfo["UserRole"].ToString();
                    int userId = Convert.ToInt32(userInfo["Id"]);

                    MessageBox.Show("Success", "Notice", MessageBoxButtons.OK);

                    Frm_MainQLBH form = new Frm_MainQLBH(userRole, userId);
                    form.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Không đúng mật khẩu hoặc tên tài khoản", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            user.Disconnect();
        }
    }
}
