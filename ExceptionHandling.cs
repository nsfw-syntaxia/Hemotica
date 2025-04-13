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

		public static bool validBirthdate(string birthdate, out DateTime parsedDate)
		{
			parsedDate = default;

			if (!Regex.IsMatch(birthdate, @"^(0[1-9]|1[0-2])/(0[1-9]|[12]\d|3[01])/\d{4}$"))
				return false;

			if (!DateTime.TryParseExact(birthdate, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
				return false;

			return true;
		}
	}
}
