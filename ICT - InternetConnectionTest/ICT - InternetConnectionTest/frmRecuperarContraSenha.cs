using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using System.Runtime.InteropServices;

namespace ICT___InternetConnectionTest
{
    public partial class frmRecuperarContraSenha : Form
    {
        public frmRecuperarContraSenha()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var Result = user.recoverPassword(txtUserRequest.Text);
            lblResultado.Text = Result;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRecuperarContraSenha_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
