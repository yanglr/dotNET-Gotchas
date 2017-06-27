//Program.cs part of UnhandledExceptionConsoleApp.exe
using System;
using ALibrary;
using System.Threading;

namespace UnhandledExceptionConsoleApp
{
	class Program
	{
		private static void Worker()
		{
			Console.WriteLine(
				"Enter two numbers separated by a return");

			int number1 = Convert.ToInt32(Console.ReadLine());
			int number2 = Convert.ToInt32(Console.ReadLine());

			double result = new Utility().Operate(number1, number2);

			Console.WriteLine("Result is {0}", result);
		}

		[STAThread]
		static void Main(string[] args)
		{
			try
			{
//				AppDomain.CurrentDomain.UnhandledException 
//					+= new UnhandledExceptionEventHandler(
//						CurrentDomain_UnhandledException);

				new Thread(new ThreadStart(Worker)).Start();
			}
			catch(Exception ex)
			{
				Console.WriteLine("Exception: " + ex.Message);
			}
		}

		private static void CurrentDomain_UnhandledException(
			object sender, UnhandledExceptionEventArgs e)
		{
			Console.WriteLine("Send the following to support");
			Console.WriteLine("Unexpected error:");
			Console.WriteLine(e.ExceptionObject);
			Console.WriteLine("Is CLR terminating: {0}", 
				e.IsTerminating);
		}
	}
}
