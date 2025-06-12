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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btMostrarCarta = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btMostrarCarta
            // 
            this.btMostrarCarta.Location = new System.Drawing.Point(217, 401);
            this.btMostrarCarta.Name = "btMostrarCarta";
            this.btMostrarCarta.Size = new System.Drawing.Size(101, 23);
            this.btMostrarCarta.TabIndex = 1;
            this.btMostrarCarta.Text = "Mostrar cartas";
            this.btMostrarCarta.UseVisualStyleBackColor = true;
            this.btMostrarCarta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(379, 401);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(101, 23);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btVerCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btMostrarCarta);
            this.Controls.Add(this.listBox1);
            this.Name = "btVerCarta";
            this.Text = "VerCartas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btMostrarCarta;
        private System.Windows.Forms.Button btSair;
    }
}