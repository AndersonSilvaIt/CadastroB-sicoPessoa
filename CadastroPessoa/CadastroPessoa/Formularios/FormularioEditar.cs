using CadastroPessoa.BancoSimular;
using CadastroPessoa.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class FormularioEditar : Form {

		Funcionario funcEditar = new Funcionario();

		public FormularioEditar() {
			InitializeComponent();
		}

		public FormularioEditar(Funcionario func) {
			InitializeComponent();

			funcEditar = func;

			txtCod_func.Text = func.cod_func;
			txtnome_func.Text = func.nome_func;
			txttelefone_func.Text = func.telefone_func;
			txtsalario_func.Text = func.salario_func.ToString();
			txtrg_func.Text = func.rg_func;
			txtcelular_func.Text = func.celular_func;
			txtcpf_func.Text = func.cpf_func;
			txtdatanasc_func.Text = func.datanasc_func;

			// Obter o Usuario
			var usuario = Banco.Usuarios.FirstOrDefault(x => x.codigo_funcionario == funcEditar.cod_func);

			txtSenha.Text = usuario.senha_usu;
			txtLogin.Text = usuario.usuario_usu;
		}

		private void btnSalvar_Click(object sender, EventArgs e) {

			var indexFunc = Banco.Funcionarios.FindIndex(x => x.cod_func == funcEditar.cod_func);

			Banco.Funcionarios.RemoveAt(indexFunc);
			
			var indexUsuario = Banco.Usuarios.FindIndex(x => x.codigo_funcionario == funcEditar.cod_func);
			Banco.Usuarios.RemoveAt(indexUsuario);

			Funcionario func = new Funcionario();
			func.cod_func = txtCod_func.Text;
			func.nome_func = txtnome_func.Text;
			func.telefone_func = txttelefone_func.Text;
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
