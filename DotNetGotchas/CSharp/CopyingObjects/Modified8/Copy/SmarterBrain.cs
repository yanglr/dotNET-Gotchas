//SmarterBrain.cs
using System;

namespace Copy
{
	public class SmarterBrain : Brain
	{
		public SmarterBrain()
		{
		}

		protected SmarterBrain(SmarterBrain another) 
			: base(another)
		{
		}

		public override object Clone()
		{
			return new SmarterBrain(this);
		}

	}
}
