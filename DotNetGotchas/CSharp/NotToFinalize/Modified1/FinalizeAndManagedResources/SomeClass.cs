//SomeClass.cs
using System;

namespace FinalizeAndManagedResources
{
	public class SomeClass
	{
		private SomeOtherClass other;

		public void Setother(SomeOtherClass otherObject)
		{
			other = otherObject;
		}

		~SomeClass()
		{
			Console.WriteLine("Finalize called on SomeClass");
			if(other != null)
			{
				other.Notify();
			}
		}
	}
}
