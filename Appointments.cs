using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hemotica
{
	public partial class Appointments : Form
	{
		private DateTime selectedDate;
		private Database db = new Database();
		private string selectedHospital;

		public Appointments(DateTime date, string hospitalName)
		{
			InitializeComponent();
			selectedDate = date;
			selectedHospital = hospitalName;
		}

		private void Appointments_Load(object sender, EventArgs e)
		{
			dtpAppointments.Value = selectedDate;
			loadHospitals();
		}

		private void loadHospitals()
		{
			try
			{
				string query = "SELECT [Hospital Name] FROM Hospitals ORDER BY [Hospital Name] ASC";
				DataTable dt = db.executeQuery(query);

				cmbxHospitals.DataSource = dt;
				cmbxHospitals.DisplayMember = "Hospital Name";
				cmbxHospitals.ValueMember = "Hospital Name";

				if (!string.IsNullOrEmpty(selectedHospital))
				{
					cmbxHospitals.SelectedValue = selectedHospital;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (!(rbtnYes1.Checked || rbtnNo1.Checked) || !(rbtnYes2.Checked || rbtnNo2.Checked) || !(rbtnYes3.Checked || rbtnNo3.Checked) ||
				!(rbtnYes4.Checked || rbtnNo4.Checked) || !(rbtnYes5.Checked || rbtnNo5.Checked) || !(rbtnYes6.Checked || rbtnNo6.Checked))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DateTime appointmentDate = dtpAppointments.Value;
			string status = (rbtnYes1.Checked && rbtnYes2.Checked && rbtnYes3.Checked &&
							 rbtnYes4.Checked && rbtnYes5.Checked && rbtnYes6.Checked) ? "Pending Approval" : "Denied";

			if (status == "Pending Approval" && !eligibility(appointmentDate))
			{
				status = "Denied";
			}

			string hospitalName = cmbxHospitals.SelectedValue.ToString();
			string hospitalUsername = db.hospitalUsername(hospitalName);

			string query = "INSERT INTO Appointments ([Donor Username], [Appointment Date], [Hospital Username], Hospital, Status) VALUES (?, ?, ?, ?, ?)";

			OleDbParameter[] parameters =
			{
				new OleDbParameter("?", UserLogs.Username),
				new OleDbParameter("?", appointmentDate.ToString("MM/dd/yyyy")),
				new OleDbParameter("?", hospitalUsername),
				new OleDbParameter("?", hospitalName),
				new OleDbParameter("?", status)
			};

			if (db.executeNonQuery(query, parameters))
			{
				if (status == "Denied")
				{
					MessageBox.Show("Appointment denied. Donor is not eligible.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("Appointment is now awaiting approval!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				this.Close();
			}
		}

		private bool eligibility(DateTime appointmentDate)
		{
			if (rbtnYes1.Checked)
			{
				string ageQuery = "SELECT Age FROM Donors WHERE Username = ?";
				OleDbParameter[] ageParameter = { new OleDbParameter("?", UserLogs.Username) };
				DataTable ageResult = db.executeQuery(ageQuery, ageParameter);

				int age = Convert.ToInt32(ageResult.Rows[0]["Age"]);
				if (age < 16 || age > 65)
				{
					return false;
				}
			}

			if (rbtnYes4.Checked)
			{
				string donationQuery = @"SELECT TOP 1 [Extraction Date] FROM Extraction WHERE [Donor Username] = ? ORDER BY [Extraction Date] DESC";
				OleDbParameter[] donationParameter = { new OleDbParameter("?", UserLogs.Username) };
				DataTable donationResult = db.executeQuery(donationQuery, donationParameter);

				if (donationResult.Rows.Count > 0)
				{
					DateTime lastDonationDate = Convert.ToDateTime(donationResult.Rows[0]["Extraction Date"]);
					TimeSpan difference = appointmentDate - lastDonationDate;

					if (difference.TotalDays < 56)
					{
						return false;
					}
				}
			}

			return true;
		}

		private void lblInformation_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://www.redcrossblood.org/faq.html#eligibility",
				UseShellExecute = true
			});
		}
	}
}
