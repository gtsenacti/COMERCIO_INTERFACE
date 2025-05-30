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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCadastroLivro = new System.Windows.Forms.Button();
            this.btncadastroEditora = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroLivro
            // 
            this.btnCadastroLivro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCadastroLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroLivro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroLivro.Location = new System.Drawing.Point(144, 49);
            this.btnCadastroLivro.Name = "btnCadastroLivro";
            this.btnCadastroLivro.Size = new System.Drawing.Size(380, 81);
            this.btnCadastroLivro.TabIndex = 0;
            this.btnCadastroLivro.Text = "Cadastrar livros";
            this.btnCadastroLivro.UseVisualStyleBackColor = false;
            this.btnCadastroLivro.Click += new System.EventHandler(this.btnCadastroLivros_Click);
            // 
            // btncadastroEditora
            // 
            this.btncadastroEditora.BackColor = System.Drawing.Color.SteelBlue;
            this.btncadastroEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastroEditora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastroEditora.Location = new System.Drawing.Point(144, 150);
            this.btncadastroEditora.Name = "btncadastroEditora";
            this.btncadastroEditora.Size = new System.Drawing.Size(380, 81);
            this.btncadastroEditora.TabIndex = 1;
            this.btncadastroEditora.Text = "Cadastrar editoras";
            this.btncadastroEditora.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.SlateGray;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(144, 252);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(380, 81);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "Usuários cadastrados";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 360);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btncadastroEditora);
            this.Controls.Add(this.btnCadastroLivro);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCadastroLivro;
        private System.Windows.Forms.Button btncadastroEditora;
        private System.Windows.Forms.Button btnUsuario;
    }
}