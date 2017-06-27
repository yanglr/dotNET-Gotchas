//Brain.cs
using System;

namespace Copy
{
	public class Brain : ICloneable
	{
		private int id;
		private static int idCount;

		public Brain() 
		{
			id = 
			System.Threading.Interlocked.Increment(ref idCount);
		}

		public Brain(Brain another) 
		{
			//Code to properly copy Brain can go here
		}

		public override string ToString()
		{
			return GetType().Name + ":" + id;
		}

		#region ICloneable Members

		public object Clone()
		{
			return MemberwiseClone();
		}

		#endregion
	}
}
