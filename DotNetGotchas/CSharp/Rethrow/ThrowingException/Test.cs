using System;

namespace ThrowingException
{
	class Test
	{
		public static void Method1()
		{
			throw new ApplicationException();
		}

		public static void Method2()
		{
			try
			{
				Method1();
			}
			catch(Exception ex)
			{
				// Code to log may go here.
				throw ex;
				//throw new ApplicationException(
				//		"Exception logged", ex);
			}
		}

		public static void Method3()
		{
			try
			{
				Method1();
			}
			catch(Exception)
			{
				// Code to log may go here.
				throw;
			}
		}

		[STAThread]
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("----- Calling Method2");
				Method2();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}

			try
			{
				Console.WriteLine("----- Calling Method3");
				Method3();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
}
