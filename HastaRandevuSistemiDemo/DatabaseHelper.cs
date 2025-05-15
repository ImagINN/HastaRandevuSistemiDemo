using Microsoft.Data.SqlClient;
using System.Data;

namespace HastaRandevuSistemiDemo
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS01;Database=RandevuSistemiDb;Trusted_Connection=True;TrustServerCertificate=true;";

        public SqlConnection GetConnection() //SqlConnection türünde bir sonuç döndürür.
        {
            return new SqlConnection(connectionString);
        }

        public DataTable ExecuteSelectQuery(string query) //Fark ettiyseniz bağlantıyı kapatmadık. Yani SqlDataAdapter Disconnected çalışır (bağlantı açık kalmaz).
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ExecuteSelectQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void ExecuteInsertQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalarQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

    }
}
