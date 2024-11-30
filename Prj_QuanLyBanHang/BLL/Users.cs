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
    internal class Users
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
        public DataTable GetAdmin()
        {
            return providers.GetData("SELECT * FROM Employees WHERE UserRole = 'Admin'", null, null, false);
        }

        public object UsersExecuteScalar(string query, string[] parameters, object[] values)
        {
            return providers.ExecuteScalar(query, parameters, values);
        }


        public int UsersExecuteNonQuery(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            return providers.ExecuteNonQuery(queryOrSpName, Parameters, Values, isStored);
        }

    }
}
