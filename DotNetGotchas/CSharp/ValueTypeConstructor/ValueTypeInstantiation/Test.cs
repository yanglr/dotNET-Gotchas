//Test.cs
using System;

namespace ValueTypeInstantiation
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			MyType instance1 = new MyType(10);
			Console.WriteLine("instance1: " + instance1);

			MyType instance2 = new MyType();
			Console.WriteLine("instance2: " + instance2);
		}
	}
}
