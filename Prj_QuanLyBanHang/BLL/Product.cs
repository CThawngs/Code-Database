using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRJ_PhamThienHung.DAL;

namespace Prj_QuanLyBanHang.BLL
{
    internal class Product
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

        public DataTable GetDataProduct(int id)
        {
            string sqlName = "sp_GetProductByID ";
            string[] parameters = { "@ProductId" };
            object[] values = { id };
            return providers.GetData(sqlName, parameters, values, true);

        }
        public int ProductExecuteNonQuery(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            return providers.ExecuteNonQuery(queryOrSpName, Parameters, Values, isStored);
        }
        public object ProductExecuteScalar(string query, string[] parameters, object[] values)
        {
            return providers.ExecuteScalar(query, parameters, values);
        }
    }
}
