using System;
using System.Runtime.InteropServices;

namespace InvokeBeep
{
	class Test
	{
		[DllImport("kernel32")]
		public static extern bool Beep(long dwFreq, 
			long dwDuration);

		[STAThread]
		static void Main(string[] args)
		{
			Beep(1000, 1000);
		}
	}
}
