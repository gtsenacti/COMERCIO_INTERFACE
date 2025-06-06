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
    public partial class frmCadastroUsuario : Form
    {
        // Lista temporária para armazenar os usuários
        private BindingList<Usuario> usuarios = new BindingList<Usuario>();

        // Caminho do arquivo de usuários
        private string caminhoArquivo = "usuarios.txt";

        public frmCadastroUsuario()
        {
            InitializeComponent();
            // Configura o DataGridView para exibir a lista de usuários
            dataGridView1.DataSource = usuarios;

            // Exemplo de setores para o ComboBox
            comboBox1.Items.AddRange(new string[] { "Administrativo", "Financeiro", "Vendas", "TI" });
            comboBox1.SelectedIndex = 0;

            // Carregar usuários do arquivo texto
            CarregarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Adiciona novo usuário à lista
            usuarios.Add(new Usuario
            {
                Nome = this.txtUsuario.Text, // txtUsuario agora é corretamente identificado como TextBox
                Senha = this.textSenha.Text, // Corrigido para acessar a propriedade Text do TextBox
                Setor = comboBox1.Text
            });

            // Salvar usuários no arquivo texto
            SalvarUsuarios();

            // Limpa os campos após o cadastro
            txtUsuario.Clear();
            textSenha.Clear();
            comboBox1.SelectedIndex = 0;
        }

        // Exemplo de método para salvar usuários em um arquivo
        private void SalvarUsuarios()
        {
            using (StreamWriter sw = new StreamWriter("usuarios.txt", false, Encoding.UTF8))
            {
                foreach (var usuario in usuarios)
                {
                    sw.WriteLine($"{usuario.Nome};{usuario.Senha};{usuario.Setor}");
                }
            }
        }

        // Carregar usuários do arquivo texto
        private void CarregarUsuarios()
        {
            usuarios.Clear();
            if (File.Exists(caminhoArquivo))
            {
                foreach (var linha in File.ReadAllLines(caminhoArquivo, Encoding.UTF8))
                {
                    var partes = linha.Split(';');
                    if (partes.Length >= 3)
                    {
                        usuarios.Add(new Usuario
                        {
                            Nome = partes[0],
                            Senha = partes[1],
                            Setor = partes[2]
                        });
                    }
                }
            }
        }

        // Classe para representar o usuário
        public class Usuario
        {
            public string Nome { get; set; }
            public string Senha { get; set; }
            public string Setor { get; set; }
        }

        // Corrigido: Alterado o nome do método txtUsuario para txtUsuario_TextChanged
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        // Corrigido: Alterado o nome do método textSenha para textSenha_TextChanged
        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListarArquivos()
        {
            string[] arquivos = Directory.GetFiles(@"C:\SeuDiretorio");
            foreach (string arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
        }
    }
}
