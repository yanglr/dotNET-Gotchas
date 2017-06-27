using System;

namespace DelegateThread
{
	class Test
	{
		private static void Method1(int val)
		{
			Console.Write("Method 1 called from Thread {0}",
				AppDomain.GetCurrentThreadId());
			Console.WriteLine(" with value {0}", val);
		}

		delegate void Method1Delegate(int val);

		[STAThread]
		static void Main(string[] args)
		{
			// It is not so easy to call Method1 from
			// another thread using the Thread class.

			Method1Delegate dlg = new Method1Delegate(Method1);
			IAsyncResult handle = dlg.BeginInvoke(2, null, null);

			Console.ReadLine();
		}
	}
}
