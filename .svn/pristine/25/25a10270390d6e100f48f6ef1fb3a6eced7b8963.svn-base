using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLNS.BLL
{
    class Connect
    {
        SqlConnection conn = new SqlConnection();
        public Connect()
        {
            string connString = @"Data Source=(local);Initial Catalog=QLNS; Intergated Security = True";

            conn.ConnectionString = connString;
        }
        public void Close()
        {
            conn.Close();
        }
    }
}
