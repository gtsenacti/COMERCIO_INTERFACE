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
    public partial class frmProdutoServiço : Form
    {
        public frmProdutoServiço()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroProdutoServicos CaProSer = new frmCadastroProdutoServicos();
            CaProSer.ShowDialog();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            frmDadosProdutoServico DaProSer = new frmDadosProdutoServico();
            DaProSer.ShowDialog();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            frmTarefasProdutosServicos TaProSer = new frmTarefasProdutosServicos();
            TaProSer.ShowDialog();
        }
    }
}
