using appComercio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            FrmCadastroCliente.ShowDialog();
            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string setor = cbSetor.Text.Trim(); // ajuste conforme seu controle de setor

            string apiUrl = $"http://localhost:5000/login?nome={Uri.EscapeDataString(usuario)}&senha={Uri.EscapeDataString(senha)}&setor={Uri.EscapeDataString(setor)}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        dynamic resultado = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);

                        if (resultado.login == true)
                        {
                            frmPrincipal principal = new frmPrincipal();
                            principal.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Usuário, senha ou setor incorretos.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao conectar com a API.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro na requisição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

