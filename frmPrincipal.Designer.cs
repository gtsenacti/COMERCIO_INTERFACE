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
            this.button3 = new System.Windows.Forms.Button();
            this.btnMapas = new System.Windows.Forms.Button();
            this.btnPersonagens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 311);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnMapas
            // 
            this.btnMapas.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnMapas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMapas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btnMapas.Image = global::appComercio.Properties.Resources.Oregon___Maps___Tom_Clancy_s_Rainbow_Six_Siege___Ubisoft__CA_;
            this.btnMapas.Location = new System.Drawing.Point(12, 12);
            this.btnMapas.Name = "btnMapas";
            this.btnMapas.Size = new System.Drawing.Size(218, 311);
            this.btnMapas.TabIndex = 1;
            this.btnMapas.Text = "Mapas";
            this.btnMapas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMapas.UseVisualStyleBackColor = true;
            this.btnMapas.Click += new System.EventHandler(this.btnMapas_Click);
            // 
            // btnPersonagens
            // 
            this.btnPersonagens.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonagens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btnPersonagens.Image = global::appComercio.Properties.Resources.Cosplay_Costumes__Cosplay_Shoes__Cosplay_Wigs_Latest___Greatest___CosplayClass_;
            this.btnPersonagens.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonagens.Location = new System.Drawing.Point(292, 12);
            this.btnPersonagens.Name = "btnPersonagens";
            this.btnPersonagens.Size = new System.Drawing.Size(222, 311);
            this.btnPersonagens.TabIndex = 0;
            this.btnPersonagens.Text = "Personagens";
            this.btnPersonagens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonagens.UseVisualStyleBackColor = true;
            this.btnPersonagens.Click += new System.EventHandler(this.btnPersonagens_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMapas);
            this.Controls.Add(this.btnPersonagens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonagens;
        private System.Windows.Forms.Button btnMapas;
        private System.Windows.Forms.Button button3;
    }
}