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

    public partial class Adicionar : Form
    {

        public Adicionar()
        {
            InitializeComponent();
        }


        private void Adicionar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class Carta
        {
            public string NomeCarta { get;set; }
            public string DescricaoCarta { get; set; }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btSalvarCarta_Click(object sender, EventArgs e)
        {
            var Carta1 = new Carta();
            Carta1.NomeCarta = txtNomeCarta.Text;
            Carta1.DescricaoCarta = txtDescricaoCarta.Text;
            txtDescricaoCarta.Text = Carta1.NomeCarta;
        }
    }
}
