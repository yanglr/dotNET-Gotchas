using System;

namespace ValTypeProp
{
	struct A
	{
		public int val;
	}

	class Test
	{
		private A theA;

		public Test()
		{
			theA = new A();
		}

		public A MyValue
		{
			get { return theA; }
			set { theA = value; }
		}

		[STAThread]
		static void Main(string[] args)
		{
			Test obj = new Test();

			A myValue = obj.MyValue;
			myValue.val = 4;

			Console.WriteLine(obj.MyValue.val);
		}
	}
}
