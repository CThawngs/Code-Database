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
            this.product_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sales_figures_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receipt_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.system_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.system_ToolStripMenuItem,
            this.product_ToolStripMenuItem,
            this.sales_figures_ToolStripMenuItem,
            this.receipt_ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // product_ToolStripMenuItem
            // 
            this.product_ToolStripMenuItem.Name = "product_ToolStripMenuItem";
            this.product_ToolStripMenuItem.Size = new System.Drawing.Size(107, 30);
            this.product_ToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // sales_figures_ToolStripMenuItem
            // 
            this.sales_figures_ToolStripMenuItem.Name = "sales_figures_ToolStripMenuItem";
            this.sales_figures_ToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.sales_figures_ToolStripMenuItem.Text = "Số Liệu Bán Hàng";
            // 
            // receipt_ToolStripMenuItem1
            // 
            this.receipt_ToolStripMenuItem1.Name = "receipt_ToolStripMenuItem1";
            this.receipt_ToolStripMenuItem1.Size = new System.Drawing.Size(100, 30);
            this.receipt_ToolStripMenuItem1.Text = "Hóa Đơn";
            // 
            // system_ToolStripMenuItem
            // 
            this.system_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_ToolStripMenuItem});
            this.system_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.application;
            this.system_ToolStripMenuItem.Name = "system_ToolStripMenuItem";
            this.system_ToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.system_ToolStripMenuItem.Text = "Hệ Thống";
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.close;
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.Exit_ToolStripMenuItem.Text = "Thoát";
            // 
            // Frm_MainQLBH
            // 
            this.ClientSize = new System.Drawing.Size(1224, 739);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_MainQLBH";
            this.Text = "Form Quản Lý Bán Hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem system_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem product_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sales_figures_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receipt_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
    }
}