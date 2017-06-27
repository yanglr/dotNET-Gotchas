using System;
using System.Threading;

namespace ThreadAborting
{
	class Test
	{
		private static void Worker()
		{
			try
			{
				try
				{
					Thread.Sleep(5000);
				}
				catch(ThreadAbortException)
				{
					Console.WriteLine(
						"ThreadAbortException caught");
				}

				Console.WriteLine(
					"Let's leave the method now");
			}
			finally
			{
				Console.WriteLine("In the finally block");
			}
		}

		[STAThread]
		static void Main(string[] args)
		{
			Thread workerThread = new Thread(
				new ThreadStart(Worker));
			workerThread.Start();

			Thread.Sleep(1000);
			Console.WriteLine("Calling abort");
			workerThread.Abort();

			Thread.Sleep(1000);
			Console.WriteLine("Main done");
		}
	}
}
