//ThreadRunner.cs
using System;
using System.Reflection;
using System.Threading;

namespace ALib
{
	public class ThreadRunnerException : ApplicationException
	{
		public ThreadRunnerException(string message) 
			: base(message) {}
	}

	public class ThreadRunner
	{
		private Delegate toRunDelegate;
		private object[] toRunParameters;
		private Thread theThread;

		public bool IsBackground
		{
			get { return theThread.IsBackground; }
			set { theThread.IsBackground = value; }
		}

		public ThreadRunner(Delegate theDelegate, 
			params object[] theParameters)
		{
			MethodInfo theMethod = theDelegate.Method;

			ParameterInfo[] theParameterInfo 
				= theMethod.GetParameters();

			if (theParameterInfo.Length != theParameters.Length)
			{
				string message 
					= String.Format(
						"Invalid number of parameters - ");
				message 
					+= String.Format(
						"expected {0} received {1}",
						theParameterInfo.Length, 
						theParameters.Length);
				throw new ThreadRunnerException(message);
			}

			for(int i = 0; i < theParameterInfo.Length; i++)
			{
				if (!theParameterInfo[i].
						ParameterType.IsInstanceOfType(
						theParameters[i]))
				{
					string message = String.Format(
                      "Parameter {0} type mismatch - ", i);
					message += String.Format(
						"Expected {0} received {1}",
                        theParameterInfo[i].ParameterType.FullName,
                        theParameters[i].GetType().FullName);
					throw new ThreadRunnerException(message);
				}
			}

			toRunDelegate = theDelegate;
			toRunParameters = theParameters;

			theThread = new Thread(new ThreadStart(Run));
		}

		public void Start()
		{
			theThread.Start();
		}

		private void Run()
		{
			toRunDelegate.DynamicInvoke(toRunParameters);
		}
	}
}
