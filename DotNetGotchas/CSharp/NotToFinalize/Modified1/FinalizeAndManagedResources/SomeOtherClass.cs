//SomeOtherClass.cs
using System;

namespace FinalizeAndManagedResources
{
	public class SomeOtherClass
	{
		private int[] values = new int[1000000];

		public void Notify()
		{
			Console.WriteLine("Entering Notify");
			lock(this)
			{
				Console.WriteLine("Notify called on SomeOtherClass");
			}
		}

		~SomeOtherClass()
		{
			Console.WriteLine("*** SomeOtherClass Finalized");
		}
	}
}
