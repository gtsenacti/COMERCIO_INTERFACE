namespace appComercio
{
    partial class TelaPrinciapal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblAdicionarCartas = new System.Windows.Forms.Label();
            this.lblVerCartas = new System.Windows.Forms.Label();
            this.lblExluirCartas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 137);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 137);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 137);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblAdicionarCartas
            // 
            this.lblAdicionarCartas.AutoSize = true;
            this.lblAdicionarCartas.Location = new System.Drawing.Point(85, 242);
            this.lblAdicionarCartas.Name = "lblAdicionarCartas";
            this.lblAdicionarCartas.Size = new System.Drawing.Size(79, 13);
            this.lblAdicionarCartas.TabIndex = 3;
            this.lblAdicionarCartas.Text = "Adicionar Carta";
            this.lblAdicionarCartas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVerCartas
            // 
            this.lblVerCartas.AutoSize = true;
            this.lblVerCartas.Location = new System.Drawing.Point(362, 242);
            this.lblVerCartas.Name = "lblVerCartas";
            this.lblVerCartas.Size = new System.Drawing.Size(56, 13);
            this.lblVerCartas.TabIndex = 4;
            this.lblVerCartas.Text = "Ver Cartas";
            this.lblVerCartas.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblExluirCartas
            // 
            this.lblExluirCartas.AutoSize = true;
            this.lblExluirCartas.Location = new System.Drawing.Point(613, 242);
            this.lblExluirCartas.Name = "lblExluirCartas";
            this.lblExluirCartas.Size = new System.Drawing.Size(71, 13);
            this.lblExluirCartas.TabIndex = 5;
            this.lblExluirCartas.Text = "Excluir Cartas";
            this.lblExluirCartas.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // TelaPrinciapal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExluirCartas);
            this.Controls.Add(this.lblVerCartas);
            this.Controls.Add(this.lblAdicionarCartas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TelaPrinciapal";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblAdicionarCartas;
        private System.Windows.Forms.Label lblVerCartas;
        private System.Windows.Forms.Label lblExluirCartas;
    }
}