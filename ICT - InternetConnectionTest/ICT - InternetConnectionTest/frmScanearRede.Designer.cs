namespace ICT___InternetConnectionTest
{
    partial class frmScanearRede
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloScanearRedes = new System.Windows.Forms.Label();
            this.dgInfoEquipamentos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtSubNet = new System.Windows.Forms.TextBox();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfoEquipamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloScanearRedes
            // 
            this.lblTituloScanearRedes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloScanearRedes.AutoSize = true;
            this.lblTituloScanearRedes.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloScanearRedes.ForeColor = System.Drawing.Color.White;
            this.lblTituloScanearRedes.Location = new System.Drawing.Point(430, 10);
            this.lblTituloScanearRedes.Name = "lblTituloScanearRedes";
            this.lblTituloScanearRedes.Size = new System.Drawing.Size(157, 23);
            this.lblTituloScanearRedes.TabIndex = 0;
            this.lblTituloScanearRedes.Text = "SCANEAR REDES";
            // 
            // dgInfoEquipamentos
            // 
            this.dgInfoEquipamentos.AllowUserToAddRows = false;
            this.dgInfoEquipamentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgInfoEquipamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInfoEquipamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInfoEquipamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInfoEquipamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.dgInfoEquipamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgInfoEquipamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgInfoEquipamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInfoEquipamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgInfoEquipamentos.ColumnHeadersHeight = 30;
            this.dgInfoEquipamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgInfoEquipamentos.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInfoEquipamentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgInfoEquipamentos.EnableHeadersVisualStyles = false;
            this.dgInfoEquipamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgInfoEquipamentos.Location = new System.Drawing.Point(427, 50);
            this.dgInfoEquipamentos.Name = "dgInfoEquipamentos";
            this.dgInfoEquipamentos.ReadOnly = true;
            this.dgInfoEquipamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInfoEquipamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgInfoEquipamentos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.dgInfoEquipamentos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgInfoEquipamentos.Size = new System.Drawing.Size(481, 483);
            this.dgInfoEquipamentos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IP ADRESS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hostname";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "STATUS";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnScan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnScan.Location = new System.Drawing.Point(335, 52);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(86, 23);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSubNet
            // 
            this.txtSubNet.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSubNet.ForeColor = System.Drawing.Color.DimGray;
            this.txtSubNet.Location = new System.Drawing.Point(103, 50);
            this.txtSubNet.Name = "txtSubNet";
            this.txtSubNet.Size = new System.Drawing.Size(226, 27);
            this.txtSubNet.TabIndex = 1;
            this.txtSubNet.Text = "Exp : 192.168.0.";
            this.txtSubNet.Enter += new System.EventHandler(this.textBox1_Enter_1);
            this.txtSubNet.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubnet.ForeColor = System.Drawing.Color.White;
            this.lblSubnet.Location = new System.Drawing.Point(11, 54);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(86, 20);
            this.lblSubnet.TabIndex = 4;
            this.lblSubnet.Text = "SUBNET :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrar.FlatAppearance.BorderSize = 0;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.Color.White;
            this.btnEncerrar.Location = new System.Drawing.Point(893, 3);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(21, 30);
            this.btnEncerrar.TabIndex = 18;
            this.btnEncerrar.Text = "X";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // frmScanearRede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(920, 545);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.dgInfoEquipamentos);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtSubNet);
            this.Controls.Add(this.lblSubnet);
            this.Controls.Add(this.lblTituloScanearRedes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScanearRede";
            this.Text = "frmScanearRede";
            ((System.ComponentModel.ISupportInitialize)(this.dgInfoEquipamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloScanearRedes;
        private System.Windows.Forms.DataGridView dgInfoEquipamentos;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtSubNet;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEncerrar;
    }
}