// Factory.cs part of ESLib.dll
using System;
using System.EnterpriseServices;

namespace ESLib
{
	public interface ITransactionCoordinator
	{
		void SetVoteToAbort();
	}

	[Transaction(TransactionOption.Required), JustInTimeActivation]
	public class Factory : ServicedComponent, ITransactionCoordinator
	{
		public Comp CreateComp(int key)
		{
			ContextUtil.MyTransactionVote 
				= TransactionVote.Abort;

			Comp theComp = new Comp();
			
			theComp.TheTransactionCoordinator = this;

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

		#region ITransactionCoordinator Members

		public void SetVoteToAbort()
		{
			ContextUtil.MyTransactionVote 
				= TransactionVote.Abort;
		}

		#endregion
	}
}
