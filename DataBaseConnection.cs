using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOP2
{
    public class DataBaseConnection
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ServiceAutoDB;Integrated Security=True";
            }
        }
        public static SqlConnection GetConnection()
        {
            
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }

        public static SqlCommand CreateCommand(string query, SqlConnection connection)
        {
         
            SqlCommand command = new SqlCommand(query, connection);
            return command;
        }
    }
}
