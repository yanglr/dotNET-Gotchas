//Wrapper.cs
using System;
using ACOMCompLib;

namespace FinalizePeril
{
	public class Wrapper : IDisposable
	{
		IMyComp comp = new MyCompClass();
		bool disposed = false;

		public int doSomething()
		{
			if (disposed) 
				throw new ObjectDisposedException(null);

			int result;
			comp.doSomething(out result);	
			return result;
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				// No managed resources to clean up
				// Clean up unmanaged resources regardless of who called us
				System.Runtime.InteropServices.Marshal.ReleaseComObject(comp);
				GC.SuppressFinalize(this);
				disposed = true;
			}
		}

		~Wrapper()
		{
			Dispose(false);
		}

		#region IDisposable Members

		public void Dispose()
		{
			Dispose(true);
		}

		#endregion
	}
}
