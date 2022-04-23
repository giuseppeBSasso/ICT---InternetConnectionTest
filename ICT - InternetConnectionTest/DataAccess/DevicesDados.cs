using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Chamando BD MYSQL
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class DevicesDados : ConnectionToMysql
    {
        //Metodo Adicionar item
        public void adicionaritem(int id_devices, string ip_address, string description, int ms, int category_id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into devices(ip_address,description,category_id)values(@ip_address,@description,@category_id)";
                    command.Parameters.AddWithValue("@ip_address", ip_address);
                    command.Parameters.AddWithValue("@description", description);
                   // command.Parameters.AddWithValue("@category_id", comboBoxCategoria.SelectedValue);
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
