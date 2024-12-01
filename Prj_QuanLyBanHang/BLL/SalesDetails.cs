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
    internal class SalesDetails
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

        public DataTable GetDataSales(int id)
        {
            string sqlName = "sp_GetSaleByID ";
            string[] parameters = { "@SalesID" };
            object[] values = { id };
            return providers.GetData(sqlName, parameters, values, true);

        }
        public DataTable GetReceiptsFromSales(int id)
        {
            string sqlName = "sp_GetReceiptsFromSale";
            string[] parameters = { "@SalesID" };
            object[] values = { id };
            return providers.GetData(sqlName, parameters, values, true);

        }
    }
}
