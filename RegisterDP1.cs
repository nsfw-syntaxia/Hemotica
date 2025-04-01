using System;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RegisterDP1 : UserControl
	{
		private Register register;
		private Donor donor;
		private Database db = new Database();

		public RegisterDP1(Register parent, Donor donor)
		{
			InitializeComponent();
			this.register = parent;
			this.donor = donor;

			tbxEmailAddress.Text = donor.Email;
			tbxUsername.Text = donor.Username;
			tbxPassword.Text = donor.Password;
			tbxConfirmPassword.Text = donor.Password;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			donor.Email = tbxEmailAddress.Text.Trim();
			donor.Username = tbxUsername.Text.Trim();
			donor.Password = tbxPassword.Text;
			string confirmPassword = tbxConfirmPassword.Text;

			if (string.IsNullOrWhiteSpace(donor.Email) || string.IsNullOrWhiteSpace(donor.Username) || string.IsNullOrWhiteSpace(donor.Password) || string.IsNullOrWhiteSpace(confirmPassword))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			List<string> errors = new List<string>();

			if (!ExceptionHandling.validEmailAddress(donor.Email))
				errors.Add("Invalid email address.");

			if (db.userExists("EmailAddress", donor.Email))
				errors.Add("Email address already exists.");

			if (db.userExists("Username", donor.Username))
				errors.Add("Username already taken.");

			if (donor.Password != confirmPassword)
				errors.Add("Passwords do not match.");

			if (errors.Count > 0)
			{
				MessageBox.Show(string.Join("\n", errors), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.showDP2();
		}

		private void cbxSPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (cbxSPassword.Checked)
			{
				tbxPassword.UseSystemPasswordChar = false;
				tbxPassword.PasswordChar = '\0';
				tbxConfirmPassword.UseSystemPasswordChar = false;
				tbxConfirmPassword.PasswordChar = '\0';
			}
			else
			{
				tbxPassword.UseSystemPasswordChar = true;	
				tbxConfirmPassword.UseSystemPasswordChar = true;
			}
		}
	}
}
