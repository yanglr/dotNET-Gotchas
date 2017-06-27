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

		//...
		class CallMethod1Helper
		{
			private SomeClass theTarget;
			private int theValue;
			public CallMethod1Helper(int val, SomeClass target)
			{
				theValue = val;
				theTarget = target;
			}

			private void CallMethod1()
			{
				theTarget.Method1(theValue);
			}

			public void Run()
			{
				new Thread(
					new ThreadStart(CallMethod1)).Start();
			}
		}

		public void DoSomething(int val)
		{
			// Some operation...

			// Want to call Method1 in different thread
			// from here?
			CallMethod1Helper helper = new CallMethod1Helper(
				val, this);
			helper.Run();

			// Some operation...
		}
	}
}
