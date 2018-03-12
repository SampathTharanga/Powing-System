using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Powing_System
{
    class ConnectionDB
    {
        public static SqlConnection Connection()
        {
            string connectionString = @"Data Source=DESKTOP-OSA8TIB\SQLEXPRESS;Initial Catalog=powingSystem_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
