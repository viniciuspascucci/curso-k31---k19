using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Generic_continuaçao
{
	class TestaContains
	{
		static void Main(string[] args)
		{
			List<int> arrayList = new List<int>();
			HashSet<int> hashSet = new HashSet<int>();

			long time = TestaContains.Contains(arrayList);
			Console.WriteLine("ArrayList: " + time + "ms");

			time = TestaContains.Contains(hashSet);
			Console.WriteLine("HashSet " + time + "ms");

		}

		public static long Contains(ICollection<int> colecao)
		{
			int size = 100000;

			for (int i = 0; i < size; i++)
			{
				colecao.Add(i);
			}

			Stopwatch sw = new Stopwatch();
			sw.Start();

			for (int i = 0; i < size; i++)
			{
				colecao.Contains(i);
			}

			sw.Stop();

			return sw.ElapsedMilliseconds;
		}
	}
}
