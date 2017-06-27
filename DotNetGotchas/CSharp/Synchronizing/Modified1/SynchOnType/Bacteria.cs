//Bacteria.cs
using System;

namespace SynchOnType
{
	public class Bacteria
	{
		private static int bacteriaCount;

		private static void IncreaseCount()
		{
			Console.WriteLine(
				"IncreaseCount called by {0} at {1}",
				AppDomain.GetCurrentThreadId(),
				DateTime.Now.ToLongTimeString());

			bacteriaCount++;

			System.Threading.Thread.Sleep(2000);
			// Used for illustration purpose
		}

		public Bacteria()
		{
			lock(GetType())
			{
				IncreaseCount();
			}
		}
	}
}
