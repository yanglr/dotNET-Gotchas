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

			lock(typeof(Bacteria))
			{
				Console.WriteLine("Starting threads at {0}",
					DateTime.Now.ToLongTimeString());

				thread1.Start();
				thread2.Start();

				Thread.Sleep(3000);
			}
		}
	}
}
