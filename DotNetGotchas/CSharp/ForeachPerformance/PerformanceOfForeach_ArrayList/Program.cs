// Program.cs
using System;
using System.Collections;

namespace PerformanceOfForeach
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.Write("Please enter number of iterations:");
			int count = Convert.ToInt32(Console.ReadLine());

			ArrayList myArray = new ArrayList();

			for(int i = 0; i < count; i++)
			{
				myArray.Add(new SomeClass());
			}

			int forStartTickCount = Environment.TickCount;
			for(int i = 0; i < count; i++)
			{
				SomeClass theObject = (SomeClass)(myArray[i]);
				theObject.Method1();
			}
			int forEndTickCount = Environment.TickCount;

			int ienumeratorStartTickCount 
				= Environment.TickCount;
			IEnumerator iter = myArray.GetEnumerator();
			while(iter.MoveNext())
			{
				SomeClass theObject 
					= (SomeClass)(iter.Current);
				theObject.Method1();				
			}
			int ienumeratorEndTickCount = Environment.TickCount;
			
			int foreachStartTickCount = Environment.TickCount;
			foreach(SomeClass theObject in myArray)
			{
				theObject.Method1();
			}
			int foreachEndTickCount = Environment.TickCount;
			
			Console.WriteLine("Timing:");

			Console.WriteLine("for: {0}", 
				(forEndTickCount - forStartTickCount)/1000.0);
		
			Console.WriteLine("enumerator: {0}", 
				(ienumeratorEndTickCount 
				- ienumeratorStartTickCount)/1000.0);

			Console.WriteLine("foreach: {0}", 
				(foreachEndTickCount
				- foreachStartTickCount)/1000.0);
		}
	}
}
