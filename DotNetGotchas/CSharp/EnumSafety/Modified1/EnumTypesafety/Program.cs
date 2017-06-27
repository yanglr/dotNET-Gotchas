using System;

namespace EnumTypesafety
{
	class Program
	{
		private static int[] resource = new int[] {0, 1, 2};

		public enum Size
		{
			Small,
			Medium,
			Large
		}

		public static void Method1(Size theSize)
		{
			if(System.Enum.IsDefined(typeof(Size), theSize))
			{
				Console.WriteLine(theSize);
				Console.WriteLine("Resource: {0}", 
					resource[(int)theSize]);
			}
			else
			{
				throw new ApplicationException(
						"Invalid input for Size");
			}
		}

		[STAThread]
		static void Main(string[] args)
		{
			try
			{
				Method1(Size.Small);
				Method1(Size.Large);
				Method1((Size) 1);
				Method1((Size) 3);
			}
			catch(ApplicationException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}
		}
	}
}
