namespace Prj_QuanLyBanHang.GUI
{
    partial class Frm_Staff
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
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_updatedAt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_typestaff = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_createdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_idstaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_namestaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_staff = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_searchstaff = new System.Windows.Forms.Button();
            this.txt_searchstaff = new System.Windows.Forms.TextBox();
            this.btn_addstaff = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_fixstaff = new System.Windows.Forms.Button();
            this.btn_deletestaff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_staff)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh Sách Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1064, 135);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_total);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(736, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 37);
            this.panel2.TabIndex = 1;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(158, 6);
            this.txt_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(142, 26);
            this.txt_total.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng nhân viên:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_updatedAt);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(399, 94);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 37);
            this.panel4.TabIndex = 0;
            // 
            // txt_updatedAt
            // 
            this.txt_updatedAt.Location = new System.Drawing.Point(148, 6);
            this.txt_updatedAt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_updatedAt.Name = "txt_updatedAt";
            this.txt_updatedAt.ReadOnly = true;
            this.txt_updatedAt.Size = new System.Drawing.Size(142, 26);
            this.txt_updatedAt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Thay Đổi:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_typestaff);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(736, 40);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(302, 37);
            this.panel6.TabIndex = 0;
            // 
            // txt_typestaff
            // 
            this.txt_typestaff.Location = new System.Drawing.Point(158, 6);
            this.txt_typestaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_typestaff.Name = "txt_typestaff";
            this.txt_typestaff.ReadOnly = true;
            this.txt_typestaff.Size = new System.Drawing.Size(142, 26);
            this.txt_typestaff.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Loại Nhân VIên:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_createdate);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(399, 40);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 37);
            this.panel5.TabIndex = 0;
            // 
            // txt_createdate
            // 
            this.txt_createdate.Location = new System.Drawing.Point(109, 6);
            this.txt_createdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_createdate.Name = "txt_createdate";
            this.txt_createdate.ReadOnly = true;
            this.txt_createdate.Size = new System.Drawing.Size(180, 26);
            this.txt_createdate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Tạo:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_idstaff);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(32, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 37);
            this.panel3.TabIndex = 0;
            // 
            // txt_idstaff
            // 
            this.txt_idstaff.Location = new System.Drawing.Point(148, 7);
            this.txt_idstaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idstaff.Name = "txt_idstaff";
            this.txt_idstaff.ReadOnly = true;
            this.txt_idstaff.Size = new System.Drawing.Size(178, 26);
            this.txt_idstaff.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Nhân Viên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_namestaff);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 37);
            this.panel1.TabIndex = 0;
            // 
            // txt_namestaff
            // 
            this.txt_namestaff.Location = new System.Drawing.Point(148, 7);
            this.txt_namestaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_namestaff.Name = "txt_namestaff";
            this.txt_namestaff.ReadOnly = true;
            this.txt_namestaff.Size = new System.Drawing.Size(178, 26);
            this.txt_namestaff.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_staff);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1064, 310);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhân Viên";
            // 
            // list_staff
            // 
            this.list_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_staff.Location = new System.Drawing.Point(0, 24);
            this.list_staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_staff.MultiSelect = false;
            this.list_staff.Name = "list_staff";
            this.list_staff.RowHeadersWidth = 62;
            this.list_staff.RowTemplate.Height = 28;
            this.list_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_staff.Size = new System.Drawing.Size(1064, 286);
            this.list_staff.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_searchstaff);
            this.groupBox3.Controls.Add(this.txt_searchstaff);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 510);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(407, 70);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo tên nhân viên";
            // 
            // btn_searchstaff
            // 
            this.btn_searchstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchstaff.ForeColor = System.Drawing.Color.Black;
            this.btn_searchstaff.Location = new System.Drawing.Point(303, 24);
            this.btn_searchstaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_searchstaff.Name = "btn_searchstaff";
            this.btn_searchstaff.Size = new System.Drawing.Size(99, 39);
            this.btn_searchstaff.TabIndex = 1;
            this.btn_searchstaff.Text = "Tìm";
            this.btn_searchstaff.UseVisualStyleBackColor = true;
            this.btn_searchstaff.Click += new System.EventHandler(this.btn_searchstaff_Click);
            // 
            // txt_searchstaff
            // 
            this.txt_searchstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchstaff.Location = new System.Drawing.Point(6, 27);
            this.txt_searchstaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_searchstaff.Name = "txt_searchstaff";
            this.txt_searchstaff.Size = new System.Drawing.Size(284, 34);
            this.txt_searchstaff.TabIndex = 0;
            // 
            // btn_addstaff
            // 
            this.btn_addstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addstaff.Location = new System.Drawing.Point(706, 532);
            this.btn_addstaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addstaff.Name = "btn_addstaff";
            this.btn_addstaff.Size = new System.Drawing.Size(116, 39);
            this.btn_addstaff.TabIndex = 12;
            this.btn_addstaff.Text = "Thêm";
            this.btn_addstaff.UseVisualStyleBackColor = true;
            this.btn_addstaff.Click += new System.EventHandler(this.btn_addstaff_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(960, 532);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(116, 39);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Đóng";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_fixstaff
            // 
            this.btn_fixstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fixstaff.Location = new System.Drawing.Point(420, 533);
            this.btn_fixstaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fixstaff.Name = "btn_fixstaff";
            this.btn_fixstaff.Size = new System.Drawing.Size(116, 39);
            this.btn_fixstaff.TabIndex = 13;
            this.btn_fixstaff.Text = "Sửa";
            this.btn_fixstaff.UseVisualStyleBackColor = true;
            this.btn_fixstaff.Click += new System.EventHandler(this.btn_fixstaff_Click);
            // 
            // btn_deletestaff
            // 
            this.btn_deletestaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletestaff.Location = new System.Drawing.Point(828, 532);
            this.btn_deletestaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deletestaff.Name = "btn_deletestaff";
            this.btn_deletestaff.Size = new System.Drawing.Size(116, 39);
            this.btn_deletestaff.TabIndex = 12;
            this.btn_deletestaff.Text = "Xóa";
            this.btn_deletestaff.UseVisualStyleBackColor = true;
            this.btn_deletestaff.Click += new System.EventHandler(this.btn_deletestaff_Click);
            // 
            // Frm_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 590);
            this.Controls.Add(this.btn_fixstaff);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_deletestaff);
            this.Controls.Add(this.btn_addstaff);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Staff";
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Staff_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_staff)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_namestaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_idstaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_updatedAt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_createdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView list_staff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_addstaff;
        private System.Windows.Forms.Button btn_searchstaff;
        private System.Windows.Forms.TextBox txt_searchstaff;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_typestaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_fixstaff;
        private System.Windows.Forms.Button btn_deletestaff;
    }
}