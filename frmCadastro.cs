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
    public partial class Cadastro : Form
    {
        // List to store registered users
        private List<User> users = new List<User>();

        // Reference to the parent form (e.g., MainForm or LoginForm)
        private Form parentForm;

        // Class to represent a user
        private class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Sector { get; set; }
            public bool IsActive { get; set; }
        }

        // Parameterless constructor for cases where no parent is available (e.g., startup form)
        public Cadastro() : this(null)
        {
        }

        public Cadastro(Form parent)
        {
            InitializeComponent();
            // Initialize DataGridView columns
            InitializeDataGridView();
            // Store the parent form reference
            this.parentForm = parent;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Username", "Usuário");
            dataGridView1.Columns.Add("Sector", "Setor");
            dataGridView1.Columns.Add("IsActive", "Ativo");
            // Password is not added for security reasons
            // Ensure single row selection
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void lblTituloLogin_Click(object sender, EventArgs e)
        {
        }

        private void pbTelaLogin_Click(object sender, EventArgs e)
        {
        }

        private void cbkativo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void gbbuscausuario_Enter(object sender, EventArgs e)
        {
            // Set focus to textBox1 and clear it when the GroupBox gains focus
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear DataGridView
            dataGridView1.Rows.Clear();

            // Validate search input
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, digite um nome de usuário para buscar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            // Search for users by username (case-insensitive)
            string searchUsername = textBox1.Text.Trim().ToLower();
            var foundUsers = users.Where(u => u.Username.ToLower().Contains(searchUsername)).ToList();

            if (foundUsers.Count == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado com o nome especificado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Populate DataGridView with search results
            foreach (var user in foundUsers)
            {
                dataGridView1.Rows.Add(user.Username, user.Sector, user.IsActive);
            }
        }

        private void btnApagarUsuario_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um usuário para apagar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected user's username
            string selectedUsername = dataGridView1.SelectedRows[0].Cells["Username"].Value?.ToString();
            if (string.IsNullOrEmpty(selectedUsername))
            {
                MessageBox.Show("Erro ao obter o nome do usuário selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show($"Deseja realmente apagar o usuário '{selectedUsername}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Find and remove the user from the list
            var userToRemove = users.FirstOrDefault(u => u.Username == selectedUsername);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                MessageBox.Show("Usuário apagado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh DataGridView with current search results (if any)
                dataGridView1.Rows.Clear();
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    string searchUsername = textBox1.Text.Trim().ToLower();
                    var foundUsers = users.Where(u => u.Username.ToLower().Contains(searchUsername)).ToList();
                    foreach (var user in foundUsers)
                    {
                        dataGridView1.Rows.Add(user.Username, user.Sector, user.IsActive);
                    }
                }
            }
            else
            {
                MessageBox.Show("Erro ao apagar o usuário. Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Exit the application when btnVoltar is clicked
            Application.Exit();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            DisplayUsers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // No search logic here; search only happens when button1 is clicked
        }

        private void RegisterUser()
        {
            // Validate username
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }

            // Validate password
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }

            // Validate sector
            if (cbSetor.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecione um setor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSetor.Focus();
                return;
            }

            // Create new user
            User newUser = new User
            {
                Username = txtUsuario.Text,
                Password = txtSenha.Text, // In a real app, hash the password
                Sector = cbSetor.SelectedItem.ToString(),
                IsActive = cbkativo.Checked
            };

            // Add to list
            users.Add(newUser);

            // Show success message
            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form fields
            txtUsuario.Clear();
            txtSenha.Clear();
            cbSetor.SelectedIndex = -1;
            cbkativo.Checked = false;
        }

        private void DisplayUsers()
        {
            // Clear any existing rows in DataGridView
            dataGridView1.Rows.Clear();

            if (users.Count == 0)
            {
                MessageBox.Show("Nenhum usuário cadastrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Populate DataGridView with user data
            foreach (var user in users)
            {
                dataGridView1.Rows.Add(user.Username, user.Sector, user.IsActive);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}