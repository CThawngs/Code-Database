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

namespace Prj_QuanLyBanHang.GUI
{
    public partial class Frm_AddEmployee : Form
    {
        Users users;
        public Frm_AddEmployee()
        {
            InitializeComponent();
        }

        private void Frm_AddEmployee_Load(object sender, EventArgs e)
        {

        }
        public bool UsernameExists(string username)
        {
            string[] parameters = { "@Username" };
            object[] values = { username };

            string query = "SELECT COUNT(*) FROM Employees WHERE Username = @Username";
            int count = (int)users.UsersExecuteScalar(query, parameters, values);

            return count > 0;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            users = new Users();

            if (txt_password.Text != txt_confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Username and password cannot be empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_password.Text.Length < 5 || !txt_password.Text.Any(char.IsDigit) || !txt_password.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Password must be at least 5 characters long and contain both letters and numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UsernameExists(txt_username.Text))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (users.Connect())
            {
                string[] parameters = { "@UserRole", "@Username", "@Password" };
                object[] values = { cmb_Type.Text, txt_username.Text, txt_password.Text };



                int rec = users.UsersExecuteNonQuery("sp_CreateEmployeeUser", parameters, values, true);
                if (rec > 0)
                {
                    MessageBox.Show("SuccessFul", "Notice", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something was wrong", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                users.Disconnect();



            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
