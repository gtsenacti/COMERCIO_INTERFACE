namespace appComercio
{
    partial class frmPrincipal
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
            this.lblProdutoServico = new System.Windows.Forms.Label();
            this.tlpTelaPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnTarefasProdutosServico = new System.Windows.Forms.Button();
            this.btnDadosProdutoServico = new System.Windows.Forms.Button();
            this.btnCadastroProdutoServico = new System.Windows.Forms.Button();
            this.tlpTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProdutoServico
            // 
            this.lblProdutoServico.AutoSize = true;
            this.lblProdutoServico.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoServico.Location = new System.Drawing.Point(186, 25);
            this.lblProdutoServico.Name = "lblProdutoServico";
            this.lblProdutoServico.Size = new System.Drawing.Size(417, 52);
            this.lblProdutoServico.TabIndex = 0;
            this.lblProdutoServico.Text = "Produtos / Serviços";
            this.lblProdutoServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpTelaPrincipal
            // 
            this.tlpTelaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTelaPrincipal.ColumnCount = 3;
            this.tlpTelaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpTelaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpTelaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpTelaPrincipal.Controls.Add(this.btnTarefasProdutosServico, 2, 0);
            this.tlpTelaPrincipal.Controls.Add(this.btnDadosProdutoServico, 1, 0);
            this.tlpTelaPrincipal.Controls.Add(this.btnCadastroProdutoServico, 0, 0);
            this.tlpTelaPrincipal.Location = new System.Drawing.Point(40, 121);
            this.tlpTelaPrincipal.Name = "tlpTelaPrincipal";
            this.tlpTelaPrincipal.RowCount = 1;
            this.tlpTelaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTelaPrincipal.Size = new System.Drawing.Size(717, 152);
            this.tlpTelaPrincipal.TabIndex = 1;
            // 
            // btnTarefasProdutosServico
            // 
            this.btnTarefasProdutosServico.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefasProdutosServico.Location = new System.Drawing.Point(475, 3);
            this.btnTarefasProdutosServico.Name = "btnTarefasProdutosServico";
            this.btnTarefasProdutosServico.Size = new System.Drawing.Size(239, 146);
            this.btnTarefasProdutosServico.TabIndex = 2;
            this.btnTarefasProdutosServico.Text = "Tarefas";
            this.btnTarefasProdutosServico.UseVisualStyleBackColor = true;
            // 
            // btnDadosProdutoServico
            // 
            this.btnDadosProdutoServico.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosProdutoServico.Location = new System.Drawing.Point(239, 3);
            this.btnDadosProdutoServico.Name = "btnDadosProdutoServico";
            this.btnDadosProdutoServico.Size = new System.Drawing.Size(230, 146);
            this.btnDadosProdutoServico.TabIndex = 1;
            this.btnDadosProdutoServico.Text = "Dados";
            this.btnDadosProdutoServico.UseVisualStyleBackColor = true;
            // 
            // btnCadastroProdutoServico
            // 
            this.btnCadastroProdutoServico.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProdutoServico.Location = new System.Drawing.Point(3, 3);
            this.btnCadastroProdutoServico.Name = "btnCadastroProdutoServico";
            this.btnCadastroProdutoServico.Size = new System.Drawing.Size(230, 146);
            this.btnCadastroProdutoServico.TabIndex = 0;
            this.btnCadastroProdutoServico.Text = "Cadastro";
            this.btnCadastroProdutoServico.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.tlpTelaPrincipal);
            this.Controls.Add(this.lblProdutoServico);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.tlpTelaPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdutoServico;
        private System.Windows.Forms.TableLayoutPanel tlpTelaPrincipal;
        private System.Windows.Forms.Button btnCadastroProdutoServico;
        private System.Windows.Forms.Button btnTarefasProdutosServico;
        private System.Windows.Forms.Button btnDadosProdutoServico;
    }
}