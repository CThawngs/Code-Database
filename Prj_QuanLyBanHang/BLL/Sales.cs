using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRJ_PhamThienHung.DAL;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;

namespace Prj_QuanLyBanHang.BLL
{
    internal class Sales
    {
        Providers providers = new Providers();

        public SqlConnection Connection()
        {
            return providers.connection;
        }

        public Boolean Connect()
        {
            return providers.Connect();
        }

        public void Disconnect()
        {
            providers.DisConnect();
        }


        public DataTable GetDataSales( )
        {
            string sqlStr = "SELECT * FROM Sales ORDER BY CreatedAt DESC";
            DateTime startDate = DateTime.Now;

             
            string[] parameters = { "@StartDate" };
            object[] values = { startDate };

            try
            {
                // Use the providers.GetData method to fetch the filtered data
                return providers.GetData(sqlStr, parameters, values, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public object SalesExecuteScalar(string query, string[] parameters, object[] values)
        {
            return providers.ExecuteScalar(query, parameters, values);
        }


    }
}
