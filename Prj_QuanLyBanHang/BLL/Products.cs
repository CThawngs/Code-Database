using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRJ_PhamThienHung.DAL;

namespace Prj_QuanLyBanHang.BLL
{
    internal class Products
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

        public DataTable GetDataProducts()
        {
            string sqlStr = "Select * from Products";

            return providers.GetData(sqlStr,null,null,false);

        }
        public int ProductsExecuteNonQuery(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            return providers.ExecuteNonQuery(queryOrSpName, Parameters, Values, isStored);
        }
        public object ProductsExecuteScalar(string query, string[] parameters, object[] values)
        {
            return providers.ExecuteScalar(query, parameters, values);
        }
    }
}
