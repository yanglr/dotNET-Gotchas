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
			Console.WriteLine(theSize);
			Console.WriteLine("Resource: {0}", 
				resource[(int)theSize]);
		}

		[STAThread]
		static void Main(string[] args)
		{
			Method1(Size.Small);
			Method1(Size.Large);
			Method1((Size) 1);
			Method1((Size) 3);
		}
	}
}
