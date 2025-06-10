namespace appComercio
{
    partial class TelaLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXsenha = new System.Windows.Forms.TextBox();
            this.TXusuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pbDado = new System.Windows.Forms.PictureBox();
            this.pbFundo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TXusuario);
            this.panel1.Controls.Add(this.TXsenha);
            this.panel1.Controls.Add(this.pbDado);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 452);
            this.panel1.TabIndex = 2;
            // 
            // TXsenha
            // 
            this.TXsenha.Location = new System.Drawing.Point(35, 325);
            this.TXsenha.Multiline = true;
            this.TXsenha.Name = "TXsenha";
            this.TXsenha.Size = new System.Drawing.Size(208, 28);
            this.TXsenha.TabIndex = 2;
            this.TXsenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXusuario
            // 
            this.TXusuario.Location = new System.Drawing.Point(35, 280);
            this.TXusuario.Multiline = true;
            this.TXusuario.Name = "TXusuario";
            this.TXusuario.Size = new System.Drawing.Size(208, 28);
            this.TXusuario.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbDado
            // 
            this.pbDado.Image = global::appComercio.Properties.Resources.Model_dado_d20_RPG;
            this.pbDado.Location = new System.Drawing.Point(35, 25);
            this.pbDado.Name = "pbDado";
            this.pbDado.Size = new System.Drawing.Size(208, 165);
            this.pbDado.TabIndex = 1;
            this.pbDado.TabStop = false;
            this.pbDado.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbFundo
            // 
            this.pbFundo.BackgroundImage = global::appComercio.Properties.Resources.img;
            this.pbFundo.Location = new System.Drawing.Point(267, -2);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(534, 452);
            this.pbFundo.TabIndex = 0;
            this.pbFundo.TabStop = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbFundo);
            this.Name = "TelaLogin";
            this.Text = "TelaLogin";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.PictureBox pbDado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXusuario;
        private System.Windows.Forms.TextBox TXsenha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}