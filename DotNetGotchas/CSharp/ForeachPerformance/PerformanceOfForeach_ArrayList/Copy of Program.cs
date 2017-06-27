using System;
using System.Collections;

namespace PerformanceOfForeach
{
	/// <summary>
	/// Illustrates the consequence of different ways
	/// to iterate.
	/// </summary>
	class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Console.Write("Please enter number of iterations:");
			int count = Convert.ToInt32(Console.ReadLine());

			int[] myArray = new int[count];

			int sum = 0;
			int forStartTickCount = Environment.TickCount;
			for(int i = 0; i < count; i++)
			{
				int theValue = myArray[i];
				sum = sum += theValue;
			}
			int forEndTickCount = Environment.TickCount;

			sum = 0;
			int ienumeratorStartTickCount = Environment.TickCount;
			IEnumerator iter = myArray.GetEnumerator();
			while(iter.MoveNext())
			{
				int theValue = (int)(iter.Current);
				sum += theValue;
			}
			int ienumeratorEndTickCount = Environment.TickCount;
			
			sum = 0;
			int foreachStartTickCount = Environment.TickCount;
			foreach(int theValue in myArray)
			{
				sum = sum += theValue;
			}
			int foreachEndTickCount = Environment.TickCount;
			
			Console.WriteLine("Timing:");

			Console.WriteLine("for: {0}", 
				(forEndTickCount - forStartTickCount)/1000.0);
		
			Console.WriteLine("enumerator: {0}", 
				(ienumeratorEndTickCount - ienumeratorStartTickCount)/1000.0);

			Console.WriteLine("foreach: {0}", 
				(foreachEndTickCount- foreachStartTickCount)/1000.0);
		}
	}
}
