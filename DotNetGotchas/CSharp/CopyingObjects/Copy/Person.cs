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
			theBrain = new Brain(another.theBrain);
			// You rely on the copy constructor of Brain
			//to make a good deep copy
		}

		public override string ToString()
		{
			return "This is person with age " +
					   theAge + " and " + 
                       theBrain;
		}

	}
}
