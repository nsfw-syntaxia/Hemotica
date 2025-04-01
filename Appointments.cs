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

		public Appointments(DateTime date)
		{
			InitializeComponent();
			selectedDate = date;
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
				string query = "SELECT [Hospital Name] FROM Hospitals";
				DataTable dt = db.executeQuery(query);

				cmbxHospitals.DataSource = dt;
				cmbxHospitals.DisplayMember = "Hospital Name";
				cmbxHospitals.ValueMember = "Hospital Name";
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

			string status = (rbtnYes1.Checked && rbtnYes2.Checked && rbtnYes3.Checked &&
							 rbtnYes4.Checked && rbtnYes5.Checked && rbtnYes6.Checked) ? "Approved" : "Denied";

			string query = "INSERT INTO Appointments ([Donor Username], [Appointment Date], Hospital, Status) VALUES (@username, @date, @hospital, @status)";

			OleDbParameter[] parameters = 
			{
				new OleDbParameter("@username", UserLogs.Username),
				new OleDbParameter("@date", dtpAppointments.Value.ToString("MM/dd/yyyy")),
				new OleDbParameter("@hospital", cmbxHospitals.SelectedValue.ToString()),
				new OleDbParameter("@status", status)
			};

			if (db.executeNonQuery(query, parameters))
			{
				if (status == "Denied")
				{
					MessageBox.Show("Appointment denied. Donor is not eligible.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("Appointment saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				this.Close();
			}
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
