using System;
using System.Threading;

namespace DelegateThread
{
	class Test
	{
		private static void Method1()
		{
			Console.WriteLine("Method1 is throwing exception");
			throw new ApplicationException("**** oops ****");
		}

		delegate void Method1Delegate();

		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("We first use a thread");
			Thread aThread 
				= new Thread(new ThreadStart(Method1));
			aThread.Start();

			Console.WriteLine("press return");
			Console.ReadLine();

			Console.WriteLine("We will use a Delegate now");
			Method1Delegate dlg = new Method1Delegate(Method1);
			IAsyncResult handle = dlg.BeginInvoke(null, null);

			Thread.Sleep(1000);

			Console.WriteLine("Was the exception reported so far?");

			try
			{
				Console.WriteLine("Let's call EndInvoke");
				dlg.EndInvoke(handle);
			}
			catch(Exception ex)
			{
				Console.WriteLine("Exception: {0}", ex.Message);
			}

			Console.WriteLine("press return");
			Console.ReadLine();
			
			Console.WriteLine("We will use a timer now");

			System.Timers.Timer theTimer 
				= new System.Timers.Timer(1000);
			theTimer.Elapsed 
				+= new System.Timers.ElapsedEventHandler(
					theTimer_Elapsed);
			theTimer.Start();

			Thread.Sleep(3000);
			theTimer.Stop();

			Console.WriteLine("press return");
			Console.ReadLine();
		}

		private static void theTimer_Elapsed(
			object sender, System.Timers.ElapsedEventArgs e)
		{
			Method1();
		}
	}
}
