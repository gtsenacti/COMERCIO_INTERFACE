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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TXusuario = new System.Windows.Forms.TextBox();
            this.TXsenha = new System.Windows.Forms.TextBox();
            this.pbDado = new System.Windows.Forms.PictureBox();
            this.pbFundo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(184, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(14, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(99, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXusuario
            // 
            this.TXusuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXusuario.Location = new System.Drawing.Point(35, 280);
            this.TXusuario.Multiline = true;
            this.TXusuario.Name = "TXusuario";
            this.TXusuario.Size = new System.Drawing.Size(208, 28);
            this.TXusuario.TabIndex = 1;
            this.TXusuario.TextChanged += new System.EventHandler(this.TXusuario_TextChanged);
            // 
            // TXsenha
            // 
            this.TXsenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXsenha.Location = new System.Drawing.Point(35, 338);
            this.TXsenha.Multiline = true;
            this.TXsenha.Name = "TXsenha";
            this.TXsenha.PasswordChar = '*';
            this.TXsenha.Size = new System.Drawing.Size(208, 28);
            this.TXsenha.TabIndex = 2;
            this.TXsenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pbDado
            // 
            this.pbDado.Image = global::appComercio.Properties.Resources.Dado1;
            this.pbDado.Location = new System.Drawing.Point(50, 39);
            this.pbDado.Name = "pbDado";
            this.pbDado.Size = new System.Drawing.Size(193, 185);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}