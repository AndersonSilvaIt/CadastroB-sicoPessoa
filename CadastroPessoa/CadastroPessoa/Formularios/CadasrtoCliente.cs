using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class CadasrtoCliente : Form {
		public CadasrtoCliente() {
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e) {
			Cliente cliente = new Cliente();
			cliente.cod_cli = txtCodigo.Text;
			cliente.nome_cli = txtNome.Text;
			cliente.telefone_fixo_cli = txtTelefone.Text;

			cliente.rg_cli = txtRG.Text;
			cliente.telefone_celular_cli = txtCelular.Text;
			cliente.cpf_cli = txtCPF.Text;
			cliente.datanasc_cli = txtDataNascimento.Text;

			Banco.Clientes.Add(cliente);
			this.Close();
		}

		private void label7_Click(object sender, EventArgs e) {

		}

		private void label8_Click(object sender, EventArgs e) {

		}

		private void label5_Click(object sender, EventArgs e) {

		}

		private void label6_Click(object sender, EventArgs e) {

		}

		private void label3_Click(object sender, EventArgs e) {

		}

		private void label4_Click(object sender, EventArgs e) {

		}

		private void label2_Click(object sender, EventArgs e) {

		}

		private void label1_Click(object sender, EventArgs e) {

		}

		private void txtCelular_TextChanged(object sender, EventArgs e) {

		}

		private void txtEmail_TextChanged(object sender, EventArgs e) {

		}

		private void txtTelefone_TextChanged(object sender, EventArgs e) {

		}

		private void txtDataNascimento_TextChanged(object sender, EventArgs e) {

		}

		private void txtRG_TextChanged(object sender, EventArgs e) {

		}

		private void txtCPF_TextChanged(object sender, EventArgs e) {

		}

		private void txtNome_TextChanged(object sender, EventArgs e) {

		}

		private void txtCodigo_TextChanged(object sender, EventArgs e) {

		}
	}
}
