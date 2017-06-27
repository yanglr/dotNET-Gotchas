//MyComp.cs as part of ESLib.dll
using System;
using System.EnterpriseServices;

namespace ESLib
{
	[Transaction(TransactionOption.Required)]
	public class MyComp : ServicedComponent
	{
		private string theMessage = "UnSet";

		[AutoComplete]
		public void SetInfo(string msg)
		{
			theMessage = msg;
		}

		[AutoComplete]
		public string GetInfo()
		{
			return theMessage;
		}
	}
}
