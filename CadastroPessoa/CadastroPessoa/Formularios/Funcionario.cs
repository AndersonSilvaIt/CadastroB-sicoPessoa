using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class Formulario : Form {
		public Formulario() {
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e) {

		}

		private void btnSalvar_Click(object sender, EventArgs e) {
			Funcionario func = new Funcionario();
			func.cod_func = txtCod_func.Text;
			func.nome_func = txtnome_func.Text;
			func.telefone_func = txttelefone_func.Text;
			if(!string.IsNullOrWhiteSpace(txtsalario_func.Text))
				func.salario_func = decimal.Parse(txtsalario_func.Text);

			func.rg_func = txtrg_func.Text;
			func.celular_func = txtcelular_func.Text;
			func.cpf_func = txtcpf_func.Text;
			func.datanasc_func = txtdatanasc_func.Text;

			Usuario usuario = new Usuario();
			usuario.codigo_funcionario = txtCod_func.Text;
			usuario.senha_usu = txtSenha.Text;
			usuario.usuario_usu = txtLogin.Text;

			Banco.Funcionarios.Add(func);
			Banco.Usuarios.Add(usuario);
			this.Close();
		}
	}
}
