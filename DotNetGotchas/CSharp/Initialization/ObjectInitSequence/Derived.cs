//Derived.cs
using System;

namespace ObjectInitSequence
{
	public class Derived : Base
	{
		private SomeClass2 obj2 = new SomeClass2();

		public Derived()
		{
			Console.WriteLine("Constructor of Derived called");
		}
	}
}
