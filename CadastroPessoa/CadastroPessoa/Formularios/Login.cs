using CadastroPessoa.BancoSimular;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CadastroPessoa.Formularios {
	public partial class Login : Form {
		public Login() {
			InitializeComponent();
		}

		private void btnEntrar_Click(object sender, EventArgs e) {

			string login = txtLogin.Text;
			string senha = txtSenha.Text;

			var usuario = Banco.Usuarios.FirstOrDefault(x => x.usuario_usu == login
			&& x.senha_usu == senha);

			if (usuario == null)
				MessageBox.Show("Usuário não encontrado");
			else {

				FormMenu frmMenu = new FormMenu();
				
				frmMenu.ShowDialog();
			}

		}
	}
}
