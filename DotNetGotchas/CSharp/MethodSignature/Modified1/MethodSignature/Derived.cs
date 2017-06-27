//Derived.cs
using System;

namespace MethodSignature
{
	public class Derived : Base
	{
		public override void Method1(double val)
		{
			Console.WriteLine(
				"Derived.Method1(double val) called");
		}

		public virtual void Method1(int val)
		{
			Console.WriteLine("Derived.Method1(int val) called");
			// You may call Method1((double) val) from here if
			// you want consistent behavior.
		}
	}
}
