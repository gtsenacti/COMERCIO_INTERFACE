namespace appComercio
{
    partial class Cadastro
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
            this.txtCadastroDeUsuario = new System.Windows.Forms.TextBox();
            this.txtCadastroDeSenha = new System.Windows.Forms.TextBox();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCadastroDeUsuario
            // 
            this.txtCadastroDeUsuario.Location = new System.Drawing.Point(292, 120);
            this.txtCadastroDeUsuario.Name = "txtCadastroDeUsuario";
            this.txtCadastroDeUsuario.Size = new System.Drawing.Size(297, 20);
            this.txtCadastroDeUsuario.TabIndex = 0;
            this.txtCadastroDeUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCadastroDeSenha
            // 
            this.txtCadastroDeSenha.Location = new System.Drawing.Point(292, 178);
            this.txtCadastroDeSenha.Name = "txtCadastroDeSenha";
            this.txtCadastroDeSenha.PasswordChar = '*';
            this.txtCadastroDeSenha.Size = new System.Drawing.Size(297, 20);
            this.txtCadastroDeSenha.TabIndex = 1;
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.AutoSize = true;
            this.lblCadastroUsuario.Location = new System.Drawing.Point(151, 127);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(133, 13);
            this.lblCadastroUsuario.TabIndex = 2;
            this.lblCadastroUsuario.Text = "Cadastrar nome do usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastrar senha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(292, 234);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(297, 20);
            this.txtConfirmarSenha.TabIndex = 4;
            this.txtConfirmarSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(179, 237);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(83, 13);
            this.lblConfirmarSenha.TabIndex = 5;
            this.lblConfirmarSenha.Text = "Confirmar senha";
            this.lblConfirmarSenha.Click += new System.EventHandler(this.lblConfirmarSenha_Click);
            // 
            // btnCadastar
            // 
            this.btnCadastar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastar.Location = new System.Drawing.Point(329, 355);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(153, 36);
            this.btnCadastar.TabIndex = 6;
            this.btnCadastar.Text = "Cadastrar";
            this.btnCadastar.UseVisualStyleBackColor = false;
            this.btnCadastar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastar);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCadastroUsuario);
            this.Controls.Add(this.txtCadastroDeSenha);
            this.Controls.Add(this.txtCadastroDeUsuario);
            this.Name = "Cadastro";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadastroDeUsuario;
        private System.Windows.Forms.TextBox txtCadastroDeSenha;
        private System.Windows.Forms.Label lblCadastroUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Button btnCadastar;
    }
}