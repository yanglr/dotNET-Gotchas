//User.cs
using System;

namespace ProblemPolymorphismConstruction
{
	class User
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Creating Manager");
			Manager mgr = new Manager(1);

			Console.WriteLine("Done");
		}
	}
}
