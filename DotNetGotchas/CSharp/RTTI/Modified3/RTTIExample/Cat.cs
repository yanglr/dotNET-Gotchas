//Cat.cs
using System;

namespace RTTIExample
{
	public class Cat : Animal
	{
		public void Meow()
		{
			Console.WriteLine("Cat Meowing");
		}

		public override void MakeNoise()
		{
			Meow();
		}

		public override bool Play(Animal other)
		{
			return false;
		}

	}
}
