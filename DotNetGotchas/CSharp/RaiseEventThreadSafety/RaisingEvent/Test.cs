//Test.cs

using System;
using System.Threading;

namespace RaisingEvent
{
	public class Test
	{
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

		public static void Main()
		{
			Console.WriteLine("---- Calling Main.TestIt ----");
			TestIt();
			Thread.Sleep(5000);
			Console.WriteLine("---- Calling AComponent.TestIt ----");
			AComponent.TestIt();
		}
	}
}
