namespace ICT___InternetConnectionTest
{
    partial class frmGerenciarEquipamentos
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
            this.lblTituloGerenciarEquipamentos = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.txtNomeEquipamento = new System.Windows.Forms.TextBox();
            this.btnReiniciar = new System.Windows.Forms.PictureBox();
            this.btnDesligar = new System.Windows.Forms.PictureBox();
            this.lblBtnDesligar = new System.Windows.Forms.Label();
            this.lblBtnReiniciar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesligar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloGerenciarEquipamentos
            // 
            this.lblTituloGerenciarEquipamentos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloGerenciarEquipamentos.AutoSize = true;
            this.lblTituloGerenciarEquipamentos.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGerenciarEquipamentos.ForeColor = System.Drawing.Color.White;
            this.lblTituloGerenciarEquipamentos.Location = new System.Drawing.Point(428, 10);
            this.lblTituloGerenciarEquipamentos.Name = "lblTituloGerenciarEquipamentos";
            this.lblTituloGerenciarEquipamentos.Size = new System.Drawing.Size(264, 23);
            this.lblTituloGerenciarEquipamentos.TabIndex = 1;
            this.lblTituloGerenciarEquipamentos.Text = "GERENCIAR EQUIPAMENTOS";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrar.FlatAppearance.BorderSize = 0;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.Color.White;
            this.btnEncerrar.Location = new System.Drawing.Point(895, 3);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(21, 30);
            this.btnEncerrar.TabIndex = 19;
            this.btnEncerrar.Text = "X";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubnet.ForeColor = System.Drawing.Color.White;
            this.lblSubnet.Location = new System.Drawing.Point(12, 78);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(248, 20);
            this.lblSubnet.TabIndex = 20;
            this.lblSubnet.Text = "Nomre do Equipamento :";
            // 
            // txtNomeEquipamento
            // 
            this.txtNomeEquipamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEquipamento.Location = new System.Drawing.Point(266, 76);
            this.txtNomeEquipamento.Name = "txtNomeEquipamento";
            this.txtNomeEquipamento.Size = new System.Drawing.Size(242, 24);
            this.txtNomeEquipamento.TabIndex = 21;
            this.txtNomeEquipamento.Text = "\\\\";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Image = global::ICT___InternetConnectionTest.Properties.Resources.atualizar;
            this.btnReiniciar.Location = new System.Drawing.Point(565, 74);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(32, 32);
            this.btnReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnReiniciar.TabIndex = 23;
            this.btnReiniciar.TabStop = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesligar.Image = global::ICT___InternetConnectionTest.Properties.Resources.desligar;
            this.btnDesligar.Location = new System.Drawing.Point(514, 74);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(32, 32);
            this.btnDesligar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDesligar.TabIndex = 22;
            this.btnDesligar.TabStop = false;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // lblBtnDesligar
            // 
            this.lblBtnDesligar.AutoSize = true;
            this.lblBtnDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnDesligar.ForeColor = System.Drawing.Color.White;
            this.lblBtnDesligar.Location = new System.Drawing.Point(510, 109);
            this.lblBtnDesligar.Name = "lblBtnDesligar";
            this.lblBtnDesligar.Size = new System.Drawing.Size(44, 9);
            this.lblBtnDesligar.TabIndex = 24;
            this.lblBtnDesligar.Text = "DESLIGAR";
            // 
            // lblBtnReiniciar
            // 
            this.lblBtnReiniciar.AutoSize = true;
            this.lblBtnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnReiniciar.ForeColor = System.Drawing.Color.White;
            this.lblBtnReiniciar.Location = new System.Drawing.Point(559, 109);
            this.lblBtnReiniciar.Name = "lblBtnReiniciar";
            this.lblBtnReiniciar.Size = new System.Drawing.Size(45, 9);
            this.lblBtnReiniciar.TabIndex = 25;
            this.lblBtnReiniciar.Text = "REINICIAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(263, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "OBS: Deve Haver um \\\\ antes do nome da maquina.";
            // 
            // frmGerenciarEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(920, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBtnReiniciar);
            this.Controls.Add(this.lblBtnDesligar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.txtNomeEquipamento);
            this.Controls.Add(this.lblSubnet);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lblTituloGerenciarEquipamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGerenciarEquipamentos";
            this.Text = "frmGerenciarEquipamentos";
            ((System.ComponentModel.ISupportInitialize)(this.btnReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesligar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloGerenciarEquipamentos;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.TextBox txtNomeEquipamento;
        private System.Windows.Forms.PictureBox btnDesligar;
        private System.Windows.Forms.PictureBox btnReiniciar;
        private System.Windows.Forms.Label lblBtnDesligar;
        private System.Windows.Forms.Label lblBtnReiniciar;
        private System.Windows.Forms.Label label4;
    }
}