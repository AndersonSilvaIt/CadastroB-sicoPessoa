using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class FormVenda : Form {

		static Venda venda;

		public FormVenda() {
			InitializeComponent();
			venda = new Venda();
			venda.VendaItens = new List<Venda_Itens>();

			var listaCliente = new List<Cliente>() { new Cliente() { cod_cli = "" , nome_cli = ""} };

			listaCliente.AddRange(Banco.Clientes);

			ddlCliente.DataSource = listaCliente;
			ddlCliente.Refresh();
			this.ddlCliente.DisplayMember = "nome_cli";
			this.ddlCliente.ValueMember = "cod_cli";


			var listaProduto = new List<Produto> { new Produto { cod_prod = "", descricao_prod = "" } };
			listaProduto.AddRange(Banco.Produtos);
			ddlProduto.DataSource = listaProduto;
			ddlProduto.Refresh();
			ddlProduto.DisplayMember = "descricao_prod";
			ddlProduto.ValueMember = "cod_prod";
		}

		private void btnAdd_Click(object sender, System.EventArgs e) {

			Venda_Itens vendaItem = new Venda_Itens();

			var produto = (ddlProduto.SelectedItem as Produto);
			if (produto != null) {
				vendaItem.cod_prod_fk = produto.cod_prod;
				vendaItem.cod_vend_fk = txtCodigoVenda.Text;
				
				vendaItem.valor_itenv = produto.valor_venda_prod;
				decimal quantidade = decimal.Parse(txtQuantidade.Text);
				vendaItem.valor_total_itenv = quantidade * produto.valor_venda_prod;
				vendaItem.quantidade_itenv = (int)quantidade;
				venda.VendaItens.Add(vendaItem);

				var binding = new BindingList<Venda_Itens>(venda.VendaItens);

				gridItensVenda.DataSource = binding;
				gridItensVenda.Refresh();

				decimal valorTotal = venda.VendaItens.Sum(x => x.valor_total_itenv);
				lblTotal.Text = valorTotal.ToString();
			}
		}

		private void btnSalvar_Click(object sender, System.EventArgs e) {

			var cliente = (ddlCliente.SelectedItem as Cliente);
			venda.cod_cli_fk = cliente.cod_cli;
			venda.cod_func_fk = txtCodigoFuncionario.Text;
			venda.data_vend = DateTime.Now;
			venda.cod_vend = txtCodigoVenda.Text;
			venda.valor_total_vend = decimal.Parse(lblTotal.Text);
			Banco.Vendas.Add(venda);
			this.Close();
		}
	}
}
