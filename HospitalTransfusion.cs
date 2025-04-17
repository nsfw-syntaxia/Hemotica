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
			{
				MessageBox.Show("Invalid quantity.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

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
			}
			else
			{
				lblResult.Text = $"UNAVAILABLE: Only {totalAvailableUnits} compatible unit(s) available.";
				btnCrossmatch.Visible = true;
				btnPhysician.Visible = false;
				lblPhysician.Visible = false;
				cmbxPhysician.Visible = false;
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
			string query = @"SELECT [First Name], [Middle Name], [Last Name] FROM Physicians WHERE [Hospital Username] = ? ORDER BY [First Name], [Last Name]";
			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			DataTable physicianList = db.executeQuery(query, parameters);

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

			// insert to database to record successful transfusion
			// updates the patient's priority to "Resolved"
			// update the extraction status in table Extraction to "Used" so that it updates blood stock
		}
	}
}
