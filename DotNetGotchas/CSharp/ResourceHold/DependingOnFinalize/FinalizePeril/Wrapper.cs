//Wrapper.cs
using System;
using ACOMCompLib;

namespace FinalizePeril
{
	public class Wrapper : IDisposable
	{
		IMyComp comp = new MyCompClass();

		public int doSomething()
		{
			int result;
			comp.doSomething(out result);	
			return result;
		}

		~Wrapper()
		{
			System.Runtime.InteropServices.Marshal.ReleaseComObject(comp);
		}

		#region IDisposable Members

		public void Dispose()
		{
			System.Runtime.InteropServices.Marshal.ReleaseComObject(comp);
		}

		#endregion
	}
}
