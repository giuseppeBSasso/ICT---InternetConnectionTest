using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class DevicesModel
    {
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

        public void EditarDados(string ip_address, string description, string category_id,string id_devices)
        {
            obj.Editar(ip_address, description, category_id,Convert.ToInt32(id_devices));
        }

        public void EliminarDados(string id_devices)
        {
            obj.Deletar(Convert.ToInt32(id_devices));
        }
    }
}
