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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "sla") //Percorrer pelo banco e procurar se o dado já está cadastrado
            {
                MessageBox.Show("Esse usuário já está cadastrado, faça o login");
            }
            else
            {
                //adicionar o usuário no db
                //Adicionar o nome usuário no gb usuario
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmLU = new frmLogin();
            this.Visible = false;
            frmLU.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linklblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal frmP = new frmPrincipal();
            frmP.Show();
            this.Visible = false;
        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
