//Test.cs
using System;

namespace ExceptionExample
{
	class Test
	{
		private static void Use(Base baseObject, int theValue)
		{
				Console.WriteLine("Executing Use with {0}, {1}",
					baseObject.GetType().Name, theValue);

			try
			{
				baseObject.Method1(theValue);
			}
			catch(InvalidInputException e)
			{
				Console.WriteLine(
					"{0} was thrown", e.GetType().FullName);
				// Handle the exception here
			}
		}

		//...

		[STAThread]
		static void Main(string[] args)
		{
			Base object1 = new Base();
			Use(object1, -1);
			Use(object1, 3);

			Derived object2 = new Derived();
			Use(object2, -1);
				//Use does not handle InputMustBeEvenException
			Use(object2, 3);
		}
	}
}
