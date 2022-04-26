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
    public partial class frmEditarItem : Form
    {
        DevicesModel objetoDM = new DevicesModel();
        private string idDevice = null;
        
        public frmEditarItem()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                objetoDM.EditarDados(textBoxIP.Text, textBoxDescricao.Text, txtCategoria.Text, txtid.Text);
                MessageBox.Show("Dados editados com sucesso!");
                LimparFrm();
                this.Close();
                //Atualizar dados do datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel editar o Registro!" + ex);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
