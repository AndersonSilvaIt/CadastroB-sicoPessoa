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
		}



	}
}
