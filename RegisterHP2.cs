using System;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RegisterHP2 : UserControl
	{
		private Register register;
		private Hospital hospital;

		public RegisterHP2(Register parent, Hospital hospital)
		{
			InitializeComponent();
			this.register = parent;
			this.hospital = hospital;

			tbxHospitalName.Text = hospital.HospitalName;
			tbxID.Text = hospital.LicenseNumber;

			if (hospital.Classification == rbtnPublic.Text) rbtnPublic.Checked = true;
			else if (hospital.Classification == rbtnPrivate.Text) rbtnPrivate.Checked = true;

			cmbxStart.SelectedItem = hospital.WeekdayStart;
			cmbxEnd.SelectedItem = hospital.WeekdayEnd;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			hospital.HospitalName = tbxHospitalName.Text.Trim();
			hospital.LicenseNumber = tbxID.Text.Trim();
			hospital.Classification = "";
			hospital.WeekdayStart = cmbxStart.SelectedItem?.ToString();
			hospital.WeekdayEnd = cmbxEnd.SelectedItem?.ToString();

			if (rbtnPublic.Checked)
				hospital.Classification = rbtnPublic.Text;
			else if (rbtnPrivate.Checked)
				hospital.Classification = rbtnPrivate.Text;

			if (string.IsNullOrWhiteSpace(hospital.HospitalName) || string.IsNullOrWhiteSpace(hospital.LicenseNumber) || string.IsNullOrWhiteSpace(hospital.Classification) || 
				string.IsNullOrWhiteSpace(hospital.WeekdayStart) || string.IsNullOrWhiteSpace(hospital.WeekdayEnd))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.showHP3();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			register.showHP1();
		}
	}
}
