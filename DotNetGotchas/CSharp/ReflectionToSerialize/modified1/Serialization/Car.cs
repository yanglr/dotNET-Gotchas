//Car.cs
using System;
using System.Runtime.Serialization;

namespace Serialization
{
	[Serializable]
	public class Car : ISerializable	
	{
		private int yearOfMake;
		private Engine theEngine;
		private int miles = 0;

		public Car(int year, Engine anEngine)
		{
			yearOfMake = year;
			theEngine = anEngine;
		}

		public override string ToString()
		{
			return yearOfMake + ":" + miles + ":" + theEngine;
		}

		#region ISerializable Members

		public Car(SerializationInfo info, 
			StreamingContext context)
		{
			yearOfMake = info.GetInt32("yearOfMake");
			theEngine = info.GetValue("theEngine", 
				typeof(Engine)) as Engine;

			try
			{
				miles = info.GetInt32("miles");
			}
			catch(Exception)
			{
				//Shhhhh, let's move on quietly.
			}
		}

		public void GetObjectData(SerializationInfo info, 
			StreamingContext context)
		{
			info.AddValue("yearOfMake", yearOfMake);
			info.AddValue("theEngine", theEngine);
			info.AddValue("miles", miles);
		}

		#endregion
	}
}
