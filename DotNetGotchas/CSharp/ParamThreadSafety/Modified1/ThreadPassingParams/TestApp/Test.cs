//Test.cs part of TestApp.exe
using System;
using ALib;

namespace TestApp
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("Main running in Thread {0}",
				AppDomain.GetCurrentThreadId());
			SomeClass anObject = new SomeClass();
			anObject.DoSomething(5);
		}
	}
}
