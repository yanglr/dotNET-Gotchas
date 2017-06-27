using System;
using System.Collections.Generic;

namespace ArrayListClassCastException
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Collection<double> myList = new Collection<double>();

			myList.Add(3.0);
			myList.Add(3); // No problem. 3 is stored as 3.0.

			double total = 0;
			foreach(double val in myList)
			{
				total += val;
			}

			Console.WriteLine(total);
		}
	}
}
