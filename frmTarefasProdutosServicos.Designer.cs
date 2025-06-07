namespace appComercio
{
    partial class frmTarefasProdutosServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarefasProdutosServicos));
            this.gbTarefaProdutoServico = new System.Windows.Forms.GroupBox();
            this.lblServiços = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.gbBuscaTarefaProdutoSevico = new System.Windows.Forms.GroupBox();
            this.txtBuscaTarefaProdutoServico = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.dgvTarefaProdutoServico = new System.Windows.Forms.DataGridView();
            this.btnCadastroTarefaProdutoServico = new System.Windows.Forms.Button();
            this.btnEditarTarefaProdutoServico = new System.Windows.Forms.Button();
            this.btnApagarTarefaProdutoServico = new System.Windows.Forms.Button();
            this.rbSomar = new System.Windows.Forms.RadioButton();
            this.rbSubtrair = new System.Windows.Forms.RadioButton();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbDividir = new System.Windows.Forms.RadioButton();
            this.btnCalcularTarefaProdutoServico = new System.Windows.Forms.Button();
            this.gbTarefaProdutoServico.SuspendLayout();
            this.gbResultado.SuspendLayout();
            this.gbBuscaTarefaProdutoSevico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefaProdutoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTarefaProdutoServico
            // 
            this.gbTarefaProdutoServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbTarefaProdutoServico.Controls.Add(this.lblServiços);
            this.gbTarefaProdutoServico.Controls.Add(this.lblProduto);
            this.gbTarefaProdutoServico.Controls.Add(this.lblCadastro);
            this.gbTarefaProdutoServico.Controls.Add(this.txtServico);
            this.gbTarefaProdutoServico.Controls.Add(this.txtProduto);
            this.gbTarefaProdutoServico.Controls.Add(this.txtCadastro);
            this.gbTarefaProdutoServico.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTarefaProdutoServico.Location = new System.Drawing.Point(12, 12);
            this.gbTarefaProdutoServico.Name = "gbTarefaProdutoServico";
            this.gbTarefaProdutoServico.Size = new System.Drawing.Size(245, 281);
            this.gbTarefaProdutoServico.TabIndex = 0;
            this.gbTarefaProdutoServico.TabStop = false;
            this.gbTarefaProdutoServico.Text = "Tarefa Produtos Serviços";
            // 
            // lblServiços
            // 
            this.lblServiços.AutoSize = true;
            this.lblServiços.Location = new System.Drawing.Point(21, 187);
            this.lblServiços.Name = "lblServiços";
            this.lblServiços.Size = new System.Drawing.Size(53, 14);
            this.lblServiços.TabIndex = 5;
            this.lblServiços.Text = "Serviços:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(21, 106);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 14);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.Text = "Produto:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(18, 29);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(54, 14);
            this.lblCadastro.TabIndex = 3;
            this.lblCadastro.Text = "Cadastro:";
            // 
            // txtServico
            // 
            this.txtServico.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServico.Location = new System.Drawing.Point(18, 204);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(207, 32);
            this.txtServico.TabIndex = 2;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(18, 119);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(207, 32);
            this.txtProduto.TabIndex = 1;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastro.Location = new System.Drawing.Point(18, 41);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(207, 32);
            this.txtCadastro.TabIndex = 0;
            // 
            // gbResultado
            // 
            this.gbResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbResultado.Controls.Add(this.txtResultado);
            this.gbResultado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(12, 372);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(245, 66);
            this.gbResultado.TabIndex = 3;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(36, 21);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(176, 35);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbBuscaTarefaProdutoSevico
            // 
            this.gbBuscaTarefaProdutoSevico.Controls.Add(this.txtBuscaTarefaProdutoServico);
            this.gbBuscaTarefaProdutoSevico.Controls.Add(this.btnBusca);
            this.gbBuscaTarefaProdutoSevico.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscaTarefaProdutoSevico.Location = new System.Drawing.Point(12, 299);
            this.gbBuscaTarefaProdutoSevico.Name = "gbBuscaTarefaProdutoSevico";
            this.gbBuscaTarefaProdutoSevico.Size = new System.Drawing.Size(245, 52);
            this.gbBuscaTarefaProdutoSevico.TabIndex = 2;
            this.gbBuscaTarefaProdutoSevico.TabStop = false;
            this.gbBuscaTarefaProdutoSevico.Text = "Busca Tarefa Produto Serviço";
            // 
            // txtBuscaTarefaProdutoServico
            // 
            this.txtBuscaTarefaProdutoServico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaTarefaProdutoServico.Location = new System.Drawing.Point(6, 19);
            this.txtBuscaTarefaProdutoServico.Name = "txtBuscaTarefaProdutoServico";
            this.txtBuscaTarefaProdutoServico.Size = new System.Drawing.Size(133, 22);
            this.txtBuscaTarefaProdutoServico.TabIndex = 3;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(164, 19);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 4;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = false;
            // 
            // dgvTarefaProdutoServico
            // 
            this.dgvTarefaProdutoServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTarefaProdutoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefaProdutoServico.Location = new System.Drawing.Point(276, 12);
            this.dgvTarefaProdutoServico.Name = "dgvTarefaProdutoServico";
            this.dgvTarefaProdutoServico.Size = new System.Drawing.Size(512, 281);
            this.dgvTarefaProdutoServico.TabIndex = 6;
            // 
            // btnCadastroTarefaProdutoServico
            // 
            this.btnCadastroTarefaProdutoServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastroTarefaProdutoServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroTarefaProdutoServico.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroTarefaProdutoServico.Location = new System.Drawing.Point(307, 310);
            this.btnCadastroTarefaProdutoServico.Name = "btnCadastroTarefaProdutoServico";
            this.btnCadastroTarefaProdutoServico.Size = new System.Drawing.Size(113, 30);
            this.btnCadastroTarefaProdutoServico.TabIndex = 7;
            this.btnCadastroTarefaProdutoServico.Text = "Cadastro";
            this.btnCadastroTarefaProdutoServico.UseVisualStyleBackColor = false;
            // 
            // btnEditarTarefaProdutoServico
            // 
            this.btnEditarTarefaProdutoServico.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditarTarefaProdutoServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarTarefaProdutoServico.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTarefaProdutoServico.Location = new System.Drawing.Point(470, 310);
            this.btnEditarTarefaProdutoServico.Name = "btnEditarTarefaProdutoServico";
            this.btnEditarTarefaProdutoServico.Size = new System.Drawing.Size(113, 30);
            this.btnEditarTarefaProdutoServico.TabIndex = 8;
            this.btnEditarTarefaProdutoServico.Text = "Editar";
            this.btnEditarTarefaProdutoServico.UseVisualStyleBackColor = false;
            // 
            // btnApagarTarefaProdutoServico
            // 
            this.btnApagarTarefaProdutoServico.BackColor = System.Drawing.Color.Tomato;
            this.btnApagarTarefaProdutoServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarTarefaProdutoServico.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarTarefaProdutoServico.Location = new System.Drawing.Point(639, 310);
            this.btnApagarTarefaProdutoServico.Name = "btnApagarTarefaProdutoServico";
            this.btnApagarTarefaProdutoServico.Size = new System.Drawing.Size(113, 30);
            this.btnApagarTarefaProdutoServico.TabIndex = 9;
            this.btnApagarTarefaProdutoServico.Text = "Apagar";
            this.btnApagarTarefaProdutoServico.UseVisualStyleBackColor = false;
            // 
            // rbSomar
            // 
            this.rbSomar.AutoSize = true;
            this.rbSomar.BackColor = System.Drawing.Color.White;
            this.rbSomar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSomar.Location = new System.Drawing.Point(307, 372);
            this.rbSomar.Name = "rbSomar";
            this.rbSomar.Size = new System.Drawing.Size(67, 20);
            this.rbSomar.TabIndex = 10;
            this.rbSomar.TabStop = true;
            this.rbSomar.Text = "Somar";
            this.rbSomar.UseVisualStyleBackColor = false;
            // 
            // rbSubtrair
            // 
            this.rbSubtrair.AutoSize = true;
            this.rbSubtrair.BackColor = System.Drawing.Color.White;
            this.rbSubtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSubtrair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSubtrair.Location = new System.Drawing.Point(424, 372);
            this.rbSubtrair.Name = "rbSubtrair";
            this.rbSubtrair.Size = new System.Drawing.Size(76, 20);
            this.rbSubtrair.TabIndex = 11;
            this.rbSubtrair.TabStop = true;
            this.rbSubtrair.Text = "Subtrair";
            this.rbSubtrair.UseVisualStyleBackColor = false;
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.BackColor = System.Drawing.Color.White;
            this.rbMultiplicar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.rbMultiplicar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiplicar.Location = new System.Drawing.Point(550, 372);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(92, 20);
            this.rbMultiplicar.TabIndex = 12;
            this.rbMultiplicar.TabStop = true;
            this.rbMultiplicar.Text = "Multiplicar";
            this.rbMultiplicar.UseVisualStyleBackColor = false;
            // 
            // rbDividir
            // 
            this.rbDividir.AutoSize = true;
            this.rbDividir.BackColor = System.Drawing.Color.White;
            this.rbDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDividir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDividir.Location = new System.Drawing.Point(686, 372);
            this.rbDividir.Name = "rbDividir";
            this.rbDividir.Size = new System.Drawing.Size(66, 20);
            this.rbDividir.TabIndex = 13;
            this.rbDividir.TabStop = true;
            this.rbDividir.Text = "Dividir";
            this.rbDividir.UseVisualStyleBackColor = false;
            // 
            // btnCalcularTarefaProdutoServico
            // 
            this.btnCalcularTarefaProdutoServico.BackColor = System.Drawing.Color.Gold;
            this.btnCalcularTarefaProdutoServico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTarefaProdutoServico.Location = new System.Drawing.Point(307, 415);
            this.btnCalcularTarefaProdutoServico.Name = "btnCalcularTarefaProdutoServico";
            this.btnCalcularTarefaProdutoServico.Size = new System.Drawing.Size(445, 23);
            this.btnCalcularTarefaProdutoServico.TabIndex = 14;
            this.btnCalcularTarefaProdutoServico.Text = "Calcular";
            this.btnCalcularTarefaProdutoServico.UseVisualStyleBackColor = false;
            // 
            // frmTarefasProdutosServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularTarefaProdutoServico);
            this.Controls.Add(this.rbDividir);
            this.Controls.Add(this.rbMultiplicar);
            this.Controls.Add(this.rbSubtrair);
            this.Controls.Add(this.rbSomar);
            this.Controls.Add(this.btnApagarTarefaProdutoServico);
            this.Controls.Add(this.btnEditarTarefaProdutoServico);
            this.Controls.Add(this.btnCadastroTarefaProdutoServico);
            this.Controls.Add(this.dgvTarefaProdutoServico);
            this.Controls.Add(this.gbBuscaTarefaProdutoSevico);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbTarefaProdutoServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTarefasProdutosServicos";
            this.Text = " Casa Fernandes Tarefa Produtos e Serviços";
            this.gbTarefaProdutoServico.ResumeLayout(false);
            this.gbTarefaProdutoServico.PerformLayout();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.gbBuscaTarefaProdutoSevico.ResumeLayout(false);
            this.gbBuscaTarefaProdutoSevico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefaProdutoServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTarefaProdutoServico;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.GroupBox gbBuscaTarefaProdutoSevico;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBuscaTarefaProdutoServico;
        private System.Windows.Forms.DataGridView dgvTarefaProdutoServico;
        private System.Windows.Forms.Button btnCadastroTarefaProdutoServico;
        private System.Windows.Forms.Button btnEditarTarefaProdutoServico;
        private System.Windows.Forms.Button btnApagarTarefaProdutoServico;
        private System.Windows.Forms.RadioButton rbSomar;
        private System.Windows.Forms.RadioButton rbSubtrair;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbDividir;
        private System.Windows.Forms.Button btnCalcularTarefaProdutoServico;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.Label lblServiços;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.TextBox txtResultado;
    }
}