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
    public partial class Frm_SalesDetails : Form
    {
        private int SalesId;
        SalesDetails salesDetails;
        public Frm_SalesDetails(int salesId)
        {
            InitializeComponent();
            SalesId = salesId;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frm_SalesDetails_Load(object sender, EventArgs e)
        {
            LoadDataSales();
        }
        private void LoadDataSales()
        {
            DataTable tblSales;
            salesDetails = new SalesDetails();

            if (salesDetails.Connect())
            {
                tblSales = salesDetails.GetDataSales(SalesId);
                salesDetails.Disconnect();

                if (tblSales.Rows.Count > 0)
                {
                    DataRow row = tblSales.Rows[0]; // Get the first row

                    txt_id.Text = row["SalesID"].ToString();
                    txt_totalrevenue.Text = row["TotalIncome"].ToString();

                    dateTime_UpdatedAt.Text = Convert.ToDateTime(row["UpdatedAt"]).ToString("yyyy-MM-dd");
                    dateTime_CreatedAt.Text = Convert.ToDateTime(row["CreatedAt"]).ToString("yyyy-MM-dd");



                    DataTable tblReceipts;
                    tblReceipts = salesDetails.GetReceiptsFromSales(SalesId);
                    list_receipt.DataSource = tblReceipts;
                    txt_receiptsNumber.Text = tblReceipts.Rows.Count.ToString();
                    BindingDataReceipts();

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
        private void BindingDataReceipts()
        {
            txt_receiptsId.DataBindings.Clear();
            txt_totalReceipts.DataBindings.Clear();

            txt_receiptsId.DataBindings.Add("text", list_receipt.DataSource, "ReceiptID");
            txt_totalReceipts.DataBindings.Add("text", list_receipt.DataSource, "TotalPrice");


        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_receiptsId.Text))
            {
                this.Hide();
                Frm_ReceiptDetails form = new Frm_ReceiptDetails(int.Parse(txt_receiptsId.Text));

                form.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a receipt", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
