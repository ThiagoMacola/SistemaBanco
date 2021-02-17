using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Banco
{
	class Cliente
	{

		public long Cpf { get; set; }
		public string Nome { get; set; }
		public Cliente(string nome, long cpf)
		{
			Nome = nome;
			Cpf = cpf;
		}
		
		public Conta Conta { get; set; }
		public Endereco Endereco {get; set;}	 
		

	}
}
