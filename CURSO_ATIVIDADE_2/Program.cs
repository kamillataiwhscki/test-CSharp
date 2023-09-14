using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE2_CURSO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Pressione A para alugar um fime ou S para sair da locadora");
			char opcao = Console.ReadKey(true).KeyChar;

			if(opcao == 'A' || opcao == 'a')
			{
				//Alugar filme
				Console.WriteLine("Pressione 1 para alugar Top Gun");
				Console.WriteLine("Pressione 2 para alugar A Bela e a Fera");
				Console.WriteLine("Pressione 3 para alugar Homem Aranha");

				int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());

				switch (opcaoFilme)
				{
					case 1:
						Console.WriteLine("Você alugou Top Gun");
						break;
					case 2:
						Console.WriteLine("Você alugou A Bela e a Fera");
						break;
					case 3:
						Console.WriteLine("Você alugou Homem Aranha");
						break;
					default:
						Console.WriteLine("Opção desconhecida...");
						break;
				}
			}
			else if(opcao == 'S' || opcao == 's')
			{
				//Sair da locadora
				Console.WriteLine("Muito obrigado! Volte sempre");
			}
			else
			{
				//Opção desconhecida
				Console.WriteLine("Opção desconhecida...");
			}
			Console.WriteLine("Pressione qualquer tecla para encerrar");
			Console.ReadKey();
		}
	}
}
