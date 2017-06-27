//Base.cs
using System;

namespace ObjectInitSequence
{
	public class Base
	{
		private SomeClass1 obj1 = new SomeClass1();

		public Base()
		{
			Console.WriteLine("Constructor of Base called");
		}
	}
}
