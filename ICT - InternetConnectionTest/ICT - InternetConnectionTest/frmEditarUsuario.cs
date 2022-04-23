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
            lblUser.Text = UserLoginCache.FirstName;
            lblLastName.Text = UserLoginCache.LastName;
            lblMail.Text = UserLoginCache.Email;
            lblPosition.Text = UserLoginCache.Position;

            //Edit Panel
            txtFirstName.Text = UserLoginCache.FirstName;
            txtLastName.Text = UserLoginCache.LastName;
            txtEmail.Text = UserLoginCache.Email;
            txtPassword.Text = UserLoginCache.Password;
            txtConfirmPass.Text = UserLoginCache.Password;
            txtCurrentPassword.UseSystemPasswordChar = true;
            txtCurrentPassword.Text = "";
        }

        private void initializePassEditControls()
        {
            LinkEditPass.Text = "Edit";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enabled = false;
            txtConfirmPass.UseSystemPasswordChar = true;
            txtConfirmPass.Enabled = false;
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
            if (LinkEditPass.Text == "Edit")
            {
                LinkEditPass.Text = "Cancel";
                txtPassword.Enabled = true;
                txtPassword.Text = "";
                txtConfirmPass.Enabled = true;
                txtConfirmPass.Text = "";
            }
            else if (LinkEditPass.Text == "Cancel")
            {
                initializePassEditControls();
                txtPassword.Text = UserLoginCache.Password;
                txtConfirmPass.Text = UserLoginCache.Password;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length >= 5)
            {
                if (txtPassword.Text == txtConfirmPass.Text)
                {
                    if (txtCurrentPassword.Text == UserLoginCache.Password)
                    {
                        var userModel = new UserModel(
                            idUser: UserLoginCache.IdUser,
                            password: txtPassword.Text,
                            firstName: txtFirstName.Text,
                            lastName: txtLastName.Text,
                            position: null,
                            email: txtEmail.Text);
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        reset();
                        panel1.Visible = false;
                    }
                    else
                        MessageBox.Show("Icorrect current password, try again");
                }
                else
                    MessageBox.Show("The password do not match, try again");
            }
            else
                MessageBox.Show("The password must have a minimum of 5 characters");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            reset();
        }
    }
}
