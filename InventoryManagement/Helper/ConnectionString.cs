using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace InventoryManagement.Helper
{
    internal class ConnectionString
    {
        public static SqlConnection GetConnection()
        {
            string query = ConfigurationManager.ConnectionStrings
                ["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(query);
            return con;
        }

    }
}
