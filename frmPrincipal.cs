using System;
using System.Windows.Forms;

namespace appComercio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            MostraData();
        }

        private void MostraData()
        {
            lblData.Text = "Conectou em: " + DateTime.Now.ToString();
        }

        private void btnTelaCadastroProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCP = new frmCadastroProduto();
            frmCP.ShowDialog();
        }
    }
}
