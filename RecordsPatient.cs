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
		}

		public Patient inputPatient()
		{
			if (isValid())
			{
				return new Patient
				{
					FirstName = tbxFName.Text,
					MiddleName = tbxMName.Text,
					LastName = tbxLName.Text,
					Gender = cmbxSex.SelectedItem.ToString(),
					Age = tbxAge.Text,
					Barangay = cmbxBarangay.SelectedItem?.ToString(),
					City = cmbxCity.SelectedItem?.ToString(),
					Province = "Cebu",
					ContactNumber = tbxCNumber.Text,
					BloodType = cmbxBType.SelectedItem.ToString()
				};
			}

			return null;
		}

		private bool isValid()
		{
			if (string.IsNullOrWhiteSpace(tbxFName.Text) || string.IsNullOrWhiteSpace(tbxLName.Text) || string.IsNullOrWhiteSpace(cmbxSex.SelectedItem.ToString()) ||
				string.IsNullOrWhiteSpace(tbxAge.Text) || string.IsNullOrWhiteSpace(cmbxBarangay.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(cmbxCity.SelectedItem?.ToString()) ||
				string.IsNullOrWhiteSpace(tbxCNumber.Text) || string.IsNullOrWhiteSpace(cmbxBType.SelectedItem.ToString()))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (cmbxSex.SelectedItem.ToString() == "Select gender" || cmbxCity.SelectedItem.ToString() == "Select city" || cmbxBType.SelectedItem.ToString() == "Select blood type")
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
	}
}
