// AComponent.cs
using System;

namespace UnInitializedDelegate
{
	public delegate void DummyDelegate();

	public class AComponent
	{
		public event DummyDelegate myEvent;

		protected virtual void OnMyEvent()
		{
			myEvent();
		}

		public void Fire()
		{
			Console.WriteLine("Raising event");
			OnMyEvent(); // Raising the event
			Console.WriteLine("Done raising event");
		}
	}
}
