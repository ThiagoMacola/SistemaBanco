namespace Sistema_Banco
{
	public class Endereco
	{
		public string Logradouro { get; set; }
		public int Numero { get; set; }
		public string Localidade { get; set; }

		public Endereco(string logradouro, int numero, string localidade)
		{
			Logradouro = logradouro;
			Numero = numero;
			Localidade = localidade;
		}
	}
}