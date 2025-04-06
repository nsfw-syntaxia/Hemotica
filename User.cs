using System;
using System.Data;
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

		internal DataTable loadDonors(Database db)
		{
			string hospitalAccess = "All";

			string query = @"SELECT [Donor ID], [First Name], [Middle Name], [Last Name], Gender, Age, [Contact Number], [Blood Type], Barangay, City, Province FROM Donors
							 WHERE Hospital = ? OR Hospital = ?";

			OleDbParameter[] parameters = 
			{
				new OleDbParameter("?", hospitalAccess),
				new OleDbParameter("?", UserLogs.Username)
			};

			return db.executeQuery(query, parameters);
		}

		internal bool deleteDonorAccount(Database db)
		{
			string query = "DELETE FROM Donors WHERE [Username] = ?";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);
					cmd.Parameters.AddWithValue("?", UserLogs.Username);

					conn.Open();
					cmd.ExecuteNonQuery();
					conn.Close();

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private string generateWalkIn(Database db)
		{
			string query = "SELECT MAX(Val(Mid([Username], 13))) AS MaxNumber FROM Donors WHERE Username LIKE ?";
			OleDbParameter[] parameters = { new OleDbParameter("?", "donor_walkin%") };
			DataTable dt = db.executeQuery(query, parameters);

			int nextNumber = 1;
			if (dt.Rows.Count > 0 && dt.Rows[0]["MaxNumber"] != DBNull.Value)
			{
				nextNumber = Convert.ToInt32(dt.Rows[0]["MaxNumber"]) + 1;
			}

			return $"donor_walkin{nextNumber}";
		}

		internal bool addDonor(Database db)
		{
			string donorUsername = generateWalkIn(db);
			string hospitalUsername = UserLogs.Username;

			string query = @"INSERT INTO Donors ([Username], [First Name], [Middle Name], [Last Name], [Gender], [Age], [Barangay], [City], [Province], [Contact Number], [Blood Type], [Hospital]) 
							 VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);

					cmd.Parameters.AddWithValue("?", donorUsername);
					cmd.Parameters.AddWithValue("?", FirstName);
					cmd.Parameters.AddWithValue("?", MiddleName);
					cmd.Parameters.AddWithValue("?", LastName);
					cmd.Parameters.AddWithValue("?", Gender);
					cmd.Parameters.AddWithValue("?", Age);
					cmd.Parameters.AddWithValue("?", Barangay);
					cmd.Parameters.AddWithValue("?", City);
					cmd.Parameters.AddWithValue("?", Province);
					cmd.Parameters.AddWithValue("?", ContactNumber);
					cmd.Parameters.AddWithValue("?", BloodType);
					cmd.Parameters.AddWithValue("?", hospitalUsername);

					conn.Open();
					cmd.ExecuteNonQuery();
					conn.Close();

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
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

		internal DataTable loadAppointments(Database db)
		{
			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string query = $@"SELECT Appointments.[Appointment ID], Donors.[First Name], Donors.[Middle Name], Donors.[Last Name], Donors.Gender, Donors.Age, Donors.[Blood Type], 
							  Donors.[Contact Number], Appointments.[Appointment Date], Appointments.Status FROM Hospitals 
							  INNER JOIN (Donors INNER JOIN Appointments ON Donors.Username = Appointments.[Donor Username]) ON Hospitals.[Hospital Name] = Appointments.Hospital
							  WHERE Appointments.Hospital = ? ORDER BY Appointments.[Appointment Date] ASC";

			OleDbParameter[] parametersAppointments = { new OleDbParameter("?", hospitalName) };
			return db.executeQuery(query, parametersAppointments);
		}
	}

	public class Admin : User
	{
		//
	}

	public class Patient : Donor
	{
		private string request;
		private string priority;

		public string Request
		{
			get { return request; }
			set { request = value; }
		}

		public string Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		internal DataTable loadPatients(Database db)
		{
			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string query = $@"SELECT [Patient ID], [First Name], [Middle Name], [Last Name], Gender, Age, [Contact Number], [Blood Type], Request, Priority, Barangay, City, Province FROM Patients 
							  WHERE [Hospital] = ?";

			OleDbParameter[] parametersPatients = { new OleDbParameter("?", hospitalName) };
			return db.executeQuery(query, parametersPatients);
		}

		internal bool addPatient(Database db)
		{
			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();
			string hospitalUsername = UserLogs.Username;

			string query = @"INSERT INTO Donors ([First Name], [Middle Name], [Last Name], [Gender], [Age], [Contact Number], [Blood Type], [Request], [Priority], [Barangay], [City], [Province],  
							 [Hospital]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			
			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);

					cmd.Parameters.AddWithValue("?", FirstName);
					cmd.Parameters.AddWithValue("?", MiddleName);
					cmd.Parameters.AddWithValue("?", LastName);
					cmd.Parameters.AddWithValue("?", Gender);
					cmd.Parameters.AddWithValue("?", Age);
					cmd.Parameters.AddWithValue("?", ContactNumber);
					cmd.Parameters.AddWithValue("?", BloodType);
					cmd.Parameters.AddWithValue("?", Request);
					cmd.Parameters.AddWithValue("?", Priority);
					cmd.Parameters.AddWithValue("?", Barangay);
					cmd.Parameters.AddWithValue("?", City);
					cmd.Parameters.AddWithValue("?", Province);
					cmd.Parameters.AddWithValue("?", hospitalUsername);
					
					conn.Open();
					cmd.ExecuteNonQuery();
					conn.Close();

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		internal bool updatePatient(Database db, int patientID)
		{
			string query = @"UPDATE Patients SET [First Name] = ?, [Middle Name] = ?, [Last Name] = ?, [Gender] = ?, [Age] = ?, [Contact Number] = ?, [Blood Type] = ?, [Request] = ?,
							 [Priority] = ?, [Barangay] = ?, [City] = ?, [Province] = ? WHERE [Patient ID] = ?";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					using (OleDbCommand cmd = new OleDbCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("?", FirstName);
						cmd.Parameters.AddWithValue("?", MiddleName);
						cmd.Parameters.AddWithValue("?", LastName);
						cmd.Parameters.AddWithValue("?", Gender);
						cmd.Parameters.AddWithValue("?", Age);
						cmd.Parameters.AddWithValue("?", ContactNumber);
						cmd.Parameters.AddWithValue("?", BloodType);
						cmd.Parameters.AddWithValue("?", Request);
						cmd.Parameters.AddWithValue("?", Priority);
						cmd.Parameters.AddWithValue("?", Barangay);
						cmd.Parameters.AddWithValue("?", City);
						cmd.Parameters.AddWithValue("?", Province);
						cmd.Parameters.AddWithValue("?", patientID);

						conn.Open();
						cmd.ExecuteNonQuery();
						conn.Close();

						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		internal bool deletePatient(int patientID, Database db)
		{
			string query = "DELETE FROM Patients WHERE [Patient ID] = ?";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);
					cmd.Parameters.AddWithValue("?", patientID);

					conn.Open();
					cmd.ExecuteNonQuery();
					conn.Close();

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}

	public class Physician : Donor
	{
		private string specialization;
		private string license;

		public string Specialization
		{
			get { return specialization; }
			set { specialization = value; }
		}

		public string License
		{
			get { return license; }
			set { license = value; }
		}

		internal DataTable loadPhysicians(Database db)
		{
			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string query = $@"SELECT [Physician ID], [First Name], [Middle Name], [Last Name], Gender, Age, Specialization, [License Number], [Contact Number] FROM Physicians 
							  WHERE [Hospital] = ?";

			OleDbParameter[] parametersPhysicians = { new OleDbParameter("?", hospitalName) };
			return db.executeQuery(query, parametersPhysicians);
		}

		internal bool addPhysician(Database db)
		{
			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();
			string hospitalUsername = UserLogs.Username;

			string query = @"INSERT INTO Physicians ([First Name], [Middle Name], [Last Name], [Gender], [Age], [Specialization], [License Number], [Contact Number], [Hospital Username], [Hospital]) 
							 VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);

					cmd.Parameters.AddWithValue("?", FirstName);
					cmd.Parameters.AddWithValue("?", MiddleName);
					cmd.Parameters.AddWithValue("?", LastName);
					cmd.Parameters.AddWithValue("?", Gender);
					cmd.Parameters.AddWithValue("?", Age);
					cmd.Parameters.AddWithValue("?", Specialization);
					cmd.Parameters.AddWithValue("?", License);
					cmd.Parameters.AddWithValue("?", ContactNumber);
					cmd.Parameters.AddWithValue("?", hospitalUsername);
					cmd.Parameters.AddWithValue("?", hospitalName);

					conn.Open();
					cmd.ExecuteNonQuery();
					conn.Close();

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		internal bool updatePhysician(Database db, int physicianID)
		{
			string query = @"UPDATE Physicians SET [First Name] = ?, [Middle Name] = ?, [Last Name] = ?, [Gender] = ?, [Age] = ?, [Specialization] = ?, [License Number] = ?, 
							 [Contact Number] = ? WHERE [Physician ID] = ?";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					using (OleDbCommand cmd = new OleDbCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("?", FirstName);
						cmd.Parameters.AddWithValue("?", MiddleName);
						cmd.Parameters.AddWithValue("?", LastName);
						cmd.Parameters.AddWithValue("?", Gender);
						cmd.Parameters.AddWithValue("?", Age);
						cmd.Parameters.AddWithValue("?", Specialization);
						cmd.Parameters.AddWithValue("?", License);
						cmd.Parameters.AddWithValue("?", ContactNumber);
						cmd.Parameters.AddWithValue("?", physicianID);

						conn.Open();
						cmd.ExecuteNonQuery();
						conn.Close();

						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		internal bool deletePhysician(int patientID, Database db)
		{
			string query = "DELETE FROM Physicians WHERE [Physician ID] = ?";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);
					cmd.Parameters.AddWithValue("?", patientID);

					conn.Open();
					cmd.ExecuteNonQuery();
					conn.Close();

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
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
