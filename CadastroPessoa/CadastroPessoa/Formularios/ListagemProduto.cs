using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class ListagemProduto : Form {
		public ListagemProduto() {
			InitializeComponent();

			var binding = new BindingList<Produto>(Banco.Produtos);
			gridProduto.DataSource = binding;
			gridProduto.Refresh();
		}

		private void btnAdd_Click(object sender, EventArgs e) {

			CadastroProduto cadastro = new CadastroProduto();
			cadastro.ShowDialog();

			var binding = new BindingList<Produto>(Banco.Produtos);
			gridProduto.DataSource = binding;
			gridProduto.Refresh();

		}

		private void btnEditar_Click(object sender, EventArgs e) {


			var teste = gridProduto.SelectedRows[0];

			var produto = (Produto)teste.DataBoundItem;

			ProdutoEditar produtoEditar = new ProdutoEditar(produto);
			produtoEditar.ShowDialog();

			var binding = new BindingList<Produto>(Banco.Produtos);
			gridProduto.DataSource = binding;
			gridProduto.Refresh();
		}

		private void btnExcluir_Click(object sender, EventArgs e) {

			var teste = gridProduto.SelectedRows[0];

			var produto = (Produto)teste.DataBoundItem;
			var indexProduto = Banco.Produtos.FindIndex(x => x.cod_prod == produto.cod_prod);

			Banco.Produtos.RemoveAt(indexProduto);

			var binding = new BindingList<Produto>(Banco.Produtos);

			gridProduto.DataSource = binding;
			gridProduto.Refresh();
		}
	}
}
