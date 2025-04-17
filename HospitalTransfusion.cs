using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class HospitalTransfusion : UserControl
	{
		Database db = new Database();
		DataTable patientList;
		DataTable physicianList;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalTransfusion()
		{
			InitializeComponent();
		}

		private void HospitalTransfusion_Load(object sender, EventArgs e)
		{
			roundControls();
			loadPatientList();

			lblResult.Text = "";
			btnCrossmatch.Visible = true;
			btnPhysician.Visible = false;
			lblPhysician.Visible = false;
			cmbxPhysician.Visible = false;
			btnTransfusion.Visible = false;
		}

		public void roundControls()
		{
			pBlood.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pBlood.Width, pBlood.Height, 20, 20));
			pCompatibility.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pCompatibility.Width, pCompatibility.Height, 20, 20));
			pPatient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pPatient.Width, pPatient.Height, 20, 20));
			pTransfusion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pTransfusion.Width, pTransfusion.Height, 20, 20));

			if (pbxCompatibility.Width > 0 && pbxCompatibility.Height > 0)
			{
				pbxCompatibility.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxCompatibility.Width, pbxCompatibility.Height, 20, 20));
			}
		}

		private void HospitalTransfusion_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		public void loadPatientList()
		{
			string query = @"SELECT [Patient ID], [First Name], [Middle Name], [Last Name] FROM Patients WHERE [Hospital Username] = ? AND NOT [Priority] = 'Resolved' 
							 ORDER BY [First Name], [Last Name]";

			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			patientList = db.executeQuery(query, parameters);

			cmbxPatient.Items.Clear();
			cmbxPatient.Items.Add("Select patient");
			cmbxPatient.SelectedIndex = 0;

			foreach (DataRow row in patientList.Rows)
			{
				string firstName = row["First Name"].ToString();
				string middleName = row["Middle Name"].ToString();
				string lastName = row["Last Name"].ToString();

				string fullName = string.IsNullOrWhiteSpace(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

				cmbxPatient.Items.Add(fullName);
			}
		}

		public void loadPatientDetails(string patientID)
		{
			string query = @"SELECT [Blood Type], Birthdate, Priority, Request FROM Patients WHERE [Patient ID] = ?";
			OleDbParameter[] parameter = { new OleDbParameter("?", patientID) };
			DataTable dt = db.executeQuery(query, parameter);

			if (dt.Rows.Count > 0)
			{
				DataRow row = dt.Rows[0];
				tbxBloodType.Text = row["Blood Type"].ToString();
				tbxBirthdate.Text = row["Birthdate"].ToString();
				tbxPriority.Text = row["Priority"].ToString();
				tbxQuantity.Text = row["Request"].ToString();
			}

			lblResult.Text = "";
			btnCrossmatch.Visible = true;
			btnPhysician.Visible = false;
			lblPhysician.Visible = false;
			cmbxPhysician.Visible = false;
			btnTransfusion.Visible = false;
			centerLabel(lblResult);
		}

		private void cmbxPatient_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbxPatient.SelectedIndex <= 0)
			{
				tbxBloodType.Text = "";
				tbxBirthdate.Text = "";
				tbxPriority.Text = "";
				tbxQuantity.Text = "";
				lblResult.Text = "";
				return;
			}

			int dataIndex = cmbxPatient.SelectedIndex - 1;
			string patientID = patientList.Rows[dataIndex]["Patient ID"].ToString();

			loadPatientDetails(patientID);
		}

		private void btnCrossmatch_Click(object sender, EventArgs e)
		{
			if (cmbxPatient.SelectedIndex <= 0)
			{
				MessageBox.Show("Please select a patient.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string requestedBloodType = tbxBloodType.Text.Trim();
			if (!int.TryParse(tbxQuantity.Text.Trim(), out int requiredQuantity))
				return;

			Dictionary<string, List<string>> compatibility = new Dictionary<string, List<string>>()
			{
				["AB+"] = new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" },
				["AB-"] = new List<string> { "A-", "B-", "AB-", "O-" },
				["A+"] = new List<string> { "A+", "A-", "O+", "O-" },
				["A-"] = new List<string> { "A-", "O-" },
				["B+"] = new List<string> { "B+", "B-", "O+", "O-" },
				["B-"] = new List<string> { "B-", "O-" },
				["O+"] = new List<string> { "O+", "O-" },
				["O-"] = new List<string> { "O-" }
			};

			List<string> compatibleTypes = compatibility[requestedBloodType];

			string query = @"SELECT [Blood Type], COUNT(*) AS Unit FROM Extraction WHERE [Status] = 'Available' AND [Expiration Date] >= Date() AND [Hospital Username] = ?
							 GROUP BY [Blood Type]";

			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			DataTable dt = db.executeQuery(query, parameters);

			int totalAvailableUnits = 0;
			foreach (DataRow row in dt.Rows)
			{
				string type = row["Blood Type"].ToString();
				int units = Convert.ToInt32(row["Unit"]);

				if (compatibleTypes.Contains(type))
				{
					totalAvailableUnits += units;
				}
			}

			if (totalAvailableUnits >= requiredQuantity)
			{
				lblResult.Text = $"AVAILABLE: {totalAvailableUnits} compatible unit(s) found.";
				btnCrossmatch.Visible = false;
				btnPhysician.Visible = true;
				lblPhysician.Visible = false;
				cmbxPhysician.Visible = false;
				btnTransfusion.Visible = false;
			}
			else
			{
				if (totalAvailableUnits == 0)
				{
					lblResult.Text = "UNAVAILABLE: No compatible unit(s) available.";
				}
				else
				{
					lblResult.Text = $"UNAVAILABLE: Only {totalAvailableUnits} compatible unit(s) available.";
				}

				btnCrossmatch.Visible = true;
				btnPhysician.Visible = false;
				lblPhysician.Visible = false;
				cmbxPhysician.Visible = false;
				btnTransfusion.Visible = false;
			}

			centerLabel(lblResult);
		}

		private void centerLabel(Label lbl)
		{
			int panelWidth = 452;
			lbl.Left = (panelWidth - lbl.PreferredWidth) / 2;
		}

		private void btnPhysician_Click(object sender, EventArgs e)
		{
			lblResult.Visible = false;
			btnCrossmatch.Visible = false;
			btnPhysician.Visible = false;
			lblPhysician.Visible = true;
			cmbxPhysician.Visible = true;
			btnTransfusion.Visible = true;

			loadPhysicianList();
		}

		private void loadPhysicianList()
		{
			string query = @"SELECT [Physician ID], [First Name], [Middle Name], [Last Name] FROM Physicians WHERE [Hospital Username] = ? ORDER BY [First Name], [Last Name]";
			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			physicianList = db.executeQuery(query, parameters);

			cmbxPhysician.Items.Clear();
			cmbxPhysician.Items.Add("Select physician");
			cmbxPhysician.SelectedIndex = 0;

			foreach (DataRow row in physicianList.Rows)
			{
				string firstName = row["First Name"].ToString();
				string middleName = row["Middle Name"].ToString();
				string lastName = row["Last Name"].ToString();

				string fullName = string.IsNullOrWhiteSpace(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

				cmbxPhysician.Items.Add(fullName);
			}
		}

		private void btnTransfusion_Click(object sender, EventArgs e)
		{
			if (cmbxPhysician.SelectedIndex <= 0)
			{
				MessageBox.Show("Please select a physician.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			addTransfusion();
			updatePatient();
			updateExtraction();

			MessageBox.Show("Blood transfer recorded successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

			cmbxPatient.SelectedIndex = 0;
			cmbxPhysician.SelectedIndex = 0;
			tbxBirthdate.Clear();
			tbxPriority.Clear();
			tbxBloodType.Clear();
			tbxQuantity.Clear();
			lblResult.Text = "";
			lblResult.Visible = true;
			btnCrossmatch.Visible = true;
			btnPhysician.Visible = false;
			lblPhysician.Visible = false;
			cmbxPhysician.Visible = false;
			btnTransfusion.Visible = false;

			loadPatientList();
			pbxCompatibility.Focus();
		}

		private void addTransfusion()
		{
			int patientIndex = cmbxPatient.SelectedIndex - 1;
			string patientID = patientList.Rows[patientIndex]["Patient ID"].ToString();

			int physicianIndex = cmbxPhysician.SelectedIndex - 1;
			string physicianID = physicianList.Rows[physicianIndex]["Physician ID"].ToString();

			string bloodType = tbxBloodType.Text.Trim();
			string quantity = tbxQuantity.Text.Trim();
			string hospitalUsername = UserLogs.Username;

			string queryHospital = @"SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] transfusionParameters = { new OleDbParameter("?", hospitalUsername) };
			DataTable hospitalData = db.executeQuery(queryHospital, transfusionParameters);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string transfusionDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

			string insertQuery = @"INSERT INTO Transfusion ([Patient ID], [Physician ID], [Blood Type], [Quantity], [Hospital Username], [Hospital], [Transfusion Date])
								   VALUES (?, ?, ?, ?, ?, ?, ?)";
			OleDbParameter[] parameters = 
			{
				new OleDbParameter("?", patientID),
				new OleDbParameter("?", physicianID),
				new OleDbParameter("?", bloodType),
				new OleDbParameter("?", quantity),
				new OleDbParameter("?", hospitalUsername),
				new OleDbParameter("?", hospitalName),
				new OleDbParameter("?", transfusionDate)
			};

			db.executeNonQuery(insertQuery, parameters);
		}

		private void updatePatient()
		{
			int patientIndex = cmbxPatient.SelectedIndex - 1;
			string patientID = patientList.Rows[patientIndex]["Patient ID"].ToString();

			string selectQuery = @"SELECT * FROM Patients WHERE [Patient ID] = ?";
			OleDbParameter[] selectParameters = { new OleDbParameter("?", patientID) };
			DataTable patientData = db.executeQuery(selectQuery, selectParameters);

			if (patientData.Rows.Count == 0)
			{
				MessageBox.Show("ERROR: Patient record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DataRow row = patientData.Rows[0];

			string insertQuery = @"INSERT INTO [Patients Archive] ([First Name], [Middle Name], [Last Name], [Gender], [Birthdate], [Age], [Contact Number], [Blood Type], [Request], 
								   [Priority], [Barangay], [City], [Province], [Hospital Username], [Hospital]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

			OleDbParameter[] insertParameters =
			{
				new OleDbParameter("?", row["First Name"]),
				new OleDbParameter("?", row["Middle Name"]),
				new OleDbParameter("?", row["Last Name"]),
				new OleDbParameter("?", row["Gender"]),
				new OleDbParameter("?", row["Birthdate"]),
				new OleDbParameter("?", row["Age"]),
				new OleDbParameter("?", row["Contact Number"]),
				new OleDbParameter("?", row["Blood Type"]),
				new OleDbParameter("?", row["Request"]),
				new OleDbParameter("?", "Resolved"),
				new OleDbParameter("?", row["Barangay"]),
				new OleDbParameter("?", row["City"]),
				new OleDbParameter("?", row["Province"]),
				new OleDbParameter("?", row["Hospital Username"]),
				new OleDbParameter("?", row["Hospital"])
			};
			db.executeNonQuery(insertQuery, insertParameters);

			string deleteQuery = @"DELETE FROM Patients WHERE [Patient ID] = ?";
			OleDbParameter[] deleteParameters = { new OleDbParameter("?", patientID) };
			db.executeNonQuery(deleteQuery, deleteParameters);
		}

		private void updateExtraction()
		{
			string requestedBloodType = tbxBloodType.Text.Trim();
			int requiredQuantity = int.Parse(tbxQuantity.Text.Trim());

			Dictionary<string, List<string>> compatibility = new Dictionary<string, List<string>>()
			{
				["AB+"] = new List<string> { "AB+", "A+", "A-", "B+", "B-", "AB-", "O+", "O-" },
				["AB-"] = new List<string> { "AB-", "A-", "B-", "O-" },
				["A+"] = new List<string> { "A+", "A-", "O+", "O-" },
				["A-"] = new List<string> { "A-", "O-" },
				["B+"] = new List<string> { "B+", "B-", "O+", "O-" },
				["B-"] = new List<string> { "B-", "O-" },
				["O+"] = new List<string> { "O+", "O-" },
				["O-"] = new List<string> { "O-" }
			};

			List<string> compatibleTypes = compatibility[requestedBloodType];

			string selectQuery = @"SELECT [Extraction ID], [Blood Type] FROM Extraction WHERE [Status] = 'Available' AND [Expiration Date] >= Date() AND [Hospital Username] = ? 
								   ORDER BY [Blood Type] = ? DESC, [Extraction ID]";
			OleDbParameter[] parameters = 
			{
				new OleDbParameter("?", UserLogs.Username),
				new OleDbParameter("?", requestedBloodType)
			};
			DataTable extractionList = db.executeQuery(selectQuery, parameters);

			int updatedCount = 0;
			foreach (DataRow row in extractionList.Rows)
			{
				if (updatedCount >= requiredQuantity) break;

				string type = row["Blood Type"].ToString();
				if (compatibleTypes.Contains(type))
				{
					string extractionID = row["Extraction ID"].ToString();
					string updateQuery = @"UPDATE Extraction SET Status = 'Used' WHERE [Extraction ID] = ?";
					OleDbParameter[] updateParams = { new OleDbParameter("?", extractionID) };
					db.executeNonQuery(updateQuery, updateParams);
					updatedCount++;
				}
			}
		}
	}
}
