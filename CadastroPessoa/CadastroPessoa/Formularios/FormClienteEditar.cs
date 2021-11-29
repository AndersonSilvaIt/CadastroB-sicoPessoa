using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class FormClienteEditar : Form {

		private static Cliente clienteEditar = new Cliente();

		public FormClienteEditar() {
			InitializeComponent();
		}

		public FormClienteEditar(Cliente cliente) {
			InitializeComponent();

			clienteEditar = cliente;

			txtCodigo.Text = clienteEditar.cod_cli;
			txtNome.Text = clienteEditar.nome_cli;
			txtTelefone.Text = clienteEditar.telefone_fixo_cli;
			txtCelular.Text = clienteEditar.telefone_celular_cli;
			txtCPF.Text = clienteEditar.cpf_cli;
			txtRG.Text = clienteEditar.rg_cli;
			txtEmail.Text = clienteEditar.email_cli;
		}

		private void btnSalvar_Click(object sender, System.EventArgs e) {

			var indexFunc = Banco.Clientes.FindIndex(x => x.cod_cli == clienteEditar.cod_cli);
			Banco.Clientes.RemoveAt(indexFunc);

			Cliente cliente = new Cliente();
			cliente.cod_cli = txtCodigo.Text;
			cliente.nome_cli = txtNome.Text;
			cliente.telefone_fixo_cli = txtTelefone.Text;

			cliente.rg_cli = txtRG.Text;
			cliente.telefone_celular_cli = txtCelular.Text;
			cliente.cpf_cli = txtCPF.Text;
			cliente.datanasc_cli = txtDataNascimento.Text;

			Banco.Clientes.Add(cliente);
			this.Close();
		}
	}
}
