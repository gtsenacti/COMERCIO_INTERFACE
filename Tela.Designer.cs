namespace appComercio
{
    partial class Tela
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
            this.btPersonagens = new System.Windows.Forms.Button();
            this.btCreditos = new System.Windows.Forms.Button();
            this.btCharecter = new System.Windows.Forms.Button();
            this.btvoltarTELA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPersonagens
            // 
            this.btPersonagens.Location = new System.Drawing.Point(300, 49);
            this.btPersonagens.Name = "btPersonagens";
            this.btPersonagens.Size = new System.Drawing.Size(200, 324);
            this.btPersonagens.TabIndex = 1;
            this.btPersonagens.Text = "Personagens ";
            this.btPersonagens.UseVisualStyleBackColor = true;
            this.btPersonagens.Click += new System.EventHandler(this.btPersonagens_Click);
            // 
            // btCreditos
            // 
            this.btCreditos.Location = new System.Drawing.Point(551, 49);
            this.btCreditos.Name = "btCreditos";
            this.btCreditos.Size = new System.Drawing.Size(200, 324);
            this.btCreditos.TabIndex = 2;
            this.btCreditos.Text = "Creditos";
            this.btCreditos.UseVisualStyleBackColor = true;
            this.btCreditos.Click += new System.EventHandler(this.btCreditos_Click);
            // 
            // btCharecter
            // 
            this.btCharecter.Location = new System.Drawing.Point(50, 49);
            this.btCharecter.Name = "btCharecter";
            this.btCharecter.Size = new System.Drawing.Size(200, 324);
            this.btCharecter.TabIndex = 0;
            this.btCharecter.Text = "New Charecter...";
            this.btCharecter.UseVisualStyleBackColor = true;
            this.btCharecter.Click += new System.EventHandler(this.btCharecter_Click);
            // 
            // btvoltarTELA
            // 
            this.btvoltarTELA.Location = new System.Drawing.Point(614, 393);
            this.btvoltarTELA.Name = "btvoltarTELA";
            this.btvoltarTELA.Size = new System.Drawing.Size(127, 35);
            this.btvoltarTELA.TabIndex = 3;
            this.btvoltarTELA.Text = "Voltar";
            this.btvoltarTELA.UseVisualStyleBackColor = true;
            this.btvoltarTELA.Click += new System.EventHandler(this.btvoltarTELA_Click);
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btvoltarTELA);
            this.Controls.Add(this.btCreditos);
            this.Controls.Add(this.btPersonagens);
            this.Controls.Add(this.btCharecter);
            this.Name = "Tela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCharecter;
        private System.Windows.Forms.Button btPersonagens;
        private System.Windows.Forms.Button btCreditos;
        private System.Windows.Forms.Button btvoltarTELA;
    }
}