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
    public partial class frmFornecedorProdutoServico : Form
    {
        public frmFornecedorProdutoServico()
        {
            InitializeComponent();
            this.Load += FrmFornecedorProdutoServico_Load;
        }

        private void FrmFornecedorProdutoServico_Load(object sender, EventArgs e)
        {
            Color minhaCor = Color.FromArgb(107, 107, 107);
            BotaoModernoTela2.AplicarEstiloArredondado(btnBuscFornecedorProdutoServico, minhaCor);
            Color minhasCor2 = Color.FromArgb(40, 46, 166);
            BotaoModernoTela2.AplicarEstiloArredondado(btnCadFornecedorProdutoServico, minhasCor2);
            Color minhaCor3 = Color.FromArgb(40, 166, 73);
            BotaoModernoTela2.AplicarEstiloArredondado(btnEditarFornecedorProdutoServico, minhaCor3);
            Color minhaCor4 = Color.FromArgb(245, 98, 98);
            BotaoModernoTela2.AplicarEstiloArredondado(btnApagarFornecedorProdutoServico, minhaCor4);
        }
    }
}
