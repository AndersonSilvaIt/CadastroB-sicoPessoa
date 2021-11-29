using CadastroPessoa.Classes;
using System;
using System.Collections.Generic;

namespace CadastroPessoa.BancoSimular {
	public static class Banco {

		public static List<Funcionario> Funcionarios = new List<Funcionario> {
			new Funcionario{ cod_func = "01", nome_func = "Funcioario Teste",
			 telefone_func = "4039-5555", celular_func = "95585-2478", cpf_func = "999.999.999-99",
			 datanasc_func = "10/10/1999", email_func = "teste@gmail", rg_func="99.999.999-9",
			 salario_func = 10000}
		};

		public static List<Usuario> Usuarios = new List<Usuario> {
			new Usuario { cod_usu = 1 , codigo_funcionario = "01", usuario_usu = "01", senha_usu = "abc@123"}
		};

		public static List<Cliente> Clientes = new List<Cliente> {

			new Cliente { cod_cli = "01", nome_cli = "Cliente 01", cpf_cli = "999.999.999-99",
			 datanasc_cli = "10/10/2010", email_cli = "pessoa01@gmail.com", rg_cli = "99.999.999-99",
			 telefone_celular_cli = "(99) 99999-9999", telefone_fixo_cli = "99 9999-9999"}
		};


	}
}
