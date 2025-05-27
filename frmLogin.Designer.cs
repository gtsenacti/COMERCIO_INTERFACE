namespace appComercio
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbTelaLogin = new System.Windows.Forms.PictureBox();
            this.gbTelaLogin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaLogin)).BeginInit();
            this.gbTelaLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTelaLogin
            // 
            this.pbTelaLogin.Location = new System.Drawing.Point(1, 2);
            this.pbTelaLogin.Name = "pbTelaLogin";
            this.pbTelaLogin.Size = new System.Drawing.Size(272, 289);
            this.pbTelaLogin.TabIndex = 0;
            this.pbTelaLogin.TabStop = false;
            // 
            // gbTelaLogin
            // 
            this.gbTelaLogin.Controls.Add(this.lblTituloLogin);
            this.gbTelaLogin.Controls.Add(this.lblUsuario);
            this.gbTelaLogin.Controls.Add(this.txtUsuario);
            this.gbTelaLogin.Controls.Add(this.lblSenha);
            this.gbTelaLogin.Controls.Add(this.txtSenha);
            this.gbTelaLogin.Controls.Add(this.lblSetor);
            this.gbTelaLogin.Controls.Add(this.cbSetor);
            this.gbTelaLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTelaLogin.Location = new System.Drawing.Point(279, 2);
            this.gbTelaLogin.Name = "gbTelaLogin";
            this.gbTelaLogin.Size = new System.Drawing.Size(337, 227);
            this.gbTelaLogin.TabIndex = 1;
            this.gbTelaLogin.TabStop = false;
            this.gbTelaLogin.Text = "Dados do usuário";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(414, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Entrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(550, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sair";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cbSetor
            // 
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Items.AddRange(new object[] {
            "",
            "Administrativo",
            "Estoque",
            "Financeiro",
            "Secretariado",
            "Vendas"});
            this.cbSetor.Location = new System.Drawing.Point(6, 191);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(325, 26);
            this.cbSetor.TabIndex = 0;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(3, 170);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(56, 19);
            this.lblSetor.TabIndex = 1;
            this.lblSetor.Text = "Setor:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 141);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(325, 26);
            this.txtSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(3, 120);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 19);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(7, 91);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(324, 26);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(6, 70);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 19);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.Location = new System.Drawing.Point(51, 31);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(240, 29);
            this.lblTituloLogin.TabIndex = 6;
            this.lblTituloLogin.Text = "Sistemas de Gestão";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(279, 235);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 45);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastro";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 292);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbTelaLogin);
            this.Controls.Add(this.pbTelaLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaLogin)).EndInit();
            this.gbTelaLogin.ResumeLayout(false);
            this.gbTelaLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTelaLogin;
        private System.Windows.Forms.GroupBox gbTelaLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

