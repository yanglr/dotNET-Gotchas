using System;
using System.Threading;

namespace SynchOnType
{
	class Test
	{
		private static void Worker1()
		{
			Console.WriteLine("In thread {0}",
				AppDomain.GetCurrentThreadId());

			Bacteria aBacteria = new Bacteria();
		}

		private static void Worker2()
		{
			Console.WriteLine("In thread {0}",
				AppDomain.GetCurrentThreadId());

			SpecializedBacteria aBacteria 
				= new SpecializedBacteria();
		}

		[STAThread]
		static void Main(string[] args)
		{
			Thread thread1 
				= new Thread(new ThreadStart(Worker1));
			Thread thread2 
				= new Thread(new ThreadStart(Worker2));

			thread1.Start();
			thread2.Start();
		}
	}
}
