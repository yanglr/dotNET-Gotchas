//Test.cs
using System;

namespace COMCompUser
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("Creating object");
			MyCOMCompLib.IMyComp theMyComp 
				= new MyCOMCompLib.MyCompClass();

			Console.WriteLine("Calling Method1");
			theMyComp.Method1();

			//Console.WriteLine("Releasing the object");
			//System.Runtime.InteropServices.Marshal.ReleaseComObject(
			//	theMyComp);

			Console.WriteLine("Setting reference to null");
			theMyComp = null;

			Console.WriteLine("Has the Object been destroyed?");
			Console.ReadLine();
		}
	}
}
