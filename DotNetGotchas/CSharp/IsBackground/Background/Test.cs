//Test.cs
using System;
using System.Threading;

namespace Background
{
	class Test
	{
		private static void Worker()
		{
			// Some activity
			Thread.Sleep(5000);

			Console.WriteLine("worker done at {0}", 
				DateTime.Now.ToLongTimeString());
		}
		[STAThread]
		static void Main(string[] args)
		{
			Thread workerThread 
				= new Thread(new ThreadStart(Worker));
			//workerThread.IsBackground = true;
			workerThread.Start();

			Console.WriteLine("Main done at {0}", 
				DateTime.Now.ToLongTimeString());
		}
	}
}
