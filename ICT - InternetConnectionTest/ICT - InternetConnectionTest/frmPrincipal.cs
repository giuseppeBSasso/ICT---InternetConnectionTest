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
using Common.Cache;

namespace ICT___InternetConnectionTest
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            LoadUserData();
            ControleDePermissoes();
        }

        private void ControleDePermissoes()
        {
            //Controle de permissões 
            if (UserLoginCache.Position == Positions.Visitante)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            if (UserLoginCache.Position == Positions.Administrador)
            {
                //CODE
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void abrirFormInPanel(object FormFilho)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);
            Form fh = FormFilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(fh);
            this.pnlPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnMonitoramento_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmMonitoramento());
        }

        private void LoadUserData()
        {
            lblPosition.Text = UserLoginCache.Position;
            lblName.Text = UserLoginCache.FirstName;
            lblEmail.Text = UserLoginCache.Email;
        }
        private void btnEncerrarCessao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a cessão?", "Warning", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void linkLabelUserPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirFormInPanel(new frmEditarUsuario());
        }

        private void btnSlide_Click_1(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 234)
            {
                pnlMenuVertical.Width = 73;
            }
            else
            {
                pnlMenuVertical.Width = 234;
            }
        }

        private void btnEncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataEHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmScanearRede());
        }
    }
}
