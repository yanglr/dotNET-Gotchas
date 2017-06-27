//Test.cs
using System;

namespace DerivedMethod
{
	public class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Derived d = new Derived();
			Base b = d;

			d.Method1();
			b.Method1();
		}
	}
}
