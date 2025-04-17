using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class HospitalTransfusions : UserControl
	{
		Database db = new Database();
		DataTable patientList;

		public HospitalTransfusions()
		{
			InitializeComponent();
		}

		private void HospitalTransfusion_Load(object sender, EventArgs e)
		{
			loadPhysicianList();
			loadPatientList();
		}

		public void loadPhysicianList()
		{
			string hospitalAccess = "All";

			string query = @"SELECT [First Name], [Middle Name], [Last Name] FROM Physicians WHERE [Hospital Username] = ?";
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

		public void loadPatientList()
		{
			string query = @"SELECT [Patient ID], [First Name], [Middle Name], [Last Name] FROM Patients WHERE [Hospital Username] = ? AND NOT [Priority] = 'Resolved'";

			OleDbParameter[] parameters =
			{
				new OleDbParameter("?", UserLogs.Username)
			};

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
			string query = @"SELECT [Blood Type], Priority, Request FROM Patients WHERE [Patient ID] = ?";
			OleDbParameter[] parameter = { new OleDbParameter("?", patientID) };
			DataTable dt = db.executeQuery(query, parameter);

			if (dt.Rows.Count > 0)
			{
				DataRow row = dt.Rows[0];
				tbxBlood.Text = row["Blood Type"].ToString();
				tbxPriority.Text = row["Priority"].ToString();
				tbxQuantity.Text = row["Request"].ToString();
			}
		}

		private void cmbxPatient_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbxPatient.SelectedIndex <= 0)
			{
				tbxBlood.Text = "";
				tbxPriority.Text = "";
				tbxQuantity.Text = "";
				return;
			}

			int dataIndex = cmbxPatient.SelectedIndex - 1;
			string patientID = patientList.Rows[dataIndex]["Patient ID"].ToString();

			loadPatientDetails(patientID);
		}

		private void btnAvailability_Click(object sender, EventArgs e)
		{
			if (cmbxPatient.SelectedIndex <= 0)
			{
				MessageBox.Show("Please select a patient.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string bloodType = tbxBlood.Text.Trim();

			if (!int.TryParse(tbxQuantity.Text.Trim(), out int quantity))
			{
				MessageBox.Show("Invalid quantity.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string query = @"SELECT Count(*) AS Unit FROM Extraction WHERE [Status] = 'Available' AND [Expiration Date] >= Date() AND [Hospital Username] = ? AND [Blood Type] = ?";
			OleDbParameter[] parameters =
			{
				new OleDbParameter("?", UserLogs.Username),
				new OleDbParameter("?", bloodType)
			};

			DataTable dt = db.executeQuery(query, parameters);
			int availableUnits = dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0]["Unit"]) : 0;

			lblResult.Size = new Size(1020, lblResult.Height);
			lblResult.Location = new Point(0, (this.Height - lblResult.Height) / 2);

			if (availableUnits >= quantity)
			{
				lblResult.Text = "Blood units are available for this request.";
				btnTransfusion.Enabled = true;
				cmbxPhysician.Enabled = true;
			}
			else
			{
				lblResult.Text = "Insufficient blood units available for transfusion.";
				btnTransfusion.Enabled = false;
				cmbxPhysician.Enabled = false;
			}


			// validate if patient is selected (just patient, disable cmbxPhysician first)
			// check if blood type and needed quantity is currently available from database under that logged in hospital
			// if available, show "Blood request is available." or sumthing better in lblResult (make it so lbl is always center horizontically in panel size 1020, 641)
			// if not available, show "Blood request is not available." or sumthing better in lblResult (make it so lbl is always center horizontically in panel size 1020, 641)
			// if available, enable btnTransfusion and cmbxPhysician
		}

		private void btnTransfusion_Click(object sender, EventArgs e)
		{
			// validate if physician is selected and if patient is selected
			// insert to database to record successful transfusion
			// updates the patient's priority to "Resolved"
			// update the extraction status in table Extraction to "Used" so that it updates blood stock
		}
	}
}
