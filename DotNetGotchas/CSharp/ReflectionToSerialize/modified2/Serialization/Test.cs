//Test.cs
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
	class Test
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine(
				"Enter s to serialize, d to deserialize");
			string input = Console.ReadLine();

			if (input.ToUpper() == "S")
			{
				Car aCar = new Car(2004, new Engine(500));
				//Car aCar = new DerivedCar(2004, new Engine(500), 22);

				Console.WriteLine("Serializing " + aCar);

				FileStream strm = new FileStream("output.dat", 
					FileMode.Create, FileAccess.Write);
				BinaryFormatter formatter = 
					new BinaryFormatter();
				formatter.Serialize(strm, aCar);
				strm.Close();
			}
			else
			{
				FileStream strm = new FileStream("output.dat", 
					FileMode.Open, FileAccess.Read);
				BinaryFormatter formatter 
					= new BinaryFormatter();
				Car aCar = formatter.Deserialize(strm) as Car;
				strm.Close();
				Console.WriteLine("DeSerialized " + aCar);
			}
		}
	}
}
