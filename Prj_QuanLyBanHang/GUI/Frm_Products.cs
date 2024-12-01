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
    public partial class Frm_Products : Form
    {
        bool flag = false;  
        public Frm_Products()
        {
            InitializeComponent();
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (list_of_products.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(list_of_products.SelectedRows[0].Cells["ProductID"].Value);

                if (productId == 0)
                {
                    MessageBox.Show("No products selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Hide();
                Frm_ProductDetails form = new Frm_ProductDetails(productId);

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

        private void Frm_Products_Load(object sender, EventArgs e)
        {
            LoadDataProducts();
            btn_Luu.Enabled = false;

        }
        private void LoadDataProducts()
        {
            DataTable tblProducts;
            Products products = new Products();

            if (products.Connect())
            {
                tblProducts = products.GetDataProducts();
                list_of_products.DataSource = tblProducts;
                products.Disconnect();


                SetStyle();
                BindingData();


                object res = products.ProductsExecuteScalar("SELECT COUNT(*) FROM Products", null, null);
                txt_total.Text = res.ToString();

            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BindingData()
        {
            txt_nameofproduct.DataBindings.Clear();
            txt_price.DataBindings.Clear();
            txt_brand.DataBindings.Clear();

            txt_price.DataBindings.Add("text", list_of_products.DataSource, "Price");
            txt_nameofproduct.DataBindings.Add("text", list_of_products.DataSource, "ProductName");
            txt_brand.DataBindings.Add("text", list_of_products.DataSource, "CategoryName");

           
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            featureSwitch();
        }
        private void featureSwitch()

        {
            flag = !flag;
            btn_Luu.Enabled = flag;
            ReadOnlySwitchInput();
        }

        private void ResetTextInput()
        {
            txt_nameofproduct.Text = "";
            txt_price.Text = "";
            txt_brand.Text = "";
        }
        private void ReadOnlySwitchInput()
        {
            txt_nameofproduct.ReadOnly = !flag;
            txt_price.ReadOnly = !flag;
            txt_brand.ReadOnly = !flag;

            if (flag == false)
            {
                BindingData();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            int price;

            if (!int.TryParse(txt_price.Text, out price))
            {
                MessageBox.Show("Please type in the correct price", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (products.Connect())
            {
                string[] parameters = {
            "@ProductName", "@CategoryName", "@Price",
            "@Brand", "@ManufacturingDate", "@ExpiryDate",
            "@Ingredients", "@StockQuantity"
        };

                object[] values = {
            txt_nameofproduct.Text,
            cmb_filter.Text,
            price,
            txt_brand.Text,
            DateTime.Now,
            DateTime.Now.AddDays(2),
            "",
            0
        };

                int rec = products.ProductsExecuteNonQuery("sp_CreateProduct", parameters, values, true);

                if (rec > 0)
                {
                    MessageBox.Show("Success", "Notice", MessageBoxButtons.OK);
                    LoadDataProducts();
                    ResetTextInput();
                    featureSwitch();
                }
                else
                {
                    MessageBox.Show("Failed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_of_products.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(list_of_products.SelectedRows[0].Cells["ProductId"].Value);

                if (productId == 0)
                {
                    MessageBox.Show("No product selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Show confirmation dialog
                DialogResult confirmation = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmation == DialogResult.Yes)
                {
                    string spName = "sp_DeleteProduct";
                    string[] parameters = { "@ProductId" };
                    object[] values = { productId };

                    Products products = new Products();

                    if (products.Connect())
                    {
                        int rec = products.ProductsExecuteNonQuery(spName, parameters, values, true);
                        if (rec > 0)
                        {
                            MessageBox.Show("Product deleted successfully.", "Notice", MessageBoxButtons.OK);
                            LoadDataProducts();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the product.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to connect to the database.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable tblProducts;
            Products products = new Products();

            if (products.Connect())
            {
                if (cmb_filter.Text == "Lọc để tìm kiếm hoặc tạo sản phẩm" || string.IsNullOrEmpty(cmb_filter.Text))
                {
                    tblProducts = products.SearchProduct(txt_search.Text);
                }
                else
                {
                    tblProducts = products.SearchProductWithFilter(txt_search.Text, cmb_filter.Text);
                }

                list_of_products.DataSource = tblProducts;
                products.Disconnect();



                SetStyle();
                BindingData();


                object res = products.ProductsExecuteScalar("SELECT COUNT(*) FROM Products", null, null);
                txt_total.Text = res.ToString();

            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetStyle()
        {
            list_of_products.Columns["ProductID"].HeaderText = "Mã sản phẩm";
            list_of_products.Columns["ProductID"].Width = 80;

            list_of_products.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            list_of_products.Columns["ProductName"].Width = 200;

            list_of_products.Columns["CategoryName"].HeaderText = "Danh mục";
            list_of_products.Columns["CategoryName"].Width = 150;

            list_of_products.Columns["Price"].HeaderText = "Giá";
            list_of_products.Columns["Price"].Width = 100;

            list_of_products.Columns["Brand"].HeaderText = "Thương hiệu";
            list_of_products.Columns["Brand"].Width = 120;

            list_of_products.Columns["ManufacturingDate"].HeaderText = "Ngày sản xuất";
            list_of_products.Columns["ManufacturingDate"].Width = 120;

            list_of_products.Columns["ExpiryDate"].HeaderText = "Ngày hết hạn";
            list_of_products.Columns["ExpiryDate"].Width = 120;

            list_of_products.Columns["Ingredients"].HeaderText = "Nguyên liệu";
            list_of_products.Columns["Ingredients"].Width = 200;

            list_of_products.Columns["StockQuantity"].HeaderText = "Số lượng tồn";
            list_of_products.Columns["StockQuantity"].Width = 100;

            list_of_products.Columns["UpdatedAt"].HeaderText = "Cập nhật lúc";
            list_of_products.Columns["UpdatedAt"].Width = 140;

            list_of_products.Columns["CreatedAt"].HeaderText = "Ngày tạo";
            list_of_products.Columns["CreatedAt"].Width = 140;

        }
    }
}
