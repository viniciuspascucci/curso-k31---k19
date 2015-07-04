using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Gerenic
{
	class TestaAdcionaNoComeco
	{
		static void Main(string[] args)
		{
			List<int> arrayList = new List<int>();

			long time = TestaAdcionaNoComeco.AdicionaNoComecoArrayList(arrayList);
			Console.WriteLine("ArrayList: " + time + "ms");

			LinkedList<int> linkedList = new LinkedList<int>();

			time = TestaAdcionaNoComeco.AdicionaNoComecoLinkedList(linkedList);
			Console.WriteLine("LinkedList: " + time + "ms");
		}

		public static long AdicionaNoComecoArrayList(List<int> lista)
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

		public static long AdicionaNoComecoLinkedList(LinkedList<int> lista)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			int size = 100000;

			for (int i = 0; i < size; i++)
			{
				lista.AddFirst(i);
			}

			sw.Stop();

			return sw.ElapsedMilliseconds;
		}
	}
}
