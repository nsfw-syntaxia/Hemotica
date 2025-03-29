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

			tbxFirstName.Text = register.FirstName;
			tbxMiddleName.Text = register.MiddleName;
			tbxLastName.Text = register.LastName;

			if (register.Gender == rbtnMale.Text) rbtnMale.Checked = true;
			else if (register.Gender == rbtnFemale.Text) rbtnFemale.Checked = true;
			else if (register.Gender == rbtnOther.Text) rbtnOther.Checked = true;
			else if (register.Gender == rbtnPNTS.Text) rbtnPNTS.Checked = true;
		}

        private void btnNext_Click(object sender, EventArgs e)
        {
			string firstName = tbxFirstName.Text.Trim();
			string middleName = tbxMiddleName.Text.Trim();
			string lastName = tbxLastName.Text.Trim();
			string gender = "";

			if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || (!rbtnMale.Checked && !rbtnFemale.Checked && !rbtnOther.Checked && !rbtnPNTS.Checked))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (rbtnMale.Checked)
				gender = rbtnMale.Text;
			else if (rbtnFemale.Checked)
				gender = rbtnFemale.Text;
			else if (rbtnOther.Checked)
				gender = rbtnOther.Text;
			else if (rbtnPNTS.Checked)
				gender = rbtnPNTS.Text;

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
