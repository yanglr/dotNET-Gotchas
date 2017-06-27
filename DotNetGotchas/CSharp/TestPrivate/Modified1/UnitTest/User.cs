using System;
using System.Security.Cryptography;
using NUnit.Framework;

namespace UnitTest
{
	public class User
	{
		private string password;

		public void ChangePassword(
			string oldPassword, string thePassword)
		{
			if ((password == null && oldPassword == null)
				|| CreateHash(oldPassword) == password)
			{
				password = CreateHash(thePassword);
			}
			else
			{
				throw new ApplicationException("Invalid password");
			}
		}

		private string CreateHash(string input)
		{
			byte[] hashCode = new SHA256Managed().ComputeHash(
				System.Text.Encoding.ASCII.GetBytes(input));

			return BitConverter.ToString(hashCode);
		}

		// In .NET 2.0, with Partial Classes, this can be 
		// in a separate file
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

				Assert.AreEqual(theUser.password, theUser.CreateHash(PASSWORD));
			}
		}
	}
}
