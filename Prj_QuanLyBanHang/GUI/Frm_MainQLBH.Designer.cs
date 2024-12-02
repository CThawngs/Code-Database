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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainQLBH));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lblNumberProducts = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer_usertime = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.system_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.product_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenue_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receipt_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staff_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
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
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Name = "label1";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_time
            // 
            resources.ApplyResources(this.lbl_time, "lbl_time");
            this.lbl_time.Name = "lbl_time";
            // 
            // lblNumberProducts
            // 
            resources.ApplyResources(this.lblNumberProducts, "lblNumberProducts");
            this.lblNumberProducts.Name = "lblNumberProducts";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblSales
            // 
            resources.ApplyResources(this.lblSales, "lblSales");
            this.lblSales.Name = "lblSales";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // piechart
            // 
            chartArea1.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.piechart.Legends.Add(legend1);
            resources.ApplyResources(this.piechart, "piechart");
            this.piechart.Name = "piechart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.piechart.Series.Add(series1);
            // 
            // timer_usertime
            // 
            this.timer_usertime.Tick += new System.EventHandler(this.timer_usertime_Tick);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // system_ToolStripMenuItem
            // 
            this.system_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_ToolStripMenuItem});
            this.system_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.application;
            this.system_ToolStripMenuItem.Name = "system_ToolStripMenuItem";
            resources.ApplyResources(this.system_ToolStripMenuItem, "system_ToolStripMenuItem");
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.close;
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            resources.ApplyResources(this.exit_ToolStripMenuItem, "exit_ToolStripMenuItem");
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // product_ToolStripMenuItem
            // 
            this.product_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.shopping_cart;
            this.product_ToolStripMenuItem.Name = "product_ToolStripMenuItem";
            resources.ApplyResources(this.product_ToolStripMenuItem, "product_ToolStripMenuItem");
            this.product_ToolStripMenuItem.Click += new System.EventHandler(this.product_ToolStripMenuItem_Click);
            // 
            // revenue_ToolStripMenuItem
            // 
            this.revenue_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.dollar;
            this.revenue_ToolStripMenuItem.Name = "revenue_ToolStripMenuItem";
            resources.ApplyResources(this.revenue_ToolStripMenuItem, "revenue_ToolStripMenuItem");
            this.revenue_ToolStripMenuItem.Click += new System.EventHandler(this.revenue_ToolStripMenuItem_Click);
            // 
            // receipt_ToolStripMenuItem1
            // 
            this.receipt_ToolStripMenuItem1.Image = global::Prj_QuanLyBanHang.Properties.Resources.copy;
            this.receipt_ToolStripMenuItem1.Name = "receipt_ToolStripMenuItem1";
            resources.ApplyResources(this.receipt_ToolStripMenuItem1, "receipt_ToolStripMenuItem1");
            this.receipt_ToolStripMenuItem1.Click += new System.EventHandler(this.receipt_ToolStripMenuItem1_Click);
            // 
            // staff_ToolStripMenuItem
            // 
            this.staff_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.staff_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.people;
            this.staff_ToolStripMenuItem.Name = "staff_ToolStripMenuItem";
            resources.ApplyResources(this.staff_ToolStripMenuItem, "staff_ToolStripMenuItem");
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.boss;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            resources.ApplyResources(this.profileToolStripMenuItem, "profileToolStripMenuItem");
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.briefcase;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            resources.ApplyResources(this.quảnLýNhânViênToolStripMenuItem, "quảnLýNhânViênToolStripMenuItem");
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // help_ToolStripMenuItem
            // 
            this.help_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giớiThiệuToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.help_ToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.help_book;
            this.help_ToolStripMenuItem.Name = "help_ToolStripMenuItem";
            resources.ApplyResources(this.help_ToolStripMenuItem, "help_ToolStripMenuItem");
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.about;
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            resources.ApplyResources(this.giớiThiệuToolStripMenuItem, "giớiThiệuToolStripMenuItem");
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Image = global::Prj_QuanLyBanHang.Properties.Resources.help_book_3d;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            resources.ApplyResources(this.hướngDẫnSửDụngToolStripMenuItem, "hướngDẫnSửDụngToolStripMenuItem");
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // Frm_MainQLBH
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label8);
            this.Controls.Add(this.piechart);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumberProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_MainQLBH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_MainQLBH_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lblNumberProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private System.Windows.Forms.Timer timer_usertime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
    }
}