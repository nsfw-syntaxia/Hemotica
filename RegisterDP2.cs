using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class RegisterDP2 : UserControl
    {
        private Register register;

        public RegisterDP2(Register parent)
        {
            InitializeComponent();
            this.register = parent;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
			string firstName = tbxFirstName.Text.Trim();
			string middleName = tbxMiddleName.Text.Trim();
			string lastName = tbxLastName.Text.Trim();
			string gender = "";

			if (string.IsNullOrWhiteSpace(firstName))
			{
				MessageBox.Show("First name is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrWhiteSpace(lastName))
			{
				MessageBox.Show("Last name is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (rbtnMale.Checked)
			{
				gender = rbtnMale.Text;
			}
			else if (rbtnFemale.Checked)
			{
				gender = rbtnFemale.Text;
			}
			else if (rbtnOther.Checked)
			{
				gender = rbtnOther.Text;
			}
			else if (rbtnPNTS.Checked)
			{
				gender = rbtnPNTS.Text;
			}
			else
			{
				MessageBox.Show("Please select a gender.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.FirstName = firstName;
			register.MiddleName = middleName;
			register.LastName = lastName;
			register.Gender = gender;

			register.showDP3();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            register.showDP1();
        }
	}
}
