namespace Prj_QuanLyBanHang.GUI
{
    partial class Frm_ReceiptDetails
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
            this.label9 = new System.Windows.Forms.Label();
            this.txt_totalproduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_numberproduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_idreceipt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTime_transaction = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.list_of_products = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime_UpdatedAt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dateTime_CreatedAt = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_products)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(572, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Chi Tiết Hóa Đơn";
            // 
            // txt_totalproduct
            // 
            this.txt_totalproduct.Enabled = false;
            this.txt_totalproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalproduct.Location = new System.Drawing.Point(28, 35);
            this.txt_totalproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_totalproduct.Name = "txt_totalproduct";
            this.txt_totalproduct.Size = new System.Drawing.Size(406, 38);
            this.txt_totalproduct.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng Tiền:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_totalproduct);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(37, 124);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(463, 80);
            this.panel5.TabIndex = 7;
            // 
            // txt_numberproduct
            // 
            this.txt_numberproduct.Enabled = false;
            this.txt_numberproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberproduct.Location = new System.Drawing.Point(28, 35);
            this.txt_numberproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_numberproduct.Name = "txt_numberproduct";
            this.txt_numberproduct.Size = new System.Drawing.Size(406, 38);
            this.txt_numberproduct.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_numberproduct);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(577, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 80);
            this.panel3.TabIndex = 9;
            // 
            // txt_idreceipt
            // 
            this.txt_idreceipt.Enabled = false;
            this.txt_idreceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idreceipt.Location = new System.Drawing.Point(28, 35);
            this.txt_idreceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idreceipt.Name = "txt_idreceipt";
            this.txt_idreceipt.Size = new System.Drawing.Size(406, 38);
            this.txt_idreceipt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_idreceipt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(37, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 80);
            this.panel2.TabIndex = 10;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(748, 538);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(126, 38);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Đóng";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_method);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(577, 159);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 80);
            this.panel4.TabIndex = 10;
            // 
            // txt_method
            // 
            this.txt_method.Enabled = false;
            this.txt_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_method.Location = new System.Drawing.Point(28, 35);
            this.txt_method.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(406, 38);
            this.txt_method.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phương Pháp Thanh Toán:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_tax);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(37, 208);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(463, 80);
            this.panel6.TabIndex = 12;
            // 
            // txt_tax
            // 
            this.txt_tax.Enabled = false;
            this.txt_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tax.Location = new System.Drawing.Point(28, 40);
            this.txt_tax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(406, 38);
            this.txt_tax.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thuế:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dateTime_transaction);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(577, 259);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(463, 80);
            this.panel7.TabIndex = 13;
            // 
            // dateTime_transaction
            // 
            this.dateTime_transaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime_transaction.CustomFormat = "dd / MM / yyyy";
            this.dateTime_transaction.Enabled = false;
            this.dateTime_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_transaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_transaction.Location = new System.Drawing.Point(28, 35);
            this.dateTime_transaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_transaction.Name = "dateTime_transaction";
            this.dateTime_transaction.Size = new System.Drawing.Size(406, 38);
            this.dateTime_transaction.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Xuất:";
            // 
            // list_of_products
            // 
            this.list_of_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_of_products.Location = new System.Drawing.Point(37, 316);
            this.list_of_products.Name = "list_of_products";
            this.list_of_products.ReadOnly = true;
            this.list_of_products.RowHeadersWidth = 51;
            this.list_of_products.RowTemplate.Height = 24;
            this.list_of_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_of_products.Size = new System.Drawing.Size(463, 260);
            this.list_of_products.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTime_UpdatedAt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(577, 343);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 80);
            this.panel1.TabIndex = 13;
            // 
            // dateTime_UpdatedAt
            // 
            this.dateTime_UpdatedAt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime_UpdatedAt.CustomFormat = "dd / MM / yyyy";
            this.dateTime_UpdatedAt.Enabled = false;
            this.dateTime_UpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_UpdatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_UpdatedAt.Location = new System.Drawing.Point(28, 35);
            this.dateTime_UpdatedAt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_UpdatedAt.Name = "dateTime_UpdatedAt";
            this.dateTime_UpdatedAt.Size = new System.Drawing.Size(406, 38);
            this.dateTime_UpdatedAt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Cập Nhật";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dateTime_CreatedAt);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(577, 436);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(463, 80);
            this.panel8.TabIndex = 14;
            // 
            // dateTime_CreatedAt
            // 
            this.dateTime_CreatedAt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime_CreatedAt.CustomFormat = "dd / MM / yyyy";
            this.dateTime_CreatedAt.Enabled = false;
            this.dateTime_CreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_CreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_CreatedAt.Location = new System.Drawing.Point(28, 35);
            this.dateTime_CreatedAt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_CreatedAt.Name = "dateTime_CreatedAt";
            this.dateTime_CreatedAt.Size = new System.Drawing.Size(406, 38);
            this.dateTime_CreatedAt.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Tạo:";
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(577, 538);
            this.btn_report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(165, 38);
            this.btn_report.TabIndex = 15;
            this.btn_report.Text = "Báo Biểu";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Frm_ReceiptDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 597);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.list_of_products);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_exit);
            this.Name = "Frm_ReceiptDetails";
            this.Text = "Chi Tiết Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ReceiptDetails_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_totalproduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_numberproduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_idreceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dateTime_transaction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView list_of_products;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTime_UpdatedAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker dateTime_CreatedAt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_report;
    }
}