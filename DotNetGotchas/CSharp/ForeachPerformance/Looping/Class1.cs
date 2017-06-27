using System;
using System.Collections;

namespace Looping
{
	class Class1
	{
		[STAThread]
		static void Main(string[] args)
		{
			int[] myArray = null;

for (int i = 0; i < myArray.Length; i++)
{
	int theValue = myArray[i];
	// Use theValue for whatever...
}

// or, we may also write:
IEnumerator iter = myArray.GetEnumerator();
while(iter.MoveNext())
{
	int theValue = (int) iter.Current;
	// Use theValue for whatever…
}

// And finally, we may write
foreach(int theValue in myArray)
{
	// Use theValue for whatever…
}
		}
	}
}
