//Bacteria.cs

using System;
using System.Threading;

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

			Thread.Sleep(2000);
			// Used for illustration purpose
		}

		public Bacteria()
		{
			lock(this)
			{
				IncreaseCount();
			}
		}
	}
}
