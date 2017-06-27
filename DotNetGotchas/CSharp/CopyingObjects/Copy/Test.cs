//Test.cs
using System;

namespace Copy
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Person sam = new Person(1, new Brain());
			Person bob = new Person(sam);

			Console.WriteLine(sam);
			Console.WriteLine(bob);
		}
	}
}
