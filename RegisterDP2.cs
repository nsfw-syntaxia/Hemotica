using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class RegisterDP2 : UserControl
    {
        private Register register;
		private Donor donor;

		public RegisterDP2(Register parent, Donor donor)
        {
            InitializeComponent();
            this.register = parent;
			this.donor = donor;

			tbxFirstName.Text = donor.FirstName;
			tbxMiddleName.Text = donor.MiddleName;
			tbxLastName.Text = donor.LastName;

			if (donor.Gender == rbtnMale.Text) rbtnMale.Checked = true;
			else if (donor.Gender == rbtnFemale.Text) rbtnFemale.Checked = true;
			else if (donor.Gender == rbtnOther.Text) rbtnOther.Checked = true;
			else if (donor.Gender == rbtnPNTS.Text) rbtnPNTS.Checked = true;
		}

        private void btnNext_Click(object sender, EventArgs e)
        {
			donor.FirstName = tbxFirstName.Text.Trim();
			donor.MiddleName = tbxMiddleName.Text.Trim();
			donor.LastName = tbxLastName.Text.Trim();
			donor.Gender = "";

			if (rbtnMale.Checked)
				donor.Gender = rbtnMale.Text;
			else if (rbtnFemale.Checked)
				donor.Gender = rbtnFemale.Text;
			else if (rbtnOther.Checked)
				donor.Gender = rbtnOther.Text;
			else if (rbtnPNTS.Checked)
				donor.Gender = rbtnPNTS.Text;

			if (string.IsNullOrWhiteSpace(donor.FirstName) || string.IsNullOrWhiteSpace(donor.LastName) || string.IsNullOrWhiteSpace(donor.Gender))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.showDP3();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            register.showDP1();
        }
	}
}
