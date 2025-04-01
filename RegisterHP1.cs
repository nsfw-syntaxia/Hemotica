using System;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RegisterHP1 : UserControl
	{
		private Register register;
		private Hospital hospital;
		private Database db = new Database();

		public RegisterHP1(Register parent, Hospital hospital)
		{
			InitializeComponent();
			this.register = parent;
			this.hospital = hospital;

			tbxEmailAddress.Text = hospital.Email;
			tbxUsername.Text = hospital.Username;
			tbxPassword.Text = hospital.Password;
			tbxConfirmPassword.Text = hospital.Password;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			hospital.Email = tbxEmailAddress.Text.Trim();
			hospital.Username = tbxUsername.Text.Trim();
			hospital.Password = tbxPassword.Text;
			string confirmPassword = tbxConfirmPassword.Text;

			if (string.IsNullOrWhiteSpace(hospital.Email) || string.IsNullOrWhiteSpace(hospital.Username) || string.IsNullOrWhiteSpace(hospital.Password) || string.IsNullOrWhiteSpace(confirmPassword))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			List<string> errors = new List<string>();

			if (!ExceptionHandling.validEmailAddress(hospital.Email))
				errors.Add("Invalid email address.");

			if (db.userExists("EmailAddress", hospital.Email))
				errors.Add("Email address already exists.");

			if (db.userExists("Username", hospital.Username))
				errors.Add("Username already taken.");

			if (hospital.Password != confirmPassword)
				errors.Add("Passwords do not match.");

			if (errors.Count > 0)
			{
				MessageBox.Show(string.Join("\n", errors), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.showHP2();
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
