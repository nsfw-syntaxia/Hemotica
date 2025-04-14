using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class HospitalTransfusion : UserControl
	{
		Database db = new Database();
		DataTable patientList;

		public HospitalTransfusion()
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

		private void cmbxPhysician_SelectedIndexChanged(object sender, EventArgs e)
		{
			// get whats selected in the combobox
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
	}
}
