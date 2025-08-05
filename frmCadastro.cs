using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace appComercio
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            alteraImagensPic();
            LimparCampos();
        }


        private void alteraImagensPic()
        {
            //Para o botão personagens
            Image imgOriginal = Properties.Resources.R6_Black_Ice_Background;
            Image imgRedimencionada = new Bitmap(imgOriginal, new Size(556, 492));
            pbBackground.Image = imgRedimencionada;

            Image imgOriginal1 = Properties.Resources.Rainbow_six_siege;
            Image imgRedimencionada1 = new Bitmap(imgOriginal1, new Size(240, 199));
            pbLogo.Image = imgRedimencionada1;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            // 1. Validações simples de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Campos faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Monta o objeto que será enviado para a API
            //Os nomes devem estar extamente iguais na API
            var novoUsuario = new
            {
                NomeUsuario = txtUsuario.Text.Trim(),
                EmailUsuario = txtEmail.Text.Trim(),
                SenhaUsuario = txtSenha.Text.Trim()
            };

            string apiPostUrl = apiRotasController.CadastroUsuario;
            string jsonBody = JsonConvert.SerializeObject(novoUsuario);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    using (var content = new StringContent(jsonBody, Encoding.UTF8, "application/json"))
                    {
                        // ===== CHAMADA POST =====
                        HttpResponseMessage response = await client.PostAsync(apiPostUrl, content);

                        if (response.StatusCode == HttpStatusCode.Created || response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Usuário criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();          // opcional: limpa as TextBox
                        }
                        else
                        {
                            string detalhe = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Erro ao salvar: {response.StatusCode}\n{detalhe}",
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (HttpRequestException hre)
                {
                    MessageBox.Show($"Falha de comunicação com a API:\n{hre.Message}",
                                    "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro inesperado:\n{ex.Message}",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
            txtUsuario.Focus();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
