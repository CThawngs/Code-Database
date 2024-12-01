namespace Prj_QuanLyBanHang.GUI
{
    partial class Frm_Receipts
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTime_receipt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_idreceiptSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_idreceipt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_receipt = new System.Windows.Forms.DataGridView();
            this.btn_moredetail = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_receipt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(391, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Hóa Đơn Bán Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel13);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(11, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1060, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTime_receipt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(16, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 38);
            this.panel2.TabIndex = 0;
            // 
            // dateTime_receipt
            // 
            this.dateTime_receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime_receipt.CustomFormat = "dd / MM / yyyy";
            this.dateTime_receipt.Enabled = false;
            this.dateTime_receipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_receipt.Location = new System.Drawing.Point(164, 7);
            this.dateTime_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_receipt.Name = "dateTime_receipt";
            this.dateTime_receipt.Size = new System.Drawing.Size(360, 26);
            this.dateTime_receipt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Xuất:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_method);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(567, 116);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(488, 38);
            this.panel8.TabIndex = 0;
            // 
            // txt_method
            // 
            this.txt_method.Enabled = false;
            this.txt_method.Location = new System.Drawing.Point(164, 7);
            this.txt_method.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_method.Name = "txt_method";
            this.txt_method.ReadOnly = true;
            this.txt_method.Size = new System.Drawing.Size(307, 26);
            this.txt_method.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Phương Pháp:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_tax);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(567, 74);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(488, 38);
            this.panel7.TabIndex = 0;
            // 
            // txt_tax
            // 
            this.txt_tax.Enabled = false;
            this.txt_tax.Location = new System.Drawing.Point(164, 7);
            this.txt_tax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.ReadOnly = true;
            this.txt_tax.Size = new System.Drawing.Size(307, 26);
            this.txt_tax.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thuế:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btn_search);
            this.panel13.Controls.Add(this.txt_idreceiptSearch);
            this.panel13.Controls.Add(this.label14);
            this.panel13.Location = new System.Drawing.Point(16, 127);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(527, 27);
            this.panel13.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(408, -1);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(116, 27);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_idreceiptSearch
            // 
            this.txt_idreceiptSearch.Location = new System.Drawing.Point(134, 2);
            this.txt_idreceiptSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idreceiptSearch.Name = "txt_idreceiptSearch";
            this.txt_idreceiptSearch.Size = new System.Drawing.Size(212, 26);
            this.txt_idreceiptSearch.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(0, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã Hóa Đơn:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_total);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(567, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(488, 38);
            this.panel5.TabIndex = 0;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(164, 7);
            this.txt_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(307, 26);
            this.txt_total.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_idreceipt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 38);
            this.panel1.TabIndex = 0;
            // 
            // txt_idreceipt
            // 
            this.txt_idreceipt.Enabled = false;
            this.txt_idreceipt.Location = new System.Drawing.Point(164, 7);
            this.txt_idreceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idreceipt.Name = "txt_idreceipt";
            this.txt_idreceipt.ReadOnly = true;
            this.txt_idreceipt.Size = new System.Drawing.Size(360, 26);
            this.txt_idreceipt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // list_receipt
            // 
            this.list_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_receipt.Location = new System.Drawing.Point(35, 265);
            this.list_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_receipt.Name = "list_receipt";
            this.list_receipt.ReadOnly = true;
            this.list_receipt.RowHeadersWidth = 62;
            this.list_receipt.RowTemplate.Height = 28;
            this.list_receipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_receipt.Size = new System.Drawing.Size(1022, 167);
            this.list_receipt.TabIndex = 1;
            // 
            // btn_moredetail
            // 
            this.btn_moredetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moredetail.Location = new System.Drawing.Point(362, 527);
            this.btn_moredetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_moredetail.Name = "btn_moredetail";
            this.btn_moredetail.Size = new System.Drawing.Size(206, 44);
            this.btn_moredetail.TabIndex = 2;
            this.btn_moredetail.Text = "Xem Thêm";
            this.btn_moredetail.UseVisualStyleBackColor = true;
            this.btn_moredetail.Click += new System.EventHandler(this.btn_fixreceipt_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(586, 527);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(206, 44);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Đóng";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Frm_Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 594);
            this.Controls.Add(this.list_receipt);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_moredetail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Receipts";
            this.Text = "Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Receipts_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_receipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_idreceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTime_receipt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView list_receipt;
        private System.Windows.Forms.Button btn_moredetail;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_idreceiptSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label6;
    }
}