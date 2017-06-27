using System;
using System.Threading;

namespace AbortAndJoin
{
	class Test
	{
		private static void Worker()
		{
			Console.WriteLine("Worker started");
			try
			{
				Thread.Sleep(5000);
			}
			finally
			{
				Console.WriteLine("Worker enters finally {0}",
					DateTime.Now.ToLongTimeString());
				Thread.Sleep(10000);
				// Simulates some cleanup activity
				Console.WriteLine("Cleanup done in Worker {0}",
					DateTime.Now.ToLongTimeString());
			}
		}

		[STAThread]
		static void Main(string[] args)
		{
			Thread workerThread 
				= new Thread(new ThreadStart(Worker));
			workerThread.IsBackground = true;
			workerThread.Start();
			Thread.Sleep(1000);

			Console.WriteLine("Aborting thread {0}",
				DateTime.Now.ToLongTimeString());
			workerThread.Abort();

			workerThread.Join();
			Console.WriteLine("Thread has aborted {0}",
				DateTime.Now.ToLongTimeString());
		}
	}
}
