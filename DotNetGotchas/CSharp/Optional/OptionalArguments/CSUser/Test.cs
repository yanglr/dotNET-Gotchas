//Test.cs part of CSUser.exe
using System;

namespace CSUser
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			AVBDNLibrary.SomeClass1 obj 
				= new AVBDNLibrary.SomeClass1();
			obj.SomeMethod(1, 2);
		}
	}
}
