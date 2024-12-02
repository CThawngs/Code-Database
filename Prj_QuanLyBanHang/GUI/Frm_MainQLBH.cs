using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Prj_QuanLyBanHang.BLL;

namespace Prj_QuanLyBanHang.GUI
{
    public partial class Frm_MainQLBH : Form
    {
        private string userRole;
        private int userId;

        public Frm_MainQLBH(string role, int id)
        {
            InitializeComponent();
            this.userRole = role;
            this.userId = id;
            timer_usertime.Interval = 1000; 
            timer_usertime.Start();

        }

        private void product_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Products form = new Frm_Products();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void receipt_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Receipts form = new Frm_Receipts();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

        private void revenue_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Sales form = new Frm_Sales();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

         

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Staff form = new Frm_Staff();

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

        private void Frm_MainQLBH_Load(object sender, EventArgs e)
        {
            if( userRole.ToLower() == "admin")
            {
                quảnLýNhânViênToolStripMenuItem.Visible = true;
            }
            lblName.Text = GetUserName().ToUpper();
            SetUpPieChart();
            lblNumberProducts.Text = GetTotalNumberOfProducts();
            lblSales.Text = GetSalesMonthlyIncome();

        }
        private void SetUpPieChart()
        {
            Product product = new Product();

            if (product.Connect())
            {

                DataTable results = product.ProductExecuteReader();

                piechart.Series.Clear();
                piechart.Series.Add("MySeries");
                piechart.Series["MySeries"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                foreach (DataRow row in results.Rows)
                {
                    string categoryName = row["CategoryName"].ToString();
                    double percentage = Convert.ToDouble(row["Percentage"]);

                    piechart.Series["MySeries"].Points.AddXY(categoryName, percentage);
                }

                piechart.Series["MySeries"].IsValueShownAsLabel = true;
                piechart.Series["MySeries"].LabelFormat = "{0:0.0}%";  

                foreach (var point in piechart.Series["MySeries"].Points)
                {
                    point.LabelForeColor = System.Drawing.Color.White;  
                }

            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSalesMonthlyIncome()
        {
            object salesData;
            Sales sales = new Sales();

            if (sales.Connect())
            {
                string queryStr = "SELECT \r\n    ISNULL(SUM(TotalIncome), 0) AS ThisMonthSales\r\nFROM \r\n    Sales\r\nWHERE \r\n    YEAR(CreatedAt) = YEAR(GETDATE()) \r\n    AND MONTH(CreatedAt) = MONTH(GETDATE());\r\n";
                salesData = sales.SalesExecuteScalar(queryStr,null,null);
                sales.Disconnect();


                decimal salesAmount = Convert.ToDecimal(salesData);
                return salesAmount.ToString("C");

        }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "0";
        }
        private string GetTotalNumberOfProducts()
        {
            object productsData;
            Products products= new Products();

            if (products.Connect())
            {
                string queryStr = "SELECT COUNT(*) AS ProductCount\r\nFROM Products;\r\n";
                productsData = products.ProductsExecuteScalar(queryStr, null, null);
                products.Disconnect();


                decimal productAmount = Convert.ToInt32(productsData);
                return productAmount.ToString();

            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "0";
        }

        private string GetUserName()
        {
            DataTable tblUser;
            User user = new User();

            if (user.Connect())
            {
                tblUser = user.GetDataUser(userId);
                user.Disconnect();

                if (tblUser.Rows.Count > 0)
                {
                    DataRow row = tblUser.Rows[0];  
                    return row["Username"].ToString();
                     
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
            return "";
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_StaffDetailscs form = new Frm_StaffDetailscs(userId,userRole);

            form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            form.ShowDialog();
        }

        private void timer_usertime_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = $"{currentTime:dddd, MMMM dd, yyyy hh:mm:ss tt}"; 

            // Set the label text
            lbl_time.Text = formattedTime;
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpFileName = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + @"\HelpData\HuongDan\HuongDan.chm";
            if (System.IO.File.Exists(helpFileName))
            {
                Help.ShowHelp(this, helpFileName);
            }
           
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpFileName = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + @"\HelpData\GioiThieu\GioiThieu.chm";
            if (System.IO.File.Exists(helpFileName))
            {
                Help.ShowHelp(this, helpFileName);
            }
        }
    }
}
