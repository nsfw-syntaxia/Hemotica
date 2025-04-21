using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
		private string birthdate;
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

		public string Birthdate
		{
			get { return birthdate; }
			set { birthdate = value; }
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
			updateAge(db);

			string hospitalAccess = "All";

			string query = @"SELECT [Donor ID], [First Name], [Middle Name], [Last Name], Gender, Birthdate, Age, [Contact Number], [Blood Type], Barangay, City, Province FROM Donors
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

		internal bool duplicateDonor(Database db)
		{
			string hospitalUsername = UserLogs.Username;

			string query = @"SELECT COUNT(*) FROM Donors WHERE [First Name] = ? AND [Last Name] = ? AND [Birthdate] = ? AND [Blood Type] = ? AND ([Hospital] = ? OR [Hospital] = 'All')";

			OleDbParameter[] checkParameters =
			{
				new OleDbParameter("?", FirstName),
				new OleDbParameter("?", LastName),
				new OleDbParameter("?", Birthdate),
				new OleDbParameter("?", BloodType),
				new OleDbParameter("?", hospitalUsername)
			};

			object result = db.executeScalar(query, checkParameters);
			if (result != null && Convert.ToInt32(result) > 0)
			{
				return true;
			}
			return false;
		}

		internal bool addDonor(Database db)
		{
			string donorUsername = generateWalkIn(db);
			string hospitalUsername = UserLogs.Username;

			string query = @"INSERT INTO Donors ([Username], [First Name], [Middle Name], [Last Name], [Gender], [Birthdate], [Age], [Barangay], [City], [Province], [Contact Number],
							 [Blood Type], [Hospital]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

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
					cmd.Parameters.AddWithValue("?", Birthdate);
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

		internal bool updateDonor(Database db, int donorID)
		{
			string query = @"UPDATE Donors SET [First Name] = ?, [Middle Name] = ?, [Last Name] = ?, [Gender] = ?, [Birthdate] = ?, [Age] = ?, [Contact Number] = ?, [Blood Type] = ?, 
							 [Barangay] = ?, [City] = ?, [Province] = ? WHERE [Donor ID] = ?";

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
						cmd.Parameters.AddWithValue("?", Birthdate);
						cmd.Parameters.AddWithValue("?", Age);
						cmd.Parameters.AddWithValue("?", ContactNumber);
						cmd.Parameters.AddWithValue("?", BloodType);
						cmd.Parameters.AddWithValue("?", Barangay);
						cmd.Parameters.AddWithValue("?", City);
						cmd.Parameters.AddWithValue("?", Province);
						cmd.Parameters.AddWithValue("?", donorID);

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

		internal bool deleteDonor(int donorID, Database db)
		{
			string query = "DELETE FROM Donors WHERE [Donor ID] = ? AND Hospital = ?";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);

					cmd.Parameters.AddWithValue("?", donorID);
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

		internal virtual void updateAge(Database db)
		{
			string today = DateTime.Today.ToString("MM/dd/yyyy");
			string query = "UPDATE Donors SET [Age] = INT(DATEDIFF('d', [Birthdate], ?) / 365.25)";
			OleDbParameter[] parameters = { new OleDbParameter("?", today) };
			db.executeNonQuery(query, parameters);
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

		internal bool deleteHospitalAccount(Database db)
		{
			string query = "DELETE FROM Hospitals WHERE [Username] = ?";

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

		internal DataTable loadAppointments(Database db)
		{
			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string query = @"SELECT Appointments.[Appointment ID], Donors.[First Name] & ' ' & Donors.[Middle Name] & ' ' & Donors.[Last Name] AS [Donor Name], Donors.Gender, 
							 Donors.Birthdate, Donors.Age, Donors.[Blood Type], Donors.[Contact Number], Appointments.[Appointment Date], Appointments.Status FROM Hospitals 
							 INNER JOIN (Appointments INNER JOIN Donors ON Appointments.[Donor Username] = Donors.Username) ON Hospitals.Username = Appointments.[Hospital Username]
							 WHERE Appointments.Hospital = ? ORDER BY Appointments.[Appointment Date] ASC";

			OleDbParameter[] parametersAppointments = { new OleDbParameter("?", hospitalName) };
			return db.executeQuery(query, parametersAppointments);
		}

		internal DataTable loadExtraction(Database db)
		{
			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();
			
			string query = @"SELECT Extraction.[Extraction ID], Donors.[First Name] & ' ' & Donors.[Middle Name] & ' ' & Donors.[Last Name] AS [Donor Name], Donors.Gender, 
							 Donors.Birthdate, Donors.Age, Donors.[Blood Type], Extraction.[Extraction Date] FROM Donors
							 INNER JOIN (Hospitals INNER JOIN Extraction ON Hospitals.Username = Extraction.[Hospital Username]) ON Donors.Username = Extraction.[Donor Username] 
							 WHERE Extraction.Hospital = ? GROUP BY Extraction.[Extraction ID], Donors.[First Name], Donors.[Middle Name], Donors.[Last Name], Donors.Gender, 
							 Donors.Birthdate, Donors.Age, Donors.[Blood Type], Extraction.[Extraction Date] ORDER BY Extraction.[Extraction Date] ASC";

			OleDbParameter[] parametersExtraction = { new OleDbParameter("?", hospitalName) };
			return db.executeQuery(query, parametersExtraction);
		}

		internal DataTable loadTransfusion(Database db)
		{
			string query = @"SELECT Transfusion.[Transfusion ID], Patients.[First Name] & ' ' & Patients.[Middle Name] & ' ' & Patients.[Last Name] AS [Patient Name], Patients.Gender, 
							 Patients.Birthdate, Patients.Age, Patients.[Contact Number], Patients.Barangay & ', ' & Patients.City & ', ' & Patients.Province AS [Address], 
							 Transfusion.[Blood Type], Transfusion.Quantity, 
							 Transfusion.[Transfusion Date], Physicians.[First Name] & ' ' & Physicians.[Middle Name] & ' ' & Physicians.[Last Name] AS [Physician Name], 
							 Physicians.[License Number] FROM Physicians 
							 INNER JOIN (Patients INNER JOIN Transfusion ON Patients.[Patient ID] = Transfusion.[Patient ID]) ON Physicians.[Physician ID] = Transfusion.[Physician ID]
							 WHERE Transfusion.[Hospital Username] = ? ORDER BY Transfusion.[Transfusion Date] ASC";

			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			return db.executeQuery(query, parameters);
		}

		internal DataTable loadBarcodes(Database db)
		{
			string query = @"SELECT [Extraction ID], [Blood Type], [Extraction Date], [Expiration Date], Status, Barcode FROM Extraction WHERE [Hospital Username] = ? 
							 ORDER BY [Extraction Date] ASC";
			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			return db.executeQuery(query, parameters);
		}

		internal DataTable loadStock(Database db)
		{
			string query = @"SELECT [Blood Type], COUNT(*) AS Unit FROM Extraction WHERE [Hospital Username] = ? AND Status = 'Available' AND [Expiration Date] >= Date()
							 GROUP BY [Blood Type]";

			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			return db.executeQuery(query, parameters);
		}

		internal bool accessDeleteDonor(int donorID, Database db)
		{
			string query = "SELECT Hospital FROM Donors WHERE [Donor ID] = ?";
			OleDbParameter[] parameters = { new OleDbParameter("?", donorID) };
			string donorHospital = string.Empty;

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);
					cmd.Parameters.AddRange(parameters);

					conn.Open();
					donorHospital = cmd.ExecuteScalar()?.ToString();
					conn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (donorHospital == "All")
			{
				MessageBox.Show("You have no access to delete this record.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
	}

	public class Admin : User
	{
		internal bool updatePassword(Database db, string password)
		{
			string hashedPassword = db.hashPassword(password);

			string query = "UPDATE Admin SET [Password] = ? WHERE [Username] = ?";

			using (OleDbConnection conn = db.getConnection())
			using (OleDbCommand cmd = new OleDbCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("?", hashedPassword);
				cmd.Parameters.AddWithValue("?", UserLogs.Username);

				try
				{
					conn.Open();
					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected > 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}

		internal int totalDonors(Database db)
		{
			string query = @"SELECT [Donor ID] AS UserID, [Email Address], [Username], [Password], 'Donor' AS UserType FROM Donors 
							 WHERE [Email Address] IS NOT NULL AND [Email Address] <> '' AND [Password] IS NOT NULL AND [Password] <> ''";

			DataTable dt = db.executeQuery(query, null);
			return dt != null ? dt.Rows.Count : 0;
		}

		internal int totalHospitals(Database db)
		{
			string query = @"SELECT [Hospital ID] AS UserID, [Email Address], [Username], [Password], 'Hospital' AS UserType FROM Hospitals 
							 WHERE [Email Address] IS NOT NULL AND [Email Address] <> '' AND [Password] IS NOT NULL AND [Password] <> ''";

			DataTable dt = db.executeQuery(query, null);
			return dt != null ? dt.Rows.Count : 0;
		}

		internal DataTable totalBloodBags(Database db)
		{
			string query = @"SELECT [Extraction ID], [Blood Type], [Extraction Date], [Expiration Date], Status, Barcode FROM Extraction";
			return db.executeQuery(query);
		}

		internal DataTable donorsBarangay(Database db)
		{
			string query = @"SELECT Barangay, City, COUNT(*) AS TotalDonors FROM Donors WHERE [Email Address] IS NOT NULL AND [Email Address] <> '' 
							 AND [Password] IS NOT NULL AND [Password] <> '' GROUP BY Barangay, City";

			return db.executeQuery(query);
		}
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

		internal DataTable loadAllPatients(Database db)
		{
			string query = @"SELECT [Patient ID], Priority FROM Patients WHERE [Hospital Username] = ?";

			OleDbParameter[] parametersPatients =
			{
				new OleDbParameter("?", UserLogs.Username)
			};
			return db.executeQuery(query, parametersPatients);
		}

		internal DataTable loadPatients(Database db)
		{
			updateAge(db);

			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string query = @"SELECT [Patient ID], [First Name], [Middle Name], [Last Name], Gender, Birthdate, Age, [Contact Number], [Blood Type], Request, Priority, 
							  Barangay, City, Province FROM Patients WHERE [Hospital] = ? AND Priority <> ?";

			OleDbParameter[] parametersPatients = 
			{ 
				new OleDbParameter("?", hospitalName),
				new OleDbParameter("?", "Resolved")
			};
			return db.executeQuery(query, parametersPatients);
		}

		internal bool duplicatePatient(Database db)
		{
			string hospitalUsername = UserLogs.Username;

			string query = @"SELECT COUNT(*) FROM Patients WHERE [First Name] = ? AND [Last Name] = ? AND [Birthdate] = ? AND [Blood Type] = ? AND [Hospital Username] = ? 
							 AND [Priority] <> 'Resolved'";

			OleDbParameter[] checkParameters =
			{
				new OleDbParameter("?", FirstName),
				new OleDbParameter("?", LastName),
				new OleDbParameter("?", Birthdate),
				new OleDbParameter("?", BloodType),
				new OleDbParameter("?", hospitalUsername)
			};

			object result = db.executeScalar(query, checkParameters);
			if (result != null && Convert.ToInt32(result) > 0)
			{
				return true;
			}
			return false;
		}

		internal bool addPatient(Database db)
		{
			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();
			string hospitalUsername = UserLogs.Username;

			string query = @"INSERT INTO Patients ([First Name], [Middle Name], [Last Name], [Gender], [Birthdate], [Age], [Contact Number], [Blood Type], [Request], 
							 [Priority], [Barangay], [City], [Province], [Hospital Username], [Hospital]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			
			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);

					cmd.Parameters.AddWithValue("?", FirstName);
					cmd.Parameters.AddWithValue("?", MiddleName);
					cmd.Parameters.AddWithValue("?", LastName);
					cmd.Parameters.AddWithValue("?", Gender);
					cmd.Parameters.AddWithValue("?", Birthdate);
					cmd.Parameters.AddWithValue("?", Age);
					cmd.Parameters.AddWithValue("?", ContactNumber);
					cmd.Parameters.AddWithValue("?", BloodType);
					cmd.Parameters.AddWithValue("?", Request);
					cmd.Parameters.AddWithValue("?", Priority);
					cmd.Parameters.AddWithValue("?", Barangay);
					cmd.Parameters.AddWithValue("?", City);
					cmd.Parameters.AddWithValue("?", Province);
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

		internal bool updatePatient(Database db, int patientID)
		{
			string query = @"UPDATE Patients SET [First Name] = ?, [Middle Name] = ?, [Last Name] = ?, [Gender] = ?, [Birthdate] = ?, [Age] = ?, [Contact Number] = ?, 
							 [Blood Type] = ?, [Request] = ?, [Priority] = ?, [Barangay] = ?, [City] = ?, [Province] = ? WHERE [Patient ID] = ?";

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
						cmd.Parameters.AddWithValue("?", Birthdate);
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

		internal override void updateAge(Database db)
		{
			string today = DateTime.Today.ToString("MM/dd/yyyy");
			string query = "UPDATE Patients SET [Age] = INT(DATEDIFF('d', [Birthdate], ?) / 365.25)";
			OleDbParameter[] parameters = { new OleDbParameter("?", today) };
			db.executeNonQuery(query, parameters);
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
			updateAge(db);

			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string query = @"SELECT [Physician ID], [First Name], [Middle Name], [Last Name], Gender, Birthdate, Age, [Contact Number], Specialization, 
							 [License Number] FROM Physicians WHERE [Hospital] = ?";

			OleDbParameter[] parametersPhysicians = { new OleDbParameter("?", hospitalName) };
			return db.executeQuery(query, parametersPhysicians);
		}

		internal bool duplicatePhysician(Database db)
		{
			string hospitalUsername = UserLogs.Username;

			string query = @"SELECT COUNT(*) FROM Physicians WHERE [First Name] = ? AND [Last Name] = ? AND [Birthdate] = ? AND [License Number] = ? AND [Hospital Username] = ?";

			OleDbParameter[] checkParameters =
			{
				new OleDbParameter("?", FirstName),
				new OleDbParameter("?", LastName),
				new OleDbParameter("?", Birthdate),
				new OleDbParameter("?", License),
				new OleDbParameter("?", hospitalUsername)
			};

			object result = db.executeScalar(query, checkParameters);
			if (result != null && Convert.ToInt32(result) > 0)
			{
				return true;
			}
			return false;
		}

		internal bool addPhysician(Database db)
		{
			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parametersHospital = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parametersHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();
			string hospitalUsername = UserLogs.Username;

			string query = @"INSERT INTO Physicians ([First Name], [Middle Name], [Last Name], [Gender], [Birthdate], [Age], [Contact Number], [Specialization], 
							 [License Number], [Hospital Username], [Hospital]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					OleDbCommand cmd = new OleDbCommand(query, conn);

					cmd.Parameters.AddWithValue("?", FirstName);
					cmd.Parameters.AddWithValue("?", MiddleName);
					cmd.Parameters.AddWithValue("?", LastName);
					cmd.Parameters.AddWithValue("?", Gender);
					cmd.Parameters.AddWithValue("?", Birthdate);
					cmd.Parameters.AddWithValue("?", Age);
					cmd.Parameters.AddWithValue("?", ContactNumber);
					cmd.Parameters.AddWithValue("?", Specialization);
					cmd.Parameters.AddWithValue("?", License);
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
			string query = @"UPDATE Physicians SET [First Name] = ?, [Middle Name] = ?, [Last Name] = ?, [Gender] = ?, [Birthdate] = ?, [Age] = ?, [Contact Number] = ?, 
							 [Specialization] = ?, [License Number] = ? WHERE [Physician ID] = ?";

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
						cmd.Parameters.AddWithValue("?", Birthdate);
						cmd.Parameters.AddWithValue("?", Age);
						cmd.Parameters.AddWithValue("?", ContactNumber);
						cmd.Parameters.AddWithValue("?", Specialization);
						cmd.Parameters.AddWithValue("?", License);
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

		internal override void updateAge(Database db)
		{
			string today = DateTime.Today.ToString("MM/dd/yyyy");
			string query = "UPDATE Physicians SET [Age] = INT(DATEDIFF('d', [Birthdate], ?) / 365.25)";
			OleDbParameter[] parameters = { new OleDbParameter("?", today) };
			db.executeNonQuery(query, parameters);
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
