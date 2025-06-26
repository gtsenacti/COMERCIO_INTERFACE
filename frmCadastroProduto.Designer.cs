namespace appComercio
{
    partial class frmCadastroProduto
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
            this.dgvCadastroProdutos = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.gbCadastroUsuario = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pbLogoCadastroProdutos = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutos)).BeginInit();
            this.gbCadastroUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCadastroProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCadastroProdutos
            // 
            this.dgvCadastroProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroProdutos.Location = new System.Drawing.Point(322, 12);
            this.dgvCadastroProdutos.Name = "dgvCadastroProdutos";
            this.dgvCadastroProdutos.Size = new System.Drawing.Size(471, 492);
            this.dgvCadastroProdutos.TabIndex = 0;
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
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCNPJ.Location = new System.Drawing.Point(2, 241);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(59, 19);
            this.lblCNPJ.TabIndex = 5;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFornecedor.Location = new System.Drawing.Point(3, 184);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(104, 19);
            this.lblFornecedor.TabIndex = 4;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNomeProduto.Location = new System.Drawing.Point(3, 128);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(77, 19);
            this.lblNomeProduto.TabIndex = 3;
            this.lblNomeProduto.Text = "Produto:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(6, 263);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(297, 26);
            this.txtCNPJ.TabIndex = 2;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(6, 206);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(297, 26);
            this.txtFornecedor.TabIndex = 1;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(6, 150);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(297, 26);
            this.txtProduto.TabIndex = 0;
            // 
            // gbCadastroUsuario
            // 
            this.gbCadastroUsuario.Controls.Add(this.pbLogoCadastroProdutos);
            this.gbCadastroUsuario.Controls.Add(this.btnBuscar);
            this.gbCadastroUsuario.Controls.Add(this.lblBuscar);
            this.gbCadastroUsuario.Controls.Add(this.txtBuscar);
            this.gbCadastroUsuario.Controls.Add(this.lblCNPJ);
            this.gbCadastroUsuario.Controls.Add(this.lblFornecedor);
            this.gbCadastroUsuario.Controls.Add(this.lblNomeProduto);
            this.gbCadastroUsuario.Controls.Add(this.txtCNPJ);
            this.gbCadastroUsuario.Controls.Add(this.txtFornecedor);
            this.gbCadastroUsuario.Controls.Add(this.txtProduto);
            this.gbCadastroUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbCadastroUsuario.Location = new System.Drawing.Point(2, 2);
            this.gbCadastroUsuario.Name = "gbCadastroUsuario";
            this.gbCadastroUsuario.Size = new System.Drawing.Size(309, 413);
            this.gbCadastroUsuario.TabIndex = 8;
            this.gbCadastroUsuario.TabStop = false;
            this.gbCadastroUsuario.Text = "Cadastrar novo usuário";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.LightCoral;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = global::appComercio.Properties.Resources.apagar;
            this.btnApagar.Location = new System.Drawing.Point(225, 435);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(86, 69);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::appComercio.Properties.Resources.cadastroLogin2;
            this.btnEditar.Location = new System.Drawing.Point(113, 435);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 69);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::appComercio.Properties.Resources.entrar;
            this.btnSalvar.Location = new System.Drawing.Point(2, 435);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 69);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // pbLogoCadastroProdutos
            // 
            this.pbLogoCadastroProdutos.Image = global::appComercio.Properties.Resources.produtosMaior;
            this.pbLogoCadastroProdutos.Location = new System.Drawing.Point(200, 25);
            this.pbLogoCadastroProdutos.Name = "pbLogoCadastroProdutos";
            this.pbLogoCadastroProdutos.Size = new System.Drawing.Size(103, 103);
            this.pbLogoCadastroProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoCadastroProdutos.TabIndex = 8;
            this.pbLogoCadastroProdutos.TabStop = false;
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
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbCadastroUsuario);
            this.Controls.Add(this.dgvCadastroProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroProduto";
            this.Text = "APP COMÉRCIO | TELA DE CADASTRO DE PRODUTOS";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutos)).EndInit();
            this.gbCadastroUsuario.ResumeLayout(false);
            this.gbCadastroUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCadastroProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastroProdutos;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.PictureBox pbLogoCadastroProdutos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbCadastroUsuario;
    }
}