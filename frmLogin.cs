using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void gbTelaLogin_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkCadastro.LinkColor = Color.Blue;
            frmCadastro frmC = new frmCadastro();
            this.Visible = false;
            frmC.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmailUsuario.Text == "Jhenny" && txtSenha.Text == "1234")
            {
                btnLogin.Text = "Login realizado";
                btnLogin.BackColor = Color.DodgerBlue;
                frmPrincipal frmP = new frmPrincipal();
                this.Visible = false;
                frmP.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha não encontrado. Tente novamente");
                txtEmailUsuario.Text = txtSenha.Text = "";
            }
        }
    }
}
