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
    public partial class Criação : Form
    {
        public static List<personas> personagens = new List<personas>();

        public static string raca; 
        public Criação()
        {
            InitializeComponent();
            cbRaca.Items.Add("Draconato");
            cbRaca.Items.Add("Elfo");

            cbClasse.Items.Add("Bardo");
            cbClasse.Items.Add("Ladino");
        }

        private void Criação_Load(object sender, EventArgs e)
        {

        }
        public class personas
        {

            public string nome { get; set; }
            public string raca { get; set; }
            public string classe { get; set; }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            raca = cbRaca.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var persona = new personas();
            persona.nome = txtNome.Text;
            persona.raca = cbRaca.Text;
            persona.classe = cbClasse.Text;
            personagens.Add(persona);
            MessageBox.Show("Personagem adicionada com sucesso");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Tela().Show();
            this.Hide();
        }
    }
}
