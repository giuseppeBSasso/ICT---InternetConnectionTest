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
using Common.Cache;

namespace ICT___InternetConnectionTest
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUÁRIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUÁRIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.DimGray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUÁRIO") {
                if (txtSenha.Text != "SENHA") {
                    UserModel user = new UserModel();
                    var validaLogin = user.LoginUser(txtUsuario.Text, txtSenha.Text);
                    if (validaLogin == true) {
                        this.Hide();
                        frmBemVindo bemVindo = new frmBemVindo();
                        bemVindo.ShowDialog();
                        frmPrincipal mainMenu = new frmPrincipal();
                        //MessageBox.Show("Bem-Vindo " + UserLoginCache.LastName + " " + UserLoginCache.FirstName,"Inicio da cessão",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                    }
                    else
                    {
                        msgError("Senha ou usuário incorretos. \n     Tente Novamente!");
                        txtSenha.Text = "SENHA";
                        txtUsuario.Focus();
                    }
                }
                else msgError("Insira a senha!");
            }
            else msgError("Insira o nome de Usuário!");
        }
        private void msgError(String msg)
        {
            lblErroMenssage.Text = "    " + msg;
            lblErroMenssage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtSenha.Text = "SENHA";
            txtSenha.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUÁRIO";
            lblErroMenssage.Visible = false;
            this.Show();
        }

        private void linkRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new frmRecuperarContraSenha();
            recoverPassword.ShowDialog();
        }
    }
}
