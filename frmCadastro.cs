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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
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
                    frmLogin frmL = new frmLogin();
                    this.Visible = false;
                    frmL.Show();
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmL = new frmLogin();
            this.Visible = false;
            frmL.Show();
        }
    }
}
