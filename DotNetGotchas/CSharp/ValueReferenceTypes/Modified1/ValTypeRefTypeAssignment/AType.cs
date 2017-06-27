//AType.cs
using System;

namespace ValTypeRefTypeAssignment
{
	public struct AType
	{
		private int aField;

		public int TheValue
		{
			get { return aField; }
			set { aField = value; }
		}
	}
}
