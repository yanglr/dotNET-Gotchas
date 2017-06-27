//Test.cs
using System;

namespace Hiding
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Derived d = new Derived();
			Base b = d;

			d.Method1();
			d.Method2();

			b.Method1();
			b.Method2();
		}
	}
}
