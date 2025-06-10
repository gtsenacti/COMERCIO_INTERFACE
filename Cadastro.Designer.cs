namespace appComercio
{
    partial class pbCadastro
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
            this.pbchina = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxTusuario = new System.Windows.Forms.TextBox();
            this.Txtsenha = new System.Windows.Forms.TextBox();
            this.TxTconfirmar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbchina)).BeginInit();
            this.SuspendLayout();
            // 
            // pbchina
            // 
            this.pbchina.BackgroundImage = global::appComercio.Properties.Resources.china;
            this.pbchina.Location = new System.Drawing.Point(-6, 3);
            this.pbchina.Name = "pbchina";
            this.pbchina.Size = new System.Drawing.Size(803, 452);
            this.pbchina.TabIndex = 0;
            this.pbchina.TabStop = false;
            this.pbchina.Click += new System.EventHandler(this.pbFundo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario : ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TxTusuario
            // 
            this.TxTusuario.Location = new System.Drawing.Point(264, 137);
            this.TxTusuario.Multiline = true;
            this.TxTusuario.Name = "TxTusuario";
            this.TxTusuario.Size = new System.Drawing.Size(301, 25);
            this.TxTusuario.TabIndex = 2;
            // 
            // Txtsenha
            // 
            this.Txtsenha.Location = new System.Drawing.Point(264, 236);
            this.Txtsenha.Multiline = true;
            this.Txtsenha.Name = "Txtsenha";
            this.Txtsenha.Size = new System.Drawing.Size(301, 25);
            this.Txtsenha.TabIndex = 3;
            // 
            // TxTconfirmar
            // 
            this.TxTconfirmar.Location = new System.Drawing.Point(264, 307);
            this.TxTconfirmar.Multiline = true;
            this.TxTconfirmar.Name = "TxTconfirmar";
            this.TxTconfirmar.Size = new System.Drawing.Size(301, 25);
            this.TxTconfirmar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite sua senha : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(261, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirme sua senha : ";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(353, 387);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(118, 23);
            this.Cadastrar.TabIndex = 7;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxTconfirmar);
            this.Controls.Add(this.Txtsenha);
            this.Controls.Add(this.TxTusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbchina);
            this.Name = "pbCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.pbCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbchina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbchina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxTusuario;
        private System.Windows.Forms.TextBox Txtsenha;
        private System.Windows.Forms.TextBox TxTconfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cadastrar;
    }
}