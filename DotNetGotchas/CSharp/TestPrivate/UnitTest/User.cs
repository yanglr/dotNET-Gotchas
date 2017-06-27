//User.cs
using System;
using System.Security.Cryptography;

namespace UnitTest
{
	public class User
	{
		private string password;

		public void ChangePassword(
			string oldPassword, string thePassword)
		{
			// Make sure that the caller is either creating 
			// a new password, or knows the old password
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

		internal string GetPassword()
		{
			return password;
		}

		private string CreateHash(string input)
		{
			byte[] hashCode = new SHA256Managed().ComputeHash(
				System.Text.Encoding.ASCII.GetBytes(input));

			return BitConverter.ToString(hashCode);
		}
	}
}
