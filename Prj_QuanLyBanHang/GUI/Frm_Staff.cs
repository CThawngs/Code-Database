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
    public partial class Frm_Staff : Form
    {

        public Frm_Staff()
        {
            InitializeComponent();
        }

        private void btn_fixstaff_Click(object sender, EventArgs e)
        {
            if (list_staff.SelectedRows.Count > 0)
            {
                int EmployeeId = Convert.ToInt32(list_staff.SelectedRows[0].Cells["EmployeeId"].Value);

                if (EmployeeId == 0)
                {
                    MessageBox.Show("No Employee selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Hide();
                Frm_StaffDetailscs form = new Frm_StaffDetailscs(EmployeeId);

                form.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please select a product to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frm_Staff_Load(object sender, EventArgs e)
        {
            LoadDataUser();
            if(txt_total.Text == "1" || txt_total.Text == "0")
            {
                btn_deletestaff.Enabled = false;
            }
        }
        
        private void LoadDataUser()
        {
            DataTable tblUsers;
            Users users = new Users();

            if (users.Connect())
            {
                tblUsers = users.GetDataUsers();
                list_staff.DataSource = tblUsers;
                users.Disconnect();


                list_staff.Columns["EmployeeID"].HeaderText = "Mã Nhân Viên";
                list_staff.Columns["EmployeeID"].Width = 80;

                list_staff.Columns["UserRole"].HeaderText = "Loại Nhân Viên";
                list_staff.Columns["UserRole"].Width = 80;

                list_staff.Columns["Username"].HeaderText = "Tên Nhân Viên";
                list_staff.Columns["Username"].Width = 150;

                list_staff  .Columns["UpdatedAt"].HeaderText = "Ngày Thay Đổi";
                list_staff.Columns["UpdatedAt"].Width = 100;

                list_staff.Columns["CreatedAt"].HeaderText = "Ngày Tạo Tài Khoản";
                list_staff.Columns["CreatedAt"].Width = 120;


                BindingData();


                object res = users.UsersExecuteScalar("SELECT COUNT(*) FROM Employees", null, null);
                txt_total.Text = res.ToString();

            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void BindingData()
        {
            txt_namestaff.DataBindings.Clear();
            txt_idstaff.DataBindings.Clear();
            txt_createdate.DataBindings.Clear();
            txt_updatedAt.DataBindings.Clear();
            txt_typestaff.DataBindings.Clear();

            txt_namestaff.DataBindings.Add("text", list_staff.DataSource, "Username");
            txt_idstaff.DataBindings.Add("text", list_staff.DataSource, "EmployeeID");
            txt_typestaff.DataBindings.Add("text", list_staff.DataSource, "UserRole");
            txt_updatedAt.DataBindings.Add("text", list_staff.DataSource, "UpdatedAt");
            txt_createdate.DataBindings.Add("text", list_staff.DataSource, "CreatedAt");


        }

         
         

        private void btn_addstaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AddEmployee form = new Frm_AddEmployee();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

        private void btn_searchstaff_Click(object sender, EventArgs e)
        {
            DataTable tblUsers;
            Users users = new Users();
            if (users.Connect())
            {
                tblUsers = users.SearchUser(txt_searchstaff.Text);
                list_staff.DataSource = tblUsers;
                users.Disconnect();


                list_staff.Columns["EmployeeID"].HeaderText = "Mã Nhân Viên";
                list_staff.Columns["EmployeeID"].Width = 80;

                list_staff.Columns["UserRole"].HeaderText = "Loại Nhân Viên";
                list_staff.Columns["UserRole"].Width = 80;

                list_staff.Columns["Username"].HeaderText = "Tên Nhân Viên";
                list_staff.Columns["Username"].Width = 150;

                list_staff.Columns["UpdatedAt"].HeaderText = "Ngày Thay Đổi";
                list_staff.Columns["UpdatedAt"].Width = 100;

                list_staff.Columns["CreatedAt"].HeaderText = "Ngày Tạo Tài Khoản";
                list_staff.Columns["CreatedAt"].Width = 120;


                BindingData();


                object res = users.UsersExecuteScalar("SELECT COUNT(*) FROM Employees", null, null);
                txt_total.Text = res.ToString();

            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_deletestaff_Click(object sender, EventArgs e)
        {
            if (list_staff.SelectedRows.Count > 0)
            {
                int employeeId = Convert.ToInt32(list_staff.SelectedRows[0].Cells["EmployeeId"].Value);

                if (employeeId == 0)
                {
                    MessageBox.Show("No staff member selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Show confirmation dialog
                DialogResult confirmation = MessageBox.Show(
                    "Are you sure you want to delete this staff member?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmation == DialogResult.Yes)
                {
                    string spName = "sp_DeleteEmployee";
                    string[] parameters = { "@EmployeeId" };
                    object[] values = { employeeId };

                    Products products = new Products();

                    if (products.Connect())
                    {
                        int rec = products.ProductsExecuteNonQuery(spName, parameters, values, true);
                        if (rec > 0)
                        {
                            MessageBox.Show("Staff member deleted successfully.", "Notice", MessageBoxButtons.OK);
                            LoadDataUser();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the staff member.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to connect to the database.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
