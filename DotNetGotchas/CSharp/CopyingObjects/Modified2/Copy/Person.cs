//Person.cs

using System;

namespace Copy
{
	public class Person
	{
		private int theAge;
		private Brain theBrain;

		public Person(int age, Brain aBrain)
		{
			theAge = age;
			theBrain = aBrain;
		}

		public Person(Person another)
		{
			theAge = another.theAge;

			if(another.theBrain is SmarterBrain)
			{
				theBrain = new SmarterBrain(
					(SmarterBrain) another.theBrain);
			}
			else
			{
				theBrain = new Brain(another.theBrain);
			}
		}

		public override string ToString()
		{
			return "This is person with age " +
					   theAge + " and " + 
                       theBrain;
		}

	}
}
