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

			MyCOMCompLib.IMyComp2 theMyComp2 
				= (MyCOMCompLib.IMyComp2) theMyComp;

			Console.WriteLine("Calling Method1");
			theMyComp.Method1();

			Console.WriteLine("Releasing the object");
			System.Runtime.InteropServices.Marshal.ReleaseComObject(
				theMyComp);

			Console.WriteLine("Calling Method2");
			theMyComp2.Method2();
			Console.ReadLine();
		}
	}
}
