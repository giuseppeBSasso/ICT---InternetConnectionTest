using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Common.Cache;
using Domain;

namespace ICT___InternetConnectionTest
{
    public partial class frmMonitoramento : Form
    {
        DevicesModel objetoDM = new DevicesModel();

        public frmMonitoramento()
        {
            InitializeComponent();
            // cboCategoria1();
            //  preenchendoComboBox();
            ControleDePermissoes();
        }

        private void ControleDePermissoes()
        {
            //Controle de permissões 
            if (UserLoginCache.Position == Positions.Visitante)
            {
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            if (UserLoginCache.Position == Positions.Administrador)
            {
                //CODE
            }
        }

        //Chamando Conexão BD MYSQL
     /*   ConnectionToMysql conexao = new ConnectionToMysql();
        MySqlCommand cmd = new MySqlCommand();*/

        //Carregando informações no combobox tempo de atualização
        private void preenchendoComboBox()
        {
            comboBoxTimePing.Items.Add("5 - Segundo");
            comboBoxTimePing.Items.Add("10 - Segundos");
        }

        //Carregando informações do BD no combobox categoria 
        void cboCategoria1()
        {
          /*  try
            {
                cmd.Connection = conexao.conectar();
                cmd.CommandText = "select *from category";
                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                comboBoxCategoria1.DataSource = ds.Tables[0];
                comboBoxCategoria1.DisplayMember = "category_name";
                comboBoxCategoria1.ValueMember = "id_category";
                conexao.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ERRO MYSQL");
            }*/
        }

        private void frmDashboard_Load(object sender, EventArgs e) { }

        //Metodo de listagem de informações no DataGridView (Tabela)
        private void Carregando()
        {
           /* try
            {
                cmd.Connection = conexao.conectar();

                cmd.CommandText = "SELECT id_devices, ip_address, description from devices where category_id = " + comboBoxCategoria1.SelectedValue;

                DataTable dt = new DataTable();

                MySqlDataAdapter dados = new MySqlDataAdapter();

                dados.SelectCommand = cmd;

                dados.Fill(dt);

                this.dgDados.DataSource = dt;

                conexao.desconectar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }


        //Metodo que efetua o ping em informações da tabela
        private void pingando()
        {
            List<String> inteiros = new List<String>();
            int aux = 0;
            if (dgDados.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgDados.Rows)
                {

                    object value = dgDados.Rows[aux].Cells["ip_address"].Value.ToString();
                    inteiros.Add((String)value);
                    aux++;
                }
            }

            int aux01 = 0;
            foreach (string item in (List<string>)inteiros)
            {

                Ping ping = new Ping();
                PingReply replay = ping.Send(item.ToString(), 1000);

                if (replay.Status == IPStatus.Success)
                {
                    dgDados.Rows[aux01].DefaultCellStyle.BackColor = Color.ForestGreen;
                    dgDados.Rows[aux01].DefaultCellStyle.ForeColor = Color.White;

                    dgDados.Rows[aux01].Cells["TempodeResposta"].Value = replay.RoundtripTime;
                    dgDados.Rows[aux01].Cells["ttl"].Value = replay.Options.Ttl;
                    dgDados.Rows[aux01].Cells["bufferSize"].Value = replay.Buffer.Length;
                    dgDados.Rows[aux01].Cells["STATUS"].Value = "ONLINE";
                }
                else
                {
                    
                    dgDados.Rows[aux01].DefaultCellStyle.BackColor = Color.Red;
                    dgDados.Rows[aux01].DefaultCellStyle.ForeColor = Color.White;

                    dgDados.Rows[aux01].Cells["TempodeResposta"].Value = replay.RoundtripTime;
                    dgDados.Rows[aux01].Cells["ttl"].Value = "0";
                    dgDados.Rows[aux01].Cells["bufferSize"].Value = replay.Buffer.Length;
                    dgDados.Rows[aux01].Cells["STATUS"].Value = "OFFILINE";
                }
                aux01++;
            }
        }

        //Botão, Metodo para chamar categoria e pingar na mesma
        private void button2_Click(object sender, EventArgs e)
        {
            Carregando();
            pingando();
        }

        //Evento de tempo, controlando quando e executado o metodo ping
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pingando();
        }

        //Combobox tempo de atualização 
        private void comboBoxTimePing_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBoxTimePing.SelectedItem == "10 - Segundos")
            {
                timer1.Interval = 10000;
                timer1.Start();
            }
            else if (comboBoxTimePing.SelectedItem == "5 - Segundo")
            {
                timer1.Interval = 5000;
                timer1.Start();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
          //  frmAdicionarItem In = new frmAdicionarItem();
           // In.ShowDialog();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMonitoramento_Load(object sender, EventArgs e)
        {
            MostrarDispositivos();
        }

        private void MostrarDispositivos()
        {
            dgDados.DataSource = objetoDM.MostrarDevices();
        }
    }
}
