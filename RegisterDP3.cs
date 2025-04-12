using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RegisterDP3 : UserControl
	{
		private Register register;
		private Donor donor;
		private Database db = new Database();

		public RegisterDP3(Register parent, Donor donor)
		{
			InitializeComponent();
			this.register = parent;
			this.donor = donor;

			tbxBirthdate.Text = donor.Birthdate;
			tbxProvince.Text = donor.Province;
			cmbxCity.SelectedItem = donor.City;
			loadBarangays(donor.City);
			cmbxBarangay.SelectedItem = donor.Barangay;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			donor.Birthdate = tbxBirthdate.Text.Trim();
			donor.Province = "Cebu";
			donor.City = cmbxCity.SelectedItem?.ToString();
			donor.Barangay = cmbxBarangay.SelectedItem?.ToString();

			if (string.IsNullOrWhiteSpace(donor.Birthdate) || string.IsNullOrWhiteSpace(donor.City) || string.IsNullOrWhiteSpace(donor.Barangay))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!ExceptionHandling.validBirthdate(donor.Birthdate, out DateTime birthdate))
			{
				MessageBox.Show("Invalid birthdate.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			donor.Age = calculateAge(birthdate);

			if (!ExceptionHandling.validAge(donor.Age, out int age))
			{
				MessageBox.Show("Invalid age.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.showDP4();
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

			string query = "SELECT Barangay FROM Address WHERE City = @City ORDER BY Barangay ASC";

			OleDbParameter[] parameters = { new OleDbParameter("@City", city) };
			DataTable barangayData = db.executeQuery(query, parameters);

			cmbxBarangay.Items.Clear();

			if (barangayData != null && barangayData.Rows.Count > 0)
			{
				foreach (DataRow row in barangayData.Rows)
				{
					cmbxBarangay.Items.Add(row["Barangay"].ToString());
				}
				cmbxBarangay.SelectedIndex = 0;
			}
		}

		private int calculateAge(DateTime birthdate)
		{
			DateTime today = DateTime.Today;
			int age = today.Year - birthdate.Year;
			if (birthdate.Date > today.AddYears(-age))
				age--;
			return age;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			register.showDP2();
		}
	}
}
