namespace appComercio
{
    partial class frmCadastroUsuario
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
            this.gbCadastroUsuario = new System.Windows.Forms.GroupBox();
            this.txtCadastroUsuario = new System.Windows.Forms.TextBox();
            this.txtCadastroSenha = new System.Windows.Forms.TextBox();
            this.cbCadastroSetor = new System.Windows.Forms.ComboBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.gbBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.gbCadastroUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastroUsuario
            // 
            this.gbCadastroUsuario.Controls.Add(this.ckbAtivo);
            this.gbCadastroUsuario.Controls.Add(this.cbCadastroSetor);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroSenha);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroUsuario);
            this.gbCadastroUsuario.Location = new System.Drawing.Point(-4, 2);
            this.gbCadastroUsuario.Name = "gbCadastroUsuario";
            this.gbCadastroUsuario.Size = new System.Drawing.Size(265, 234);
            this.gbCadastroUsuario.TabIndex = 0;
            this.gbCadastroUsuario.TabStop = false;
            this.gbCadastroUsuario.Text = "Cadastro do Usuário:";
            // 
            // txtCadastroUsuario
            // 
            this.txtCadastroUsuario.Location = new System.Drawing.Point(21, 35);
            this.txtCadastroUsuario.Name = "txtCadastroUsuario";
            this.txtCadastroUsuario.Size = new System.Drawing.Size(221, 20);
            this.txtCadastroUsuario.TabIndex = 0;
            // 
            // txtCadastroSenha
            // 
            this.txtCadastroSenha.Location = new System.Drawing.Point(21, 88);
            this.txtCadastroSenha.Name = "txtCadastroSenha";
            this.txtCadastroSenha.Size = new System.Drawing.Size(221, 20);
            this.txtCadastroSenha.TabIndex = 1;
            // 
            // cbCadastroSetor
            // 
            this.cbCadastroSetor.FormattingEnabled = true;
            this.cbCadastroSetor.Items.AddRange(new object[] {
            "",
            "Vendas",
            "Administrativo"});
            this.cbCadastroSetor.Location = new System.Drawing.Point(21, 139);
            this.cbCadastroSetor.Name = "cbCadastroSetor";
            this.cbCadastroSetor.Size = new System.Drawing.Size(221, 21);
            this.cbCadastroSetor.TabIndex = 2;
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAtivo.Location = new System.Drawing.Point(21, 187);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(54, 20);
            this.ckbAtivo.TabIndex = 3;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbBuscarUsuario
            // 
            this.gbBuscarUsuario.Location = new System.Drawing.Point(-4, 278);
            this.gbBuscarUsuario.Name = "gbBuscarUsuario";
            this.gbBuscarUsuario.Size = new System.Drawing.Size(265, 160);
            this.gbBuscarUsuario.TabIndex = 1;
            this.gbBuscarUsuario.TabStop = false;
            this.gbBuscarUsuario.Text = "Buscar Usuário";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbBuscarUsuario);
            this.Controls.Add(this.gbCadastroUsuario);
            this.Name = "frmCadastroUsuario";
            this.Text = "frmCadastroUsuario";
            this.gbCadastroUsuario.ResumeLayout(false);
            this.gbCadastroUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroUsuario;
        private System.Windows.Forms.TextBox txtCadastroUsuario;
        private System.Windows.Forms.TextBox txtCadastroSenha;
        private System.Windows.Forms.ComboBox cbCadastroSetor;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.GroupBox gbBuscarUsuario;
    }
}