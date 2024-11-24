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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_totalexpenditure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_totalrevenue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_typetime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_money = new System.Windows.Forms.DataGridView();
            this.btn_moredetail = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_money)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(463, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 32);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 231);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_totalexpenditure);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(33, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1133, 46);
            this.panel3.TabIndex = 0;
            // 
            // txt_totalexpenditure
            // 
            this.txt_totalexpenditure.Location = new System.Drawing.Point(229, 9);
            this.txt_totalexpenditure.Name = "txt_totalexpenditure";
            this.txt_totalexpenditure.ReadOnly = true;
            this.txt_totalexpenditure.Size = new System.Drawing.Size(741, 30);
            this.txt_totalexpenditure.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng Tiền Chi:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_totalrevenue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(33, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 46);
            this.panel2.TabIndex = 0;
            // 
            // txt_totalrevenue
            // 
            this.txt_totalrevenue.Location = new System.Drawing.Point(229, 9);
            this.txt_totalrevenue.Name = "txt_totalrevenue";
            this.txt_totalrevenue.ReadOnly = true;
            this.txt_totalrevenue.Size = new System.Drawing.Size(741, 30);
            this.txt_totalrevenue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Tiền Thu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_typetime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(33, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 46);
            this.panel1.TabIndex = 0;
            // 
            // cb_typetime
            // 
            this.cb_typetime.FormattingEnabled = true;
            this.cb_typetime.Items.AddRange(new object[] {
            "Năm",
            "Tháng",
            "Tuần"});
            this.cb_typetime.Location = new System.Drawing.Point(229, 7);
            this.cb_typetime.Name = "cb_typetime";
            this.cb_typetime.Size = new System.Drawing.Size(741, 33);
            this.cb_typetime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Thời Gian:";
            // 
            // list_money
            // 
            this.list_money.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_money.Location = new System.Drawing.Point(13, 307);
            this.list_money.Name = "list_money";
            this.list_money.RowHeadersWidth = 62;
            this.list_money.RowTemplate.Height = 28;
            this.list_money.Size = new System.Drawing.Size(1200, 347);
            this.list_money.TabIndex = 8;
            // 
            // btn_moredetail
            // 
            this.btn_moredetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moredetail.Location = new System.Drawing.Point(360, 669);
            this.btn_moredetail.Name = "btn_moredetail";
            this.btn_moredetail.Size = new System.Drawing.Size(228, 51);
            this.btn_moredetail.TabIndex = 9;
            this.btn_moredetail.Text = "Xem Thêm";
            this.btn_moredetail.UseVisualStyleBackColor = true;
            this.btn_moredetail.Click += new System.EventHandler(this.btn_moredetail_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(630, 669);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(228, 51);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Đóng";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Frm_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 740);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_moredetail);
            this.Controls.Add(this.list_money);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Sales";
            this.Text = "Doanh Thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_totalexpenditure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_totalrevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_typetime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView list_money;
        private System.Windows.Forms.Button btn_moredetail;
        private System.Windows.Forms.Button btn_exit;
    }
}