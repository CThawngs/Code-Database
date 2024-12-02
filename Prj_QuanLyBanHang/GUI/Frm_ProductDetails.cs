using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_QuanLyBanHang.BLL;

namespace Prj_QuanLyBanHang.GUI
{
    public partial class Frm_ProductDetails : Form
    {
        private int ProductId;
        private Timer debounceTimer;
        Product product;
        public Frm_ProductDetails(int ProductId)
        {
            InitializeComponent();
            this.ProductId = ProductId;
            debounceTimer = new Timer();
            debounceTimer.Interval = 300;  
            debounceTimer.Tick += DebounceTimer_Tick;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frm_ProductDetails_Load(object sender, EventArgs e)
        {
            LoadDataProduct();
        }

        private void LoadDataProduct()
        {
            DataTable tblProduct;
             product = new Product();

            if (product.Connect())
            {
                tblProduct = product.GetDataProduct(this.ProductId);
                product.Disconnect();

                if (tblProduct.Rows.Count > 0)
                {
                    DataRow row = tblProduct.Rows[0];  

                    txt_nameofproduct.Text = row["ProductName"].ToString();
                    txt_price.Text = row["Price"].ToString();
                    txt_brand.Text = row["Brand"].ToString();
                    txt_id.Text = row["ProductID"].ToString();
                    txt_manufacturingdate.Text = Convert.ToDateTime(row["ManufacturingDate"]).ToString("yyyy-MM-dd");
                    txt_expirydate.Text = Convert.ToDateTime(row["ExpiryDate"]).ToString("yyyy-MM-dd");
                    txt_ingredient.Text = row["Ingredients"].ToString();
                    txt_stockQuantity.Text = row["StockQuantity"].ToString();
                    cmb_category.SelectedItem = row["CategoryName"].ToString();
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


        private void button1_Click(object sender, EventArgs e)
        {
            // Restart the Timer on button click
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            // Stop the Timer to prevent multiple triggers
            debounceTimer.Stop();

            // Call the method after debounce delay
            LoadDataProduct();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int productId, stockQuantity;
            double price;
            DateTime manufacturingDate, expiryDate;
            product = new Product();

            if (!int.TryParse(txt_id.Text, out productId))
            {
                MessageBox.Show("Invalid Product ID. Please enter a numeric value.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Price
            if (!double.TryParse(txt_price.Text, out price))
            {
                MessageBox.Show("Invalid Price. Please enter a numeric value with decimals.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Stock Quantity
            if (!int.TryParse(txt_stockQuantity.Text, out stockQuantity))
            {
                MessageBox.Show("Invalid Stock Quantity. Please enter a numeric value.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Dates
            if (!DateTime.TryParse(txt_manufacturingdate.Text, out manufacturingDate))
            {
                MessageBox.Show("Invalid Manufacturing Date. Please use a valid date format (yyyy-MM-dd).", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(txt_expirydate.Text, out expiryDate))
            {
                MessageBox.Show("Invalid Expiry Date. Please use a valid date format (yyyy-MM-dd).", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (product.Connect())
            {
                string spName = "sp_UpdateProduct";
                string[] parameters ={"@ProductID","@ProductName","@CategoryName","@Price","@Brand","@ManufacturingDate","@ExpiryDate","@Ingredients","@StockQuantity"};

                object[] values = {
    productId,
    txt_nameofproduct.Text,
    cmb_category.Text,
    price,
    txt_brand.Text,
    manufacturingDate,
    expiryDate,
    txt_ingredient.Text,
    stockQuantity
};

                int rec = product.ProductExecuteNonQuery(spName,parameters,values,true);

                if(rec > 0)
                {
                    MessageBox.Show("Successful", "Notice", MessageBoxButtons.OK);
                    LoadDataProduct();
                }
                else
                {
                    MessageBox.Show("Failed to update product.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                product.Disconnect();
            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
