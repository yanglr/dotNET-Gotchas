using System;

namespace OrderOfCatch
{
	class Program
	{
		public static void AMethod()
		{
			throw new ApplicationException();
		}

		[STAThread]
		static void Main(string[] args)
		{
			try
			{
				AMethod();
			}
			catch(Exception ex)
			{
				Console.WriteLine("Caught Exception");
			}
			catch(ApplicationException ae)
				// Results in compilation error.
			{
				Console.WriteLine(
					"Caught ApplicationException");
			}
		}
	}
}
