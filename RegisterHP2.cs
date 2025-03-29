using System;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RegisterHP2 : UserControl
	{
		private Register register;

		public RegisterHP2(Register parent)
		{
			InitializeComponent();
			this.register = parent;

			tbxHospitalName.Text = register.HospitalName;
			tbxID.Text = register.LicenseID;

			if (register.Classification == rbtnPublic.Text) rbtnPublic.Checked = true;
			else if (register.Classification == rbtnPrivate.Text) rbtnPrivate.Checked = true;

			cmbxStart.SelectedItem = register.WeekdaysStart;
			cmbxEnd.SelectedItem = register.WeekdaysEnd;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			register.showHP1();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			string hospitalName = tbxHospitalName.Text.Trim();
			string licenseID = tbxID.Text.Trim();
			string classification = "";
			string weekdaysStart = cmbxStart.SelectedItem?.ToString();
			string weekdaysEnd = cmbxEnd.SelectedItem?.ToString();

			if (string.IsNullOrWhiteSpace(hospitalName) || string.IsNullOrWhiteSpace(licenseID) || (!rbtnPublic.Checked && !rbtnPrivate.Checked) || string.IsNullOrWhiteSpace(weekdaysStart) || string.IsNullOrWhiteSpace(weekdaysEnd))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (rbtnPublic.Checked)
				classification = rbtnPublic.Text;
			else if (rbtnPrivate.Checked)
				classification = rbtnPrivate.Text;

			register.HospitalName = hospitalName;
			register.LicenseID = licenseID;
			register.Classification = classification;
			register.WeekdaysStart = weekdaysStart;
			register.WeekdaysEnd = weekdaysEnd;

			register.showHP3();
		}
	}
}
