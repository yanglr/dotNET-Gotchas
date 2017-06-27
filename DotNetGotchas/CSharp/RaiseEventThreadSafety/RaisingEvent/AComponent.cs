//AComponent.cs 

using System;
using System.Threading;

namespace RaisingEvent
{
	public class AComponent
	{
		public event EventHandler myEvent;

		private void DoWork()
		{
			EventHandler localHandler = null;
			lock(this)
			{
				if (myEvent != null)
				{
					Console.WriteLine("myEvent is not null");
					Thread.Sleep(2000); 
					// Intentional delay to illustrate

					localHandler = myEvent;
					Console.WriteLine("Got a safe copy");
				}
			}

			if (localHandler != null)
			{
				localHandler(this, new EventArgs());
			}
			else
			{
				Console.WriteLine("localHandler is null!!!!!!!!!!!");
			}
		}

		public void Work()
		{
			Thread aThread = new Thread(
				new ThreadStart(DoWork));

			aThread.Start();
		}

		private static void TestHandler(
			object sender, EventArgs e)
		{
			Console.WriteLine("Handler called");
		}

		public static void TestIt()
		{
			AComponent obj = new AComponent();
			obj.myEvent += new EventHandler(TestHandler);
			
			obj.Work();

			Thread.Sleep(1000);

			Console.WriteLine("Trying to unregister handler");
			obj.myEvent -= new EventHandler(TestHandler);
			Console.WriteLine("handler unregistered");
		}

	}
}