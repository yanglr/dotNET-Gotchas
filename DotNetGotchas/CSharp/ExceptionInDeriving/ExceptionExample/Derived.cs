using System;

namespace ExceptionExample
{
	/// <summary>
	/// A Derived class that violates LSP.
	/// </summary>
	public class Derived : Base
	{
		/// <summary>
		/// Method1 does something with input
		/// </summary>
		/// <param name="val">val to work with</param>
		/// <exception cref="InvalidInputException">
		/// thrown if parameter is 0
		/// </exception>
		/// <exception cref="InputMustBeEvenException">
		/// thrown if parameter is not even
		/// </exception>
		public override void Method1(int val)
		{
			if ((val % 2) != 0)
			{
				// Not an even number
				throw new InputMustBeEvenException();
			}

			base.Method1(val);
			//Continue with rest of the code		
		}

	}
}
