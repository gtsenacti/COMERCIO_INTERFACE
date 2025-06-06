using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appComercio
{
    public partial class frmLogin : Form
    {
        private TextBox txtUsuario;
        private TextBox txtSenha;

        public frmLogin()
        {
            InitializeComponent();
            txtUsuario = new TextBox
            {
                Location = new Point(100, 50),
                Size = new Size(200, 20)
            };
            txtSenha = new TextBox
            {
                Location = new Point(100, 80),
                Size = new Size(200, 20),
                PasswordChar = '*'
            };
            this.Controls.Add(txtUsuario);
            this.Controls.Add(txtSenha);

            comboBox1.Items.AddRange(new string[] { "Administrativo", "Financeiro", "Vendas", "TI" });
            comboBox1.SelectedIndex = 0;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frm = new frmCadastroUsuario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSair(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidarLogin(string nome, string senha, string setor)
        {
            string caminhoArquivo = "usuarios.txt"; // mesmo caminho usado no cadastro
            if (!File.Exists(caminhoArquivo))
                return false;

            var linhas = File.ReadAllLines(caminhoArquivo);
            foreach (var linha in linhas)
            {
                var partes = linha.Split(';');
                if (partes.Length == 3 &&
                    partes[0] == nome &&
                    partes[1] == senha &&
                    partes[2] == setor)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string setor = comboBox1.Text.Trim();

            // Se o setor não for necessário, passe null para setor
            if (ValidarLogin(usuario, senha, setor))
            {
                frmProdutoServico frm = new frmProdutoServico();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário, senha ou setor inválidos!");
            }
        }
    }
}

