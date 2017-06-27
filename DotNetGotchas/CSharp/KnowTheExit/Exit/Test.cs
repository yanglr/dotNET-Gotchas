using System;
using System.Threading;

namespace Exit
{
	class Test
	{
		public static void Worker()
		{
			Console.WriteLine("worker thread started");
			try
			{
				Thread.Sleep(5000);
			}
			catch(ThreadInterruptedException)
			{
				Console.WriteLine("worker interrupted");
			}
			catch(ThreadAbortException)
			{
				Console.WriteLine("worker aborted");
			}
		}

		[STAThread]
		static void Main(string[] args)
		{
			Thread workerThread1 = new Thread(
				new ThreadStart(Worker));
			workerThread1.Start();
			Thread.Sleep(1000);

			Console.WriteLine("Interrupting worker1 at {0}",
				DateTime.Now.ToLongTimeString());

			workerThread1.Interrupt();

			Thread workerThread2 = new Thread(
				new ThreadStart(Worker));
			workerThread2.Start();
			Thread.Sleep(1000);

			Console.WriteLine("Calling Exit");

			Environment.Exit(0);
		}
	}
}
