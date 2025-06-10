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
    public partial class pbCadastro : Form
    {
        public static string senha;
        public static string consenha;
        public static string usuario;
        public pbCadastro()
        {
            InitializeComponent();

            ResizeImage();
        }
        private void ResizeImage()
        {
            //Para o botão personagens
            Image imgOriginal2 = Properties.Resources.china;
            Image imgRedimencionada2 = new Bitmap(imgOriginal2, new Size(802, 451));
            pbchina.Image = imgRedimencionada2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbFundo_Click(object sender, EventArgs e)
        {

        }

        private void pbCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = TxTusuario.Text;
            senha = Txtsenha.Text;
            consenha = TxTconfirmar.Text;

            if (string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(consenha))
            {
                MessageBox.Show("Você não prencheu os campos corretamente");
            }
            else if (senha != consenha)
            {
                MessageBox.Show("A senha não foi digitada corretamente");
            }
            else
            {

                MessageBox.Show("Cadstro feito com sucesso LEEEEEESGOOO!!!");
                new TelaLogin().Show();
                this.Hide();
            }
        }
    }
}