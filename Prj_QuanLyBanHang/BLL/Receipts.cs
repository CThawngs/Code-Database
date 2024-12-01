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
    internal class Receipts
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

        public DataTable GetDataReceipts()
        {
            string sqlStr = "Select * from Receipts";

            return providers.GetData(sqlStr, null, null, false);

        }

        public DataTable SearchReceipts(int input)
        {
            string sqlStr = "SELECT * FROM Receipts WHERE ReceiptID = @input";

            string[] parameters = { "@input" };
            object[] values = { input };

            // Execute the query using the data provider
            return providers.GetData(sqlStr, parameters, values, false);
        }


    }
}
