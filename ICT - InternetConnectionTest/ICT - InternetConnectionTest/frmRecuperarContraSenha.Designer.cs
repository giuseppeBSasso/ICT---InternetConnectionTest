namespace ICT___InternetConnectionTest
{
    partial class frmRecuperarContraSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecuperarSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.PictureBox();
            this.lblTituloRecuperarSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite Seu Nome de Usuário ou E-mail :";
            // 
            // txtRecuperarSenha
            // 
            this.txtRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecuperarSenha.Location = new System.Drawing.Point(30, 77);
            this.txtRecuperarSenha.Name = "txtRecuperarSenha";
            this.txtRecuperarSenha.Size = new System.Drawing.Size(301, 23);
            this.txtRecuperarSenha.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(337, 77);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(27, 116);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado :";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Image = global::ICT___InternetConnectionTest.Properties.Resources.Close_Icon;
            this.btnEncerrar.Location = new System.Drawing.Point(596, 3);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(15, 15);
            this.btnEncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEncerrar.TabIndex = 8;
            this.btnEncerrar.TabStop = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblTituloRecuperarSenha
            // 
            this.lblTituloRecuperarSenha.AutoSize = true;
            this.lblTituloRecuperarSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloRecuperarSenha.ForeColor = System.Drawing.Color.White;
            this.lblTituloRecuperarSenha.Location = new System.Drawing.Point(238, 2);
            this.lblTituloRecuperarSenha.Name = "lblTituloRecuperarSenha";
            this.lblTituloRecuperarSenha.Size = new System.Drawing.Size(150, 19);
            this.lblTituloRecuperarSenha.TabIndex = 9;
            this.lblTituloRecuperarSenha.Text = "RECUPERAR SENHA";
            // 
            // frmRecuperarContraSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(613, 229);
            this.Controls.Add(this.lblTituloRecuperarSenha);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtRecuperarSenha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperarContraSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecuperarContraSenha";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRecuperarContraSenha_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecuperarSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox btnEncerrar;
        private System.Windows.Forms.Label lblTituloRecuperarSenha;
    }
}