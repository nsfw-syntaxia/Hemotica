using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RegisterDP3 : UserControl
	{
		private Register register;

		public RegisterDP3(Register parent)
		{
			InitializeComponent();
			this.register = parent;

			tbxProvince.Text = register.Province;
			cmbxCity.SelectedItem = register.City;
			loadBarangays(register.City);
			cmbxBarangay.SelectedItem = register.Barangay;
			tbxAge.Text = register.Age;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			register.showDP2();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			string province = "Cebu";
			string city = cmbxCity.SelectedItem?.ToString();
			string barangay = cmbxBarangay.SelectedItem?.ToString();
			string ageDonor = tbxAge.Text.Trim();

			if (string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(barangay) || string.IsNullOrWhiteSpace(ageDonor))
			{
				MessageBox.Show("Please fill the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(ageDonor, out int age) || age < 1 || age > 120)
			{
				MessageBox.Show("Invalid age input.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.Province = province;
			register.City = city;
			register.Barangay = barangay;
			register.Age = ageDonor;

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

			Database db = new Database();
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
