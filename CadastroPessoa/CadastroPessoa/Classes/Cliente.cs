using System;

namespace CadastroPessoa.Classes {
	public class Cliente {

		public string cod_cli { get; set; }
		public string nome_cli { get; set; }
		public string cpf_cli { get; set; }
		public string rg_cli { get; set; }
		public string datanasc_cli { get; set; }

		public string telefone_fixo_cli { get; set; }
		public string telefone_celular_cli { get; set; }
		public string email_cli { get; set; }
	}
}
