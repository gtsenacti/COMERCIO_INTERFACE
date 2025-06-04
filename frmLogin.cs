using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appComercio;

namespace appComercio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Color minhaCor = Color.FromArgb(40, 46, 166);
            EstiloBotoes.AplicarEstiloArredondado(btnCadastrar, minhaCor);
            Color minhaCor2 = Color.FromArgb(40, 166, 73);
            EstiloBotoes.AplicarEstiloArredondado(btnEntrar, minhaCor2);
            Color minhaCor3 = Color.FromArgb(245, 98, 98);
            EstiloBotoes.AplicarEstiloArredondado(btnSair, minhaCor3);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            frmCadastroCliente FrmCadastroCliente = new frmCadastroCliente();
            FrmCadastroCliente.Show();
            this.Visible = false;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}

