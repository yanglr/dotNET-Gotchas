//Engine.cs
using System;

namespace Serialization
{
	[Serializable]
	public class Engine
	{
		private int power;

		public Engine(int thePower)
		{
			power = thePower;
		}

		public override string ToString()
		{
			return power.ToString();
		}

	}
}
