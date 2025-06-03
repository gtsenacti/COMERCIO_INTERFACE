namespace appComercio
{
    partial class frmCadastroProdutoServico
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
            this.gbCadastroProdutoServico = new System.Windows.Forms.GroupBox();
            this.gbBuscarCadastroProdutoServico = new System.Windows.Forms.GroupBox();
            this.txtBuscarCadastroProdutoServico = new System.Windows.Forms.TextBox();
            this.btnBuscarCadastroProdutoServico = new System.Windows.Forms.Button();
            this.gbBuscarCadastroProdutoServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastroProdutoServico
            // 
            this.gbCadastroProdutoServico.Font = new System.Drawing.Font("Arial", 12F);
            this.gbCadastroProdutoServico.Location = new System.Drawing.Point(26, 20);
            this.gbCadastroProdutoServico.Name = "gbCadastroProdutoServico";
            this.gbCadastroProdutoServico.Size = new System.Drawing.Size(268, 191);
            this.gbCadastroProdutoServico.TabIndex = 0;
            this.gbCadastroProdutoServico.TabStop = false;
            this.gbCadastroProdutoServico.Text = "Cadastro Produto/Serviço";
            this.gbCadastroProdutoServico.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbBuscarCadastroProdutoServico
            // 
            this.gbBuscarCadastroProdutoServico.Controls.Add(this.btnBuscarCadastroProdutoServico);
            this.gbBuscarCadastroProdutoServico.Controls.Add(this.txtBuscarCadastroProdutoServico);
            this.gbBuscarCadastroProdutoServico.Location = new System.Drawing.Point(30, 239);
            this.gbBuscarCadastroProdutoServico.Name = "gbBuscarCadastroProdutoServico";
            this.gbBuscarCadastroProdutoServico.Size = new System.Drawing.Size(263, 61);
            this.gbBuscarCadastroProdutoServico.TabIndex = 1;
            this.gbBuscarCadastroProdutoServico.TabStop = false;
            this.gbBuscarCadastroProdutoServico.Text = "Buscar Cadastro:";
            this.gbBuscarCadastroProdutoServico.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txtBuscarCadastroProdutoServico
            // 
            this.txtBuscarCadastroProdutoServico.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBuscarCadastroProdutoServico.Location = new System.Drawing.Point(6, 26);
            this.txtBuscarCadastroProdutoServico.Name = "txtBuscarCadastroProdutoServico";
            this.txtBuscarCadastroProdutoServico.Size = new System.Drawing.Size(144, 23);
            this.txtBuscarCadastroProdutoServico.TabIndex = 0;
            // 
            // btnBuscarCadastroProdutoServico
            // 
            this.btnBuscarCadastroProdutoServico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCadastroProdutoServico.Location = new System.Drawing.Point(184, 19);
            this.btnBuscarCadastroProdutoServico.Name = "btnBuscarCadastroProdutoServico";
            this.btnBuscarCadastroProdutoServico.Size = new System.Drawing.Size(59, 29);
            this.btnBuscarCadastroProdutoServico.TabIndex = 1;
            this.btnBuscarCadastroProdutoServico.Text = "Buscar";
            this.btnBuscarCadastroProdutoServico.UseVisualStyleBackColor = true;
            // 
            // frmCadastroProdutoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbBuscarCadastroProdutoServico);
            this.Controls.Add(this.gbCadastroProdutoServico);
            this.Name = "frmCadastroProdutoServico";
            this.Text = "frmCadastroProdutoServico";
            this.gbBuscarCadastroProdutoServico.ResumeLayout(false);
            this.gbBuscarCadastroProdutoServico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroProdutoServico;
        private System.Windows.Forms.GroupBox gbBuscarCadastroProdutoServico;
        private System.Windows.Forms.TextBox txtBuscarCadastroProdutoServico;
        private System.Windows.Forms.Button btnBuscarCadastroProdutoServico;
    }
}