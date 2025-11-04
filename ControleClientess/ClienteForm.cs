using System.Net.Http.Json;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace ControleClientess
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteRepository _repository; //só pode criar no construtor
        private int? editingId = null;

        List<ItemGenero> itemGeneros = new List<ItemGenero>
        {
            new ItemGenero { Valor = Genero.Masculino, Descricao = "Masculino"},
            new ItemGenero { Valor = Genero.Feminino, Descricao = "Feminino"}
        };

        private void CarregarGenero()
        {
            cmbGenero.DataSource = itemGeneros;
            cmbGenero.DisplayMember = "Descricao";
            cmbGenero.ValueMember = "Valor";
        }
        public ClienteForm()
        {
            InitializeComponent();
            CarregarGenero();
            _repository = new ClienteRepository();
            AtualizarGrid();
            LimparCampos();
        }

        private void AtualizarGrid()
        {
            var clientes = _repository.ListarTodos();
            gridClientes.DataSource = clientes;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            cmbGenero.SelectedIndex = -1;
            editingId = null;
            gridClientes.ClearSelection();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteCadastro);

            if (gridClientes.SelectedRows.Count == 0)
                return;

            var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtCep.Text = cliente.Cep;
            txtLogradouro.Text = cliente.Logradouro;
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            txtEstado.Text = cliente.Estado;

            cmbGenero.SelectedItem = itemGeneros.FirstOrDefault(ig => ig.Valor == cliente.Genero);
            editingId = cliente.Id;

            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedItem == null)
            {
                MessageBox.Show("Selecione um gênero.");
                return;
            }
            ItemGenero genero = (ItemGenero)cmbGenero.SelectedItem;

            var cliente = new Cliente
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Genero = genero.Valor,
                Cep = txtCep.Text.Trim(),
                Bairro = txtBairro.Text.Trim(),
                Logradouro = txtLogradouro.Text.Trim(),
                Cidade = txtCidade.Text.Trim(),
                Estado = txtEstado.Text.Trim()
            };
            _repository.Adicionar(cliente);
            AtualizarGrid();
            LimparCampos();
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Excluir registro?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tcCliente.SelectTab(tpClienteConsulta);
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            string CEP = txtCep.Text.Replace("-", "").Trim();

            if (CEP.Length == 8)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://viacep.com.br/ws/");

                    var response = await client.GetAsync($"{CEP}/json/");

                    if (response.IsSuccessStatusCode)
                    {
                        var cepData = await response.Content.ReadFromJsonAsync<Cliente>();
                        if (cepData != null && cepData.Erro != true)
                        {
                            txtLogradouro.Text = cepData.Logradouro;
                            txtBairro.Text = cepData.Bairro;
                            txtCidade.Text = cepData.Cidade;
                            txtEstado.Text = cepData.Estado;
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao consultar o CEP.");
                    }
                }
            }
        }

        private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
