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

    public partial class TelaLogin : Form
    {
        public string usuario1;
        public string senha1;
        public TelaLogin()
        {
            InitializeComponent();

            ResizeImage();
        }

        private void ResizeImage()
        {
         
            Image imgOriginal = Properties.Resources.Model_dado_d20_RPG;
            Image imgRedimencionada = new Bitmap(imgOriginal, new Size(207, 164));
            pbDado.Image = imgRedimencionada;

            Image imgOriginal1 = Properties.Resources.img;
            Image imgRedimencionada1 = new Bitmap(imgOriginal1, new Size(533, 451));
            pbFundo.Image = imgRedimencionada1;
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario1 = TXusuario.Text;
            senha1 = TXsenha.Text;

            if (string.IsNullOrWhiteSpace(senha1) || string.IsNullOrWhiteSpace(usuario1))
            {
                MessageBox.Show("Você não prencheu os campos corretamente");
            }
            else if (senha1 != pbCadastro.senha)
            {
                MessageBox.Show("A senha não foi digitada corretamente");
            }
            else if (usuario1 != pbCadastro.usuario)
            {
                MessageBox.Show("O usuario não existe");
            }
            else if (senha1 == pbCadastro.senha && usuario1 == pbCadastro.usuario)
            {
                new Tela().Show();
                    this.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new pbCadastro().Show();
            this.Hide();
        }
    }
}
