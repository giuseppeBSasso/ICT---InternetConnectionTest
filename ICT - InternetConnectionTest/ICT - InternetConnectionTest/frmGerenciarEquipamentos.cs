using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT___InternetConnectionTest
{
    public partial class frmGerenciarEquipamentos : Form
    {
        public frmGerenciarEquipamentos()
        {
            InitializeComponent();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DesligarEquipamento()
        {
            ProcessStartInfo systeminfo = new  ProcessStartInfo();
            Process process = new Process();
            string NomeEquipamento;

            //Constroi e executa o comando
            NomeEquipamento = "shutdown /s /f /m " + txtNomeEquipamento.Text;
            systeminfo.FileName = "PowerShell.exe";
            systeminfo.Arguments = NomeEquipamento;
            process.StartInfo = systeminfo;

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
        }

        private void ReiniciaEquipamento()
        {
            ProcessStartInfo systeminfo = new ProcessStartInfo();
            Process process = new Process();
            string NomeEquipamento;

            //Constroi e executa o comando
            NomeEquipamento = "shutdown /r /f /m " + txtNomeEquipamento.Text;
            systeminfo.FileName = "PowerShell.exe";
            systeminfo.Arguments = NomeEquipamento;
            process.StartInfo = systeminfo;

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            DesligarEquipamento();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciaEquipamento();
        }
    }
}
