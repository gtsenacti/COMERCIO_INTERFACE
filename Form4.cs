using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appComercio
{

    public partial class Adicionar : Form
    {
        public static List<Carta> CartasSalvas = new List<Carta>();

        public Adicionar()
        {
            InitializeComponent();
            cbTipoCarta.Items.Add("Normal");
            cbTipoCarta.Items.Add("Fusão");
            cbTipoCarta.Items.Add("Sincron");
            cbTipoCarta.Items.Add("XY");
            cbTipoCarta.Items.Add("Pendolu");
            cbTipoCarta.Items.Add("Link");
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
            public int NivelCarta { get; set; }
            public string TipoCarta { get; set; }
            
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void btSalvarCarta_Click(object sender, EventArgs e)
        {
            var Cart = new Carta();
            Cart.NomeCarta = txtNomeCarta.Text;
            Cart.DescricaoCarta = txtDescricaoCarta.Text;
            Cart.NivelCarta =  (int)nudNivelCarta.Value;
            Cart.TipoCarta = cbTipoCarta.Text.Trim();
            CartasSalvas.Add(Cart);
            MessageBox.Show($"Carta #{Adicionar.CartasSalvas.Count} salva com sucesso!");
          
        }

        private void txtDescricaoCarta_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudNivelCarta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new TelaPrinciapal().Show();
            this.Hide();
        }
    }
}
