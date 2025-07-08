namespace appComercio
{
    partial class Personagenss
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
            this.btvoltarTELA = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // btvoltarTELA
            // 
            this.btvoltarTELA.Location = new System.Drawing.Point(641, 396);
            this.btvoltarTELA.Name = "btvoltarTELA";
            this.btvoltarTELA.Size = new System.Drawing.Size(127, 35);
            this.btvoltarTELA.TabIndex = 4;
            this.btvoltarTELA.Text = "Voltar";
            this.btvoltarTELA.UseVisualStyleBackColor = true;
            this.btvoltarTELA.Click += new System.EventHandler(this.btvoltarTELA_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(474, 396);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(127, 35);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(456, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 354);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(13, 25);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(408, 354);
            this.Data.TabIndex = 7;
            this.Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Personagenss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btvoltarTELA);
            this.Name = "Personagenss";
            this.Text = "Personagenss";
            this.Load += new System.EventHandler(this.Personagenss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btvoltarTELA;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Data;
    }
}