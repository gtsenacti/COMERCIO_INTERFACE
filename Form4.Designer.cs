namespace appComercio
{
    partial class Adicionar
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
            this.txtNomeCarta = new System.Windows.Forms.TextBox();
            this.lblNomeCarta = new System.Windows.Forms.Label();
            this.nudNivelCarta = new System.Windows.Forms.NumericUpDown();
            this.lblNivelCarta = new System.Windows.Forms.Label();
            this.lblDescricaoCarta = new System.Windows.Forms.Label();
            this.txtDescricaoCarta = new System.Windows.Forms.TextBox();
            this.cbTipoCarta = new System.Windows.Forms.ComboBox();
            this.lblTipoCarta = new System.Windows.Forms.Label();
            this.btSalvarCarta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNivelCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCarta
            // 
            this.txtNomeCarta.Location = new System.Drawing.Point(144, 56);
            this.txtNomeCarta.Name = "txtNomeCarta";
            this.txtNomeCarta.Size = new System.Drawing.Size(186, 20);
            this.txtNomeCarta.TabIndex = 0;
            this.txtNomeCarta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNomeCarta
            // 
            this.lblNomeCarta.AutoSize = true;
            this.lblNomeCarta.Location = new System.Drawing.Point(58, 59);
            this.lblNomeCarta.Name = "lblNomeCarta";
            this.lblNomeCarta.Size = new System.Drawing.Size(80, 13);
            this.lblNomeCarta.TabIndex = 1;
            this.lblNomeCarta.Text = "Nome Da Carta";
            // 
            // nudNivelCarta
            // 
            this.nudNivelCarta.Location = new System.Drawing.Point(145, 103);
            this.nudNivelCarta.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudNivelCarta.Name = "nudNivelCarta";
            this.nudNivelCarta.Size = new System.Drawing.Size(186, 20);
            this.nudNivelCarta.TabIndex = 2;
            // 
            // lblNivelCarta
            // 
            this.lblNivelCarta.AutoSize = true;
            this.lblNivelCarta.Location = new System.Drawing.Point(65, 105);
            this.lblNivelCarta.Name = "lblNivelCarta";
            this.lblNivelCarta.Size = new System.Drawing.Size(73, 13);
            this.lblNivelCarta.TabIndex = 3;
            this.lblNivelCarta.Text = "Nivel da carta";
            this.lblNivelCarta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescricaoCarta
            // 
            this.lblDescricaoCarta.AutoSize = true;
            this.lblDescricaoCarta.Location = new System.Drawing.Point(3, 153);
            this.lblDescricaoCarta.Name = "lblDescricaoCarta";
            this.lblDescricaoCarta.Size = new System.Drawing.Size(135, 13);
            this.lblDescricaoCarta.TabIndex = 4;
            this.lblDescricaoCarta.Text = "Descrição / Efeito de carta";
            // 
            // txtDescricaoCarta
            // 
            this.txtDescricaoCarta.Location = new System.Drawing.Point(146, 153);
            this.txtDescricaoCarta.Multiline = true;
            this.txtDescricaoCarta.Name = "txtDescricaoCarta";
            this.txtDescricaoCarta.Size = new System.Drawing.Size(185, 122);
            this.txtDescricaoCarta.TabIndex = 5;
            // 
            // cbTipoCarta
            // 
            this.cbTipoCarta.FormattingEnabled = true;
            this.cbTipoCarta.Location = new System.Drawing.Point(146, 306);
            this.cbTipoCarta.Name = "cbTipoCarta";
            this.cbTipoCarta.Size = new System.Drawing.Size(121, 21);
            this.cbTipoCarta.TabIndex = 6;
            this.cbTipoCarta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTipoCarta
            // 
            this.lblTipoCarta.AutoSize = true;
            this.lblTipoCarta.Location = new System.Drawing.Point(65, 309);
            this.lblTipoCarta.Name = "lblTipoCarta";
            this.lblTipoCarta.Size = new System.Drawing.Size(70, 13);
            this.lblTipoCarta.TabIndex = 7;
            this.lblTipoCarta.Text = "Tipo da carta";
            // 
            // btSalvarCarta
            // 
            this.btSalvarCarta.Location = new System.Drawing.Point(144, 385);
            this.btSalvarCarta.Name = "btSalvarCarta";
            this.btSalvarCarta.Size = new System.Drawing.Size(75, 23);
            this.btSalvarCarta.TabIndex = 8;
            this.btSalvarCarta.Text = "Salvar";
            this.btSalvarCarta.UseVisualStyleBackColor = true;
            this.btSalvarCarta.Click += new System.EventHandler(this.btSalvarCarta_Click);
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalvarCarta);
            this.Controls.Add(this.lblTipoCarta);
            this.Controls.Add(this.cbTipoCarta);
            this.Controls.Add(this.txtDescricaoCarta);
            this.Controls.Add(this.lblDescricaoCarta);
            this.Controls.Add(this.lblNivelCarta);
            this.Controls.Add(this.nudNivelCarta);
            this.Controls.Add(this.lblNomeCarta);
            this.Controls.Add(this.txtNomeCarta);
            this.Name = "Adicionar";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Adicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNivelCarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCarta;
        private System.Windows.Forms.Label lblNomeCarta;
        private System.Windows.Forms.NumericUpDown nudNivelCarta;
        private System.Windows.Forms.Label lblNivelCarta;
        private System.Windows.Forms.Label lblDescricaoCarta;
        private System.Windows.Forms.TextBox txtDescricaoCarta;
        private System.Windows.Forms.ComboBox cbTipoCarta;
        private System.Windows.Forms.Label lblTipoCarta;
        private System.Windows.Forms.Button btSalvarCarta;
    }
}