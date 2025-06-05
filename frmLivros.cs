using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace appComercio
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void frmLivros_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void linklblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal frmP = new frmPrincipal();
            frmP.Show();
            this.Visible = false;
        }

        private void gbCadastroLivros_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal frmP = new frmPrincipal();
            frmP.Show();
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "" || txtISBN.Text == "" || txtGenero.Text=="")
            {
                MessageBox.Show("Campo vazio. Nenhum dado foi cadastrado");
            }
            else
            {
                if (txtISBN.Text == "sla") //Percorrer pelo banco e procurar se o dado já está cadastrado
                {
                    MessageBox.Show("Esse livro já está cadastrado.");
                }
                else
                {
                    //adicionar o usuário no db
                    //Adicionar o usuário no dgv usuario
                }
            }
        }
    }
}
