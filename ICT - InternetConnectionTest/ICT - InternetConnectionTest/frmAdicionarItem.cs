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
        public frmAdicionarItem()
        {
            InitializeComponent();
           // cboCategoria();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Carregando informações do BD no combobox categoria 
          public void cboCategoria()
          {
            /*  try
              {
                  cmd.Connection = conexao.conectar();
                  cmd.CommandText = "select *from category";
                  DataSet ds = new DataSet();
                  MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                  adapter.Fill(ds);
                  comboBoxCategoria.DataSource = ds.Tables[0];
                  comboBoxCategoria.DisplayMember = "category_name";
                  comboBoxCategoria.ValueMember = "id_category";
                  conexao.desconectar();
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }*/
          }

          //Metodo para inserir informações no Banco de Dados
          private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          /*  try
            {
                command.Connection = connection;
                command.CommandText = "insert into devices(ip_address,description,category_id)values(@ip_address,@description,@category_id)";
                command.Parameters.AddWithValue("@ip_address", ip_address);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@category_id", comboBoxCategoria.SelectedValue);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
                MessageBox.Show("ADICIONADO");
                conexao.desconectar();

                textBoxIP.Clear();
                textBoxDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
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

        private void btnAdicionarCategoria_Click(object sender, EventArgs e)
        {

        }

    }
}
