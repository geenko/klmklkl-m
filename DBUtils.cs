using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace delivery_food
{
    internal class DBUtils
    {
        public static MySqlConnection GetMySqlConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "delivery";
            string user = "root";
            string password = "0000";

            return DBMySqlUtils.GetMySqlConnection(host, port, database, user, password);
        }
    }
}
