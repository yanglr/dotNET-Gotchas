//Test.cs as part of ESUser.exe
using System;
using ESLib;

namespace ESUser
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			MyComp theComp = new MyComp();

			theComp.SetInfo("hello");

			Console.WriteLine(theComp.GetInfo());
		}
	}
}
