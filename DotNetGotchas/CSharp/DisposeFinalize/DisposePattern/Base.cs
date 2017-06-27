//Base.cs
using System;

public class Base : IDisposable
{
	private bool disposed = false;
	private readonly int id;

	public Base(int theID)
	{
		id = theID;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			if (disposing)
			{
				Console.WriteLine(
					"Base Cleaning up managed resources on {0}",
					id);

				// Code to clean up managed resources
			}

			Console.WriteLine(
				"Base Cleaning up unmanaged resources on {0}", id);

			// Code to clean up unmanaged resources
		}

		disposed = true;
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	~Base()
	{
		Console.WriteLine("*** Finalize called on Base {0}", id);
		Dispose(false);
	}
}
