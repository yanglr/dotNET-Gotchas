using System;
using System.Threading;

namespace Interrupting
{
	class Test
	{
		public static void Worker()
		{
			try
			{
				Console.WriteLine("worker started at {0}",
					DateTime.Now.ToLongTimeString());

				string str = null;
				for(int i = 0; i < 30000; i++)
				{
					str += i.ToString();
					// Simulating some activity
				}

				Thread.Sleep(1000);
			}
			catch(ThreadInterruptedException)
			{
				Console.WriteLine("Thread interrupted at {0}",
					DateTime.Now.ToLongTimeString());
			}

			Console.WriteLine(
				"Continuing after Exception is caught");
		}

		[STAThread]
		static void Main(string[] args)
		{
			Thread workerThread = new Thread(
				new ThreadStart(Worker));
			//workerThread.IsBackground = true;
			workerThread.Start();
			Thread.Sleep(1000);

			Console.WriteLine("Interrupting worker at {0}",
				DateTime.Now.ToLongTimeString());

			workerThread.Interrupt();
		}
	}
}
