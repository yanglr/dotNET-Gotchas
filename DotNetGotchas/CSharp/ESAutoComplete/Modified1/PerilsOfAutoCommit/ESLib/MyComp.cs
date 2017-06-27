//MyComp.cs as part of ESLib.dll
using System;
using System.EnterpriseServices;

namespace ESLib
{
	[Transaction(TransactionOption.Required)]
	public class MyComp : ServicedComponent
	{
		private string theMessage = "UnSet";

		//[AutoComplete]
		public void SetInfo(string msg)
		{
			ContextUtil.MyTransactionVote 
				= TransactionVote.Abort;

			theMessage = msg;

			// If something is wrong, throw exception 
			// and the vote will remain in Abort.

			ContextUtil.MyTransactionVote 
				= TransactionVote.Commit;
		}

		//[AutoComplete]
		public string GetInfo()
		{
			ContextUtil.MyTransactionVote 
				= TransactionVote.Abort;

			// If something is wrong, throw exception 
			// and the vote will remain in Abort.
			ContextUtil.MyTransactionVote 
				= TransactionVote.Commit;

			return theMessage;
		}
	}
}
