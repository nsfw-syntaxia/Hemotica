using System;
using System.Data.OleDb;
using System.IO;

namespace Hemotica
{
	abstract public class User
	{
		private string email;
		private string username;
		private string password;
		private string contactNumber;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public string ContactNumber
		{
			get { return contactNumber; }
			set { contactNumber = value; }
		}
	}

	public class Donor : User
	{
		private string firstName;
		private string middleName;
		private string lastName;
		private string gender;
		private string age;
		private string barangay;
		private string city;
		private string province = "Cebu";
		private string bloodType;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string MiddleName
		{
			get { return middleName; }
			set { middleName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		public string Age
		{
			get { return age; }
			set { age = value; }
		}

		public string Barangay
		{
			get { return barangay; }
			set { barangay = value; }
		}

		public string City
		{
			get { return city; }
			set { city = value; }
		}

		public string Province
		{
			get { return province; }
			set { province = value; }
		}

		public string BloodType
		{
			get { return bloodType; }
			set { bloodType = value; }
		}
	}

	public class Hospital : User
	{
		private string hospitalName;
		private string licenseNumber;
		private string classification;
		private string weekdayStart;
		private string weekdayEnd;
		private string weekendStart;
		private string weekendEnd;
		private string address;

		public string HospitalName
		{
			get { return hospitalName; }
			set { hospitalName = value; }
		}

		public string LicenseNumber
		{
			get { return licenseNumber; }
			set { licenseNumber = value; }
		}

		public string Classification
		{
			get { return classification; }
			set { classification = value; }
		}

		public string WeekdayStart
		{
			get { return weekdayStart; }
			set { weekdayStart = value; }
		}

		public string WeekdayEnd
		{
			get { return weekdayEnd; }
			set { weekdayEnd = value; }
		}

		public string WeekendStart
		{
			get { return weekendStart; }
			set { weekendStart = value; }
		}

		public string WeekendEnd
		{
			get { return weekendEnd; }
			set { weekendEnd = value; }
		}

		public string Address
		{
			get { return address; }
			set { address = value; }
		}
	}

	public class Admin : User
	{
		//
	}

	public static class UserLogs
	{
		public static string Username { get; set; } = null;
		public static string UserType { get; set; } = null;
		public static string Login { get; set; } = null;
		public static string Logout { get; set; } = null;

		public static void endSession()
		{
			Username = null;
			UserType = null;
		}

		public static void setLogin()
		{
			Login = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
		}

		public static void setLogout()
		{
			Logout = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
		}

		internal static void LogoutUser(Database db)
		{
			if (!string.IsNullOrEmpty(Username))
			{
				setLogout();
				string logoutSession = Logout;

				string logoutQuery = @"UPDATE UserLogs SET [Logout Session] = ? WHERE [Username] = ? AND [User Type] = ? AND [Logout Session] IS NULL";
				OleDbParameter[] logoutParameters =
				{
					new OleDbParameter("?", logoutSession),
					new OleDbParameter("?", Username),
					new OleDbParameter("?", UserType)
				};

				db.executeNonQuery(logoutQuery, logoutParameters);
				endSession();
			}
		}

		internal static void LoginUser(Database db)
		{
			setLogin();
			string loginSession = Login;

			string loginQuery = "INSERT INTO UserLogs ([Username], [User Type], [Login Session]) VALUES (?, ?, ?)";
			OleDbParameter[] loginParameters =
			{
				new OleDbParameter("?", Username),
				new OleDbParameter("?", UserType),
				new OleDbParameter("?", Login)
			};

			db.executeNonQuery(loginQuery, loginParameters);
		}
	}
}
