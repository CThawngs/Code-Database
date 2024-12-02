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
    public partial class Frm_StaffDetailscs : Form
    {
        private int employeeId;
        private string CurrentUserRole;
        private Timer debounceTimer;
        User user;
        public Frm_StaffDetailscs(int id , string role)
        {
            InitializeComponent();
            this.employeeId = id;
            debounceTimer = new Timer();
            debounceTimer.Interval = 300; 
            debounceTimer.Tick += DebounceTimer_Tick;
            CurrentUserRole = role;
        }
        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            LoadDataStaff();
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frm_StaffDetailscs_Load(object sender, EventArgs e)
        {
            LoadDataStaff();
            if (CurrentUserRole.ToLower() == "admin")
            {
                cb_typestaff.Enabled = true;
            }
            else
            {
                cb_typestaff.Enabled = false;
            }
        }
        private void LoadDataStaff()
        {
            DataTable tblUser;
            user = new User();

            if (user.Connect())
            {
                tblUser = user.GetDataUser(this.employeeId);
                user.Disconnect();

                if (tblUser.Rows.Count > 0)
                {
                    DataRow row = tblUser.Rows[0];  

                    txt_namestaff.Text = row["Username"].ToString();
                    txt_id.Text = row["EmployeeID"].ToString();
                    txt_pass.Text = row["Password"].ToString();

                    string updatedAtString = row["UpdatedAt"].ToString();
                    DateTime changedAtVal = DateTime.Parse(updatedAtString);
                    time_changedate.Value = changedAtVal;

                    string createdDateString = row["CreatedAt"].ToString();
                    DateTime createdAtVal = DateTime.Parse(createdDateString);
                    time_createdate.Value = createdAtVal;

                    string role = row["UserRole"].ToString();

                    if(role.ToLower() == "admin" )
                    {
                        cb_typestaff.SelectedIndex = 0;
                    }
                    else
                    {
                        cb_typestaff.SelectedIndex =1 ;

                    }

                }
                else
                {
                    MessageBox.Show("No product data found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            user = new User();

            

            if (user.Connect())
            {
                string spName = "sp_UpdateEmployee";
                string[] parameters = { "@EmployeeID", "@Username", "@Password", "@UserRole" };

                object[] values = {txt_id.Text,txt_namestaff.Text,txt_pass.Text,cb_typestaff.Text};

                int rec = user.UserExecuteNonQuery(spName, parameters, values, true);

                if (rec > 0)
                {
                    MessageBox.Show("Successful", "Notice", MessageBoxButtons.OK);
                    LoadDataStaff();
                }
                else
                {
                    MessageBox.Show("Failed to update product.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                user.Disconnect();
            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
