using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RecordsDonor : UserControl
	{
		HospitalRecords hospitalRecords;
		Donor donor = new Donor();
		Database db = new Database();

		public RecordsDonor(HospitalRecords parent)
		{
			InitializeComponent();
			this.hospitalRecords = parent;

			tbxFName.Text = "First Name";
			tbxMName.Text = "Middle Name";
			tbxLName.Text = "Last Name";
			tbxAge.Text = "Age";
			tbxCNumber.Text = "Contact Number";
		}

		public Donor inputDonor()
		{
			if (isValid())
			{
				return new Donor
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
					BloodType = cmbxBType.SelectedItem?.ToString()
				};
			}

			return null;
		}

		public void selectDonor(Donor donor)
		{
			tbxFName.Text = donor.FirstName;
			tbxMName.Text = string.IsNullOrWhiteSpace(donor.MiddleName) ? "" : donor.MiddleName;
			tbxLName.Text = donor.LastName;
			cmbxSex.SelectedItem = donor.Gender;
			tbxAge.Text = donor.Age;
			cmbxCity.SelectedItem = donor.City;
			loadBarangays(donor.City);
			cmbxBarangay.SelectedItem = donor.Barangay;
			tbxCNumber.Text = donor.ContactNumber;
			cmbxBType.SelectedItem = donor.BloodType;
		}

		private bool isValid()
		{
			if (string.IsNullOrWhiteSpace(tbxFName.Text) || string.IsNullOrWhiteSpace(tbxLName.Text) || string.IsNullOrWhiteSpace(cmbxSex.SelectedItem?.ToString()) ||
				string.IsNullOrWhiteSpace(tbxAge.Text) || string.IsNullOrWhiteSpace(cmbxBarangay.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(cmbxCity.SelectedItem?.ToString()) ||
				string.IsNullOrWhiteSpace(tbxCNumber.Text) || string.IsNullOrWhiteSpace(cmbxBType.SelectedItem?.ToString()) || cmbxSex.SelectedIndex == 0 || cmbxCity.SelectedIndex == 0 || 
				cmbxBType.SelectedIndex == 0)
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			List<string> errors = new List<string>();

			if (!ExceptionHandling.validAge(tbxAge.Text, out int age))
				errors.Add("Invalid age.");

			if(!ExceptionHandling.validContactNumber(tbxCNumber.Text))
				errors.Add("Invalid contact number.");

			if (errors.Count > 0)
			{
				MessageBox.Show(string.Join("\n", errors), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

				if (donor.Barangay != null && cmbxBarangay.Items.Contains(donor.Barangay))
				{
					cmbxBarangay.SelectedItem = donor.Barangay;
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
	}
}
