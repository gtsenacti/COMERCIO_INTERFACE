namespace appComercio
{
    partial class frmDadosProdutoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDadosProdutoServico));
            this.dgvCadastroProdutoServico = new System.Windows.Forms.DataGridView();
            this.gbBuscaCadastroProdutoServiços = new System.Windows.Forms.GroupBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBuscaCadastroServico = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbCadastroProdutoServico = new System.Windows.Forms.GroupBox();
            this.lblServiços = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.txtServicos = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutoServico)).BeginInit();
            this.gbBuscaCadastroProdutoServiços.SuspendLayout();
            this.gbCadastroProdutoServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCadastroProdutoServico
            // 
            this.dgvCadastroProdutoServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCadastroProdutoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroProdutoServico.Location = new System.Drawing.Point(336, 12);
            this.dgvCadastroProdutoServico.Name = "dgvCadastroProdutoServico";
            this.dgvCadastroProdutoServico.Size = new System.Drawing.Size(452, 426);
            this.dgvCadastroProdutoServico.TabIndex = 8;
            // 
            // gbBuscaCadastroProdutoServiços
            // 
            this.gbBuscaCadastroProdutoServiços.Controls.Add(this.btnBusca);
            this.gbBuscaCadastroProdutoServiços.Controls.Add(this.txtBuscaCadastroServico);
            this.gbBuscaCadastroProdutoServiços.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscaCadastroProdutoServiços.Location = new System.Drawing.Point(12, 278);
            this.gbBuscaCadastroProdutoServiços.Name = "gbBuscaCadastroProdutoServiços";
            this.gbBuscaCadastroProdutoServiços.Size = new System.Drawing.Size(305, 66);
            this.gbBuscaCadastroProdutoServiços.TabIndex = 7;
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
            this.btnBusca.TabIndex = 4;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = false;
            // 
            // txtBuscaCadastroServico
            // 
            this.txtBuscaCadastroServico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCadastroServico.Location = new System.Drawing.Point(9, 28);
            this.txtBuscaCadastroServico.Name = "txtBuscaCadastroServico";
            this.txtBuscaCadastroServico.Size = new System.Drawing.Size(174, 26);
            this.txtBuscaCadastroServico.TabIndex = 3;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Tomato;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(242, 381);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 35);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(133, 381);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 35);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(21, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // gbCadastroProdutoServico
            // 
            this.gbCadastroProdutoServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCadastroProdutoServico.Controls.Add(this.lblServiços);
            this.gbCadastroProdutoServico.Controls.Add(this.lblProduto);
            this.gbCadastroProdutoServico.Controls.Add(this.lblCadastro);
            this.gbCadastroProdutoServico.Controls.Add(this.txtServicos);
            this.gbCadastroProdutoServico.Controls.Add(this.txtProduto);
            this.gbCadastroProdutoServico.Controls.Add(this.txtCadastro);
            this.gbCadastroProdutoServico.Location = new System.Drawing.Point(12, 12);
            this.gbCadastroProdutoServico.Name = "gbCadastroProdutoServico";
            this.gbCadastroProdutoServico.Size = new System.Drawing.Size(305, 248);
            this.gbCadastroProdutoServico.TabIndex = 0;
            this.gbCadastroProdutoServico.TabStop = false;
            this.gbCadastroProdutoServico.Text = "Cadastro-Produtos/Serviços";
            // 
            // lblServiços
            // 
            this.lblServiços.AutoSize = true;
            this.lblServiços.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiços.Location = new System.Drawing.Point(6, 187);
            this.lblServiços.Name = "lblServiços";
            this.lblServiços.Size = new System.Drawing.Size(53, 14);
            this.lblServiços.TabIndex = 5;
            this.lblServiços.Text = "Serviços:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(6, 97);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 14);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.Text = "Produto:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(6, 16);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(54, 14);
            this.lblCadastro.TabIndex = 3;
            this.lblCadastro.Text = "Cadastro:";
            // 
            // txtServicos
            // 
            this.txtServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicos.Location = new System.Drawing.Point(9, 203);
            this.txtServicos.Name = "txtServicos";
            this.txtServicos.Size = new System.Drawing.Size(290, 31);
            this.txtServicos.TabIndex = 2;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(9, 114);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(290, 31);
            this.txtProduto.TabIndex = 1;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastro.Location = new System.Drawing.Point(9, 30);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(290, 31);
            this.txtCadastro.TabIndex = 0;
            // 
            // frmDadosProdutoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCadastroProdutoServico);
            this.Controls.Add(this.gbBuscaCadastroProdutoServiços);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbCadastroProdutoServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDadosProdutoServico";
            this.Text = "Casa Fernandes Dados Produtos e Serviços";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutoServico)).EndInit();
            this.gbBuscaCadastroProdutoServiços.ResumeLayout(false);
            this.gbBuscaCadastroProdutoServiços.PerformLayout();
            this.gbCadastroProdutoServico.ResumeLayout(false);
            this.gbCadastroProdutoServico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastroProdutoServico;
        private System.Windows.Forms.GroupBox gbBuscaCadastroProdutoServiços;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBuscaCadastroServico;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbCadastroProdutoServico;
        private System.Windows.Forms.Label lblServiços;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txtServicos;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCadastro;
    }
}