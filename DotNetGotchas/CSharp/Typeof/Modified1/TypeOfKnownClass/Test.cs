using System;

namespace TypeOfKnownClass
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Type theType = typeof(Test);

			Console.WriteLine(theType.FullName);
		}
	}
}
