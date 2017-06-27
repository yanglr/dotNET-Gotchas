//Test.cs
using System;

namespace COMCompUser
{
	class Test
	{
		//...
		[MTAThread] // You will see the effect of this attribute
		static void Main(string[] args)
		//...
		{
			MyCOMCompLib.IMyComp theMyComp 
				= new MyCOMCompLib.MyCompClass();

			theMyComp.Method1();
		}
	}
}
