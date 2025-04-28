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
			btnApprove.Visible = false;
			btnReject.Visible = false;
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
			btnApprove.Visible = false;
			btnReject.Visible = false;
			loadHospitals();
		}

		private void lRequests_Click(object sender, EventArgs e)
		{
			requests();
		}

		private void loadRequests()
		{
			DataTable dt = admin.bloodRequests(db);
			if (dt != null)
			{
				dgvDataMax.DataSource = dt;
			}
		}

		public void requests()
		{
			btnDelete.Visible = false;
			btnApprove.Visible = true;
			btnReject.Visible = true;
			loadRequests();
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

		public bool updateRequestStatus(int requestID, string newStatus)
		{
			string query = "UPDATE [Blood Requests] SET [Status] = ? WHERE [Blood Request ID] = ?";

			OleDbParameter[] parameters = 
			{
				new OleDbParameter("?", newStatus),
				new OleDbParameter("?", requestID)
			};

			return db.executeNonQuery(query, parameters);
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			if (dgvDataMax.SelectedRows.Count > 0)
			{
				int requestID = Convert.ToInt32(dgvDataMax.SelectedRows[0].Cells["Blood Request ID"].Value);

				bool success = updateRequestStatus(requestID, "Approved");

				if (success)
				{
					MessageBox.Show("Blood request approved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					loadRequests();
				}
				else
				{
					MessageBox.Show("Blood request approval failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Please select a request awaiting approval.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnReject_Click(object sender, EventArgs e)
		{
			if (dgvDataMax.SelectedRows.Count > 0)
			{
				int requestID = Convert.ToInt32(dgvDataMax.SelectedRows[0].Cells["Blood Request ID"].Value);

				bool success = updateRequestStatus(requestID, "Denied");

				if (success)
				{
					MessageBox.Show("Blood request has been denied.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					loadRequests();
				}
				else
				{
					MessageBox.Show("Blood request rejection failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
