//Animal.cs
using System;

namespace RTTIExample
{
	public abstract class Animal
	{
		public void Eat()
		{
			Console.WriteLine("Animal eating");
		}

		public abstract void MakeNoise();
	}
}
