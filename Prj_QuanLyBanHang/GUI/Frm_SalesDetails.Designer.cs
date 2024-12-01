namespace Prj_QuanLyBanHang.GUI
{
    partial class Frm_SalesDetails
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_totalrevenue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_details = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_receipt = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_receiptsNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime_CreatedAt = new System.Windows.Forms.DateTimePicker();
            this.dateTime_UpdatedAt = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_receiptsId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_totalReceipts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_receipt)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(418, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chi Tiết Doanh Thu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_totalrevenue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(38, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 65);
            this.panel2.TabIndex = 8;
            // 
            // txt_totalrevenue
            // 
            this.txt_totalrevenue.Enabled = false;
            this.txt_totalrevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalrevenue.Location = new System.Drawing.Point(228, 18);
            this.txt_totalrevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_totalrevenue.Name = "txt_totalrevenue";
            this.txt_totalrevenue.Size = new System.Drawing.Size(767, 34);
            this.txt_totalrevenue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Tiền Thu:";
            // 
            // btn_details
            // 
            this.btn_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details.Location = new System.Drawing.Point(414, 546);
            this.btn_details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(183, 36);
            this.btn_details.TabIndex = 9;
            this.btn_details.Text = "Xem chi tiết";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(633, 546);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 36);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Đóng";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.list_receipt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1074, 261);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // list_receipt
            // 
            this.list_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_receipt.Enabled = false;
            this.list_receipt.Location = new System.Drawing.Point(6, 23);
            this.list_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_receipt.MultiSelect = false;
            this.list_receipt.Name = "list_receipt";
            this.list_receipt.RowHeadersWidth = 62;
            this.list_receipt.RowTemplate.Height = 28;
            this.list_receipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_receipt.Size = new System.Drawing.Size(502, 210);
            this.list_receipt.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_receiptsNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(556, 139);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 65);
            this.panel1.TabIndex = 9;
            // 
            // txt_receiptsNumber
            // 
            this.txt_receiptsNumber.Enabled = false;
            this.txt_receiptsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_receiptsNumber.Location = new System.Drawing.Point(232, 21);
            this.txt_receiptsNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_receiptsNumber.Name = "txt_receiptsNumber";
            this.txt_receiptsNumber.Size = new System.Drawing.Size(245, 34);
            this.txt_receiptsNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng hóa đơn:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTime_CreatedAt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(38, 208);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 65);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(59, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Tạo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTime_UpdatedAt);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(556, 208);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 65);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Cập Nhật:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_id);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(38, 139);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(501, 65);
            this.panel5.TabIndex = 10;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(198, 21);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(284, 34);
            this.txt_id.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Doanh Thu:";
            // 
            // dateTime_CreatedAt
            // 
            this.dateTime_CreatedAt.Enabled = false;
            this.dateTime_CreatedAt.Location = new System.Drawing.Point(198, 26);
            this.dateTime_CreatedAt.Name = "dateTime_CreatedAt";
            this.dateTime_CreatedAt.Size = new System.Drawing.Size(284, 22);
            this.dateTime_CreatedAt.TabIndex = 1;
            // 
            // dateTime_UpdatedAt
            // 
            this.dateTime_UpdatedAt.Enabled = false;
            this.dateTime_UpdatedAt.Location = new System.Drawing.Point(232, 26);
            this.dateTime_UpdatedAt.Name = "dateTime_UpdatedAt";
            this.dateTime_UpdatedAt.Size = new System.Drawing.Size(245, 22);
            this.dateTime_UpdatedAt.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_receiptsId);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(515, 23);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(518, 65);
            this.panel6.TabIndex = 10;
            // 
            // txt_receiptsId
            // 
            this.txt_receiptsId.Enabled = false;
            this.txt_receiptsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_receiptsId.Location = new System.Drawing.Point(261, 21);
            this.txt_receiptsId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_receiptsId.Name = "txt_receiptsId";
            this.txt_receiptsId.Size = new System.Drawing.Size(245, 34);
            this.txt_receiptsId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(81, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Hóa Đơn:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_totalReceipts);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(515, 101);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(518, 65);
            this.panel7.TabIndex = 11;
            // 
            // txt_totalReceipts
            // 
            this.txt_totalReceipts.Enabled = false;
            this.txt_totalReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalReceipts.Location = new System.Drawing.Point(263, 21);
            this.txt_totalReceipts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_totalReceipts.Name = "txt_totalReceipts";
            this.txt_totalReceipts.Size = new System.Drawing.Size(243, 34);
            this.txt_totalReceipts.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng Tiền Hóa Đơn:";
            // 
            // Frm_SalesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 593);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_SalesDetails";
            this.Text = "Chi Tiết Doanh Thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_SalesDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_receipt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_totalrevenue;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView list_receipt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_receiptsNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTime_CreatedAt;
        private System.Windows.Forms.DateTimePicker dateTime_UpdatedAt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_totalReceipts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_receiptsId;
        private System.Windows.Forms.Label label7;
    }
}