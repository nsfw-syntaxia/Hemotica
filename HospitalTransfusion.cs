using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class HospitalTransfusion : UserControl
	{
		Database db = new Database();

		public HospitalTransfusion()
		{
			InitializeComponent();
		}

		private void HospitalTransfusion_Load(object sender, EventArgs e)
		{
			loadPhysicianList();
		}

		public void loadPhysicianList()
		{
			string hospitalAccess = "All";

			string query = @"SELECT [First Name], [Middle Name], [Last Name] FROM Physicians WHERE [Hospital Username] = ?";

			OleDbParameter[] parameters =
			{
				new OleDbParameter("?", UserLogs.Username)
			};
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

		public void loadPatients()
		{

		}

		public void loadPatientDetails()
		{

		}

		private void cmbxPhysician_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
