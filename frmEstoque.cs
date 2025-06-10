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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
            this.Load += FrmEstoque_Load;
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            Color minhaCor = Color.FromArgb(107, 107, 107);
            BotaoModernoTela2.AplicarEstiloArredondado(btnBuscEstoqueProdutoServico, minhaCor);
            Color minhasCor2 = Color.FromArgb(40, 46, 166);
            BotaoModernoTela2.AplicarEstiloArredondado(btnCadEstoqueProdutoServico, minhasCor2);
            Color minhaCor3 = Color.FromArgb(40, 166, 73);
            BotaoModernoTela2.AplicarEstiloArredondado(btnEditarEstoqueProdutoServico, minhaCor3);
            Color minhaCor4 = Color.FromArgb(245, 98, 98);
            BotaoModernoTela2.AplicarEstiloArredondado(btnApagarEstoqueProdutoServico, minhaCor4);
        }
    }
}
