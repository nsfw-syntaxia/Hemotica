using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class AdminRecords : UserControl
	{
		private Admin admin = new Admin();
		private Database db = new Database();

		public AdminRecords()
		{
			InitializeComponent();
		}

		private void lDonors_Click(object sender, EventArgs e)
		{
			donors();
		}

		private void loadDonors()
		{
			DataTable dt = admin.loadDonors(db);

			if (dt != null)
			{
				dgvDataMax.DataSource = dt;
			}
		}

		public void donors()
		{
			btnDelete.Visible = true;
			loadDonors();
		}

		private void lHospitals_Click(object sender, EventArgs e)
		{
			hospitals();
		}

		private void loadHospitals()
		{
			DataTable dt = admin.loadHospitals(db);

			if (dt != null)
			{
				dgvDataMax.DataSource = dt;
			}
		}

		public void hospitals()
		{
			btnDelete.Visible = true;
			loadHospitals();
		}

		private void lRequests_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			deleteUsers();
			mstrpRecords.Focus();
		}

		public void deleteUsers()
		{
			if (dgvDataMax.SelectedRows.Count > 0)
			{
				int recordID = Convert.ToInt32(dgvDataMax.SelectedRows[0].Cells[0].Value);

				var confirmResult = MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (confirmResult == DialogResult.Yes)
				{
					string recordType = dgvDataMax.SelectedRows[0].Cells[0].OwningColumn.Name;

					bool isDeleted = false;

					if (recordType == "Donor ID")
					{
						isDeleted = admin.deleteDonor(recordID, db);
					}
					else if (recordType == "Hospital ID")
					{
						isDeleted = admin.deleteHospital(recordID, db);
					}

					if (isDeleted)
					{
						MessageBox.Show("Record deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

						if (recordType == "Donor ID")
						{
							loadDonors();
						}
						else if (recordType == "Hospital ID")
						{
							loadHospitals();
						}
					}
					else
					{
						MessageBox.Show("Record deletion failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a record to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
