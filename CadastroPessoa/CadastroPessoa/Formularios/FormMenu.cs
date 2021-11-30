using System;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class FormMenu : Form {
		public FormMenu() {
			InitializeComponent();
		}

		private void btnFunc_Click(object sender, EventArgs e) {

			FormListFuncionario formListFuncionario = new FormListFuncionario();
			formListFuncionario.ShowDialog();
		}

		private void btnCliente_Click(object sender, EventArgs e) {

			ClienteListagem frmCliente = new ClienteListagem();
			frmCliente.ShowDialog();
		}

		private void btnProduto_Click(object sender, EventArgs e) {

			ListagemProduto listagemProduto = new ListagemProduto();
			listagemProduto.ShowDialog();

		}
	}
}
