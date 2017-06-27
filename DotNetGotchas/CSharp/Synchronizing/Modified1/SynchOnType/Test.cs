using System;
using System.Threading;

namespace SynchOnType
{
	class Test
	{
		private static void Worker()
		{
			Console.WriteLine("In thread {0}",
				AppDomain.GetCurrentThreadId());

			Bacteria aBacteria = new Bacteria();
		}

		[STAThread]
		static void Main(string[] args)
		{
			Thread thread1 = new Thread(new ThreadStart(Worker));
			Thread thread2 = new Thread(new ThreadStart(Worker));

			thread1.Start();
			thread2.Start();
		}
	}
}
