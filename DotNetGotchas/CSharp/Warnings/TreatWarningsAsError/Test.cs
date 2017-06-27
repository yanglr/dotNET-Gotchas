using System;

namespace TreatWarningsAsError
{
	public class Base
	{
		public virtual void foo() {}
	}

	public class Derived : Base
	{
		public void foo() {}
	}

	public class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			int val;

			Console.WriteLine("Test");
		}
	}
}
