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
using System.Threading.Tasks;
using static System.Console;

//add do scan
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace ICT___InternetConnectionTest
{
    public partial class frmScanearRede : Form
    {
        public frmScanearRede()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            Ping ping;
            IPAddress addr;
            PingReply pingReply;
            IPHostEntry host;
            String name;

            Parallel.For(0, 254, (i, loopState) =>
            {              
                ping = new Ping();
                pingReply = ping.Send(textBox1.Text + i.ToString());          

                this.BeginInvoke((Action)delegate ()
                {
                    if (pingReply.Status == IPStatus.Success)
                    {
                        try
                        {
                            addr = IPAddress.Parse(textBox1.Text + i.ToString());
                            host = Dns.GetHostEntry(addr);
                            name = host.HostName;

                            dataGridView1.Rows.Add();
                            int nRowIndex = dataGridView1.Rows.Count - 1;
                            dataGridView1.Rows[nRowIndex].Cells[0].Value = textBox1.Text + i.ToString();
                            dataGridView1.Rows[nRowIndex].Cells[1].Value = name;
                            dataGridView1.Rows[nRowIndex].Cells[2].Value = "ATIVO";
                        }
                        catch (SocketException ex)
                        {
                            name = "?";
                        }
                    }                   
                });
            });          
            MessageBox.Show("Scan Completo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Exp : 192.168.0.")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Exp : 192.168.0.";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
