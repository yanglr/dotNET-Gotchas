//Test.cs
using System;
using NUnit.Framework;
using System.Security.Cryptography;

namespace UnitTest
{
	[TestFixture]
	public class Test
	{
		private User theUser;

		[SetUp]
		public void CreateUser()
		{
			theUser = new User();
		}

		[Test]
		public void TestSetPassword()
		{
			string PASSWORD = "Cod!ng";

			theUser.ChangePassword(null, PASSWORD);
			// How do you assert that the password has been set?
			// You can rely on calling the GetPassword method to do this.
			// However, do you really want to provide a 
			// method to get the password?
            
			// OK, let’s write one for now.

			byte[] hashCode = new SHA256Managed().ComputeHash(
				System.Text.Encoding.ASCII.GetBytes(PASSWORD));

			string hashCodeString = BitConverter.ToString(hashCode);

			Assert.AreEqual(hashCodeString, theUser.GetPassword());
		}
	}
}
