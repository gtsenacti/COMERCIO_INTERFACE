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
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private void btCharecter_Click(object sender, EventArgs e)
        {
            new Criação().Show();
            this.Hide();
        }

        private void btPersonagens_Click(object sender, EventArgs e)
        {
            new Personagenss().Show();
            this.Hide();
        }

        private void btvoltarTELA_Click(object sender, EventArgs e)
        {
            new TelaLogin().Show();
            this.Hide();
        }

        private void btCreditos_Click(object sender, EventArgs e)
        {
            new Creditos().Show();
            this.Hide();
        }
    }
}
