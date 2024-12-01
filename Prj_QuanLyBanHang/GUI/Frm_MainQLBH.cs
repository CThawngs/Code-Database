using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_QuanLyBanHang.GUI
{
    public partial class Frm_MainQLBH : Form
    {
        private string userRole;
        private int userId;

        public Frm_MainQLBH(string role, int id)
        {
            InitializeComponent();
            this.userRole = role;
            this.userId = id;
        }

        private void product_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Products form = new Frm_Products();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void receipt_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Receipts form = new Frm_Receipts();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

        private void revenue_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Sales form = new Frm_Sales();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

         

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Staff form = new Frm_Staff();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

        private void Frm_MainQLBH_Load(object sender, EventArgs e)
        {
            if( userRole.ToLower() == "admin")
            {
                quảnLýNhânViênToolStripMenuItem.Visible = true;
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_StaffDetailscs form = new Frm_StaffDetailscs(userId);

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }
    }
}
