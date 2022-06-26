namespace ICT___InternetConnectionTest
{
    partial class frmSobreICT
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
            this.btnEncerrar = new System.Windows.Forms.PictureBox();
            this.lblTituloSobre = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCriador = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Image = global::ICT___InternetConnectionTest.Properties.Resources.Close_Icon;
            this.btnEncerrar.Location = new System.Drawing.Point(595, 4);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(15, 15);
            this.btnEncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEncerrar.TabIndex = 9;
            this.btnEncerrar.TabStop = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblTituloSobre
            // 
            this.lblTituloSobre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloSobre.AutoSize = true;
            this.lblTituloSobre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloSobre.ForeColor = System.Drawing.Color.White;
            this.lblTituloSobre.Location = new System.Drawing.Point(282, 2);
            this.lblTituloSobre.Name = "lblTituloSobre";
            this.lblTituloSobre.Size = new System.Drawing.Size(56, 19);
            this.lblTituloSobre.TabIndex = 10;
            this.lblTituloSobre.Text = "SOBRE";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(12, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 32);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "ICT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "InternetConnectionTest";
            // 
            // lblCriador
            // 
            this.lblCriador.AutoSize = true;
            this.lblCriador.BackColor = System.Drawing.Color.Gray;
            this.lblCriador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriador.ForeColor = System.Drawing.Color.White;
            this.lblCriador.Location = new System.Drawing.Point(192, 201);
            this.lblCriador.Name = "lblCriador";
            this.lblCriador.Size = new System.Drawing.Size(238, 19);
            this.lblCriador.TabIndex = 13;
            this.lblCriador.Text = "By : GIUSEPPE BIAZOTTO SASSO";
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(505, 85);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(96, 32);
            this.lblVersao.TabIndex = 14;
            this.lblVersao.Text = "V : 1.0";
            // 
            // frmSobreICT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(613, 229);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblCriador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTituloSobre);
            this.Controls.Add(this.btnEncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSobreICT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SobreICT";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSobreICT_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnEncerrar;
        private System.Windows.Forms.Label lblTituloSobre;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCriador;
        private System.Windows.Forms.Label lblVersao;
    }
}