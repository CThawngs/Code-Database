using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRJ_PhamThienHung.DAL;

namespace Prj_QuanLyBanHang.BLL
{
    internal class User
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

        public Dictionary<string, object> CheckUser(string User, string Pass)
        {
            Dictionary<string, object> userInfo = new Dictionary<string, object>();

            try
            {
                string strSql = "SELECT EmployeeID, UserRole FROM Employees WHERE Username = @TaiKhoan AND Password = @MatKhau";
                string[] parameters = { "@TaiKhoan", "@MatKhau" };
                object[] values = { User, Pass };

                // Use the ExecuteReader method from Providers
                using (SqlDataReader reader = providers.ExecuteReader(strSql, parameters, values, false))
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userInfo["UserRole"] = reader["UserRole"].ToString();
                            userInfo["Id"] = (int)reader["EmployeeID"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userInfo;
        }



    }
}
