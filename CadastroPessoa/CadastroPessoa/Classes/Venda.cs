﻿namespace CadastroPessoa.Classes {
	public class Venda {

		public string cod_vend { get; set; }
		public string cod_func_fk { get; set; }
		public string cod_cli_fk { get; set; }
		public string data_vend { get; set; }
		public string forma_pagamento_vend { get; set; }
		public decimal valor_total_vend { get; set; }

	}
}
