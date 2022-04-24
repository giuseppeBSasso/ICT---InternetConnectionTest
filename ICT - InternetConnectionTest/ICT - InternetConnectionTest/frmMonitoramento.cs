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

        //Carregando informações no combobox tempo de atualização
        private void preenchendoComboBox()
        {
            comboBoxTimePing.Items.Add("5 - Segundo");
            comboBoxTimePing.Items.Add("10 - Segundos");
        }

        private void frmDashboard_Load(object sender, EventArgs e) { }


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
            frmAdicionarItem In = new frmAdicionarItem();
            In.ShowDialog();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMonitoramento_Load(object sender, EventArgs e)
        {
            MostrarDispositivos();
            preenchendoComboBox();
            CarregandoProgressBar();
        }

        //Lista informações no datagrid
        public void MostrarDispositivos()
        {
            DevicesModel objeto = new DevicesModel();
            dgDados.DataSource = objeto.MostrarDevices();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBarPing.Value += 1;
            if (progressBarPing.Value == 100)
            {
                timer2.Stop();
                pingando();
                timer3.Start();
                lblCarregandoInfo.Text = "INFORMAÇÕES CARREGADAS!";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer3.Stop();
               //this.progressBarPing.Visible = false;
            }
        }

        private void CarregandoProgressBar()
        {
            lblCarregandoInfo.Visible = true;
            this.Opacity = 0.0;
            progressBarPing.Value = 0;
            progressBarPing.Minimum = 0;
            progressBarPing.Maximum = 100;

            timer2.Start();
            progressBarPing.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarItem frm = new frmEditarItem();
            if (dgDados.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dgDados.CurrentRow.Cells["id_devices"].Value.ToString();
                frm.textBoxIP.Text = dgDados.CurrentRow.Cells["ip_address"].Value.ToString();
                frm.textBoxDescricao.Text = dgDados.CurrentRow.Cells["description"].Value.ToString();
                frm.txtCategoria.Text = dgDados.CurrentRow.Cells["category_id"].Value.ToString();

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um fila para editar!");
            }
        }
    }
}
