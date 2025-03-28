using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RegisterDP1 : UserControl
	{
		private Register register;
		private Database db = new Database();

		public RegisterDP1(Register parent)
		{
			InitializeComponent();
			this.register = parent;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			string email = tbxEmailAddress.Text.Trim();
			string username = tbxUsername.Text.Trim();
			string password = tbxPassword.Text;
			string confirmPassword = tbxConfirmPassword.Text;

			if (!validEmail(email))
			{
				MessageBox.Show("Invalid email address.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (db.userExists("EmailAddress", email))
			{
				MessageBox.Show("Email address already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (db.userExists("Username", username))
			{
				MessageBox.Show("Username already taken.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (password != confirmPassword)
			{
				MessageBox.Show("Passwords do not match.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			register.EmailAddress = email;
			register.Username = username;
			register.Password = db.hashPassword(password);

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

		private bool validEmail(string email)
		{
			string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
			return Regex.IsMatch(email, pattern);
		}
	}
}
