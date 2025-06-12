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
    public partial class Personagenss : Form
    {
        public Personagenss()
        {
            InitializeComponent();
            for ( int i = 0; i < Criação.personagens.Count; i++)
            {
                var pr = Criação.personagens[i];
                string descricao = $"{pr.nome} {pr.raca} {pr.classe} ";
                listBox1.Items.Add(descricao);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btvoltarTELA_Click(object sender, EventArgs e)
        {
            new Tela().Show();
            this.Hide();

        }
    }
}
