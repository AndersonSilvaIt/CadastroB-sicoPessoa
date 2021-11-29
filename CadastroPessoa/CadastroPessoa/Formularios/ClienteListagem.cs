using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class ClienteListagem : Form {
		public ClienteListagem() {

			InitializeComponent();

			var binding = new BindingList<Cliente>(Banco.Clientes);
			gridCliente.DataSource = binding;
			gridCliente.Refresh();
		}

		private void btnAdd_Click(object sender, EventArgs e) {

			CadasrtoCliente frmCliente = new CadasrtoCliente();
			frmCliente.ShowDialog();

		}

		private void btnEditar_Click(object sender, EventArgs e) {

			CadasrtoCliente frmCliente = new CadasrtoCliente();
			frmCliente.ShowDialog();

		}

		private void btnExcluir_Click(object sender, EventArgs e) {

			var teste = gridCliente.SelectedRows[0];

			var cliente = (Cliente)teste.DataBoundItem;
			var indexFunc = Banco.Funcionarios.FindIndex(x => x.cod_func == cliente.cod_cli);
			Banco.Clientes.RemoveAt(indexFunc);

			var binding = new BindingList<Cliente>(Banco.Clientes);

			gridCliente.DataSource = binding;
			gridCliente.Refresh();
		}
	}
}