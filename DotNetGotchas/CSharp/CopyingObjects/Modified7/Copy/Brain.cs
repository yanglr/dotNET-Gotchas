//Brain.cs
using System;

namespace Copy
{
	public class Brain : ICloneable
	{
		private readonly int id;
		private static int idCount;

		public Brain() 
		{
			id = 
			System.Threading.Interlocked.Increment(ref idCount);
		}

		protected Brain(Brain another) 
		{
			id = 
			System.Threading.Interlocked.Increment(ref idCount);
		}

		public override string ToString()
		{
			return GetType().Name + ":" + id;
		}

		#region ICloneable Members

		public virtual object Clone()
		{
			return new Brain(this);
		}

		#endregion
	}
}
