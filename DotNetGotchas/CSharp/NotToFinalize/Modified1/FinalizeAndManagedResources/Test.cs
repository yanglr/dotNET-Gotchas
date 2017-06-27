//Test.cs
using System;

namespace FinalizeAndManagedResources
{
	class Test
	{
		private static void ohoh(SomeOtherClass obj)
		{
			SomeClass object1 = new SomeClass();
			object1.Setother(obj);
		}

		[STAThread]
		static void Main(string[] args)
		{
			SomeOtherClass object2 = new SomeOtherClass();

			lock(object2)
			{
				ohoh(object2);
				GC.Collect();
				//GC.WaitForPendingFinalizers();
				Console.WriteLine("OK let's release lock in Main");
			}

			Console.WriteLine("Are we here");
		}
	}
}
