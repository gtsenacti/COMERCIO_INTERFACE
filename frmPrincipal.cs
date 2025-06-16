using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appComercio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            alteraImagensBotoes();
        }

        private void alteraImagensBotoes()
        {
            //Para o botão personagens
            Image imgOriginal = Properties.Resources.Cosplay_Costumes__Cosplay_Shoes__Cosplay_Wigs_Latest___Greatest___CosplayClass_;
            Image imgRedimencionada = new Bitmap(imgOriginal, new Size(221, 310));
            btnPersonagens.Image = imgRedimencionada;

            //botão mapas
            Image imgOriginal2 = Properties.Resources.Oregon___Maps___Tom_Clancy_s_Rainbow_Six_Siege___Ubisoft__CA_;
            Image imgRedimencionada2 = new Bitmap(imgOriginal2, new Size(221, 310));
            btnMapas.Image = imgRedimencionada2;

            //botão cosmeticos
            Image imgOriginal3 = Properties.Resources.cosmeticos2;
            Image imgRedimencionada3 = new Bitmap(imgOriginal3, new Size(221, 310));
            btnCosmeticos.Image = imgRedimencionada3;


        }

        private void btnPersonagens_Click(object sender, EventArgs e)
        {
            frmPersonagens frmPersonagens = new frmPersonagens();
            frmPersonagens.Show();
            this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMapas_Click(object sender, EventArgs e)
        {

        }

        private void btnCosmeticos_Click(object sender, EventArgs e)
        {

        }
    }
}
