//Test.cs
using System;

namespace DisposePattern
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Derived object1 = new Derived(1);
			Derived object2 = new Derived(2);

			object1.Dispose();
		}
	}
}
