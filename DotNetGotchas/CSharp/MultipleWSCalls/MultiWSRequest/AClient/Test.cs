//Test.cs part of AClient.exe
using System;
using AClient.ACSWSForMultiRequest;

namespace AClient
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			MyService service = new MyService();
			service.CookieContainer =
				new System.Net.CookieContainer();

			service.Credentials =
				System.Net.CredentialCache.DefaultCredentials;

			Console.WriteLine(
				"Making synchronous request at {0}",
				DateTime.Now.ToLongTimeString());

			Console.WriteLine("Recevied {0} at {1}",
				service.Method1(0),
				DateTime.Now.ToLongTimeString());

			Console.WriteLine("Making two requests at {0}",
				DateTime.Now.ToLongTimeString());

			service.BeginMethod1(1, new AsyncCallback(display), 
				service);

			service.BeginMethod1(2, new AsyncCallback(display),
				service);

			Console.ReadLine();
		}

		private static void display(IAsyncResult handle)
		{
			MyService theService = 
				handle.AsyncState as MyService;

			string result = theService.EndMethod1(handle);

			Console.WriteLine("Result {0} received {1}", 
				result, DateTime.Now.ToLongTimeString());
		}
	}
}
