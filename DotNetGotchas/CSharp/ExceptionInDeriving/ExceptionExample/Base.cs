//Base.cs
using System;

namespace ExceptionExample
{
	/// <summary>
	/// A class to illustrate Excetion in Inheritance
	/// </summary>
	public class Base
	{
		/// <summary>
		/// Method1 does some thing on input given.
		/// </summary>
		/// <param name="val">Input to work on</param>
		/// <exception 
		/// cref="ExceptionExample.InvalidInputException">
		/// Thrown if parameter is less than 0.
		/// </exception>
		public virtual void Method1(int val)
		{
			if (val < 0)
				throw new InvalidInputException();
			//... rest of the code goes here
		}
	}
}
