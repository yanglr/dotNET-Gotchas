//Utility.cs part of ALibrary.dll
using System;

namespace ALibrary
{
	public class Utility
	{
		public double Operate(int value1, int value2)
		{
			// Some operation
			// Of course, this is an enormous programming error
			// Never do division without making sure the denominator
			// is not zero.
			// We’re just doing it here for the sake of example.
			double val = value1 / value2;
			return Math.Sqrt(val);
		}
	}
}
