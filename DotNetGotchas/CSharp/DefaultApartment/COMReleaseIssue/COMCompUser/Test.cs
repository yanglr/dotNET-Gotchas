//Test.cs
using System;
using System.Threading;

namespace COMCompUser
{
	class Test
	{
		static void Worker()
		{
			Thread currentThread = Thread.CurrentThread;
			Console.WriteLine("In worker thread");

			Console.WriteLine("Apartment in worker is {0}",
                currentThread.ApartmentState.ToString());

			Console.WriteLine("Creating COM object");
			MyCOMCompLib.IMyComp theMyComp 
				= new MyCOMCompLib.MyCompClass();

			Console.WriteLine("Apartment in worker is {0}",  
				currentThread.ApartmentState.ToString());
		}

		static void Main(string[] args)
		{
			Thread currentThread = Thread.CurrentThread;
			Console.WriteLine("Apartment in main is {0}", 
				currentThread.ApartmentState.ToString());

			Console.WriteLine("Creating COM object");
			MyCOMCompLib.IMyComp theMyComp 
				= new MyCOMCompLib.MyCompClass();

			Console.WriteLine("Apartment in main is {0}", 
				currentThread.ApartmentState.ToString());

			Thread workerThread = new Thread(
				new ThreadStart(Worker));
			//Not setting IsBackground on thread intentionally
			workerThread.Start();
		}
	}
}
