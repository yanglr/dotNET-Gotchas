//Derived.cs
using System;

namespace Hiding
{
	public class Derived : Base
	{
		public override void Method1()
		{
			Console.WriteLine("Derived.Method1 called");
		}

		public new void Method2()
		{
			Console.WriteLine("Derived.Method2 called");
		}
	}
}
