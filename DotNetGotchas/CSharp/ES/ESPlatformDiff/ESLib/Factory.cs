// Factory.cs part of ESLib.dll
using System;
using System.EnterpriseServices;

namespace ESLib
{
	[Transaction(TransactionOption.Required), JustInTimeActivation]
	public class Factory : ServicedComponent
	{
		public Comp CreateComp(int key)
		{
			ContextUtil.MyTransactionVote 
				= TransactionVote.Abort;

			Comp theComp = new Comp();
			theComp.init(key);

			ContextUtil.MyTransactionVote 
				= TransactionVote.Commit;

			return theComp;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				ContextUtil.DeactivateOnReturn = true;
			}
			base.Dispose (disposing);
		}

	}
}
