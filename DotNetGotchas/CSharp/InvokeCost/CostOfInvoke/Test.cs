using System;
using System.Reflection;

namespace CostOfInvoke
{
	class Test
	{
		public static void Method1()
		{
		}

		[STAThread]
		static void Main(string[] args)
		{
			Console.Write("Enter number of iterations:");
			int iterations = Convert.ToInt32(Console.ReadLine());

			int directCallStartTick = Environment.TickCount;
			for(int i = 0; i < iterations; i++)
			{
				Method1();
			}
			int directCallEndTick = Environment.TickCount;

			MethodInfo theMethod 
				= typeof(Test).GetMethod("Method1");
			int InvokeCallStartTick = Environment.TickCount;
			for(int i = 0; i < iterations; i++)
			{
				theMethod.Invoke(typeof(Test), null);
			}
			int InvokeCallEndTick = Environment.TickCount;

			Console.WriteLine("Time taken:");
			Console.WriteLine("Direct call: {0}",
				(directCallEndTick 
				- directCallStartTick) / 1000.0);

			Console.WriteLine("Invoke call: {0}",
				(InvokeCallEndTick 
				- InvokeCallStartTick) / 1000.0);
		}
	}
}
