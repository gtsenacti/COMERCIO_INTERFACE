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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblPlaceholder_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadU = new frmCadastroUsuario();
            this.Visible = false;
            frmCadU.Show();
        }

        private void btnCadastroLivros_Click(object sender, EventArgs e)
        {
            frmLivros frmLiv = new frmLivros();
            this.Visible = false;
            frmLiv.Show();
        }

        private void btnCadastroEditora_Click(object sender, EventArgs e)
        {
            frmEditora frmE = new frmEditora();
            this.Visible = false;
            frmE.Show();   
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            frmReservas frmR = new frmReservas();
            this.Visible = false;
            frmR.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmL = new frmLogin();
            this.Visible = false;
            frmL.Show();
        }
    }
}
