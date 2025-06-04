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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.gbCadastroUsuario = new System.Windows.Forms.GroupBox();
            this.lblCadastroSetor = new System.Windows.Forms.Label();
            this.lblCadastroSenha = new System.Windows.Forms.Label();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCadastroSetor = new System.Windows.Forms.ComboBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.txtCadastroSenha = new System.Windows.Forms.TextBox();
            this.txtCadastroUsuario = new System.Windows.Forms.TextBox();
            this.gbBuscaUsuario = new System.Windows.Forms.GroupBox();
            this.btnBuscaUsuario = new System.Windows.Forms.Button();
            this.txtBuscaUsuario = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroUsuario = new System.Windows.Forms.Button();
            this.btnEditarCadastroUsuario = new System.Windows.Forms.Button();
            this.btnApagarCadastroUsuario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbCadastroUsuario.SuspendLayout();
            this.gbBuscaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadastroUsuario
            // 
            this.gbCadastroUsuario.Controls.Add(this.lblCadastroSetor);
            this.gbCadastroUsuario.Controls.Add(this.lblCadastroSenha);
            this.gbCadastroUsuario.Controls.Add(this.lblCadastroUsuario);
            this.gbCadastroUsuario.Controls.Add(this.groupBox1);
            this.gbCadastroUsuario.Controls.Add(this.cbCadastroSetor);
            this.gbCadastroUsuario.Controls.Add(this.ckbAtivo);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroSenha);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroUsuario);
            this.gbCadastroUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbCadastroUsuario.Name = "gbCadastroUsuario";
            this.gbCadastroUsuario.Size = new System.Drawing.Size(294, 229);
            this.gbCadastroUsuario.TabIndex = 0;
            this.gbCadastroUsuario.TabStop = false;
            this.gbCadastroUsuario.Text = "Cadastro Usuário";
            // 
            // lblCadastroSetor
            // 
            this.lblCadastroSetor.AutoSize = true;
            this.lblCadastroSetor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroSetor.Location = new System.Drawing.Point(25, 122);
            this.lblCadastroSetor.Name = "lblCadastroSetor";
            this.lblCadastroSetor.Size = new System.Drawing.Size(36, 14);
            this.lblCadastroSetor.TabIndex = 8;
            this.lblCadastroSetor.Text = "Setor:";
            // 
            // lblCadastroSenha
            // 
            this.lblCadastroSenha.AutoSize = true;
            this.lblCadastroSenha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroSenha.Location = new System.Drawing.Point(22, 65);
            this.lblCadastroSenha.Name = "lblCadastroSenha";
            this.lblCadastroSenha.Size = new System.Drawing.Size(41, 14);
            this.lblCadastroSenha.TabIndex = 7;
            this.lblCadastroSenha.Text = "Senha:";
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.AutoSize = true;
            this.lblCadastroUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroUsuario.Location = new System.Drawing.Point(22, 11);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(47, 14);
            this.lblCadastroUsuario.TabIndex = 6;
            this.lblCadastroUsuario.Text = "Usuário:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(108, -78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbCadastroSetor
            // 
            this.cbCadastroSetor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadastroSetor.FormattingEnabled = true;
            this.cbCadastroSetor.Items.AddRange(new object[] {
            "",
            "secretaria",
            "administração",
            "faturamento"});
            this.cbCadastroSetor.Location = new System.Drawing.Point(25, 141);
            this.cbCadastroSetor.Name = "cbCadastroSetor";
            this.cbCadastroSetor.Size = new System.Drawing.Size(255, 30);
            this.cbCadastroSetor.TabIndex = 4;
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAtivo.Location = new System.Drawing.Point(25, 193);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(54, 20);
            this.ckbAtivo.TabIndex = 3;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtCadastroSenha
            // 
            this.txtCadastroSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroSenha.Location = new System.Drawing.Point(25, 81);
            this.txtCadastroSenha.Name = "txtCadastroSenha";
            this.txtCadastroSenha.Size = new System.Drawing.Size(255, 29);
            this.txtCadastroSenha.TabIndex = 1;
            // 
            // txtCadastroUsuario
            // 
            this.txtCadastroUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroUsuario.Location = new System.Drawing.Point(25, 28);
            this.txtCadastroUsuario.Name = "txtCadastroUsuario";
            this.txtCadastroUsuario.Size = new System.Drawing.Size(255, 29);
            this.txtCadastroUsuario.TabIndex = 0;
            this.txtCadastroUsuario.UseSystemPasswordChar = true;
            // 
            // gbBuscaUsuario
            // 
            this.gbBuscaUsuario.Controls.Add(this.btnBuscaUsuario);
            this.gbBuscaUsuario.Controls.Add(this.txtBuscaUsuario);
            this.gbBuscaUsuario.Location = new System.Drawing.Point(12, 274);
            this.gbBuscaUsuario.Name = "gbBuscaUsuario";
            this.gbBuscaUsuario.Size = new System.Drawing.Size(294, 78);
            this.gbBuscaUsuario.TabIndex = 1;
            this.gbBuscaUsuario.TabStop = false;
            this.gbBuscaUsuario.Text = "Busca Usuário:";
            // 
            // btnBuscaUsuario
            // 
            this.btnBuscaUsuario.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscaUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaUsuario.Location = new System.Drawing.Point(205, 19);
            this.btnBuscaUsuario.Name = "btnBuscaUsuario";
            this.btnBuscaUsuario.Size = new System.Drawing.Size(91, 29);
            this.btnBuscaUsuario.TabIndex = 1;
            this.btnBuscaUsuario.Text = "Buscar";
            this.btnBuscaUsuario.UseVisualStyleBackColor = false;
            // 
            // txtBuscaUsuario
            // 
            this.txtBuscaUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaUsuario.Location = new System.Drawing.Point(6, 19);
            this.txtBuscaUsuario.Name = "txtBuscaUsuario";
            this.txtBuscaUsuario.Size = new System.Drawing.Size(193, 29);
            this.txtBuscaUsuario.TabIndex = 0;
            // 
            // btnSalvarCadastroUsuario
            // 
            this.btnSalvarCadastroUsuario.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSalvarCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarCadastroUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroUsuario.Location = new System.Drawing.Point(12, 360);
            this.btnSalvarCadastroUsuario.Name = "btnSalvarCadastroUsuario";
            this.btnSalvarCadastroUsuario.Size = new System.Drawing.Size(79, 33);
            this.btnSalvarCadastroUsuario.TabIndex = 2;
            this.btnSalvarCadastroUsuario.Text = "Salvar";
            this.btnSalvarCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarCadastroUsuario
            // 
            this.btnEditarCadastroUsuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditarCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCadastroUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCadastroUsuario.Location = new System.Drawing.Point(120, 360);
            this.btnEditarCadastroUsuario.Name = "btnEditarCadastroUsuario";
            this.btnEditarCadastroUsuario.Size = new System.Drawing.Size(79, 32);
            this.btnEditarCadastroUsuario.TabIndex = 3;
            this.btnEditarCadastroUsuario.Text = "Editar";
            this.btnEditarCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // btnApagarCadastroUsuario
            // 
            this.btnApagarCadastroUsuario.BackColor = System.Drawing.Color.Tomato;
            this.btnApagarCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarCadastroUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarCadastroUsuario.Location = new System.Drawing.Point(230, 361);
            this.btnApagarCadastroUsuario.Name = "btnApagarCadastroUsuario";
            this.btnApagarCadastroUsuario.Size = new System.Drawing.Size(78, 32);
            this.btnApagarCadastroUsuario.TabIndex = 4;
            this.btnApagarCadastroUsuario.Text = "Apagar";
            this.btnApagarCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 413);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(435, 163);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 6;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnApagarCadastroUsuario);
            this.Controls.Add(this.btnEditarCadastroUsuario);
            this.Controls.Add(this.btnSalvarCadastroUsuario);
            this.Controls.Add(this.gbBuscaUsuario);
            this.Controls.Add(this.gbCadastroUsuario);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuario";
            this.Text = "Casa Fernandes - Tela de Cadastro de Usuários";
            this.gbCadastroUsuario.ResumeLayout(false);
            this.gbCadastroUsuario.PerformLayout();
            this.gbBuscaUsuario.ResumeLayout(false);
            this.gbBuscaUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroUsuario;
        private System.Windows.Forms.TextBox txtCadastroUsuario;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.TextBox txtCadastroSenha;
        private System.Windows.Forms.ComboBox cbCadastroSetor;
        private System.Windows.Forms.GroupBox gbBuscaUsuario;
        private System.Windows.Forms.TextBox txtBuscaUsuario;
        private System.Windows.Forms.Button btnBuscaUsuario;
        private System.Windows.Forms.Button btnSalvarCadastroUsuario;
        private System.Windows.Forms.Button btnEditarCadastroUsuario;
        private System.Windows.Forms.Button btnApagarCadastroUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCadastroUsuario;
        private System.Windows.Forms.Label lblCadastroSenha;
        private System.Windows.Forms.Label lblCadastroSetor;
    }
}