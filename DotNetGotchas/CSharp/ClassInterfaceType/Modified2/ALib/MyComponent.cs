using System;
using System.Runtime.InteropServices;

namespace ALib
{
	[Guid("74555C62-75CD-4c87-940A-4AE8A69FFCB2"), 
		InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IMy
	{
		void Method1();
	}

	[Guid("53DEF193-D7A4-4ce3-938E-A7A35B5F7AB7"), 
		ClassInterface(ClassInterfaceType.None)]
	public class MyComponent : IMy
	{
		public void Method1()
		{
			//...
		}
	}
}				
