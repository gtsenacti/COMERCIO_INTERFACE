using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace appComercio
{
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private async void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            await CarregaDados();
        }

        private async Task CarregaDados()
        {
            string apiUrl = apiRotasController.CadastroProduto;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<CadastroProdutoModel>>(jsonString);

                        dgvCadastroProdutos.DataSource = dados;
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
    }
}
