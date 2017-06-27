//Employee.cs
using System;

namespace ProblemPolymorphismConstruction
{
	public class Employee
	{
		public Employee()
		{
			Console.WriteLine("Employee's constructor called");

			Work();
		}

		public virtual void Work()
		{
			Console.WriteLine("Employee is working");
		}
	}
}
