using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import MySqlClient
using MySql.Data.MySqlClient;


namespace DataAccess
{
    public abstract class ConnectionToMysql
    {
        private readonly string connectionString;

        public ConnectionToMysql()
        {
            connectionString = "server=localhost; database = ict_bd; username=root; password=;";
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
