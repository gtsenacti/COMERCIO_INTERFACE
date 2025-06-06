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
    public partial class frmProdutoServico : Form
    {
        public frmProdutoServico()
        {
            InitializeComponent();
        }

        private void Button4(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            frmDadosProdutoServiço frm = new frmDadosProdutoServiço();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            frmTarefasProdutoServiço frm = new frmTarefasProdutoServiço();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
