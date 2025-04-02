using System;
using System.Data;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RecordsPhysician : UserControl
	{
		HospitalRecords hospitalRecords;
		Physician physician = new Physician();
		Database db = new Database();

		public RecordsPhysician(HospitalRecords parent)
		{
			InitializeComponent();
			this.hospitalRecords = parent;

			tbxFName.Text = "First Name";
			tbxMName.Text = "Middle Name";
			tbxLName.Text = "Last Name";
			tbxAge.Text = "Age";
			tbxSpecialization.Text = "Specialization";
			tbxLicense.Text = "License";
			tbxCNumber.Text = "Contact Number";
		}

		public Physician inputPhysician()
		{
			if (isValid())
			{
				return new Physician
				{
					FirstName = tbxFName.Text,
					MiddleName = tbxMName.Text == "Middle Name" ? "" : tbxMName.Text,
					LastName = tbxLName.Text,
					Gender = cmbxSex.SelectedItem?.ToString(),
					Age = tbxAge.Text,
					Specialization = tbxSpecialization.Text,
					License = tbxLicense.Text,
					ContactNumber = tbxCNumber.Text
				};
			}

			return null;
		}

		public void selectPhysician(Physician physician)
		{
			tbxFName.Text = physician.FirstName;
			tbxMName.Text = string.IsNullOrWhiteSpace(physician.MiddleName) ? "" : physician.MiddleName;
			tbxLName.Text = physician.LastName;
			cmbxSex.SelectedItem = physician.Gender;
			tbxAge.Text = physician.Age;
			tbxSpecialization.Text = physician.Specialization;
			tbxLicense.Text = physician.License;
			tbxCNumber.Text = physician.ContactNumber;
		}

		private bool isValid()
		{
			if (string.IsNullOrWhiteSpace(tbxFName.Text) || string.IsNullOrWhiteSpace(tbxLName.Text) || string.IsNullOrWhiteSpace(cmbxSex.SelectedItem?.ToString()) ||
				string.IsNullOrWhiteSpace(tbxAge.Text) || string.IsNullOrWhiteSpace(tbxSpecialization.Text) || string.IsNullOrWhiteSpace(tbxLicense.Text) ||
				string.IsNullOrWhiteSpace(tbxCNumber.Text) || cmbxSex.SelectedIndex == 0)
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

		private void tbxFName_Enter(object sender, EventArgs e)
		{
			if (tbxFName.Text == "First Name")
				tbxFName.Text = "";
		}

		private void tbxFName_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxFName.Text))
				tbxFName.Text = "First Name";
		}

		private void tbxMName_Enter(object sender, EventArgs e)
		{
			if (tbxMName.Text == "Middle Name")
				tbxMName.Text = "";
		}

		private void tbxMName_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxMName.Text))
				tbxMName.Text = "Middle Name";
		}

		private void tbxLName_Enter(object sender, EventArgs e)
		{
			if (tbxLName.Text == "Last Name")
				tbxLName.Text = "";
		}

		private void tbxLName_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxLName.Text))
				tbxLName.Text = "Last Name";
		}

		private void tbxAge_Enter(object sender, EventArgs e)
		{
			if (tbxAge.Text == "Age")
				tbxAge.Text = "";
		}

		private void tbxAge_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxAge.Text))
				tbxAge.Text = "Age";
		}

		private void tbxSpecialization_Enter(object sender, EventArgs e)
		{
			if (tbxSpecialization.Text == "Specialization")
				tbxSpecialization.Text = "";
		}

		private void tbxSpecialization_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxSpecialization.Text))
				tbxSpecialization.Text = "Specialization";
		}

		private void tbxLicense_Enter(object sender, EventArgs e)
		{
			if (tbxLicense.Text == "License Number")
				tbxLicense.Text = "";
		}

		private void tbxLicense_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxLicense.Text))
				tbxLicense.Text = "License Number";
		}

		private void tbxCNumber_Enter(object sender, EventArgs e)
		{
			if (tbxCNumber.Text == "Contact Number")
				tbxCNumber.Text = "";
		}

		private void tbxCNumber_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxCNumber.Text))
				tbxCNumber.Text = "Contact Number";
		}
	}
}
