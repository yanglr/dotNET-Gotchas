using System;

namespace WhyNoFinalize
{
	public class SomeClass
	{
		private SomeOtherClass ref1;
		
		public SomeClass(SomeOtherClass givenObject)
		{
			ref1 = givenObject;
		}

		~SomeClass()
		{
			ref1 = null;
		}
	}
}
