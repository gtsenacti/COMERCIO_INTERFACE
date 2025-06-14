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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCadastroProdutos
            // 
            this.dgvCadastroProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroProdutos.Location = new System.Drawing.Point(336, 2);
            this.dgvCadastroProdutos.Name = "dgvCadastroProdutos";
            this.dgvCadastroProdutos.Size = new System.Drawing.Size(462, 447);
            this.dgvCadastroProdutos.TabIndex = 0;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCadastroProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroProduto";
            this.Text = "APP COMÉRCIO | TELA DE CADASTRO DE PRODUTOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastroProdutos;
    }
}