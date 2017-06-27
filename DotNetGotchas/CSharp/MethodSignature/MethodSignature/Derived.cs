//Derived.cs
using System;

namespace MethodSignature
{
	public class Derived : Base
	{
		public virtual void Method1(int val)
		{
			Console.WriteLine("Derived.Method1(int val) called");
		}
	}
}
