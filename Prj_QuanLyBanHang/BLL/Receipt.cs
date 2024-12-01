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
    internal class Receipt
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

        public DataTable GetDataReceipt(int id)
        {
            string sqlName = "sp_GetReceiptByID ";
            string[] parameters = { "@ReceiptID" };
            object[] values = { id };
            return providers.GetData(sqlName, parameters, values, true);

        }
        public DataTable GetDataProductsReceipt(int id)
        {
            string sqlName = "sp_GetProductsFromReceipt";
            string[] parameters = { "@ReceiptID" };
            object[] values = { id };
            return providers.GetData(sqlName, parameters, values, true);

        }
         
         
    }
}
