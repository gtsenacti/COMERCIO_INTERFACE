    using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appComercio
{
    public partial class frmCadastroProdutoServico : Form
    {
        public frmCadastroProdutoServico()
        {
            InitializeComponent();
            this.Load += frmCadastroProdutoServico_Load;

        }

        private async void frmCadastroProdutoServico_Load(object sender, EventArgs e)
        {
            Color minhaCor = Color.FromArgb(107, 107, 107);
            BotaoModernoTela2.AplicarEstiloArredondado(btnBuscCadastroProdutoServico, minhaCor);
            Color minhasCor2 = Color.FromArgb(40, 46, 166);
            BotaoModernoTela2.AplicarEstiloArredondado(btnCadCadastraProdutoServico, minhasCor2);
            Color minhaCor3 = Color.FromArgb(40, 166, 73);
            BotaoModernoTela2.AplicarEstiloArredondado(btnEditarCadastroProdutoServico, minhaCor3);
            Color minhaCor4 = Color.FromArgb(245, 98, 98);
            BotaoModernoTela2.AplicarEstiloArredondado(btnApagarCadastroProdutoServico, minhaCor4);
            await CarregaDados();
            AdaptaTamanho();
        }

        private void AdaptaTamanho()
        {
            
        }

        private async Task CarregaDados()
        {
            string apiUrl = APIRotasController.CadastroProdutoServico;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<CadastroProdutoServicoModel>>(jsonString);

                        dgvCadastroProdutoServico.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async void btnBuscCadastroProdutoServico_Click(object sender, EventArgs e)
        {
            string valorBusca = txtBuscCadastroProdutoServico.Text.Trim();

            if (string.IsNullOrEmpty(valorBusca))
            {
                MessageBox.Show("Digite um valor para buscar.");
                return;
            }

            string urlBase = "http://localhost:5000/CadastroProdutoServico";
            string endpoint = "";

            if (rbCodCadastroProdutoServicoBucar.Checked)
            {
                // Tenta converter valorBusca para long
                if (!long.TryParse(valorBusca, out long codBarra))
                {
                    MessageBox.Show("Código de barras inválido. Digite apenas números.");
                    return;
                }
                endpoint = $"{urlBase}/codigo/{codBarra}";
            }
            else if (rbNomeCadastroProdutoServicoBucar.Checked)
            {
                endpoint = $"{urlBase}/nome/{Uri.EscapeDataString(valorBusca)}";
            }
            else
            {
                MessageBox.Show("Selecione Código ou Nome.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(endpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var tabela = JsonConvert.DeserializeObject<DataTable>(json);
                        dgvCadastroProdutoServico.DataSource = tabela;
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
            }
        }
    }
}
