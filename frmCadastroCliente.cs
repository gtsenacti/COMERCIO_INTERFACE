using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appComercio;

namespace appComercio
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
            this.Load += frmCadastroCliente_Load;

            cbCadastroSetor.Items.Add("Administração");
            cbCadastroSetor.Items.Add("Estoque");
            cbCadastroSetor.Items.Add("Financeiro");
            cbCadastroSetor.Items.Add("Secretaria");
            cbCadastroSetor.Items.Add("Vendas");
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            Color minhaCor = Color.FromArgb(107, 107, 107);
            BotaoModernoTela2.AplicarEstiloArredondado(btnBuscarUsuario, minhaCor);
            Color minhasCor2 = Color.FromArgb(40, 46, 166);
            BotaoModernoTela2.AplicarEstiloArredondado(btnSalvarCadastroUsuario, minhasCor2);
            Color minhaCor3 = Color.FromArgb(40, 166, 73);
            BotaoModernoTela2.AplicarEstiloArredondado(btnEditarCadastroUsuario, minhaCor3);
            Color minhaCor4 = Color.FromArgb(245, 98, 98);
            BotaoModernoTela2.AplicarEstiloArredondado(btnApagarCadastroUsuario, minhaCor4);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
