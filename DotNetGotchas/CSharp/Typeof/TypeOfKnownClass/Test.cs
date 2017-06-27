using System;

namespace TypeOfKnownClass
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Type theType = Type.GetType("Test");

			Console.WriteLine(theType.FullName);
		}
	}
}
