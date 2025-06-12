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
    public partial class btVerCarta : Form
    {
        public btVerCarta()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Adicionar.CartasSalvas.Count;i++)
            {
                var carta = Adicionar.CartasSalvas[i];
                string texto = $"{i + 1}   -   Nome: {carta.NomeCarta}     Tipo: {carta.TipoCarta}     Nível: {carta.NivelCarta}";
                listBox1.Items.Add(texto);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new TelaPrinciapal().Show();
            this.Hide();
        }
    }
}
