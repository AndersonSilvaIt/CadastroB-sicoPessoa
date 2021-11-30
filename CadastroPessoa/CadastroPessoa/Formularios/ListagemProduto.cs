using System;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class ListagemProduto : Form {
		public ListagemProduto() {
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e) {

			CadastroProduto cadastro = new CadastroProduto();
			cadastro.ShowDialog();

		}
	}
}
