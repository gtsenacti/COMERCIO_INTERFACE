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
    public partial class frmPersonagens : Form
    {
        public frmPersonagens()
        {
            InitializeComponent();

            alteraImagensBotoes();
        }

        private void alteraImagensBotoes()
        {
            //Para o botão personagens
            Image imgOriginal = Properties.Resources.Rainbow_six_siege_Twitch;
            Image imgRedimencionada = new Bitmap(imgOriginal, new Size(338, 539));
            btnTwitch.Image = imgRedimencionada;
        }

        private void btnTwitch_Click(object sender, EventArgs e)
        {
            frmTwitch frmTwitch = new frmTwitch();
            frmTwitch.Show();
            this.Close();
        }
    }
}
