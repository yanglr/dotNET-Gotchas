//AType.cs
using System;

namespace ValTypeRefTypeAssignment
{
	public class AType
	{
		private int aField;

		public int TheValue
		{
			get { return aField; }
			set { aField = value; }
		}
	}
}
