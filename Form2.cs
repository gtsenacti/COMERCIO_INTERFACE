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
        public static string CadastroUsuario;
        public static  string CadastroSenha;
        public static string ConfirmaSenha;



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

            CadastroUsuario = txtCadastroDeUsuario.Text;
            CadastroSenha = txtCadastroDeSenha.Text;
            ConfirmaSenha = txtConfirmarSenha.Text;

            if (string.IsNullOrWhiteSpace(CadastroSenha) || string.IsNullOrWhiteSpace(CadastroUsuario) || string.IsNullOrWhiteSpace(ConfirmaSenha))
            {
                MessageBox.Show("Você não prencheu os campos corretamente");
            }else if(CadastroSenha != ConfirmaSenha)
            {   
                    MessageBox.Show("A senha não foi digitada corretamente");   
            }
            else
            {
                
                MessageBox.Show("Cadstro feito com sucesso");
                new Menu().Show();
                this.Hide();
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
