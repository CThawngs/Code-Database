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
    public partial class Frm_ReceiptDetails : Form
    {
        private int ReceiptId;
        Receipt receipt;

        public Frm_ReceiptDetails(int receiptId)
        {
            InitializeComponent();
            ReceiptId = receiptId;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frm_ReceiptDetails_Load(object sender, EventArgs e)
        {
            LoadDataReceipt();
        }
        private void LoadDataReceipt()
        {
            DataTable tblReceipt;
            receipt = new Receipt();

            if (receipt.Connect())
            {
                tblReceipt = receipt.GetDataReceipt(ReceiptId);
                receipt.Disconnect();

                if (tblReceipt.Rows.Count > 0)
                {
                    DataRow row = tblReceipt.Rows[0]; // Get the first row

                    txt_idreceipt.Text = row["ReceiptID"].ToString();
                    txt_method.Text = row["PaymentMethod"].ToString();
                    txt_totalproduct.Text = row["TotalPrice"].ToString();
                    txt_tax.Text = row["Tax"].ToString();

                    dateTime_UpdatedAt.Text = Convert.ToDateTime(row["UpdatedAt"]).ToString("yyyy-MM-dd");
                    dateTime_CreatedAt.Text = Convert.ToDateTime(row["CreatedAt"]).ToString("yyyy-MM-dd");
                    dateTime_transaction.Text = Convert.ToDateTime(row["TransactionDate"]).ToString("yyyy-MM-dd");



                    DataTable tblProducts;
                    tblProducts = receipt.GetDataProductsReceipt(ReceiptId);
                    list_products.DataSource = tblProducts;
                    txt_numberproduct.Text = tblProducts.Rows.Count.ToString();
                }
                else
                {
                    MessageBox.Show("No product data found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
