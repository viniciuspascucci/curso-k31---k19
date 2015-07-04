using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Gerenic
{
	class TestaAdcionaNoFinal
	{
		static void Main(string[] args)
		{
			List<int> arrayList = new List<int>();

			long temp = TestaAdcionaNoFinal.AdicionaNoFinal(arrayList);
			Console.WriteLine("ArrayList: " + temp + "ms");

			LinkedList<int> linkedList = new LinkedList<int>();

			temp = TestaAdcionaNoFinal.AdicionaNoFinal(linkedList);
			Console.WriteLine("LinkedList: " + temp + "ms");
		}

		public static long AdicionaNoFinal(ICollection<int> lista)
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
