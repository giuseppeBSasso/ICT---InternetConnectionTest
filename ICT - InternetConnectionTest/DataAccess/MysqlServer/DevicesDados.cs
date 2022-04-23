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
        //private DevicesDados conectar = new DevicesDados();
      //  MySqlDataReader leer;
        DataTable tabela = new DataTable();
        MySqlDataAdapter dados = new MySqlDataAdapter();
      //  MySqlConnection conec = new MySqlConnection("server=localhost; database = ict_bd; username=root; password=;");

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
                  //  leer = command.ExecuteReader();
                  //  tabela.Load(dados);
                    return tabela;
                }
            }
        }
    }
}
