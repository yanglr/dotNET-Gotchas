//Test.cs part of ESUser.exe
using System;
using ESLib;

namespace ESUser
{
	class Test
	{
		public static void Work()
		{
			using(Factory theFactory = new Factory())
			{

				try
				{
					Comp component1 = theFactory.CreateComp(1);
					Comp component2 = theFactory.CreateComp(2);

					Console.WriteLine(component1.GetValue());
					Console.WriteLine(component2.GetValue());

					component1.SetValue(1);
					component2.SetValue(-1);

					Console.WriteLine(component1.GetValue());
					Console.WriteLine(component2.GetValue());
				}
				catch(Exception ex)
				{
					Console.WriteLine("Oops: " + ex.Message);
				}
			} // theFactory is Disposed here.
		}

		public static void Main()
		{
			try
			{
				Work();
			}
			catch(Exception ex)
			{
				Console.WriteLine("Error:" + ex.Message);
			}
		}
	}
}
