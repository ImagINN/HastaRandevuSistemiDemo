using Microsoft.Data.SqlClient;
using System.Data;

namespace HastaRandevuSistemiDemo
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS01;Database=RandevuSistemiDb;Trusted_Connection=True;TrustServerCertificate=true;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable ExecuteSelectQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
    }
}
