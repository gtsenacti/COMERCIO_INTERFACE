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
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.cbCadastroSetor = new System.Windows.Forms.ComboBox();
            this.txtCadastroSenha = new System.Windows.Forms.TextBox();
            this.txtCadastroUsuario = new System.Windows.Forms.TextBox();
            this.gbBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroUsuario = new System.Windows.Forms.Button();
            this.btnEditarCadastroUsuario = new System.Windows.Forms.Button();
            this.btnApagarCadastroUsuario = new System.Windows.Forms.Button();
            this.dgvCadastroUsuario = new System.Windows.Forms.DataGridView();
            this.gbCadastroUsuario.SuspendLayout();
            this.gbBuscarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadastroUsuario
            // 
            this.gbCadastroUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.gbCadastroUsuario.Controls.Add(this.lblSetor);
            this.gbCadastroUsuario.Controls.Add(this.lblSenha);
            this.gbCadastroUsuario.Controls.Add(this.lblCadastro);
            this.gbCadastroUsuario.Controls.Add(this.ckbAtivo);
            this.gbCadastroUsuario.Controls.Add(this.cbCadastroSetor);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroSenha);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroUsuario);
            this.gbCadastroUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroUsuario.Location = new System.Drawing.Point(-4, 2);
            this.gbCadastroUsuario.Name = "gbCadastroUsuario";
            this.gbCadastroUsuario.Size = new System.Drawing.Size(265, 234);
            this.gbCadastroUsuario.TabIndex = 0;
            this.gbCadastroUsuario.TabStop = false;
            this.gbCadastroUsuario.Text = "Cadastro do Usuário:";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Arial", 8F);
            this.lblSetor.Location = new System.Drawing.Point(18, 126);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(33, 14);
            this.lblSetor.TabIndex = 6;
            this.lblSetor.Text = "Setor";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 8F);
            this.lblSenha.Location = new System.Drawing.Point(18, 75);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 14);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Arial", 8F);
            this.lblCadastro.Location = new System.Drawing.Point(18, 25);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(54, 14);
            this.lblCadastro.TabIndex = 4;
            this.lblCadastro.Text = "Cadastro:";
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.ckbAtivo.Location = new System.Drawing.Point(21, 187);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(62, 20);
            this.ckbAtivo.TabIndex = 3;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // cbCadastroSetor
            // 
            this.cbCadastroSetor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.cbCadastroSetor.FormattingEnabled = true;
            this.cbCadastroSetor.Items.AddRange(new object[] {
            "",
            "Vendas",
            "Administrativo"});
            this.cbCadastroSetor.Location = new System.Drawing.Point(21, 145);
            this.cbCadastroSetor.Name = "cbCadastroSetor";
            this.cbCadastroSetor.Size = new System.Drawing.Size(221, 24);
            this.cbCadastroSetor.TabIndex = 2;
            // 
            // txtCadastroSenha
            // 
            this.txtCadastroSenha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.txtCadastroSenha.Location = new System.Drawing.Point(21, 94);
            this.txtCadastroSenha.Name = "txtCadastroSenha";
            this.txtCadastroSenha.Size = new System.Drawing.Size(221, 23);
            this.txtCadastroSenha.TabIndex = 1;
            this.txtCadastroSenha.TextChanged += new System.EventHandler(this.txtCadastroSenha_TextChanged);
            // 
            // txtCadastroUsuario
            // 
            this.txtCadastroUsuario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.txtCadastroUsuario.Location = new System.Drawing.Point(21, 44);
            this.txtCadastroUsuario.Name = "txtCadastroUsuario";
            this.txtCadastroUsuario.Size = new System.Drawing.Size(221, 23);
            this.txtCadastroUsuario.TabIndex = 0;
            this.txtCadastroUsuario.TextChanged += new System.EventHandler(this.txtCadastroUsuario_TextChanged);
            // 
            // gbBuscarUsuario
            // 
            this.gbBuscarUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.gbBuscarUsuario.Controls.Add(this.btnBuscarUsuario);
            this.gbBuscarUsuario.Controls.Add(this.txtBuscarUsuario);
            this.gbBuscarUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarUsuario.Location = new System.Drawing.Point(-4, 278);
            this.gbBuscarUsuario.Name = "gbBuscarUsuario";
            this.gbBuscarUsuario.Size = new System.Drawing.Size(265, 69);
            this.gbBuscarUsuario.TabIndex = 1;
            this.gbBuscarUsuario.TabStop = false;
            this.gbBuscarUsuario.Text = "Buscar Usuário";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarUsuario.Location = new System.Drawing.Point(187, 25);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(78, 29);
            this.btnBuscarUsuario.TabIndex = 1;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(16, 27);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(164, 22);
            this.txtBuscarUsuario.TabIndex = 0;
            // 
            // btnSalvarCadastroUsuario
            // 
            this.btnSalvarCadastroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvarCadastroUsuario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvarCadastroUsuario.Location = new System.Drawing.Point(17, 377);
            this.btnSalvarCadastroUsuario.Name = "btnSalvarCadastroUsuario";
            this.btnSalvarCadastroUsuario.Size = new System.Drawing.Size(74, 40);
            this.btnSalvarCadastroUsuario.TabIndex = 2;
            this.btnSalvarCadastroUsuario.Text = "Salvar";
            this.btnSalvarCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarCadastroUsuario
            // 
            this.btnEditarCadastroUsuario.BackColor = System.Drawing.Color.Yellow;
            this.btnEditarCadastroUsuario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarCadastroUsuario.Location = new System.Drawing.Point(97, 377);
            this.btnEditarCadastroUsuario.Name = "btnEditarCadastroUsuario";
            this.btnEditarCadastroUsuario.Size = new System.Drawing.Size(80, 40);
            this.btnEditarCadastroUsuario.TabIndex = 3;
            this.btnEditarCadastroUsuario.Text = "Editar";
            this.btnEditarCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // btnApagarCadastroUsuario
            // 
            this.btnApagarCadastroUsuario.BackColor = System.Drawing.Color.Red;
            this.btnApagarCadastroUsuario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnApagarCadastroUsuario.Location = new System.Drawing.Point(183, 377);
            this.btnApagarCadastroUsuario.Name = "btnApagarCadastroUsuario";
            this.btnApagarCadastroUsuario.Size = new System.Drawing.Size(77, 40);
            this.btnApagarCadastroUsuario.TabIndex = 4;
            this.btnApagarCadastroUsuario.Text = "Apagar";
            this.btnApagarCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // dgvCadastroUsuario
            // 
            this.dgvCadastroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroUsuario.Location = new System.Drawing.Point(299, 2);
            this.dgvCadastroUsuario.Name = "dgvCadastroUsuario";
            this.dgvCadastroUsuario.Size = new System.Drawing.Size(489, 436);
            this.dgvCadastroUsuario.TabIndex = 5;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCadastroUsuario);
            this.Controls.Add(this.btnApagarCadastroUsuario);
            this.Controls.Add(this.btnEditarCadastroUsuario);
            this.Controls.Add(this.btnSalvarCadastroUsuario);
            this.Controls.Add(this.gbBuscarUsuario);
            this.Controls.Add(this.gbCadastroUsuario);
            this.Name = "frmCadastroUsuario";
            this.Text = "Pica Pau Móveis Rusticos";
            this.gbCadastroUsuario.ResumeLayout(false);
            this.gbCadastroUsuario.PerformLayout();
            this.gbBuscarUsuario.ResumeLayout(false);
            this.gbBuscarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroUsuario;
        private System.Windows.Forms.TextBox txtCadastroUsuario;
        private System.Windows.Forms.TextBox txtCadastroSenha;
        private System.Windows.Forms.ComboBox cbCadastroSetor;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.GroupBox gbBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnSalvarCadastroUsuario;
        private System.Windows.Forms.Button btnEditarCadastroUsuario;
        private System.Windows.Forms.Button btnApagarCadastroUsuario;
        private System.Windows.Forms.DataGridView dgvCadastroUsuario;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCadastro;
    }
}