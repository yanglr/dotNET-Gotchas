//Manager.cs
using System;

namespace ProblemPolymorphismConstruction
{
	public class Manager : Employee
	{
		private Room theRoom = null;
		private int managementLevel = 0;

		public Manager(int level)
		{
			Console.WriteLine("Manager's constructor called");

			managementLevel = level;

			if (level < 2)
                theRoom = new Room();
			else
				theRoom = new ExecutiveRoom();
		}

		public override void Work()
		{
			Console.WriteLine("Manager's work called");

			theRoom.OpenWindow();
			base.Work();
		}
	}
}
