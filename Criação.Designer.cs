namespace appComercio
{
    partial class Criação
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btvoltarCRIAR = new System.Windows.Forms.Button();
            this.btSALVAR = new System.Windows.Forms.Button();
            this.pbRaca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);
            this.txtNome.TabIndex = 0;
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(64, 149);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(165, 21);
            this.cbRaca.TabIndex = 1;
            this.cbRaca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbClasse
            // 
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(64, 199);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(165, 21);
            this.cbClasse.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raça: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Classe: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btvoltarCRIAR
            // 
            this.btvoltarCRIAR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btvoltarCRIAR.Location = new System.Drawing.Point(207, 366);
            this.btvoltarCRIAR.Name = "btvoltarCRIAR";
            this.btvoltarCRIAR.Size = new System.Drawing.Size(79, 35);
            this.btvoltarCRIAR.TabIndex = 4;
            this.btvoltarCRIAR.Text = "Voltar";
            this.btvoltarCRIAR.UseVisualStyleBackColor = false;
            this.btvoltarCRIAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // btSALVAR
            // 
            this.btSALVAR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSALVAR.Location = new System.Drawing.Point(67, 366);
            this.btSALVAR.Name = "btSALVAR";
            this.btSALVAR.Size = new System.Drawing.Size(79, 35);
            this.btSALVAR.TabIndex = 3;
            this.btSALVAR.Text = "Salvar";
            this.btSALVAR.UseVisualStyleBackColor = false;
            this.btSALVAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbRaca
            // 
            this.pbRaca.Location = new System.Drawing.Point(446, 61);
            this.pbRaca.Name = "pbRaca";
            this.pbRaca.Size = new System.Drawing.Size(302, 340);
            this.pbRaca.TabIndex = 6;
            this.pbRaca.TabStop = false;
            this.pbRaca.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Criação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSALVAR);
            this.Controls.Add(this.btvoltarCRIAR);
            this.Controls.Add(this.pbRaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.txtNome);
            this.Name = "Criação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criação";
            this.Load += new System.EventHandler(this.Criação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbRaca;
        private System.Windows.Forms.Button btvoltarCRIAR;
        private System.Windows.Forms.Button btSALVAR;
    }
}