using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PRJ_PhamThienHung.DAL
{
    class Providers
    {
        private SqlConnection connection;

        public bool Connect()
        {
            try
            {
                string connectionStr = ConfigurationManager.ConnectionStrings["ConnectStr"].ConnectionString;
                connection = new SqlConnection(connectionStr);

                if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                {
                    connection.Open();
                }
                return true;
            }
            catch (SqlException ex)
            {
                LogError(ex);
                MessageBox.Show($"Database connection error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        public void DisConnect()
        {
            if (connection != null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private SqlConnection GetOpenConnection()
        {
            if (connection == null || connection.State != ConnectionState.Open)
            {
                Connect();
            }
            return connection;
        }

        public SqlCommand Command(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            if (string.IsNullOrEmpty(queryOrSpName))
                throw new ArgumentException("Query or stored procedure name cannot be null or empty.");

            if (Parameters != null && Values != null && Parameters.Length != Values.Length)
                throw new ArgumentException("The number of parameters must match the number of values.");

            SqlCommand cmd = new SqlCommand(queryOrSpName, GetOpenConnection())
            {
                CommandType = isStored ? CommandType.StoredProcedure : CommandType.Text
            };

            if (Parameters != null)
            {
                for (int i = 0; i < Parameters.Length; i++)
                {
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = Parameters[i],
                        Value = Values[i] ?? DBNull.Value,
                        SqlDbType = DetermineSqlDbType(Values[i])  
                    });
                }
            }

            return cmd;
        }

        public SqlDataReader ExecuteReader(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            try
            {
                SqlCommand cmd = Command(queryOrSpName, Parameters, Values, isStored);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                LogError(ex);
                MessageBox.Show($"Error executing reader: {ex.Message}");
                throw; // Rethrow to allow upstream handling if necessary
            }
        }

        public int ExecuteNonQuery(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            try
            {
                SqlCommand cmd = Command(queryOrSpName, Parameters, Values, isStored);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                LogError(ex);
                MessageBox.Show($"Error executing non-query: {ex.Message}");
                return 0;
            }
            finally
            {
                DisConnect();
            }
        }

        public object ExecuteScalar(string queryOrSpName, string[] Parameters, object[] Values)
        {
            try
            {
                SqlCommand cmd = Command(queryOrSpName, Parameters, Values, false);
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                LogError(ex);
                MessageBox.Show($"Error executing scalar: {ex.Message}");
                return null;
            }
            finally
            {
                DisConnect();
            }
        }

        public DataTable GetData(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            DataTable tbl = new DataTable();
            try
            {
                SqlCommand cmd = Command(queryOrSpName, Parameters, Values, isStored);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tbl);
                }
                return tbl;
            }
            catch (SqlException ex)
            {
                LogError(ex);
                MessageBox.Show($"Error fetching data: {ex.Message}");
                return tbl; // Return empty DataTable
            }
            finally
            {
                DisConnect();
            }
        }

        private void LogError(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        private SqlDbType DetermineSqlDbType(object value)
        {
            if (value is int)
                return SqlDbType.Int;
            if (value is string)
                return SqlDbType.NVarChar;
            if (value is DateTime)
                return SqlDbType.DateTime;
            if (value is bool)
                return SqlDbType.Bit;
            return SqlDbType.Variant;
        }
    }
}
