using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Import MySqlClient
//using MySql.Data.MySqlClient;
using DataAccess;

namespace Domain
{
    public class DevicesModel
    {
        //private DevicesModel objetoDM = new DevicesModel();
        private DataAccess.MysqlServer.DevicesDados obj = new DataAccess.MysqlServer.DevicesDados();

        public DataTable MostrarDevices()
        {
            DataTable tabela = new DataTable();
            tabela = obj.Mostrar();
            return tabela;
        }

        public void InserirDados(string ip_address, string description, string category_id)
        {
            obj.Inserir(ip_address, description, category_id);
        }
    }
}
