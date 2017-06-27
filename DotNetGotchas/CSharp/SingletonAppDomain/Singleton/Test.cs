using System;
using System.Threading;
using System.Reflection;

namespace Singleton
{
	class Test : MarshalByRefObject
	{
		public void Run()
		{
			MySingleton object1 = MySingleton.GetInstance();

			Console.WriteLine("Object created at {0}",
				object1.creationTime.ToLongTimeString());

			Thread.Sleep(1000);

			MySingleton object2 = MySingleton.GetInstance();
			Console.WriteLine("Object created at {0}",
				object1.creationTime.ToLongTimeString());
		}

		[STAThread]
		static void Main(string[] args)
		{
			Test anObject = new Test();

			anObject.Run();
			Thread.Sleep(1000);

			AppDomain domain = 
				AppDomain.CreateDomain("MyDomain");
			Test proxy = 
				domain.CreateInstance(
					Assembly.GetExecutingAssembly().FullName,
				typeof(Test).FullName).Unwrap() as Test;
			proxy.Run();

			Thread.Sleep(1000);
			anObject.Run();

		}
	}
}
