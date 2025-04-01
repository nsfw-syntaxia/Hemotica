using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Hemotica
{
	internal class ExceptionHandling
	{
		public static bool validEmailAddress(string email)
		{
			return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
		}

		public static bool validAge(string ageString, out int age)
		{
			return int.TryParse(ageString, out age) && age >= 1 && age <= 120;
		}

		public static bool validContactNumber(string number)
		{
			return Regex.IsMatch(number, @"^(\(\d{3}\) \d{3}-\d{4}|\d{10,15})$");
		}
	}
}
