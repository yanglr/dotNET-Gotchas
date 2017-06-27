//DerivedCar.cs
using System;
using System.Runtime.Serialization;

namespace Serialization
{
	[Serializable]
	public class DerivedCar : Car
	{
		private int someValue;

		public DerivedCar(int year, Engine anEngine, int val)
			: base(year, anEngine)
		{
			someValue = val;
		}

		public DerivedCar(SerializationInfo info, 
			StreamingContext context) 
			: base(info, context)
		{
			SerializationHelper.SetData(
				typeof(DerivedCar), this, info);
		}

		public override void GetObjectData(SerializationInfo info, 
			StreamingContext context)
		{
			base.GetObjectData(info, context);
			SerializationHelper.GetData(
				typeof(DerivedCar), this, info);
		}

		public override string ToString()
		{
			return base.ToString () + ":" + someValue;
		}

	}
}
