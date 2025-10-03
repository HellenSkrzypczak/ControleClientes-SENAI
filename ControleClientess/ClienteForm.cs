namespace ControleClientess
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //if (clienteSelecionado == null)
            //{

            //}
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
    }
}
