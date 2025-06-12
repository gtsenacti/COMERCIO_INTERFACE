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
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image imgOriginal1 = Properties.Resources.Creditos;
            Image imgRedimencionada1 = new Bitmap(imgOriginal1, new Size(800, 456));
            pbcreditos.Image = imgRedimencionada1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Tela().Show();
            this.Hide();
        }
    }
}
