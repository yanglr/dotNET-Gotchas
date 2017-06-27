using System;
using System.Threading;

namespace BackgroundThreadAndAbort
{
	class Test
	{
		private static void Worker()
		{
			Console.WriteLine(
				"Worker started... given chance to cleanup?");
			try
			{
				Thread.Sleep(5000);
			}
			catch(ThreadAbortException)
			{
				Console.WriteLine(
					"Thread aborted exception received");
			}
		}

		[STAThread]
		static void Main(string[] args)
		{
			Thread workerThread 
				= new Thread(new ThreadStart(Worker));
			workerThread.IsBackground = true;
			workerThread.Start();

			Thread.Sleep(2000);
			Console.WriteLine("Main done");
		}
	}
}
