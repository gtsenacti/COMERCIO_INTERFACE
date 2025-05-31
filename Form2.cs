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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblConfirmarSenha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string CadastroUsuario = txtCadastroDeUsuario.Text;
            string CadastroSenha = txtCadastroDeSenha.Text;
            string ConfirmaSenha = txtConfirmarSenha.Text;

            if (string.IsNullOrWhiteSpace(CadastroSenha) || string.IsNullOrWhiteSpace(CadastroUsuario) || string.IsNullOrWhiteSpace(ConfirmaSenha))
            {
                MessageBox.Show("Você não prencheu os campos corretamente");
            }else if(CadastroSenha != ConfirmaSenha)
            {   
                    MessageBox.Show("A senha não foi digitada corretamente");   
            }
            else
            {
                var LogInUsuario = CadastroUsuario;
                var LogInSenha = CadastroSenha;
                MessageBox.Show("Cadstro feito com sucesso");
                new Menu().Show();
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
