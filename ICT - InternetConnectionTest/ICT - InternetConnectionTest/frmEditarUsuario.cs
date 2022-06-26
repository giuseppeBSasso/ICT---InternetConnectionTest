using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace ICT___InternetConnectionTest
{
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditControls();
        }

        private void loadUserData()
        {
            //View
            lblName.Text = UserLoginCache.FirstName;
            lblSobrenome.Text = UserLoginCache.LastName;
            lblEmail.Text = UserLoginCache.Email;
            lblPermissao.Text = UserLoginCache.Position;

            //Edit Panel
            txtPrimeiroNome.Text = UserLoginCache.FirstName;
            txtSobrenome.Text = UserLoginCache.LastName;
            txtEmail.Text = UserLoginCache.Email;
            txtSenha.Text = UserLoginCache.Password;
            txtComfirmarSenha.Text = UserLoginCache.Password;
            txtSenhaAtual.UseSystemPasswordChar = true;
            txtSenhaAtual.Text = "";
        }

        private void initializePassEditControls()
        {
            LinkEditPass.Text = "Editar";
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.Enabled = false;
            txtComfirmarSenha.UseSystemPasswordChar = true;
            txtComfirmarSenha.Enabled = false;
        }

        private void reset()
        {
            initializePassEditControls();
            loadUserData();
        }

        private void btnEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            loadUserData();
        }

        private void LinkEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkEditPass.Text == "Editar")
            {
                LinkEditPass.Text = "Cancelar";
                txtSenha.Enabled = true;
                txtSenha.Text = "";
                txtComfirmarSenha.Enabled = true;
                txtComfirmarSenha.Text = "";
            }
            else if (LinkEditPass.Text == "Cancelar")
            {
                initializePassEditControls();
                txtSenha.Text = UserLoginCache.Password;
                txtComfirmarSenha.Text = UserLoginCache.Password;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length >= 5)
            {
                if (txtSenha.Text == txtComfirmarSenha.Text)
                {
                    if (txtSenhaAtual.Text == UserLoginCache.Password)
                    {
                        var userModel = new UserModel(
                            idUser: UserLoginCache.IdUser,
                            password: txtSenha.Text,
                            firstName: txtPrimeiroNome.Text,
                            lastName: txtSobrenome.Text,
                            position: null,
                            email: txtEmail.Text);
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        reset();
                        panel1.Visible = false;
                    }
                    else
                        MessageBox.Show("Senha atual incorreta, tente novamente!");
                }
                else
                    MessageBox.Show("As senhas não corresponde, tente novamente!");
            }
            else
                MessageBox.Show("A senha deve ter no mínimo 5 caracteres!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            reset();
        }
    }
}
