//Trainer.cs
using System;

namespace RTTIExample
{
	public class Trainer
	{
		public void Train(Animal anAnimal)
		{
			anAnimal.Eat();
			//Using casting

			Dog doggie = (Dog) anAnimal;
			doggie.Bark();

			Cat aCat = (Cat) anAnimal;
			aCat.Meow();
		}
	}
}
