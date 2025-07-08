using appComercio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            await CarregarDados();
        }

        private async Task CarregarDados()
        {
            string apiUrl = APIRotasController.CadastroUsuario;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<CadastroUsuarioModel>>(jsonString);

                        dgvCadastroUsuario.DataSource = dados;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnSalvarCadastroUsuario_Click(object sender, EventArgs e)
        {
            // Verifica se campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(txtCadastroUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtCadastroSenha.Text) ||
                string.IsNullOrWhiteSpace(cbCadastroSetor.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios antes de salvar.");
                return;
            }

            string nome = txtCadastroUsuario.Text.Trim();

            // Verifica se o usuário já existe (mesmo nome)
            string checkUrl = $"{APIRotasController.CadastroUsuario}/buscarPorNome?nome={Uri.EscapeDataString(nome)}";

            using (HttpClient checkClient = new HttpClient())
            {
                checkClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage checkResponse = await checkClient.GetAsync(checkUrl);

                if (checkResponse.IsSuccessStatusCode)
                {
                    string checkJson = await checkResponse.Content.ReadAsStringAsync();
                    var usuariosExistentes = JsonConvert.DeserializeObject<List<CadastroUsuarioModel>>(checkJson);

                    if (usuariosExistentes != null && usuariosExistentes.Count > 0)
                    {
                        MessageBox.Show("Já existe um usuário com esse nome. Use o botão EDITAR para modificá-lo.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao verificar se o usuário já existe.");
                    return;
                }
            }

            // Cria o novo usuário
            var novoUsuario = new CadastroUsuarioModel
            {
                NomeUsuario = txtCadastroUsuario.Text.Trim(),
                SenhaUsuario = txtCadastroSenha.Text.Trim(),
                SetorUsuario = cbCadastroSetor.Text.Trim(),
            };

            string jsonString = JsonConvert.SerializeObject(novoUsuario);
            string apiUrl = APIRotasController.CadastroUsuario;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("✅ Usuário cadastrado com sucesso!");

                        // Limpa os campos
                        txtCadastroUsuario.Clear();
                        txtCadastroUsuario.Tag = null;
                        txtCadastroSenha.Clear();
                        cbCadastroSetor.SelectedIndex = -1;

                        // Atualiza a lista no DataGridView
                        await CarregarDados(); // <-- esse método você já deve ter
                    }
                    else
                    {
                        MessageBox.Show("❌ Erro ao cadastrar: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠ Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string nome = txtBuscarUsuario.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Digite um nome válido.");
                return;
            }

            // Corrigido aqui!
            string apiUrl = $"{APIRotasController.CadastroUsuario}/buscarPorNome?nome={Uri.EscapeDataString(nome)}";
           

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                       

                        var usuarios = JsonConvert.DeserializeObject<List<CadastroUsuarioModel>>(jsonString);

                        if (usuarios != null && usuarios.Count > 0)
                        {
                            var usuario = usuarios[0];
                            txtCadastroUsuario.Text = usuario.NomeUsuario;
                            txtCadastroSenha.Text = usuario.SenhaUsuario;
                            cbCadastroSetor.Text = usuario.SetorUsuario;

                            txtCadastroUsuario.Tag = usuario.id;
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado na lista.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro na resposta da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async void btnEditarCadastroUsuario_Click(object sender, EventArgs e)
        {
            // Verifica se o ID foi carregado (ou seja, se um usuário foi buscado antes)
            if (txtCadastroUsuario.Tag == null)
            {
                MessageBox.Show("Busque um usuário antes de tentar editar.");
                return;
            }

            // Validação simples
            if (string.IsNullOrWhiteSpace(txtCadastroUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtCadastroSenha.Text) ||
                string.IsNullOrWhiteSpace(cbCadastroSetor.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de editar.");
                return;
            }

            // Prepara o objeto com os dados alterados
            var usuarioEditado = new CadastroUsuarioModel
            {
                id = (int)txtCadastroUsuario.Tag, // pega o ID salvo no buscar
                NomeUsuario = txtCadastroUsuario.Text.Trim(),
                SenhaUsuario = txtCadastroSenha.Text.Trim(),
                SetorUsuario = cbCadastroSetor.Text.Trim()
            };

            // Monta a URL para PUT
            string url = $"{APIRotasController.CadastroUsuario}/{usuarioEditado.id}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(usuarioEditado);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.PutAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("✅ Usuário atualizado com sucesso!");

                        // Limpa os campos
                        txtCadastroUsuario.Clear();
                        txtCadastroUsuario.Tag = null;
                        txtCadastroSenha.Clear();
                        cbCadastroSetor.SelectedIndex = -1;

                        // Atualiza a lista (caso esteja usando DataGridView)
                        await CarregarDados();
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao atualizar: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar à API: {ex.Message}");
                }
            }
        }

        private async void btnApagarCadastroUsuario_Click(object sender, EventArgs e)
        {
            // Verifica se o ID do usuário foi carregado
            if (txtCadastroUsuario.Tag == null)
            {
                MessageBox.Show("Busque um usuário antes de apagar.");
                return;
            }

            // Confirmação
            var confirmar = MessageBox.Show("Tem certeza que deseja apagar este usuário?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes)
                return;

            int idUsuario = (int)txtCadastroUsuario.Tag;
            string url = $"{APIRotasController.CadastroUsuario}/{idUsuario}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("🗑️ Usuário apagado com sucesso!");

                        // Limpa os campos
                        txtCadastroUsuario.Clear();
                        txtCadastroUsuario.Tag = null;
                        txtCadastroSenha.Clear();
                        cbCadastroSetor.SelectedIndex = -1;

                        await CarregarDados(); // Atualiza o grid, se estiver usando
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao apagar usuário: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar à API: {ex.Message}");
                }
            }
        }
    }
}
