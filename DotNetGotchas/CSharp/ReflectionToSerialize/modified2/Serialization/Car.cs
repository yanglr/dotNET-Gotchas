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
			SerializationHelper.SetData(typeof(Car), this, info);
		}

		public virtual void GetObjectData(SerializationInfo info, 
			StreamingContext context)
		{
			SerializationHelper.GetData(typeof(Car), this, info);
		}

		#endregion
	}
}
