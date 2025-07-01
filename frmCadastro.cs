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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            alteraImagensPic();
        }

        private void alteraImagensPic()
        {
            //Para o botão personagens
            Image imgOriginal = Properties.Resources.R6_Black_Ice_Background;
            Image imgRedimencionada = new Bitmap(imgOriginal, new Size(556, 492));
            pbBackground.Image = imgRedimencionada;

            Image imgOriginal1 = Properties.Resources.Rainbow_six_siege;
            Image imgRedimencionada1 = new Bitmap(imgOriginal1, new Size(240, 199));
            pbLogo.Image = imgRedimencionada1;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Conta criada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Conta criada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
