using System;
using System.Windows.Forms;

namespace appComercio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmCadUsu = new frmCadastroUsuario();
            frmCadUsu.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPrincipal frmP = new frmPrincipal();
            frmP.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            frmAgenda frma = new frmAgenda();
            frma.ShowDialog();
        }
    }
}
