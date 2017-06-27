//MyType.cs
using System;

namespace ValueTypeInstantiation
{
	public struct MyType
	{
		private int val;

		public override string ToString()
		{
			return "The value is " + val;
		}

		//public MyType() {} // Can't be provided

		public MyType(int initialValue)
		{
			val = initialValue;
		}
	}
}
