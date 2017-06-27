using System;
using System.Collections;

namespace ArrayListClassCastException
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			ArrayList myList = new ArrayList();

			myList.Add(3.0);
			myList.Add(3); 
				// Oops. 3 is boxed in as int not double

			double total = 0;
			foreach(double val in myList) // Exception here.
			{
				total += val;
			}

			Console.WriteLine(total);
		}
	}
}
