using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class FormListFuncionario : Form {

		public FormListFuncionario() {
			InitializeComponent();
			
			var binding = new BindingList<Funcionario>(Banco.Funcionarios);
			gridFuncionario.DataSource = binding;
			gridFuncionario.Refresh();
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			Formulario form = new Formulario();
			form.ShowDialog();

			var binding = new BindingList<Funcionario>(Banco.Funcionarios);
			gridFuncionario.DataSource = binding;
			gridFuncionario.Refresh();
		}

		private void btnEditar_Click(object sender, EventArgs e) {

			var teste =	gridFuncionario.SelectedRows[0];

			var funcionario = (Funcionario)teste.DataBoundItem;

			FormularioEditar formularioEditar = new FormularioEditar(funcionario);
			formularioEditar.ShowDialog();

			var binding = new BindingList<Funcionario>(Banco.Funcionarios);
			gridFuncionario.DataSource = binding;
			gridFuncionario.Refresh();
		}

		private void btnExcluir_Click(object sender, EventArgs e) {
			var teste = gridFuncionario.SelectedRows[0];

			var funcionario = (Funcionario)teste.DataBoundItem;

			var indexFunc = Banco.Funcionarios.FindIndex(x => x.cod_func == funcionario.cod_func);

			Banco.Funcionarios.RemoveAt(indexFunc);

			var binding = new BindingList<Funcionario>(Banco.Funcionarios);
			gridFuncionario.DataSource = binding;
			gridFuncionario.Refresh();
		}
	}
}
