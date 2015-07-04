using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
	class Program
	{
		delegate bool Filtro(Pessoa p);

		static void Main(string[] args)
		{
			List<Pessoa> pessoas = new List<Pessoa>
			{
				new Pessoa {Nome = "Vinicius" , Idade = 22},
				new Pessoa {Nome = "Mariana" , Idade = 14},
				new Pessoa {Nome = "Cristina" , Idade = 45},
				new Pessoa {Nome = "Gino" , Idade = 50},
				new Pessoa {Nome = "Niishi" , Idade = 18}
			};

			Filtro FiltrarPessoasJovens = FiltraPessoasJovens;
			Filtro FiltrarPessoasIdosas = FiltraPessoasIdosas;

			//Pessoas jovens
			Console.WriteLine("Pessoas jovens: ");
			List<Pessoa> pessoaDeIdadeJovem = Filtrar(pessoas, FiltraPessoasJovens);
			Imprime(pessoaDeIdadeJovem);

			Console.WriteLine("Pessoas Idosas");
			List<Pessoa> pessoasDeIdadeIdosa = Filtrar(pessoas, FiltrarPessoasIdosas);
			Imprime(pessoasDeIdadeIdosa);

		}

		static List<Pessoa> Filtrar(List<Pessoa> pessoas, Filtro filtro)
		{
			List<Pessoa> pessoasFiltrada = new List<Pessoa>();
			foreach (var pessoa in pessoas)
			{
				if (filtro(pessoa))
				{
					pessoasFiltrada.Add(pessoa);
				}
			}
			return pessoasFiltrada;
		}

		static bool FiltraPessoasJovens(Pessoa pessoa)
		{
			return pessoa.Idade < 30;
		}
		
		static bool FiltraPessoasIdosas(Pessoa pessoa)
		{
			return pessoa.Idade > 30;
		}

		static void Imprime(List<Pessoa> pessoas)
		{
			foreach (var p in pessoas)
			{
				Console.WriteLine("Nome: {0} ,Idade: {1}", p.Nome, p.Idade);
			}
			Console.WriteLine();
		}
	}
}
