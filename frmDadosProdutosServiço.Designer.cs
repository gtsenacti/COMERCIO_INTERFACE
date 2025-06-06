namespace appComercio
{
    partial class frmDadosProdutosServiço
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
            this.gbDadosProdutoServiço = new System.Windows.Forms.GroupBox();
            this.gbDadosPodutoServiço = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbTelaLogin = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalvarProdutoServiço = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditarProdutorServiços = new System.Windows.Forms.Button();
            this.gbDadosPodutoServiço.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDadosProdutoServiço
            // 
            this.gbDadosProdutoServiço.BackColor = System.Drawing.SystemColors.Control;
            this.gbDadosProdutoServiço.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosProdutoServiço.Location = new System.Drawing.Point(12, 32);
            this.gbDadosProdutoServiço.Name = "gbDadosProdutoServiço";
            this.gbDadosProdutoServiço.Size = new System.Drawing.Size(344, 233);
            this.gbDadosProdutoServiço.TabIndex = 19;
            this.gbDadosProdutoServiço.TabStop = false;
            this.gbDadosProdutoServiço.Text = "Dados Produtos/Serviço";
            // 
            // gbDadosPodutoServiço
            // 
            this.gbDadosPodutoServiço.Controls.Add(this.btnBuscar);
            this.gbDadosPodutoServiço.Controls.Add(this.textBox1);
            this.gbDadosPodutoServiço.Location = new System.Drawing.Point(12, 289);
            this.gbDadosPodutoServiço.Name = "gbDadosPodutoServiço";
            this.gbDadosPodutoServiço.Size = new System.Drawing.Size(344, 74);
            this.gbDadosPodutoServiço.TabIndex = 20;
            this.gbDadosPodutoServiço.TabStop = false;
            this.gbDadosPodutoServiço.Text = "Busca Dados Produto/Serviço";
            this.gbDadosPodutoServiço.Enter += new System.EventHandler(this.gbDadosPodutoServiço_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(221, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 34);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar       ";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(7, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 7;
            // 
            // pbTelaLogin
            // 
            this.pbTelaLogin.Location = new System.Drawing.Point(362, 51);
            this.pbTelaLogin.Name = "pbTelaLogin";
            this.pbTelaLogin.Size = new System.Drawing.Size(272, 312);
            this.pbTelaLogin.TabIndex = 22;
            this.pbTelaLogin.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(427, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 23;
            this.button2.Text = "Apagar     ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSalvarProdutoServiço
            // 
            this.btnSalvarProdutoServiço.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarProdutoServiço.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarProdutoServiço.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarProdutoServiço.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProdutoServiço.Location = new System.Drawing.Point(91, 381);
            this.btnSalvarProdutoServiço.Name = "btnSalvarProdutoServiço";
            this.btnSalvarProdutoServiço.Size = new System.Drawing.Size(105, 46);
            this.btnSalvarProdutoServiço.TabIndex = 24;
            this.btnSalvarProdutoServiço.Text = "Salvar        ";
            this.btnSalvarProdutoServiço.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarProdutoServiço.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 331);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnEditarProdutorServiços
            // 
            this.btnEditarProdutorServiços.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditarProdutorServiços.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProdutorServiços.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarProdutorServiços.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProdutorServiços.Location = new System.Drawing.Point(265, 381);
            this.btnEditarProdutorServiços.Name = "btnEditarProdutorServiços";
            this.btnEditarProdutorServiços.Size = new System.Drawing.Size(100, 45);
            this.btnEditarProdutorServiços.TabIndex = 26;
            this.btnEditarProdutorServiços.Text = "Editar      ";
            this.btnEditarProdutorServiços.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarProdutorServiços.UseVisualStyleBackColor = false;
            // 
            // DadosProdutosServiço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.btnEditarProdutorServiços);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalvarProdutoServiço);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbTelaLogin);
            this.Controls.Add(this.gbDadosPodutoServiço);
            this.Controls.Add(this.gbDadosProdutoServiço);
            this.Name = "DadosProdutosServiço";
            this.Text = "DadosProdutosServiço";
            this.gbDadosPodutoServiço.ResumeLayout(false);
            this.gbDadosPodutoServiço.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosProdutoServiço;
        private System.Windows.Forms.GroupBox gbDadosPodutoServiço;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbTelaLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalvarProdutoServiço;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditarProdutorServiços;
    }
}