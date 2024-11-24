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
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_idcustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_namecustomer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_idreceipt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_receipt = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cb_typemoney = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_idproduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_totalproduct = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_numberproduct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_idreceiptSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_nameproduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_moredetail = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_receipt)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(440, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Hóa Đơn Bán Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1193, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTime_receipt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(18, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 47);
            this.panel2.TabIndex = 0;
            // 
            // dateTime_receipt
            // 
            this.dateTime_receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTime_receipt.CustomFormat = "dd / MM / yyyy";
            this.dateTime_receipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_receipt.Location = new System.Drawing.Point(185, 9);
            this.dateTime_receipt.Name = "dateTime_receipt";
            this.dateTime_receipt.Size = new System.Drawing.Size(405, 30);
            this.dateTime_receipt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Xuất:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_idcustomer);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(18, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(593, 47);
            this.panel6.TabIndex = 0;
            // 
            // txt_idcustomer
            // 
            this.txt_idcustomer.Location = new System.Drawing.Point(185, 9);
            this.txt_idcustomer.Name = "txt_idcustomer";
            this.txt_idcustomer.ReadOnly = true;
            this.txt_idcustomer.Size = new System.Drawing.Size(405, 30);
            this.txt_idcustomer.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Khách Hàng:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_phonenumber);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(638, 145);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(549, 47);
            this.panel8.TabIndex = 0;
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(185, 9);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.ReadOnly = true;
            this.txt_phonenumber.Size = new System.Drawing.Size(345, 30);
            this.txt_phonenumber.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số Điện Thoại:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_address);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(638, 92);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(549, 47);
            this.panel7.TabIndex = 0;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(185, 9);
            this.txt_address.Name = "txt_address";
            this.txt_address.ReadOnly = true;
            this.txt_address.Size = new System.Drawing.Size(345, 30);
            this.txt_address.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa Chỉ:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_namecustomer);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(638, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(549, 47);
            this.panel5.TabIndex = 0;
            // 
            // txt_namecustomer
            // 
            this.txt_namecustomer.Location = new System.Drawing.Point(185, 9);
            this.txt_namecustomer.Name = "txt_namecustomer";
            this.txt_namecustomer.ReadOnly = true;
            this.txt_namecustomer.Size = new System.Drawing.Size(345, 30);
            this.txt_namecustomer.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Khách Hàng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_idreceipt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 47);
            this.panel1.TabIndex = 0;
            // 
            // txt_idreceipt
            // 
            this.txt_idreceipt.Location = new System.Drawing.Point(185, 9);
            this.txt_idreceipt.Name = "txt_idreceipt";
            this.txt_idreceipt.ReadOnly = true;
            this.txt_idreceipt.Size = new System.Drawing.Size(405, 30);
            this.txt_idreceipt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_receipt);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel12);
            this.groupBox2.Controls.Add(this.panel11);
            this.groupBox2.Controls.Add(this.panel10);
            this.groupBox2.Controls.Add(this.panel13);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1193, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // list_receipt
            // 
            this.list_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_receipt.Location = new System.Drawing.Point(18, 128);
            this.list_receipt.Name = "list_receipt";
            this.list_receipt.RowHeadersWidth = 62;
            this.list_receipt.RowTemplate.Height = 28;
            this.list_receipt.Size = new System.Drawing.Size(1150, 209);
            this.list_receipt.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cb_typemoney);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(796, 38);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(372, 34);
            this.panel9.TabIndex = 0;
            // 
            // cb_typemoney
            // 
            this.cb_typemoney.FormattingEnabled = true;
            this.cb_typemoney.Items.AddRange(new object[] {
            "VNĐ",
            "USD",
            "YÊN Nhật"});
            this.cb_typemoney.Location = new System.Drawing.Point(129, 1);
            this.cb_typemoney.Name = "cb_typemoney";
            this.cb_typemoney.Size = new System.Drawing.Size(228, 33);
            this.cb_typemoney.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(0, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại Tiền:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_idproduct);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(410, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 34);
            this.panel4.TabIndex = 0;
            // 
            // txt_idproduct
            // 
            this.txt_idproduct.Location = new System.Drawing.Point(119, 3);
            this.txt_idproduct.Name = "txt_idproduct";
            this.txt_idproduct.ReadOnly = true;
            this.txt_idproduct.Size = new System.Drawing.Size(238, 30);
            this.txt_idproduct.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Hàng:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txt_totalproduct);
            this.panel12.Controls.Add(this.label13);
            this.panel12.Location = new System.Drawing.Point(796, 90);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(372, 34);
            this.panel12.TabIndex = 0;
            // 
            // txt_totalproduct
            // 
            this.txt_totalproduct.Location = new System.Drawing.Point(129, 3);
            this.txt_totalproduct.Name = "txt_totalproduct";
            this.txt_totalproduct.ReadOnly = true;
            this.txt_totalproduct.Size = new System.Drawing.Size(228, 30);
            this.txt_totalproduct.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(0, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tổng Tiền:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txt_discount);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Location = new System.Drawing.Point(410, 87);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(372, 34);
            this.panel11.TabIndex = 0;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(119, 3);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.ReadOnly = true;
            this.txt_discount.Size = new System.Drawing.Size(238, 30);
            this.txt_discount.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(0, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Giảm Giá:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txt_numberproduct);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Location = new System.Drawing.Point(18, 87);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(372, 34);
            this.panel10.TabIndex = 0;
            // 
            // txt_numberproduct
            // 
            this.txt_numberproduct.Location = new System.Drawing.Point(119, 3);
            this.txt_numberproduct.Name = "txt_numberproduct";
            this.txt_numberproduct.ReadOnly = true;
            this.txt_numberproduct.Size = new System.Drawing.Size(238, 30);
            this.txt_numberproduct.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số Lượng:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btn_search);
            this.panel13.Controls.Add(this.txt_idreceiptSearch);
            this.panel13.Controls.Add(this.label14);
            this.panel13.Location = new System.Drawing.Point(345, 350);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(560, 34);
            this.panel13.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(411, 0);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(130, 34);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_idreceiptSearch
            // 
            this.txt_idreceiptSearch.Location = new System.Drawing.Point(151, 3);
            this.txt_idreceiptSearch.Name = "txt_idreceiptSearch";
            this.txt_idreceiptSearch.Size = new System.Drawing.Size(238, 30);
            this.txt_idreceiptSearch.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(0, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã Hóa Đơn:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_nameproduct);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(18, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 34);
            this.panel3.TabIndex = 0;
            // 
            // txt_nameproduct
            // 
            this.txt_nameproduct.Location = new System.Drawing.Point(119, 3);
            this.txt_nameproduct.Name = "txt_nameproduct";
            this.txt_nameproduct.ReadOnly = true;
            this.txt_nameproduct.Size = new System.Drawing.Size(238, 30);
            this.txt_nameproduct.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Hàng:";
            // 
            // btn_moredetail
            // 
            this.btn_moredetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moredetail.Location = new System.Drawing.Point(368, 667);
            this.btn_moredetail.Name = "btn_moredetail";
            this.btn_moredetail.Size = new System.Drawing.Size(232, 55);
            this.btn_moredetail.TabIndex = 2;
            this.btn_moredetail.Text = "Xem Thêm";
            this.btn_moredetail.UseVisualStyleBackColor = true;
            this.btn_moredetail.Click += new System.EventHandler(this.btn_fixreceipt_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(620, 667);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(232, 55);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Đóng";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Frm_Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 743);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_moredetail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Receipts";
            this.Text = "Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_receipt)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_idcustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_namecustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_nameproduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_idproduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txt_totalproduct;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txt_numberproduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView list_receipt;
        private System.Windows.Forms.ComboBox cb_typemoney;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_idreceiptSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_moredetail;
        private System.Windows.Forms.Button btn_exit;
    }
}