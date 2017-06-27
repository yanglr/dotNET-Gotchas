using System;
using System.Threading;

namespace ResetAbort
{
	class Test
	{
		private static void Worker()
		{
			try
			{
				Thread.Sleep(5000);
			}
			catch(ThreadAbortException)
			{
				Console.WriteLine(
					"ThreadAbortException caught");
				Thread.ResetAbort();
			}

			Console.WriteLine("Look where we are now!");

			Thread.Sleep(10000);
		}

		[STAThread]
		static void Main(string[] args)
		{
			Thread workerThread 
				= new Thread(new ThreadStart(Worker));
			workerThread.Start();

			Thread.Sleep(1000);
			Console.WriteLine("Calling abort");
			workerThread.Abort();

			Thread.Sleep(2000);
			Console.WriteLine("Main done");
		}
	}
}
