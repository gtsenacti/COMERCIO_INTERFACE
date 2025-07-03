namespace appComercio
{
    partial class btVerCarta
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
            this.btSair = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.dgvCartas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartas)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(501, 401);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(101, 23);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(191, 401);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 3;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // dgvCartas
            // 
            this.dgvCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartas.Location = new System.Drawing.Point(23, 12);
            this.dgvCartas.Name = "dgvCartas";
            this.dgvCartas.Size = new System.Drawing.Size(765, 363);
            this.dgvCartas.TabIndex = 4;
            this.dgvCartas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCartas_CellContentClick);
            // 
            // btVerCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCartas);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btSair);
            this.Name = "btVerCarta";
            this.Text = "VerCartas";
            this.Load += new System.EventHandler(this.btVerCarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridView dgvCartas;
    }
}