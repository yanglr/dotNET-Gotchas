//Test.cs part of C# project Iterateover.exe
using System;

namespace IterateOver
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			object[] objects = new object[3];

			for(int i = 0; i < 3; i++)
			{
				objects[i] = new object();
			}

			foreach(Object anObj in objects)
			{
				Console.WriteLine(anObj.GetHashCode());
			}
		}
	}
}
