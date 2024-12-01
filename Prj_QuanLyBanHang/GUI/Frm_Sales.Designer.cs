namespace Prj_QuanLyBanHang.GUI
{
    partial class Frm_Sales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_totalrevenue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_typetime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_moredetail = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.chart_sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(412, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh Mục Doanh Thu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1067, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_id);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(29, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 37);
            this.panel3.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(204, 7);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(659, 26);
            this.txt_id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Doanh Thu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_totalrevenue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(29, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 37);
            this.panel2.TabIndex = 0;
            // 
            // txt_totalrevenue
            // 
            this.txt_totalrevenue.Location = new System.Drawing.Point(204, 7);
            this.txt_totalrevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_totalrevenue.Name = "txt_totalrevenue";
            this.txt_totalrevenue.ReadOnly = true;
            this.txt_totalrevenue.Size = new System.Drawing.Size(659, 26);
            this.txt_totalrevenue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Tiền Thu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_typetime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(29, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 37);
            this.panel1.TabIndex = 0;
            // 
            // cb_typetime
            // 
            this.cb_typetime.FormattingEnabled = true;
            this.cb_typetime.Items.AddRange(new object[] {
            "Mỗi Năm",
            "Mỗi Tháng",
            "Mỗi Tuần",
            "Mỗi Ngày"});
            this.cb_typetime.Location = new System.Drawing.Point(204, 6);
            this.cb_typetime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_typetime.Name = "cb_typetime";
            this.cb_typetime.Size = new System.Drawing.Size(659, 28);
            this.cb_typetime.TabIndex = 1;
            this.cb_typetime.SelectedIndexChanged += new System.EventHandler(this.cb_typetime_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Thời Gian:";
            // 
            // btn_moredetail
            // 
            this.btn_moredetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moredetail.Location = new System.Drawing.Point(320, 535);
            this.btn_moredetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_moredetail.Name = "btn_moredetail";
            this.btn_moredetail.Size = new System.Drawing.Size(203, 41);
            this.btn_moredetail.TabIndex = 9;
            this.btn_moredetail.Text = "Xem Thêm";
            this.btn_moredetail.UseVisualStyleBackColor = true;
            this.btn_moredetail.Click += new System.EventHandler(this.btn_moredetail_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(560, 535);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(203, 41);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Đóng";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // chart_sales
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_sales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_sales.Legends.Add(legend1);
            this.chart_sales.Location = new System.Drawing.Point(76, 290);
            this.chart_sales.Name = "chart_sales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_sales.Series.Add(series1);
            this.chart_sales.Size = new System.Drawing.Size(958, 224);
            this.chart_sales.TabIndex = 10;
            this.chart_sales.Text = "chart1";
            this.chart_sales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart_sales_MouseClick);
            // 
            // Frm_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 592);
            this.Controls.Add(this.chart_sales);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_moredetail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Sales";
            this.Text = "Doanh Thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_totalrevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_typetime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_moredetail;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sales;
    }
}