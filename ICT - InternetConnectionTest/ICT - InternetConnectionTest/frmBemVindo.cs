﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace ICT___InternetConnectionTest
{
    public partial class frmBemVindo : Form
    {
        public frmBemVindo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBarBemVindo.Value += 1;
            if (progressBarBemVindo.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void frmBemVindo_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserLoginCache.FirstName + ", " + UserLoginCache.LastName;
            this.Opacity = 0.0;
            progressBarBemVindo.Value = 0;
            progressBarBemVindo.Minimum = 0;
            progressBarBemVindo.Maximum = 100;

            timer1.Start();
        }
    }
}
