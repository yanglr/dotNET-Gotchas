//Person.cs

using System;

namespace Copy
{
	public class Person : ICloneable
	{
		private int theAge;
		private Brain theBrain;

		public Person(int age, Brain aBrain)
		{
			theAge = age;
			theBrain = aBrain;
		}

		protected Person(Person another)
		{
			theAge = another.theAge;

			theBrain = another.theBrain.Clone() as Brain;
		}

		public override string ToString()
		{
			return "This is person with age " +
					   theAge + " and " + 
                       theBrain;
		}

		#region ICloneable Members

		public virtual object Clone()
		{
			return new Person(this);
		}

		#endregion
	}
}
