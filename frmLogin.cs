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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            alteraImagensPic();
        }

        private void alteraImagensPic()
        {
            //Para o botão personagens
            Image imgOriginal = Properties.Resources.Fundo;
            Image imgRedimencionada = new Bitmap(imgOriginal, new Size(852, 508));
            pbBackground.Image = imgRedimencionada;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
