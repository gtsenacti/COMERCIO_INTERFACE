namespace appComercio
{
    partial class frmCadastroProdutoServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProdutoServicos));
            this.gbCadastroProdutoServiço = new System.Windows.Forms.GroupBox();
            this.gbBuscaCadastroProdutoServiços = new System.Windows.Forms.GroupBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBuscaCadastroServico = new System.Windows.Forms.TextBox();
            this.dgvCadastroProdutoServico = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtServiços = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblServiços = new System.Windows.Forms.Label();
            this.gbCadastroProdutoServiço.SuspendLayout();
            this.gbBuscaCadastroProdutoServiços.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadastroProdutoServiço
            // 
            this.gbCadastroProdutoServiço.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCadastroProdutoServiço.Controls.Add(this.lblServiços);
            this.gbCadastroProdutoServiço.Controls.Add(this.lblProdutos);
            this.gbCadastroProdutoServiço.Controls.Add(this.lblCadastro);
            this.gbCadastroProdutoServiço.Controls.Add(this.txtServiços);
            this.gbCadastroProdutoServiço.Controls.Add(this.txtProduto);
            this.gbCadastroProdutoServiço.Controls.Add(this.txtCadastro);
            this.gbCadastroProdutoServiço.Location = new System.Drawing.Point(12, 12);
            this.gbCadastroProdutoServiço.Name = "gbCadastroProdutoServiço";
            this.gbCadastroProdutoServiço.Size = new System.Drawing.Size(305, 248);
            this.gbCadastroProdutoServiço.TabIndex = 0;
            this.gbCadastroProdutoServiço.TabStop = false;
            this.gbCadastroProdutoServiço.Text = "Cadastro-Produtos/Serviços";
            // 
            // gbBuscaCadastroProdutoServiços
            // 
            this.gbBuscaCadastroProdutoServiços.Controls.Add(this.btnBusca);
            this.gbBuscaCadastroProdutoServiços.Controls.Add(this.txtBuscaCadastroServico);
            this.gbBuscaCadastroProdutoServiços.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscaCadastroProdutoServiços.Location = new System.Drawing.Point(12, 278);
            this.gbBuscaCadastroProdutoServiços.Name = "gbBuscaCadastroProdutoServiços";
            this.gbBuscaCadastroProdutoServiços.Size = new System.Drawing.Size(305, 66);
            this.gbBuscaCadastroProdutoServiços.TabIndex = 1;
            this.gbBuscaCadastroProdutoServiços.TabStop = false;
            this.gbBuscaCadastroProdutoServiços.Text = "Busca Cadastro Produto Serviço";
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(212, 25);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 29);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = false;
            // 
            // txtBuscaCadastroServico
            // 
            this.txtBuscaCadastroServico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCadastroServico.Location = new System.Drawing.Point(9, 28);
            this.txtBuscaCadastroServico.Name = "txtBuscaCadastroServico";
            this.txtBuscaCadastroServico.Size = new System.Drawing.Size(177, 26);
            this.txtBuscaCadastroServico.TabIndex = 1;
            // 
            // dgvCadastroProdutoServico
            // 
            this.dgvCadastroProdutoServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCadastroProdutoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroProdutoServico.Location = new System.Drawing.Point(336, 12);
            this.dgvCadastroProdutoServico.Name = "dgvCadastroProdutoServico";
            this.dgvCadastroProdutoServico.Size = new System.Drawing.Size(452, 426);
            this.dgvCadastroProdutoServico.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(21, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(133, 381);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 35);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Tomato;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(242, 381);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 35);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastro.Location = new System.Drawing.Point(6, 38);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(293, 32);
            this.txtCadastro.TabIndex = 0;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(9, 122);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(290, 32);
            this.txtProduto.TabIndex = 1;
            // 
            // txtServiços
            // 
            this.txtServiços.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiços.Location = new System.Drawing.Point(9, 206);
            this.txtServiços.Name = "txtServiços";
            this.txtServiços.Size = new System.Drawing.Size(293, 32);
            this.txtServiços.TabIndex = 2;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(6, 22);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(51, 14);
            this.lblCadastro.TabIndex = 3;
            this.lblCadastro.Text = "Cadastro";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(11, 106);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(44, 14);
            this.lblProdutos.TabIndex = 4;
            this.lblProdutos.Text = "Produto";
            // 
            // lblServiços
            // 
            this.lblServiços.AutoSize = true;
            this.lblServiços.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiços.Location = new System.Drawing.Point(6, 190);
            this.lblServiços.Name = "lblServiços";
            this.lblServiços.Size = new System.Drawing.Size(50, 14);
            this.lblServiços.TabIndex = 5;
            this.lblServiços.Text = "Serviços";
            // 
            // frmCadastroProdutoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvCadastroProdutoServico);
            this.Controls.Add(this.gbBuscaCadastroProdutoServiços);
            this.Controls.Add(this.gbCadastroProdutoServiço);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroProdutoServicos";
            this.Text = "Casa Fernandes Cadastro Produtos e Serviços";
            this.gbCadastroProdutoServiço.ResumeLayout(false);
            this.gbCadastroProdutoServiço.PerformLayout();
            this.gbBuscaCadastroProdutoServiços.ResumeLayout(false);
            this.gbBuscaCadastroProdutoServiços.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutoServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroProdutoServiço;
        private System.Windows.Forms.GroupBox gbBuscaCadastroProdutoServiços;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBuscaCadastroServico;
        private System.Windows.Forms.DataGridView dgvCadastroProdutoServico;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtServiços;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.Label lblServiços;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblCadastro;
    }
}