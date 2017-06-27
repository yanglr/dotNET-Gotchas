using System;
using System.Data;

namespace ReadingXML
{
	class Test
	{
		private static void timeRead(bool fetchSchema)
		{
			DataSet ds = new DataSet();

			int startTime = Environment.TickCount;

			if (fetchSchema)
			{
				ds.ReadXmlSchema(@"..\..\data.xsd");
			}

			ds.ReadXml(@"..\..\data.xml");
			
			int endTime = Environment.TickCount;
	
			Console.WriteLine(
				"Time taken to read {0} rows is {1} ms",
				ds.Tables[0].Rows.Count,
				(endTime - startTime));
		}

		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("Reading XML into DataSet");
			timeRead(false);

			Console.WriteLine(
			"Reading XML into DataSet after reading Schema");
			timeRead(true);
		}
	}
}
