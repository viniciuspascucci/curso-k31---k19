using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Collections
{
	class TestaArrayInicio
	{
		static void Main()
		{
			ArrayList nomesInicio = new ArrayList();

			long tempo = TestaArrayInicio.AdicionaNoComeco(nomesInicio);
			Console.WriteLine("ArrayList: " + tempo + "ms");
		}

		public static long AdicionaNoComeco(IList lista)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			int size = 100000;

			for (int i = 0; i < size; i++)
			{
				lista.Insert(0, 1);
			}

			sw.Stop();

			return sw.ElapsedMilliseconds;
		}
	}
}
