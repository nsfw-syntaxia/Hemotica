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
			//loadPhysicianList();
			loadPatientList();
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

		/*
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
		*/

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
				tbxBloodType.Text = row["Blood Type"].ToString();
				tbxPriority.Text = row["Priority"].ToString();
				tbxQuantity.Text = row["Request"].ToString();
			}
		}

		private void cmbxPatient_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbxPatient.SelectedIndex <= 0)
			{
				tbxBloodType.Text = "";
				tbxPriority.Text = "";
				tbxQuantity.Text = "";
				return;
			}

			int dataIndex = cmbxPatient.SelectedIndex - 1;
			string patientID = patientList.Rows[dataIndex]["Patient ID"].ToString();

			loadPatientDetails(patientID);
		}

		/*
		private void btnAvailability_Click(object sender, EventArgs e)
		{
			if (cmbxPatient.SelectedIndex <= 0)
			{
				MessageBox.Show("Please select a patient.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string bloodType = tbxBloodType.Text.Trim();

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
		*/
	}
}
