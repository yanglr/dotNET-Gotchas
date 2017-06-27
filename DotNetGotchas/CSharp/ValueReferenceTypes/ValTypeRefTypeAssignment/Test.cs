//Test.cs
using System;

namespace ValTypeRefTypeAssignment
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			AType firstInstance = new AType();

			firstInstance.TheValue = 2;

			AType secondInstance = new AType();
			secondInstance.TheValue = 3;

			Console.WriteLine("The values are {0} and {1}", 
				firstInstance.TheValue, 
				secondInstance.TheValue);

			firstInstance = secondInstance; // Line A

			Console.Write("Values after assignment ");
			Console.WriteLine("are {0} and {1}", 
				firstInstance.TheValue, 
				secondInstance.TheValue);

			secondInstance.TheValue = 4;

			Console.Write("Values after modifying TheValue ");
			Console.Write("in secondInstance are ");
			Console.WriteLine("{0} and {1}", 
				firstInstance.TheValue, 
				secondInstance.TheValue);
		}
	}
}
