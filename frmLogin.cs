using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appComercio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Código executado ao carregar o formulário (se necessário)
        }

        private void pbTelaLogin_Click(object sender, EventArgs e)
        {
            // Clique na imagem (se tiver funcionalidade)
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Quando o texto do usuário mudar (se necessário)
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta temporariamente o formulário de login

            using (Cadastro cadastro = new Cadastro()) // Certifique-se de que sua classe se chama 'Cadastro'
            {
                cadastro.ShowDialog(); // Abre o cadastro de forma modal
            }

            this.Show(); // Reexibe o formulário de login depois que o cadastro for fechado
        }
    }
}
