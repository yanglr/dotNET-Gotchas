//Test.cs
using System;
using NUnit.Framework;

namespace DivisionByZeroExample
{
	[TestFixture]
	public class Test
	{
		private Calculator calc;

		[SetUp]
		public void Setup()
		{
			calc = new Calculator();
		}

		[Test]
		public void TestSimpleDivide()
		{
			Assert.AreEqual(2, calc.Divide(4, 2));
		}

		[Test, ExpectedException(typeof(DivideByZeroException))]
		public void TestDivisionByZero()
		{
			calc.Divide(4, 0);
		}
	}
}