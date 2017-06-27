//using Derived.cs
using System;

namespace DisposePattern
{
	public class Derived : Base
	{
		public Derived(int theID) : base(theID) {}

		protected override void Dispose(bool disposing)
		{
			base.Dispose (disposing);

			if (disposing)
			{
				Console.WriteLine(
					"Derived Cleaning up managed resources");
				// Code to clean up managed resources
			}

			Console.WriteLine(
					"Derived Cleaning up unmanaged resources");
			// Code to clean up unmanaged resources
		}
	}
}
