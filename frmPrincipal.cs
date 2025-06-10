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
            this.Load += frmPrincipal_Load;
        }

      
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Color minhaCor = Color.FromArgb(40, 46, 166);
            EstiloBotoes.AplicarEstiloArredondado(btnCadastroProdutoServico, minhaCor);
            Color minhaCor2 = Color.FromArgb(40, 166, 73);
            EstiloBotoes.AplicarEstiloArredondado(btnDadosProdutoServico, minhaCor2);
            Color minhaCor3 = Color.FromArgb(245, 98, 98);
            EstiloBotoes.AplicarEstiloArredondado(btnTarefasProdutosServico, minhaCor3);
        }

        private void btnCadastroProdutoServico_Click(object sender, EventArgs e)
        {
            frmCadastroProdutoServico CadastroProdutos = new frmCadastroProdutoServico();
            CadastroProdutos.ShowDialog();
            
        }

        private void btnDadosProdutoServico_Click(object sender, EventArgs e)
        {
            frmFornecedorProdutoServico FornecedorProdutos = new frmFornecedorProdutoServico();
            FornecedorProdutos.ShowDialog();
        }

        private void btnTarefasProdutosServico_Click(object sender, EventArgs e)
        {
            frmEstoque estoque = new frmEstoque();
            estoque.ShowDialog();
        }
    }
}
