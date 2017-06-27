//Trainer.cs
using System;

namespace RTTIExample
{
	public class Trainer
	{
		public void Train(Animal anAnimal)
		{
			anAnimal.Eat();

			//Using Abstraction and Polymorphism

			anAnimal.MakeNoise();
		}
	}
}
