using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class ProdutoEditar : Form {
		public ProdutoEditar() {
			InitializeComponent();
		}

		static Produto produtoEditar;

		public ProdutoEditar(Produto produto) {
			InitializeComponent();

			produtoEditar = produto;

			txtCod_func.Text = produto.cod_prod;
			txtDescricao.Text = produto.descricao_prod;
			txtNome.Text = produto.nome_prod;
			txtValorVenda.Text = produto.valor_venda_prod.ToString();
		}

		private void btnSalvar_Click(object sender, System.EventArgs e) {

			var indexProduto = Banco.Produtos.FindIndex(x => x.cod_prod == produtoEditar.cod_prod);

			Banco.Produtos.RemoveAt(indexProduto);

			Produto produto = new Produto();
			produto.cod_prod = txtCod_func.Text;
			produto.descricao_prod = txtDescricao.Text;
			produto.nome_prod = txtNome.Text;
			produto.valor_venda_prod = decimal.Parse(txtValorVenda.Text);

			Banco.Produtos.Add(produto);

			this.Close();
		}
	}
}
