using System;

namespace SuppressFinalize
{
	public class Test : IDisposable
	{
		private readonly int id;
		
		public Test(int theID)
		{
			id = theID;
		}

		~Test()
		{
			Console.WriteLine("Finalize called on {0}", id);
		}

		#region IDisposable Members

		public void Dispose()
		{
			Console.WriteLine("Dispose called on {0}", id);
			GC.SuppressFinalize(this);
		}

		#endregion

		[STAThread]
		static void Main(string[] args)
		{
			int count = 1;
			Test object1 = new Test(count++);
			Test object2 = new Test(count++);

			object1.Dispose();

			Console.WriteLine("Main done");
		}
	}
}
