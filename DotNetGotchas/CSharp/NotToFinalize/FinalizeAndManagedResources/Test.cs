//Test.cs
using System;

namespace FinalizeAndManagedResources
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			SomeClass object1 = new SomeClass();
			SomeOtherClass object2 = new SomeOtherClass();
			object1.Setother(object2);
		}
	}
}
