//Dog.cs
using System;

namespace RTTIExample
{
	public class Dog : Animal
	{
		public void Bark()
		{
			Console.WriteLine("Dog barking");
		}

		public override void MakeNoise()
		{
			Bark();
		}

		public override bool Play(Animal other)
		{
			if (other is Dog) 
				return true;
			else
                return false;
		}

	}
}
