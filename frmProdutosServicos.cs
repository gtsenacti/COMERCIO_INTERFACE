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
    public partial class frmProdutosServicos : Form
    {
        public frmProdutosServicos()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastroProdutoServico_Click(object sender, EventArgs e)
        {
            frmCadastroProdutoServico CaProSer = new frmCadastroProdutoServico();
            CaProSer.ShowDialog();
        }

        private void btnDadosProdutosSevico_Click(object sender, EventArgs e)
        {
            frmDadosProdutoServico DaProSer = new frmDadosProdutoServico();
            DaProSer.ShowDialog();
        }

        private void btnTarefaProdutoServico_Click(object sender, EventArgs e)
        {
            frmTarefasProdutosServicos TaProSer = new frmTarefasProdutosServicos();
            TaProSer.ShowDialog();
        }
    }
}
