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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cadastro().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var MenuUsuario = txtUsuario.Text;
            var MenuSenha = txtSenha.Text;
            var usuario = Cadastro.CadastroUsuario;
            var senha = Cadastro.CadastroSenha;
            if (usuario == MenuUsuario && senha == MenuSenha) { 
            new TelaPrinciapal().Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("As informações estão incorretas");
                txtSenha.Text = "";
                txtUsuario.Text = "";
            }

            }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
