using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Banco
{
	class Program
	{
		static void Main(string[] args)
		{
			float numeroConta, num = 0, valor = 0;
			string nome, logradouro, localidade;
			long cpf;
			int escolha = 0, numero, agencia, ag = 0;


				Console.WriteLine("Bem Vindo ao banco Cobra Kai");						
				Console.WriteLine();                                                    
				Console.Write("Digite seu Nome: ");
				nome = Console.ReadLine();                                                
				Console.Write("Digite seu CPF: ");
				cpf = long.Parse(Console.ReadLine());
				Cliente cliente1 = new Cliente(nome, cpf);                                
				Conta conta2 = new Conta(5556, 44444777788);                              
			do
				{
					Console.WriteLine(" 1 - Criar Conta");									
					Console.WriteLine(" 2 - Realizar Deposito");
					Console.WriteLine(" 3 - Realizar Saque");
					Console.WriteLine(" 4 - Realizar Transferencia");
					Console.WriteLine(" 5 - Imprima Saldo");
					Console.WriteLine(" 0 - Para sair");
					Console.WriteLine();
					Console.Write("Escolha uma das opções acima: ");
				try
				{
					escolha = int.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.WriteLine("Digite um Valor entre 1 e 4");
				}
				if (escolha > 0 && escolha < 6)
				{
					switch (escolha)
					{
						case 1:
							Console.Write("Digite o seu endereço: ");
							logradouro = Console.ReadLine();                                                                                                          //os valores dentro do () são os valores que a função vai precisar? ou eu entendi errado? 
							Console.Write("Digite o numero da casa: ");
							numero = int.Parse(Console.ReadLine());
							Console.Write("Digite a sua cidade: ");
							localidade = Console.ReadLine();
							Endereco endereco1 = new Endereco(logradouro,numero,localidade);
							cliente1.Endereco = endereco1;

							Console.Write("Digite numero agencia: ");
							agencia = int.Parse(Console.ReadLine());                                                               
							Console.Write("Digite o numero da conta: ");
							numeroConta = float.Parse(Console.ReadLine());
							Conta conta1 = new Conta(agencia, numero);
							cliente1.Conta = conta1;
							break;																								// os dados nao ficam salvos dentro da classe cliente, será porque preciso criar um vetor? ou tem outro modo de fazer?
						case 2:
							float dinheiro = 0;
							Console.Write("Digite o Valor que você deseja depositar: ");									
							dinheiro = float.Parse(Console.ReadLine());
							cliente1.Conta.Deposito(dinheiro);
							break;	
						case 3:
							Console.Write("Digite o Valor que você quer sacar: ");
							dinheiro = float.Parse(Console.ReadLine());
							cliente1.Conta.Saque(dinheiro);
							break;
						case 4:
							Console.WriteLine("Digite o numero da Agencia que deseja transferir: ");
							ag = int.Parse(Console.ReadLine());
							Console.WriteLine("Digite o numero da Conta que deseja transferir: ");
							num = float.Parse(Console.ReadLine());
							if ((conta2.Agencia == ag) && (conta2.Numero == num))
							{
								Console.WriteLine("Qual valor você deseja transferir: ");
								valor = float.Parse(Console.ReadLine());
								cliente1.Conta.Saque(valor);
								conta2.Deposito(valor);
							}
							else Console.WriteLine("NUMERO ERRADO");
							break;
						case 5:
							Console.WriteLine("Seu saldo é de: " + cliente1.Conta.Saldo);
							break;
					}
				}
			} while (escolha != 0);
			Console.WriteLine("Precione Qualquer Tecla para Finalizar");
			Console.ReadKey();
		
		}
	}
}

// Criação de Classes com suas respectivas propriedades ok!
//Está ok o como foi criado as classes?
/*Elabore um programa que:
			Cadastre as Contas Correntes pelos Clientes de um banco:
			-O Cliente deve possuir (CPF, Nome e Endereço completo)
			-A conta ao ser criada possui: Agencia, Numero e Saldo(inicialmente Zero)


			O usuário poderá escolher em um menu principal se deseja:

			1) informar todos os dados da conta a ser criada (Conta/Cliente)
			2) permitir que o cliente faça um depósito
			3) permitir que um cliente faça um saque (se tiver saldo disponível)
			4) faça a transferência de um valor X para outra conta que exista
			5) imprima seu saldo*/



//Criar Classe Cliente CPF-NOME-ENDEREÇO(CRIAR OUTRA CLASSE) 
//Classe Conta Corrente (AGENCIA, NUMERO, SALDO(INICIALMENTE 0)) 
//Criar Menu
//Criar Interaçoes do menu





//os valores dentro do () são os valores que a função vai precisar? ou eu entendi errado?
//Primeira Etapa Criada 
/*conta = new Conta();     
Console.WriteLine();
Console.WriteLine("Dados Usuario:");
Console.Write("Cpf do Individuo: ");
c.Cpf = long.Parse(Console.ReadLine());
Console.Write("Nome do Individuo: ");
c.Nome = Console.ReadLine();
Console.Write("Rua/Av: ");
endereco.Logradouro = Console.ReadLine();
Console.Write("Numero: ");
endereco.Numero = int.Parse(Console.ReadLine());
Console.Write("Cidade/Estado: ");
endereco.Localidade = Console.ReadLine();
//Conta 
Console.Write("Numero da Agencia: ");
conta.Agencia = int.Parse(Console.ReadLine());
Console.Write("Numero da Conta: ");
conta.Numero = int.Parse(Console.ReadLine());
Console.Write("Saldo: ");
conta.Saldo = float.Parse(Console.ReadLine());
c.endereco = endereco;
c.conta = conta;*/

//como devo passar o valor para que ele fique alocado na classe cliente até eu fechar o programa?
//os valores dentro do () são os valores que a função vai precisar? ou eu entendi errado? 
//estes objetos que sao criados na função são usados como parametro para passar o valor pros objetos das classes?
//Eu preciso criar um vetor para armazenar o saldo do numero da conta dos clientes?
//não sei se fiz a referencia de maneira correta, eu sei que o deposito vai utilizar oque tiver dentro da classe conta propriedade saldo e numero da conta corrente)