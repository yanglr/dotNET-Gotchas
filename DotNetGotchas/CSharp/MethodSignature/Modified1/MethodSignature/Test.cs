//Test.cs
using System;

namespace MethodSignature
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Derived d = new Derived();
			Base b = d;

			// b and d refer to the same object now.
			b.Method1(3);
			d.Method1(3);
		}
	}
}
