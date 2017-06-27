using System;

namespace Singleton
{
	public class MySingleton
	{
		public readonly DateTime creationTime;

		protected MySingleton()
		{
			creationTime = DateTime.Now;
		}

		protected static MySingleton theInstance =
			new MySingleton();

		public static MySingleton GetInstance()
		{
			return theInstance;
		}
	}
}
