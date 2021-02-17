using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Banco
{
	class Conta
	{
		public int Agencia { get; set; }          
		public float Numero { get; set; }
		public float Saldo { get; set; }

		public void Deposito(float dinheiro)
		{
			Saldo += dinheiro;

		}

		public void Saque(float dinheiro)
		{
			if (Saldo >= dinheiro)
			{
				Saldo -= dinheiro;
			}
			else Console.WriteLine("FANFARÃO VOCÊ NAO TEM DINHEIRO SUFICIENTE PRA ESSE SAQUE");
		
		
		}







		public Conta(int agencia, float numero)
		{
			Agencia = agencia;
			Numero = numero;
			Saldo = 0;
		}

	}
}
