//Test.cs
using System;
using ACOMCompLib;

namespace FinalizePeril
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			int iterations = Convert.ToInt32(args[0]);
			int result = 0;
			for(int i = 0; i < iterations; i++)
			{
				Wrapper theWrapper = null;
				try
				{
					theWrapper = new Wrapper();
					result = theWrapper.doSomething();
				}
				finally
				{
					theWrapper.Dispose();
				}
			}

			Console.WriteLine(result);
			Console.WriteLine("End of Main");
		}
	}
}
