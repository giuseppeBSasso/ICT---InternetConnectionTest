using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    class DevicesMonitoring
    {
        DevicesDados devicesDados = new DevicesDados();

        //Informações de dispositivos
        private int id_devices;
        private string ip_address;
        private string description;
        private int ms;
        private int category_id;

        //Constructors
        public DevicesMonitoring(int id_devices, string ip_address, string description, int ms, int category_id)
        {
            this.id_devices = id_devices;
            this.ip_address = ip_address;
            this.description = description;
            this.ms = ms;
            this.category_id = category_id;
        }

        public string adicionarDevices()
        {
            try
            {
                DevicesDados.adicionaritem(id_devices, ip_address, description, ms, category_id);
               // AddDevices(FirstName, Password);
                return "Item adicionado com sucesso";
            }
            catch (Exception ex)
            {
                return "Não foi possivel atualizar o banco";
            }
        }

        public bool AddDevices(int id_devices, string ip_address, string description, int ms, int category_id)
        {
            return DevicesDados.adicionaritem(id_devices, ip_address, description, ms, category_id);
        }
    }
}
