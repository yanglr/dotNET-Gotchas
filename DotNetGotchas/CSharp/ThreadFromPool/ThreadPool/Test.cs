using System;
using System.Threading;

namespace ThreadPool
{
	class Test
	{
		private static void Method1()
		{
			Console.Write("Executed by Thread {0} which is ",
				AppDomain.GetCurrentThreadId());

			if (!Thread.CurrentThread.IsThreadPoolThread)
                Console.Write("not ");

			Console.WriteLine("from the thread pool at {0}",
				DateTime.Now.ToLongTimeString());

			Thread.Sleep(35000);
		}

		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("Using our own thread");
			for(int i = 0; i < 5; i++)
			{
				new Thread(new ThreadStart(Method1)).Start();
				Thread.Sleep(1000);
			}

			Console.WriteLine("Press any key to use timer");
			Console.ReadLine();
			Console.WriteLine("Using timer");
			System.Timers.Timer theTimer 
				= new System.Timers.Timer(1000);
			theTimer.Elapsed 
				+= new System.Timers.ElapsedEventHandler(
						theTimer_Elapsed);
			theTimer.Start();
			Thread.Sleep(45000);
			theTimer.Stop();
		}

		private static void theTimer_Elapsed(
			object sender, System.Timers.ElapsedEventArgs e)
		{
			Method1();
		}
	}
}
