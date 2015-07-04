using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Collections
{
	class TestaArray
	{
		static void Main(string[] args)
		{
			ArrayList nomes = new ArrayList();

			long tempo = TestaArray.AdicionaNoFinal(nomes);
			Console.WriteLine("ArrayList: " + tempo + " ms ");
		}

		public static long AdicionaNoFinal(IList lista)
		{
			Stopwatch sw = new Stopwatch();

			sw.Start();
			int size = 100000;

			for (int i = 0; i < size; i++)
			{
				lista.Add(i);
			}

			sw.Stop();

			return sw.ElapsedMilliseconds;
		}
	}
}
