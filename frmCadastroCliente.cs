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
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            Color minhaCor = Color.FromArgb(107, 107, 107);
            EstiloBotoes.AplicarEstiloArredondado(btnBuscarUsuario, minhaCor);
            Color minhasCor2 = Color.FromArgb(40, 46, 166);
            EstiloBotoes.AplicarEstiloArredondado(btnSalvarCadastroUsuario, minhasCor2);
            Color minhaCor3 = Color.FromArgb(40, 166, 73);
            EstiloBotoes.AplicarEstiloArredondado(btnEditarCadastroUsuario, minhaCor3);
            Color minhaCor4 = Color.FromArgb(245, 98, 98);
            EstiloBotoes.AplicarEstiloArredondado(btnApagarCadastroUsuario, minhaCor4);
        }
    }
}
