namespace appComercio
{
    partial class frmCadastroCliente
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
            this.cbCadastroSetor = new System.Windows.Forms.ComboBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.lblCadastroSetor = new System.Windows.Forms.Label();
            this.lblCadastroSenha = new System.Windows.Forms.Label();
            this.txtCadastroSenha = new System.Windows.Forms.TextBox();
            this.txtCadastroUsuario = new System.Windows.Forms.TextBox();
            this.gbBuscarusuario = new System.Windows.Forms.GroupBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroUsuario = new System.Windows.Forms.Button();
            this.btnApagarCadastroUsuario = new System.Windows.Forms.Button();
            this.btnEditarCadastroUsuario = new System.Windows.Forms.Button();
            this.dgvCadastroUsuario = new System.Windows.Forms.DataGridView();
            this.gbCadastroUsuario.SuspendLayout();
            this.gbBuscarusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadastroUsuario
            // 
            this.gbCadastroUsuario.Controls.Add(this.cbCadastroSetor);
            this.gbCadastroUsuario.Controls.Add(this.ckbAtivo);
            this.gbCadastroUsuario.Controls.Add(this.lblCadastroNome);
            this.gbCadastroUsuario.Controls.Add(this.lblCadastroSetor);
            this.gbCadastroUsuario.Controls.Add(this.lblCadastroSenha);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroSenha);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroUsuario);
            this.gbCadastroUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroUsuario.Location = new System.Drawing.Point(2, 1);
            this.gbCadastroUsuario.Name = "gbCadastroUsuario";
            this.gbCadastroUsuario.Size = new System.Drawing.Size(371, 241);
            this.gbCadastroUsuario.TabIndex = 0;
            this.gbCadastroUsuario.TabStop = false;
            this.gbCadastroUsuario.Text = "Cadastro de Usuários";
            // 
            // cbCadastroSetor
            // 
            this.cbCadastroSetor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadastroSetor.FormattingEnabled = true;
            this.cbCadastroSetor.Location = new System.Drawing.Point(24, 179);
            this.cbCadastroSetor.Name = "cbCadastroSetor";
            this.cbCadastroSetor.Size = new System.Drawing.Size(305, 26);
            this.cbCadastroSetor.TabIndex = 3;
            this.cbCadastroSetor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAtivo.Location = new System.Drawing.Point(24, 213);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(15, 14);
            this.ckbAtivo.TabIndex = 4;
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroNome.Location = new System.Drawing.Point(26, 32);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(150, 19);
            this.lblCadastroNome.TabIndex = 1;
            this.lblCadastroNome.Text = "Qual e o seu nome";
            // 
            // lblCadastroSetor
            // 
            this.lblCadastroSetor.AutoSize = true;
            this.lblCadastroSetor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroSetor.Location = new System.Drawing.Point(20, 157);
            this.lblCadastroSetor.Name = "lblCadastroSetor";
            this.lblCadastroSetor.Size = new System.Drawing.Size(128, 19);
            this.lblCadastroSetor.TabIndex = 1;
            this.lblCadastroSetor.Text = "Escolha o setor";
            // 
            // lblCadastroSenha
            // 
            this.lblCadastroSenha.AutoSize = true;
            this.lblCadastroSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroSenha.Location = new System.Drawing.Point(20, 95);
            this.lblCadastroSenha.Name = "lblCadastroSenha";
            this.lblCadastroSenha.Size = new System.Drawing.Size(123, 19);
            this.lblCadastroSenha.TabIndex = 1;
            this.lblCadastroSenha.Text = "Crie sua senha";
            // 
            // txtCadastroSenha
            // 
            this.txtCadastroSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroSenha.Location = new System.Drawing.Point(24, 117);
            this.txtCadastroSenha.Name = "txtCadastroSenha";
            this.txtCadastroSenha.Size = new System.Drawing.Size(305, 26);
            this.txtCadastroSenha.TabIndex = 1;
            // 
            // txtCadastroUsuario
            // 
            this.txtCadastroUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroUsuario.Location = new System.Drawing.Point(24, 54);
            this.txtCadastroUsuario.Name = "txtCadastroUsuario";
            this.txtCadastroUsuario.Size = new System.Drawing.Size(305, 26);
            this.txtCadastroUsuario.TabIndex = 0;
            // 
            // gbBuscarusuario
            // 
            this.gbBuscarusuario.Controls.Add(this.btnBuscarUsuario);
            this.gbBuscarusuario.Controls.Add(this.txtBuscarUsuario);
            this.gbBuscarusuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarusuario.Location = new System.Drawing.Point(2, 248);
            this.gbBuscarusuario.Name = "gbBuscarusuario";
            this.gbBuscarusuario.Size = new System.Drawing.Size(371, 58);
            this.gbBuscarusuario.TabIndex = 1;
            this.gbBuscarusuario.TabStop = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(282, 16);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(83, 35);
            this.btnBuscarUsuario.TabIndex = 6;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.Location = new System.Drawing.Point(8, 19);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(270, 32);
            this.txtBuscarUsuario.TabIndex = 5;
            // 
            // btnSalvarCadastroUsuario
            // 
            this.btnSalvarCadastroUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvarCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarCadastroUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroUsuario.Location = new System.Drawing.Point(5, 326);
            this.btnSalvarCadastroUsuario.Name = "btnSalvarCadastroUsuario";
            this.btnSalvarCadastroUsuario.Size = new System.Drawing.Size(129, 45);
            this.btnSalvarCadastroUsuario.TabIndex = 7;
            this.btnSalvarCadastroUsuario.Text = "Salva";
            this.btnSalvarCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // btnApagarCadastroUsuario
            // 
            this.btnApagarCadastroUsuario.BackColor = System.Drawing.Color.LightCoral;
            this.btnApagarCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagarCadastroUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarCadastroUsuario.Location = new System.Drawing.Point(276, 326);
            this.btnApagarCadastroUsuario.Name = "btnApagarCadastroUsuario";
            this.btnApagarCadastroUsuario.Size = new System.Drawing.Size(80, 45);
            this.btnApagarCadastroUsuario.TabIndex = 9;
            this.btnApagarCadastroUsuario.Text = "Apagar";
            this.btnApagarCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarCadastroUsuario
            // 
            this.btnEditarCadastroUsuario.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditarCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCadastroUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCadastroUsuario.Location = new System.Drawing.Point(140, 325);
            this.btnEditarCadastroUsuario.Name = "btnEditarCadastroUsuario";
            this.btnEditarCadastroUsuario.Size = new System.Drawing.Size(129, 46);
            this.btnEditarCadastroUsuario.TabIndex = 8;
            this.btnEditarCadastroUsuario.Text = "Editar";
            this.btnEditarCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // dgvCadastroUsuario
            // 
            this.dgvCadastroUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCadastroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroUsuario.Location = new System.Drawing.Point(380, 13);
            this.dgvCadastroUsuario.Name = "dgvCadastroUsuario";
            this.dgvCadastroUsuario.Size = new System.Drawing.Size(408, 358);
            this.dgvCadastroUsuario.TabIndex = 10;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.dgvCadastroUsuario);
            this.Controls.Add(this.btnSalvarCadastroUsuario);
            this.Controls.Add(this.btnApagarCadastroUsuario);
            this.Controls.Add(this.btnEditarCadastroUsuario);
            this.Controls.Add(this.gbBuscarusuario);
            this.Controls.Add(this.gbCadastroUsuario);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.gbCadastroUsuario.ResumeLayout(false);
            this.gbCadastroUsuario.PerformLayout();
            this.gbBuscarusuario.ResumeLayout(false);
            this.gbBuscarusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroUsuario;
        private System.Windows.Forms.TextBox txtCadastroSenha;
        private System.Windows.Forms.TextBox txtCadastroUsuario;
        private System.Windows.Forms.Label lblCadastroSenha;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.ComboBox cbCadastroSetor;
        private System.Windows.Forms.Label lblCadastroSetor;
        private System.Windows.Forms.GroupBox gbBuscarusuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button btnSalvarCadastroUsuario;
        private System.Windows.Forms.Button btnApagarCadastroUsuario;
        private System.Windows.Forms.Button btnEditarCadastroUsuario;
        private System.Windows.Forms.DataGridView dgvCadastroUsuario;
    }
}