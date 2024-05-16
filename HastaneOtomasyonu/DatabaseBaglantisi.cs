using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class DatabaseBaglantisi
    {
        private string SQLConnectionStringLocal = @"Server = SCA\SQLEXPRESS;Database =HastaneOtomasyonu; Trusted_Connection = True;";
        public SqlConnection con = new SqlConnection();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlCommand com = new SqlCommand();
        public SqlException exception = null;
        public DatabaseBaglantisi()
        {
            exception = null;
            con = new SqlConnection(SQLConnectionStringLocal);
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.GetType().Name + " - " + ex.Message);
                }
            }
        }
    }
}
