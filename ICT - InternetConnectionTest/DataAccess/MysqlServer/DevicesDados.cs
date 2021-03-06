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

        public void Inserir(string ip_address,string description,string category_id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into devices(ip_address, description, category_id)values(@ip_address, @description, @category_id)";
                    command.Parameters.AddWithValue("@ip_address", ip_address);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@category_id", category_id);
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Editar(string ip_address, string description, string category_id,int id_devices)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update devices set ip_address=@ip_address,description=@description,category_id=@category_id where id_devices=@id_devices";
                    command.Parameters.AddWithValue("@ip_address", ip_address);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@category_id", category_id);
                    command.Parameters.AddWithValue("@id_devices", id_devices);
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Deletar(int id_devices)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from devices where id_devices=@id_devices";
                    command.Parameters.AddWithValue("@id_devices", id_devices);
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
