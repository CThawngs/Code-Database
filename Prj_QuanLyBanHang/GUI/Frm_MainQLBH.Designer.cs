namespace Prj_QuanLyBanHang.GUI
{
    partial class Frm_MainQLBH
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.system_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.product_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenue_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receipt_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staff_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.system_ToolStripMenuItem,
            this.product_ToolStripMenuItem,
            this.revenue_ToolStripMenuItem,
            this.receipt_ToolStripMenuItem1,
            this.staff_ToolStripMenuItem,
            this.help_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1179, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // system_ToolStripMenuItem
            // 
            this.system_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_ToolStripMenuItem});
            this.system_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.application;
            this.system_ToolStripMenuItem.Name = "system_ToolStripMenuItem";
            this.system_ToolStripMenuItem.Size = new System.Drawing.Size(112, 28);
            this.system_ToolStripMenuItem.Text = "Hệ Thống";
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.close;
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.exit_ToolStripMenuItem.Text = "Thoát";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // product_ToolStripMenuItem
            // 
            this.product_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.shopping_cart;
            this.product_ToolStripMenuItem.Name = "product_ToolStripMenuItem";
            this.product_ToolStripMenuItem.Size = new System.Drawing.Size(112, 28);
            this.product_ToolStripMenuItem.Text = "Sản Phẩm";
            this.product_ToolStripMenuItem.Click += new System.EventHandler(this.product_ToolStripMenuItem_Click);
            // 
            // revenue_ToolStripMenuItem
            // 
            this.revenue_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.dollar;
            this.revenue_ToolStripMenuItem.Name = "revenue_ToolStripMenuItem";
            this.revenue_ToolStripMenuItem.Size = new System.Drawing.Size(119, 28);
            this.revenue_ToolStripMenuItem.Text = "Doanh Thu";
            this.revenue_ToolStripMenuItem.Click += new System.EventHandler(this.revenue_ToolStripMenuItem_Click);
            // 
            // receipt_ToolStripMenuItem1
            // 
            this.receipt_ToolStripMenuItem1.Image = global::Prj_QuanLyBanHang.Properties.Resources.copy;
            this.receipt_ToolStripMenuItem1.Name = "receipt_ToolStripMenuItem1";
            this.receipt_ToolStripMenuItem1.Size = new System.Drawing.Size(107, 28);
            this.receipt_ToolStripMenuItem1.Text = "Hóa Đơn";
            this.receipt_ToolStripMenuItem1.Click += new System.EventHandler(this.receipt_ToolStripMenuItem1_Click);
            // 
            // staff_ToolStripMenuItem
            // 
            this.staff_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.staff_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.people;
            this.staff_ToolStripMenuItem.Name = "staff_ToolStripMenuItem";
            this.staff_ToolStripMenuItem.Size = new System.Drawing.Size(115, 28);
            this.staff_ToolStripMenuItem.Text = "Nhân Viên";
            this.staff_ToolStripMenuItem.Click += new System.EventHandler(this.user_ToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.profileToolStripMenuItem.Text = "Profile hiện hành";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            // 
            // help_ToolStripMenuItem
            // 
            this.help_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.help_book;
            this.help_ToolStripMenuItem.Name = "help_ToolStripMenuItem";
            this.help_ToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.help_ToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // Frm_MainQLBH
            // 
            this.ClientSize = new System.Drawing.Size(1203, 672);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_MainQLBH";
            this.Text = "Quản Lý Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem product_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenue_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receipt_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staff_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem system_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
    }
}