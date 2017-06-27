//Test.cs
using System;

namespace MarkOverride
{
	class Test
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
