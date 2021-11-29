namespace CadastroPessoa.Classes {
	public class Venda_Itens {

		public int cod_itenv { get; set; }
		public int quantidade_itenv { get; set; }
		public decimal valor_itenv { get; set; }
		public decimal valor_total_itenv { get; set; }
		public int cod_prod_fk { get; set; }
		public int cod_vend_fk { get; set; }
	}
}
