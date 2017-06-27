//StopWatch.cs part of CSLib.dll
using System;

namespace CSLib
{
	public class StopWatch
	{
		public virtual void Start() {}

		public virtual void Stop() {}

		public virtual void Reset()
		{
		}

		public int ElapasedTime
		{
			get { return 0; }
		}
	}
}
