//Test.cs
using System;

namespace UnInitializedDelegate
{
	public class Test
	{
		private void callback1()
		{
			Console.WriteLine("callback1 called");
		}

		private void callback2()
		{
			Console.WriteLine("callback2 called");
		}

		private void Work()
		{
			AComponent obj = new AComponent();

			Console.WriteLine("Registering 2 callbacks");
			obj.myEvent += new DummyDelegate(callback1);
			obj.myEvent += new DummyDelegate(callback2);
			obj.Fire();

			Console.WriteLine("Removing 1 callback");
			obj.myEvent -= new DummyDelegate(callback2);
			obj.Fire();
			
			Console.WriteLine("Removing the other callback");
			obj.myEvent -= new DummyDelegate(callback1);
			obj.Fire();
		}

		[STAThread]
		static void Main(string[] args)
		{
			Test testObj = new Test();
			testObj.Work();
		}
	}
}
