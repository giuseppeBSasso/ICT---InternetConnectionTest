using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace ICT___InternetConnectionTest
{
    public partial class frmAdicionarItem : Form
    {
        DevicesModel objetoDM = new DevicesModel();

        public frmAdicionarItem()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam); 

        //Metodo para inserir informações no Banco de Dados
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (textBoxIP.Text == "")
            {
                MessageBox.Show("Favor informe os dados!");
            }
            else
            {
                try
                {
                    objetoDM.InserirDados(textBoxIP.Text, textBoxDescricao.Text, txtCategoria.Text);
                    MessageBox.Show("Dados cadastrados com sucesso!");
                    LimparFrm();
                    //Atualizar dados do datagridview
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel cadastrar novos items!" + ex);
                }
            }
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparFrm()
        {
            textBoxDescricao.Clear();
            textBoxIP.Clear();
            txtCategoria.Clear();
            txtid.Clear();
        }
    }
}
