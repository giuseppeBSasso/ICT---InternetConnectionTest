/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import MySqlClient
using MySql.Data.MySqlClient;

namespace ICT___InternetConnectionTest
{
    class ConnectionToMysql
    {
        MySqlConnection con = new MySqlConnection();

        //Construtor
        public ConnectionToMysql()
        {
            con.ConnectionString = "server=localhost; database = ict_bd; username=root; password=;";
        }

        //Metodo conectar
        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        //Metodo desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
*/