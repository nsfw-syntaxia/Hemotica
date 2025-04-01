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

		private void btnConnection_Click(object sender, EventArgs e)
		{
			db.connectDatabase();
		}

		private void lDonors_Click(object sender, EventArgs e)
		{
			btnConnection.Visible = false;
			dgvDataMax.Visible = true;
			btnDeleteMax.Visible = true;

			dgvDataMin.Visible = false;
			flpInputs.Visible = false;
			btnInsert.Visible = false;
			btnUpdate.Visible = false;
			btnDeleteMin.Visible = false;

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
					if (hospital.deleteDonor(donorID, db))
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
			flpInputs.Controls.Add(new RecordsPatient(this));
			loadPatients();
		}

		private void loadPatients()
		{
			DataTable dt = hospital.loadPatients(db);

			if (dt != null)
			{
				dgvDataMin.DataSource = dt;
			}
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (flpInputs.Controls.Count > 0 && flpInputs.Controls[0] is RecordsPatient recordsPatient)
			{
				Patient patient = recordsPatient.inputPatient();

				if (patient != null)
				{
					if (patient.addPatient(db))
					{
						MessageBox.Show("Patient record inserted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

						flpInputs.Controls.Clear();
						flpInputs.Controls.Add(new RecordsPatient(this));
						loadPatients();
					}
					else
					{
						MessageBox.Show("Patient record insertion failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnDeleteMin_Click(object sender, EventArgs e)
		{
			if (flpInputs.Controls.Count > 0 && flpInputs.Controls[0] is RecordsPatient recordsPatient)
			{
				if (dgvDataMin.SelectedRows.Count > 0)
				{
					int patientID = Convert.ToInt32(dgvDataMin.SelectedRows[0].Cells["Patient ID"].Value);

					var confirmResult = MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (confirmResult == DialogResult.Yes)
					{
						if (hospital.deletePatient(patientID, db))
						{
							MessageBox.Show("Patient record deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

							DataTable dt = hospital.loadPatients(db);
							dgvDataMin.DataSource = dt;
						}
						else
						{
							MessageBox.Show("Patient record deletion failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}

		private void lPhysicians_Click(object sender, EventArgs e)
		{
			//flpInputs.Controls.Clear();
			//flpInputs.Controls.Add(new RecordsPhysician());
		}
	}
}
