using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RecordsPatient : UserControl
	{
		HospitalRecords hospitalRecords;
		Patient patient = new Patient();
		Database db = new Database();

		public RecordsPatient(HospitalRecords parent)
		{
			InitializeComponent();
			this.hospitalRecords = parent;

			tbxFName.Text = "First Name";
			tbxMName.Text = "Middle Name";
			tbxLName.Text = "Last Name";
			tbxAge.Text = "Age";
			tbxCNumber.Text = "Contact Number";
			tbxRequest.Text = "Request number of";
		}

		public Patient inputPatient()
		{
			if (isValid())
			{
				return new Patient
				{
					FirstName = tbxFName.Text,
					MiddleName = tbxMName.Text == "Middle Name" ? "" : tbxMName.Text,
					LastName = tbxLName.Text,
					Gender = cmbxSex.SelectedItem?.ToString(),
					Age = tbxAge.Text,
					Barangay = cmbxBarangay.SelectedItem?.ToString(),
					City = cmbxCity.SelectedItem?.ToString(),
					Province = "Cebu",
					ContactNumber = tbxCNumber.Text,
					BloodType = cmbxBType.SelectedItem?.ToString(),
					Request = tbxRequest.Text,
					Priority = cmbxPriority.SelectedItem?.ToString()
				};
			}

			return null;
		}

		public void selectPatient(Patient patient)
		{
			tbxFName.Text = patient.FirstName;
			tbxMName.Text = string.IsNullOrWhiteSpace(patient.MiddleName) ? "" : patient.MiddleName;
			tbxLName.Text = patient.LastName;
			cmbxSex.SelectedItem = patient.Gender;
			tbxAge.Text = patient.Age;
			cmbxCity.SelectedItem = patient.City;
			loadBarangays(patient.City);
			cmbxBarangay.SelectedItem = patient.Barangay;
			tbxCNumber.Text = patient.ContactNumber;
			cmbxBType.SelectedItem = patient.BloodType;
			tbxRequest.Text = patient.Request;
			cmbxPriority.SelectedItem = patient.Priority;
		}

		private bool isValid()
		{
			if (string.IsNullOrWhiteSpace(tbxFName.Text) || string.IsNullOrWhiteSpace(tbxLName.Text) || string.IsNullOrWhiteSpace(cmbxSex.SelectedItem?.ToString()) ||
				string.IsNullOrWhiteSpace(tbxAge.Text) || string.IsNullOrWhiteSpace(cmbxBarangay.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(cmbxCity.SelectedItem?.ToString()) ||
				string.IsNullOrWhiteSpace(tbxCNumber.Text) || string.IsNullOrWhiteSpace(cmbxBType.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(tbxRequest.Text) ||
				string.IsNullOrWhiteSpace(cmbxPriority.SelectedItem?.ToString()) || cmbxSex.SelectedIndex == 0 || cmbxCity.SelectedIndex == 0 || cmbxBType.SelectedIndex == 0 || 
				cmbxPriority.SelectedIndex == 0)
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (!ExceptionHandling.validAge(tbxAge.Text, out int age))
			{
				MessageBox.Show("Invalid age.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}

		private void cmbxCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedCity = cmbxCity.SelectedItem?.ToString();

			if (!string.IsNullOrEmpty(selectedCity))
			{
				loadBarangays(selectedCity);
			}
		}

		private void loadBarangays(string city)
		{
			if (string.IsNullOrWhiteSpace(city)) return;

			string query = "SELECT Barangay FROM Address WHERE City = ? ORDER BY Barangay ASC";

			OleDbParameter[] parameters = { new OleDbParameter("?", city) };
			DataTable barangayData = db.executeQuery(query, parameters);

			cmbxBarangay.Items.Clear();

			if (barangayData != null && barangayData.Rows.Count > 0)
			{
				foreach (DataRow row in barangayData.Rows)
				{
					cmbxBarangay.Items.Add(row["Barangay"].ToString());
				}

				if (patient.Barangay != null && cmbxBarangay.Items.Contains(patient.Barangay))
				{
					cmbxBarangay.SelectedItem = patient.Barangay;
				}
				else
				{
					cmbxBarangay.SelectedIndex = 0;
				}
			}
		}

		private void tbxFName_Enter(object sender, EventArgs e)
		{
			if (tbxFName.Text == "First Name")
				tbxFName.Text = "";
		}

		private void tbxMName_Enter(object sender, EventArgs e)
		{
			if (tbxMName.Text == "Middle Name")
				tbxMName.Text = "";
		}

		private void tbxLName_Enter(object sender, EventArgs e)
		{
			if (tbxLName.Text == "Last Name")
				tbxLName.Text = "";
		}

		private void tbxAge_Enter(object sender, EventArgs e)
		{
			if (tbxAge.Text == "Age")
				tbxAge.Text = "";
		}

		private void tbxCNumber_Enter(object sender, EventArgs e)
		{
			if (tbxCNumber.Text == "Contact Number")
				tbxCNumber.Text = "";
		}

		private void tbxRequest_Enter(object sender, EventArgs e)
		{
			if (tbxRequest.Text == "Request number of")
				tbxRequest.Text = "";
		}

		private void tbxFName_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxFName.Text))
				tbxFName.Text = "First Name";
		}

		private void tbxMName_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxMName.Text))
				tbxMName.Text = "Middle Name";
		}

		private void tbxLName_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxLName.Text))
				tbxLName.Text = "Last Name";
		}

		private void tbxAge_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxAge.Text))
				tbxAge.Text = "Age";
		}

		private void tbxCNumber_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxCNumber.Text))
				tbxCNumber.Text = "Contact Number";
		}

		private void tbxRequest_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxRequest.Text))
				tbxRequest.Text = "Request number of";
		}
	}
}
