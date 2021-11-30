using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class CadastroProduto : Form {
		public CadastroProduto() {
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e) {

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
