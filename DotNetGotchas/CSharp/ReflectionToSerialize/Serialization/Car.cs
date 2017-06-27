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

		public Car(int year, Engine anEngine)
		{
			yearOfMake = year;
			theEngine = anEngine;
		}

		public override string ToString()
		{
			return yearOfMake + ":" + theEngine;
		}

		#region ISerializable Members

		public Car(SerializationInfo info, 
			StreamingContext context)
		{
			yearOfMake = info.GetInt32("yearOfMake");
			theEngine = info.GetValue("theEngine", 
					typeof(Engine)) as Engine;
		}

		public void GetObjectData(SerializationInfo info, 
			StreamingContext context)
		{
			info.AddValue("yearOfMake", yearOfMake);
			info.AddValue("theEngine", theEngine);
		}

		#endregion
	}
}
