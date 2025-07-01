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
    public partial class frmTwitch : Form
    {
        public frmTwitch()
        {
            InitializeComponent();

            alteraImagensPic();
        }

        private void alteraImagensPic()
        {
            //Para o botão personagens
            Image imgOriginal = Properties.Resources.Y0R6_BADGE_Twitch_L;
            Image imgRedimencionada = new Bitmap(imgOriginal, new Size(100, 100));
            pbLogotwitch.Image = imgRedimencionada;

            Image imgOriginal1 = Properties.Resources.SG_CQB;
            Image imgRedimencionada1 = new Bitmap(imgOriginal1, new Size(285, 90));
            btnSg.Image = imgRedimencionada1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmTwitch_Load(object sender, EventArgs e)
        {

        }

        private void pbF2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPersonagens frmPersonagens = new frmPersonagens();
            frmPersonagens.Show();
            this.Hide();
        }
    }
}
