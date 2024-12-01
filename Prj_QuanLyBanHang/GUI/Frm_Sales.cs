using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

using System.Windows.Forms;
using Prj_QuanLyBanHang.BLL;
using System.Windows.Forms.VisualStyles;

namespace Prj_QuanLyBanHang.GUI
{
    public partial class Frm_Sales : Form
    {
        private TimeFilter  currentTimeFilter  ;  
        public Frm_Sales()
        {
            InitializeComponent();
        }

        private void btn_moredetail_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_id.Text))
            {
                Frm_SalesDetails form = new Frm_SalesDetails(int.Parse(txt_id.Text));

                form.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a date", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void SetStyleChart()
        {
            chart_sales.ChartAreas[0].BackColor = Color.AliceBlue; 

            chart_sales.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart_sales.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chart_sales.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            chart_sales.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            chart_sales.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;  
            chart_sales.ChartAreas[0].AxisX.ScrollBar.Size = 20; 
            chart_sales.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll; 
        }

        private void cb_typetime_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_typetime.SelectedItem.ToString())
            {
                case "Mỗi Ngày":
                    currentTimeFilter = TimeFilter.Daily;
                    break;
                case "Mỗi Tuần":
                    currentTimeFilter = TimeFilter.Weekly;
                    break;
                case "Mỗi Tháng":
                    currentTimeFilter = TimeFilter.Monthly;
                    break;
                case "Mỗi Năm":
                    currentTimeFilter = TimeFilter.Yearly;
                    break;
                default:
                    currentTimeFilter = TimeFilter.Daily;
                    break;
            }

            LoadDataProducts();

        }

        private void Frm_Sales_Load(object sender, EventArgs e)
        {
            currentTimeFilter = TimeFilter.Daily;

            if (chart_sales.Series.IndexOf("TotalIncome") == -1)
            {
                chart_sales.Series.Add("TotalIncome");
            }

            if (chart_sales.Series.IndexOf("Series1") != -1)
            {
                chart_sales.Series.Remove(chart_sales.Series["Series1"]);
            }

            chart_sales.Series["TotalIncome"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chart_sales.ChartAreas[0].AxisX.Title = "Thời Gian";
            chart_sales.ChartAreas[0].AxisY.Title = "Tổng tiền";

            cb_typetime.SelectedIndex = 3;
            LoadDataProducts();
            


        }


        private void LoadDataProducts()
        {
            DataTable tblSales;
            Sales sales = new Sales();

            if (sales.Connect())
            {
                tblSales = sales.GetDataSales();
                sales.Disconnect();

                BindChartData(tblSales);
                chart_sales.ChartAreas[0].AxisX.ScaleView.Zoom(0, tblSales.Rows.Count);

                decimal totalIncome = GroupSalesData(tblSales).Sum(item => (decimal)item.TotalIncome);
                txt_totalrevenue.Text = totalIncome.ToString("C");

                SetStyleChart();
                if (cb_typetime.Text != "Mỗi Ngày")
                {
                    btn_moredetail.Enabled = false;
                }
                else
                {
                    btn_moredetail.Enabled = true;

                }


            }
            else
            {
                MessageBox.Show("Failed to connect to database", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindChartData(DataTable tblSales)
        {
            chart_sales.Series["TotalIncome"].Points.Clear();

            var groupedData = GroupSalesData(tblSales);

            foreach (var item in groupedData)
            {
                int pointIndex = chart_sales.Series["TotalIncome"].Points.AddXY(item.Period, item.TotalIncome);

                DataPoint point = chart_sales.Series["TotalIncome"].Points[pointIndex];
                if (currentTimeFilter == TimeFilter.Daily)
                {
                    point.Tag = item.SalesID.ToString();
                }
            }
        }




        private IEnumerable<dynamic> GroupSalesData(DataTable tblSales)
        {
            switch (currentTimeFilter)
            {
                case TimeFilter.Daily:
                    return from row in tblSales.AsEnumerable()
                           group row by row.Field<DateTime>("CreatedAt").ToString("yyyy-MM-dd") into g
                           select new
                           {
                               Period = g.Key,
                               TotalIncome = g.Sum(r => r.Field<decimal>("TotalIncome")),
                               SalesID = g.First().Field<int>("SalesID")  
                           };

                case TimeFilter.Weekly:
                    return from row in tblSales.AsEnumerable()
                           let weekNumber = System.Globalization.CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(row.Field<DateTime>("CreatedAt"), System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                           group row by new { Year = row.Field<DateTime>("CreatedAt").Year, Week = weekNumber } into g
                           select new
                           {
                               Period = $"{g.Key.Year}-W{g.Key.Week:D2}",
                               TotalIncome = g.Sum(r => r.Field<decimal>("TotalIncome")),
                               SalesID = g.First().Field<int>("SalesID")   
                           };

                case TimeFilter.Monthly:
                    return from row in tblSales.AsEnumerable()
                           group row by row.Field<DateTime>("CreatedAt").ToString("yyyy-MM") into g
                           select new
                           {
                               Period = g.Key,
                               TotalIncome = g.Sum(r => r.Field<decimal>("TotalIncome")),
                               SalesID = g.First().Field<int>("SalesID")   
                           };

                case TimeFilter.Yearly:
                    return from row in tblSales.AsEnumerable()
                           group row by row.Field<DateTime>("CreatedAt").Year into g
                           select new
                           {
                               Period = g.Key,
                               TotalIncome = g.Sum(r => r.Field<decimal>("TotalIncome")),
                               SalesID = g.First().Field<int>("SalesID")   
                           };

                default:
                    return Enumerable.Empty<dynamic>();
            }
        }



        private void chart_sales_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = chart_sales.HitTest(e.X, e.Y);

            if (hit.ChartElementType == ChartElementType.DataPoint && cb_typetime.Text == "Mỗi Ngày")
            {
                DataPoint selectedPoint = chart_sales.Series[hit.Series.Name].Points[hit.PointIndex];

                string selectedID = selectedPoint.Tag.ToString();

                txt_id.Text = selectedID;  
            }
        }

    }
}
