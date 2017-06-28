using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ImportExportManagement
{
    class DatabaseAccess
    {
        private static MySqlConnection connection;
                

        public static MySqlConnection getConnection() {
            
            if (connection == null)
            {
                connection = new MySqlConnection(ConnectionConfiguration.ConnectionString("IEManagement"));
            }
            return connection;
               
            
        }
    }
}
