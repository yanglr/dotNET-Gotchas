//Program.cs
using System;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace XmlSerializerException
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			ArrayList myList = new ArrayList();
			myList.Add(new SomeType());

			try
			{
				using(FileStream fileStrm 
						  = new FileStream("output.xml",
						  FileMode.Create))
				{
					XmlSerializer theSerializer 
						= new XmlSerializer(
							typeof(ArrayList));
					theSerializer.Serialize(fileStrm, myList);
				}
			}
			catch(InvalidOperationException ex)
			{
				Console.WriteLine(
					"OOps: The Problem is \"{0}\"", 
					ex.Message);
			}
			catch(Exception catchAllEx)
			{
				Console.WriteLine(
					"OOps: The Problem is \"{0}\"", 
					catchAllEx.Message);
				throw;
			}
		}
	}
}
