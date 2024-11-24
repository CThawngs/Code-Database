﻿using System;
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
    public partial class Frm_Products : Form
    {
        public Frm_Products()
        {
            InitializeComponent();
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ProductDetails form = new Frm_ProductDetails();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
