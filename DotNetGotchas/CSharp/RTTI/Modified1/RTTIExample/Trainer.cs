//Trainer.cs
using System;

namespace RTTIExample
{
	public class Trainer
	{
		public void Train(Animal anAnimal)
		{
			anAnimal.Eat();

			//Using RTTI

			if (anAnimal is Dog)
			{
				Dog doggie = (Dog) anAnimal;
				doggie.Bark();
			}
			else if (anAnimal is Cat)
			{
					Cat aCat = (Cat) anAnimal;
					aCat.Meow();
			}

//			Dog doggie = anAnimal as Dog;
//			if (doggie != null)
//			{
//				doggie.Bark();
//			}
		}
	}
}
