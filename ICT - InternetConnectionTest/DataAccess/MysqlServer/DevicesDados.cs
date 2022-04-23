using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Import MySqlClient
using MySql.Data.MySqlClient;

namespace DataAccess.MysqlServer
{
    public class DevicesDados : ConnectionToMysql
    {
        DataTable tabela = new DataTable();
        MySqlDataAdapter dados = new MySqlDataAdapter();

        public DataTable Mostrar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {   
                    command.Connection = connection;
                    command.CommandText = "Select *from devices";
                    dados.SelectCommand = command;
                    dados.Fill(tabela);
                    return tabela;
                }
            }
        }
    }
}
