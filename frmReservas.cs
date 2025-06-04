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
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void gbBtn_Enter(object sender, EventArgs e)
        {

        }

        private void linklblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal frmP = new frmPrincipal();
            this.Visible = false;
            frmP.Show(); 
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
