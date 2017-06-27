//Test.cs
using System;

namespace RTTIExample
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Dog spencer = new Dog();
			Cat snow = new Cat();
			Trainer jimmy = new Trainer();

			jimmy.Train(spencer);
			jimmy.Train(snow);
		}
	}
}
