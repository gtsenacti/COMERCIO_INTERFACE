namespace appComercio
{
    partial class frmPersonagens
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
            this.btnTwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(395, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 539);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(785, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 539);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnTwitch
            // 
            this.btnTwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.btnTwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitch.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwitch.ForeColor = System.Drawing.Color.White;
            this.btnTwitch.Image = global::appComercio.Properties.Resources.Rainbow_six_siege_Twitch;
            this.btnTwitch.Location = new System.Drawing.Point(12, 12);
            this.btnTwitch.Name = "btnTwitch";
            this.btnTwitch.Size = new System.Drawing.Size(338, 539);
            this.btnTwitch.TabIndex = 0;
            this.btnTwitch.Text = "Twitch";
            this.btnTwitch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTwitch.UseVisualStyleBackColor = false;
            this.btnTwitch.Click += new System.EventHandler(this.btnTwitch_Click);
            // 
            // frmPersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(21)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1135, 563);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTwitch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}