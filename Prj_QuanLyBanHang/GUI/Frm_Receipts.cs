using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_QuanLyBanHang.BLL;

namespace Prj_QuanLyBanHang.GUI
{
    public partial class Frm_Receipts : Form
    {
        public Frm_Receipts()
        {
            InitializeComponent();
        }

        private void btn_fixreceipt_Click(object sender, EventArgs e)
        {
            if (list_receipt.SelectedRows.Count > 0)
            {
                int receiptID = Convert.ToInt32(list_receipt.SelectedRows[0].Cells["ReceiptID"].Value);

                if (receiptID == 0)
                {
                    MessageBox.Show("No products selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Hide();
                Frm_ReceiptDetails form = new Frm_ReceiptDetails(receiptID);

                form.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frm_Receipts_Load(object sender, EventArgs e)
        {
            LoadDataReceipts();
        }
        private void LoadDataReceipts()
        {
            DataTable tblReceipts;
            Receipts receipts = new Receipts();

            if (receipts.Connect())
            {
                tblReceipts = receipts.GetDataReceipts();
                list_receipt.DataSource = tblReceipts;
                receipts.Disconnect();

                SetStyle();
                BindingData();
 
            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SetStyle()
        {
            list_receipt.Columns["ReceiptID"].HeaderText = "ID hóa đơn";
            list_receipt.Columns["ReceiptID"].Width = 80;

            list_receipt.Columns["TotalPrice"].HeaderText = "Tổng tiền";
            list_receipt.Columns["TotalPrice"].Width = 100;

            list_receipt.Columns["Tax"].HeaderText = "Thuế";
            list_receipt.Columns["Tax"].Width = 80;

            list_receipt.Columns["PaymentMethod"].HeaderText = "Phương thức thanh toán";
            list_receipt.Columns["PaymentMethod"].Width = 150;

            list_receipt.Columns["TransactionDate"].HeaderText = "Ngày giao dịch";
            list_receipt.Columns["TransactionDate"].Width = 120;

            list_receipt.Columns["UpdatedAt"].HeaderText = "Cập nhật lần cuối";
            list_receipt.Columns["UpdatedAt"].Width = 140;

            list_receipt.Columns["CreatedAt"].HeaderText = "Ngày tạo";
            list_receipt.Columns["CreatedAt"].Width = 120;




        }
        private void BindingData()
        {
            txt_idreceipt.DataBindings.Clear();
            txt_method.DataBindings.Clear();
            txt_tax.DataBindings.Clear();
            txt_total.DataBindings.Clear();
            dateTime_receipt.DataBindings.Clear();

            txt_idreceipt.DataBindings.Add("Text", list_receipt.DataSource, "ReceiptID");
            txt_method.DataBindings.Add("Text", list_receipt.DataSource, "PaymentMethod");
            txt_tax.DataBindings.Add("Text", list_receipt.DataSource, "Tax");
            txt_total.DataBindings.Add("Text", list_receipt.DataSource, "TotalPrice");
            dateTime_receipt.DataBindings.Add("Value", list_receipt.DataSource, "TransactionDate");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable tblReceipts;
            Receipts receipts = new Receipts();

            if (string.IsNullOrEmpty(txt_idreceiptSearch.Text))
            {
                LoadDataReceipts();
                return;
            }

            if (!int.TryParse(txt_idreceiptSearch.Text, out int receiptSearchId))
            {
                MessageBox.Show("Please enter a valid receipt ID (integer).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            if (receipts.Connect())
            {
                tblReceipts = receipts.SearchReceipts(receiptSearchId);
                list_receipt.DataSource = tblReceipts;
                receipts.Disconnect();

                SetStyle();
                BindingData();
            }
            else
            {
                MessageBox.Show("Failed to connect to database.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
