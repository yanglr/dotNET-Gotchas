//Brain.cs
using System;

namespace Copy
{
	public class Brain
	{
		public Brain() {}

		public Brain(Brain another) 
		{
			//Code to properly copy Brain can go here
		}

		public override string ToString()
		{
			return GetType().Name + ":" + GetHashCode();
		}

	}
}
