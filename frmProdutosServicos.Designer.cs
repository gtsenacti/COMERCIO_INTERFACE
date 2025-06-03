namespace appComercio
{
    partial class frmProdutosServicos
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
            this.lblProdutoServicos = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastroProdutoServico = new System.Windows.Forms.Button();
            this.btnDadosProdutosSevico = new System.Windows.Forms.Button();
            this.btnTarefaProdutoServico = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProdutoServicos
            // 
            this.lblProdutoServicos.AutoSize = true;
            this.lblProdutoServicos.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoServicos.Location = new System.Drawing.Point(269, 64);
            this.lblProdutoServicos.Name = "lblProdutoServicos";
            this.lblProdutoServicos.Size = new System.Drawing.Size(273, 32);
            this.lblProdutoServicos.TabIndex = 0;
            this.lblProdutoServicos.Text = "Produtos / Serviços";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnCadastroProdutoServico, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDadosProdutosSevico, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTarefaProdutoServico, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(64, 198);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 105);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnCadastroProdutoServico
            // 
            this.btnCadastroProdutoServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastroProdutoServico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProdutoServico.Location = new System.Drawing.Point(4, 4);
            this.btnCadastroProdutoServico.Name = "btnCadastroProdutoServico";
            this.btnCadastroProdutoServico.Size = new System.Drawing.Size(215, 97);
            this.btnCadastroProdutoServico.TabIndex = 0;
            this.btnCadastroProdutoServico.Text = "Cadastro";
            this.btnCadastroProdutoServico.UseVisualStyleBackColor = true;
            // 
            // btnDadosProdutosSevico
            // 
            this.btnDadosProdutosSevico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDadosProdutosSevico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosProdutosSevico.Location = new System.Drawing.Point(226, 4);
            this.btnDadosProdutosSevico.Name = "btnDadosProdutosSevico";
            this.btnDadosProdutosSevico.Size = new System.Drawing.Size(215, 97);
            this.btnDadosProdutosSevico.TabIndex = 1;
            this.btnDadosProdutosSevico.Text = "Dados";
            this.btnDadosProdutosSevico.UseVisualStyleBackColor = true;
            // 
            // btnTarefaProdutoServico
            // 
            this.btnTarefaProdutoServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTarefaProdutoServico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefaProdutoServico.Location = new System.Drawing.Point(448, 4);
            this.btnTarefaProdutoServico.Name = "btnTarefaProdutoServico";
            this.btnTarefaProdutoServico.Size = new System.Drawing.Size(217, 97);
            this.btnTarefaProdutoServico.TabIndex = 2;
            this.btnTarefaProdutoServico.Text = "Tarefas";
            this.btnTarefaProdutoServico.UseVisualStyleBackColor = true;
            // 
            // frmProdutosServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblProdutoServicos);
            this.Name = "frmProdutosServicos";
            this.Text = "Pica Pau Móveis Rusticos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdutoServicos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCadastroProdutoServico;
        private System.Windows.Forms.Button btnDadosProdutosSevico;
        private System.Windows.Forms.Button btnTarefaProdutoServico;
    }
}