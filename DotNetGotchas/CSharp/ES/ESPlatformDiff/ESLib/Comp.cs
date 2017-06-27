// Comp.cs part of ESLib.dll
using System;
using System.EnterpriseServices;

namespace ESLib
{
	[Transaction(TransactionOption.Required), JustInTimeActivation]
	public class Comp : ServicedComponent
	{
		private int theKey;
		private int theVal;

		internal void init(int key)
		{
			ContextUtil.MyTransactionVote 
				= TransactionVote.Abort;

			theKey = key;
			theVal = key * 10;

			ContextUtil.MyTransactionVote 
				= TransactionVote.Commit;
		}

		public int GetValue()
		{
			return theVal;
		}

		public void SetValue(int val)
		{
			ContextUtil.MyTransactionVote 
				= TransactionVote.Abort;

			theVal = val;

			if (val < 0)
			{
				ContextUtil.DeactivateOnReturn = true;
				throw new ApplicationException(
						"Invalid value");
			}

			ContextUtil.MyTransactionVote 
				= TransactionVote.Commit;
		}
	}
}
