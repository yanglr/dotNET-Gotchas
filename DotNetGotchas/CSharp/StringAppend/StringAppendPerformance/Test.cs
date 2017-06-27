using System;

namespace StringAppendPerformance
{
	class Test
	{
		private const string format = "{0,-15} {1,-20} {2,-15}";
		
		static void Main()
		{
			int[] iterations = new int[] {10, 100, 
				1000, 2500, 5000, 7500, 
				10000, 15000, 25000, 35000,
				50000, 65000, 75000, 85000,
				100000, 150000, 250000, 350000, 500000, 
				650000, 750000, 850000, 1000000 };

			Console.WriteLine(format, 
					"# of Appends", "Time (in sec) for +", 
					"Time (in sec) for StringBuilder");
			foreach(int count in iterations)
			{
				Run(count);
			}
		}

		static void Run(int count /* number of strings to append */)
		{
			string str = null;
			int startCount = Environment.TickCount;

			for (int i = 0; i < count; i++)
			{
				str = str + ".";
			}

			int endCount = Environment.TickCount;

			double timeTakenByPlus = 
				(endCount - startCount) / 1000.0;

			System.Text.StringBuilder bldr = 
				new System.Text.StringBuilder();

			startCount = Environment.TickCount;
			for (int i = 0; i < count; i++)
			{
				bldr.Append(".");
			}
			endCount = Environment.TickCount;

			double timeTakenByStringBuilder = 
				(endCount - startCount) / 1000.0;

			Console.WriteLine(format, count, timeTakenByPlus, timeTakenByStringBuilder);
		}
	}
}
