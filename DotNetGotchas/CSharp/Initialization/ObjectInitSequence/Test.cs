//Test.cs
using System;

namespace ObjectInitSequence
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Derived obj = new Derived();
		}
	}
}
