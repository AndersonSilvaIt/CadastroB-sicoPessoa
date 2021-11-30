using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class VendaListagem : Form {
		public VendaListagem() {
			InitializeComponent();

			var binding = new BindingList<Venda>(Banco.Vendas);
			gridVenda.DataSource = binding;
			gridVenda.Refresh();

		}

		private void btnAdd_Click(object sender, EventArgs e) {
			FormVenda frmVenda = new FormVenda();
			frmVenda.ShowDialog();

			var binding = new BindingList<Venda>(Banco.Vendas);
			gridVenda.DataSource = binding;
			gridVenda.Refresh();

		}
	}
}
