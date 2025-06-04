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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.btnCadastroReserva = new System.Windows.Forms.Button();
            this.btnCadastroLivro = new System.Windows.Forms.Button();
            this.btnCadastroEditora = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUsuario.Location = new System.Drawing.Point(3, 135);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(489, 60);
            this.btnCadastroUsuario.TabIndex = 2;
            this.btnCadastroUsuario.Text = "Cadastrar Usuário";
            this.btnCadastroUsuario.UseVisualStyleBackColor = false;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCadastroReserva
            // 
            this.btnCadastroReserva.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCadastroReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroReserva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroReserva.Location = new System.Drawing.Point(3, 201);
            this.btnCadastroReserva.Name = "btnCadastroReserva";
            this.btnCadastroReserva.Size = new System.Drawing.Size(489, 60);
            this.btnCadastroReserva.TabIndex = 3;
            this.btnCadastroReserva.Text = "Cadastrar Reserva";
            this.btnCadastroReserva.UseVisualStyleBackColor = false;
            this.btnCadastroReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnCadastroLivro
            // 
            this.btnCadastroLivro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCadastroLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroLivro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroLivro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastroLivro.Location = new System.Drawing.Point(3, 3);
            this.btnCadastroLivro.Name = "btnCadastroLivro";
            this.btnCadastroLivro.Size = new System.Drawing.Size(489, 60);
            this.btnCadastroLivro.TabIndex = 0;
            this.btnCadastroLivro.Text = "Cadastrar Livro";
            this.btnCadastroLivro.UseVisualStyleBackColor = false;
            this.btnCadastroLivro.Click += new System.EventHandler(this.btnCadastroLivros_Click);
            // 
            // btnCadastroEditora
            // 
            this.btnCadastroEditora.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastroEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroEditora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroEditora.Location = new System.Drawing.Point(3, 69);
            this.btnCadastroEditora.Name = "btnCadastroEditora";
            this.btnCadastroEditora.Size = new System.Drawing.Size(489, 60);
            this.btnCadastroEditora.TabIndex = 1;
            this.btnCadastroEditora.Text = "Cadastrar Editora";
            this.btnCadastroEditora.UseVisualStyleBackColor = false;
            this.btnCadastroEditora.Click += new System.EventHandler(this.btnCadastroEditora_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnCadastroReserva, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastroEditora, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastroUsuario, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastroLivro, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(209, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 264);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(914, 450);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.Button btnCadastroReserva;
        private System.Windows.Forms.Button btnCadastroLivro;
        private System.Windows.Forms.Button btnCadastroEditora;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}