//SomeClass.cs part of ALib.dll
using System;
using System.Threading;

namespace ALib
{
	public class SomeClass
	{
		private void Method1(int val)
		{
			// Some operation takes place here
			Console.WriteLine(
				"Method1 runs on Thread {0} with {1}",
				AppDomain.GetCurrentThreadId(), val);
		}

		private int theValToUseByCallMethod1;

		private void CallMethod1()
		{
			Method1(theValToUseByCallMethod1);
		}

		public void DoSomething(int val)
		{
			// Some operation...

			// Want to call Method1 in different thread
			// from here?
			theValToUseByCallMethod1 = val;
			new Thread(new ThreadStart(CallMethod1)).Start();

			// Some operation...
		}
	}
}
