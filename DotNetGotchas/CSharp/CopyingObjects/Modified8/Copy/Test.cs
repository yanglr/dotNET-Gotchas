//Test.cs
using System;

namespace Copy
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Person sam = new Person(1, new SmarterBrain());
			//Person bob = new Person(sam);
			Person bob = sam.Clone() as Person;

			Console.WriteLine(sam);
			Console.WriteLine(bob);
		}
	}
}
