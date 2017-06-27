//Derived.cs
using System;

namespace DerivedMethod
{
	public class Derived : Base
	{
		public virtual void Method1()
		{
			Console.WriteLine("Derived.Method1 called");
		}
	}
}
