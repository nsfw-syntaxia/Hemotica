using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class HospitalRecords : UserControl
	{
		private Hospital hospital;
		private Database db = new Database();

		public HospitalRecords()
		{
			InitializeComponent();
			this.hospital = new Hospital();
		}

		private void HospitalRecords_Load(object sender, EventArgs e)
		{
			//
		}

		private void btnConnection_Click(object sender, EventArgs e)
		{
			db.connectDatabase();
		}

		private void lDonors_Click(object sender, EventArgs e)
		{
			btnConnection.Visible = false;
			dgvDataMax.Visible = true;
			btnDeleteMax.Visible = true;

			DataTable dt = hospital.loadDonors(db);

			if (dt != null)
			{
				dgvDataMax.DataSource = dt;
			}
		}

		private void btnDeleteMax_Click(object sender, EventArgs e)
		{
			if (dgvDataMax.SelectedRows.Count > 0)
			{
				int donorID = Convert.ToInt32(dgvDataMax.SelectedRows[0].Cells["Donor ID"].Value);

				var confirmResult = MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (confirmResult == DialogResult.Yes)
				{
					bool isDeleted = hospital.deleteDonor(donorID, db);

					if (isDeleted)
					{
						MessageBox.Show("Donor record deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

						DataTable dt = hospital.loadDonors(db);
						dgvDataMax.DataSource = dt;
					}
					else
					{
						MessageBox.Show("Donor record deletion failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void lPatients_Click(object sender, EventArgs e)
		{
			btnConnection.Visible = false;
			dgvDataMax.Visible = false;
			btnDeleteMax.Visible = false;

			dgvDataMin.Visible = true;
			flpInputs.Visible = true;
			btnInsert.Visible = true;
			btnUpdate.Visible = true;
			btnDeleteMin.Visible = true;
			flpInputs.Controls.Clear();
		}

		private void lPhysicians_Click(object sender, EventArgs e)
		{
			//flpInputs.Controls.Clear();
			//flpInputs.Controls.Add(new RecordsPhysician());
		}
	}
}
