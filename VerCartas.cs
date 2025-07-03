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
    public partial class btVerCarta : Form
    {
        public btVerCarta()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            new TelaPrinciapal().Show();
            this.Hide();
        }

        
        private void DgvCartas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
             private async void btVerCarta_Load (object sender, EventArgs e)
        {
            await CarregarDados();
        }

        private async Task CarregarDados()
        {
            string apiUrl = apiRotasController.CadastroCarta;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<CadastroCartaModel>>(jsonString);

                        dgvCartas.DataSource = dados;
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

