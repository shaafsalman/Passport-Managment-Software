using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPassport.Config
{
    class ConnectionFile
    {
        public string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FastPassport;User ID=admin;Password=1122;Persist Security Info=True;";

        public SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }
        public String getConnectionString()
        {
            return ConnectionString;
        }
    }
}

