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
            this.dgvCadastroUsuario = new System.Windows.Forms.DataGridView();
            this.gbCadastroUsuario = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCadastroSetor = new System.Windows.Forms.TextBox();
            this.txtCadastroSenha = new System.Windows.Forms.TextBox();
            this.txtCadastroNome = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pbLogoCadastroUsuario = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroUsuario)).BeginInit();
            this.gbCadastroUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCadastroUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCadastroUsuario
            // 
            this.dgvCadastroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroUsuario.Location = new System.Drawing.Point(338, 12);
            this.dgvCadastroUsuario.Name = "dgvCadastroUsuario";
            this.dgvCadastroUsuario.Size = new System.Drawing.Size(311, 517);
            this.dgvCadastroUsuario.TabIndex = 0;
            // 
            // gbCadastroUsuario
            // 
            this.gbCadastroUsuario.Controls.Add(this.pbLogoCadastroUsuario);
            this.gbCadastroUsuario.Controls.Add(this.btnBuscar);
            this.gbCadastroUsuario.Controls.Add(this.lblBuscar);
            this.gbCadastroUsuario.Controls.Add(this.txtBuscar);
            this.gbCadastroUsuario.Controls.Add(this.lblSetor);
            this.gbCadastroUsuario.Controls.Add(this.lblSenha);
            this.gbCadastroUsuario.Controls.Add(this.lblNome);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroSetor);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroSenha);
            this.gbCadastroUsuario.Controls.Add(this.txtCadastroNome);
            this.gbCadastroUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbCadastroUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbCadastroUsuario.Name = "gbCadastroUsuario";
            this.gbCadastroUsuario.Size = new System.Drawing.Size(309, 413);
            this.gbCadastroUsuario.TabIndex = 1;
            this.gbCadastroUsuario.TabStop = false;
            this.gbCadastroUsuario.Text = "Cadastrar novo usuário";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBuscar.Location = new System.Drawing.Point(2, 296);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(70, 19);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(6, 318);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(297, 26);
            this.txtBuscar.TabIndex = 3;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSetor.Location = new System.Drawing.Point(2, 241);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(56, 19);
            this.lblSetor.TabIndex = 5;
            this.lblSetor.Text = "Setor:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSenha.Location = new System.Drawing.Point(3, 184);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 19);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNome.Location = new System.Drawing.Point(3, 128);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 19);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtCadastroSetor
            // 
            this.txtCadastroSetor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroSetor.Location = new System.Drawing.Point(6, 263);
            this.txtCadastroSetor.Name = "txtCadastroSetor";
            this.txtCadastroSetor.Size = new System.Drawing.Size(297, 26);
            this.txtCadastroSetor.TabIndex = 2;
            // 
            // txtCadastroSenha
            // 
            this.txtCadastroSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroSenha.Location = new System.Drawing.Point(6, 206);
            this.txtCadastroSenha.Name = "txtCadastroSenha";
            this.txtCadastroSenha.Size = new System.Drawing.Size(297, 26);
            this.txtCadastroSenha.TabIndex = 1;
            // 
            // txtCadastroNome
            // 
            this.txtCadastroNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroNome.Location = new System.Drawing.Point(6, 150);
            this.txtCadastroNome.Name = "txtCadastroNome";
            this.txtCadastroNome.Size = new System.Drawing.Size(297, 26);
            this.txtCadastroNome.TabIndex = 0;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.LightCoral;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = global::appComercio.Properties.Resources.apagar;
            this.btnApagar.Location = new System.Drawing.Point(235, 451);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(86, 69);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::appComercio.Properties.Resources.cadastroLogin2;
            this.btnEditar.Location = new System.Drawing.Point(123, 451);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 69);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::appComercio.Properties.Resources.entrar;
            this.btnSalvar.Location = new System.Drawing.Point(12, 451);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 69);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // pbLogoCadastroUsuario
            // 
            this.pbLogoCadastroUsuario.Image = global::appComercio.Properties.Resources.usuarios;
            this.pbLogoCadastroUsuario.Location = new System.Drawing.Point(6, 25);
            this.pbLogoCadastroUsuario.Name = "pbLogoCadastroUsuario";
            this.pbLogoCadastroUsuario.Size = new System.Drawing.Size(103, 100);
            this.pbLogoCadastroUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogoCadastroUsuario.TabIndex = 8;
            this.pbLogoCadastroUsuario.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBuscar.Image = global::appComercio.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(111, 350);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 56);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 541);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbCadastroUsuario);
            this.Controls.Add(this.dgvCadastroUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroUsuario";
            this.Text = "APP COMÉRCIO | TELA DE CADASTRO DE USUÁRIOS";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroUsuario)).EndInit();
            this.gbCadastroUsuario.ResumeLayout(false);
            this.gbCadastroUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCadastroUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastroUsuario;
        private System.Windows.Forms.GroupBox gbCadastroUsuario;
        private System.Windows.Forms.TextBox txtCadastroSetor;
        private System.Windows.Forms.TextBox txtCadastroSenha;
        private System.Windows.Forms.TextBox txtCadastroNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.PictureBox pbLogoCadastroUsuario;
    }
}