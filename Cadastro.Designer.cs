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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbchina)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbchina
            // 
            this.pbchina.BackgroundImage = global::appComercio.Properties.Resources.china;
            this.pbchina.Location = new System.Drawing.Point(-6, -1);
            this.pbchina.Name = "pbchina";
            this.pbchina.Size = new System.Drawing.Size(809, 456);
            this.pbchina.TabIndex = 0;
            this.pbchina.TabStop = false;
            this.pbchina.Click += new System.EventHandler(this.pbFundo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario : ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TxTusuario
            // 
            this.TxTusuario.Location = new System.Drawing.Point(17, 52);
            this.TxTusuario.Multiline = true;
            this.TxTusuario.Name = "TxTusuario";
            this.TxTusuario.Size = new System.Drawing.Size(308, 25);
            this.TxTusuario.TabIndex = 2;
            this.TxTusuario.TextChanged += new System.EventHandler(this.TxTusuario_TextChanged);
            // 
            // Txtsenha
            // 
            this.Txtsenha.Location = new System.Drawing.Point(17, 160);
            this.Txtsenha.Multiline = true;
            this.Txtsenha.Name = "Txtsenha";
            this.Txtsenha.Size = new System.Drawing.Size(308, 25);
            this.Txtsenha.TabIndex = 3;
            // 
            // TxTconfirmar
            // 
            this.TxTconfirmar.Location = new System.Drawing.Point(17, 236);
            this.TxTconfirmar.Multiline = true;
            this.TxTconfirmar.Name = "TxTconfirmar";
            this.TxTconfirmar.Size = new System.Drawing.Size(308, 25);
            this.TxTconfirmar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite sua senha : ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirme sua senha : ";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(194, 284);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(118, 23);
            this.Cadastrar.TabIndex = 7;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Cadastrar);
            this.panel1.Controls.Add(this.TxTusuario);
            this.panel1.Controls.Add(this.TxTconfirmar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txtsenha);
            this.panel1.Location = new System.Drawing.Point(218, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 333);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pbCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbchina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pbCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.pbCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbchina)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}