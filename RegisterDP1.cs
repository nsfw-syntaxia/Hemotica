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

			loadData();
		}

		public void loadData()
		{
			tbxEmailAddress.Text = register.EmailAddress ?? "";
			tbxUsername.Text = register.Username ?? "";
			tbxPassword.Text = register.Password ?? "";
			tbxConfirmPassword.Text = register.Password ?? "";
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			string email = tbxEmailAddress.Text.Trim();
			string username = tbxUsername.Text.Trim();
			string password = tbxPassword.Text;
			string confirmPassword = tbxConfirmPassword.Text;

			List<string> errors = new List<string>();

			if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
			{
				MessageBox.Show("Please fill the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!validEmail(email))
				errors.Add("Invalid email address.");

			if (!string.IsNullOrWhiteSpace(email) && db.userExists("EmailAddress", email))
				errors.Add("Email address already exists.");

			if (!string.IsNullOrWhiteSpace(username) && db.userExists("Username", username))
				errors.Add("Username already taken.");

			if (!string.IsNullOrEmpty(password) && password != confirmPassword)
				errors.Add("Passwords do not match.");

			if (errors.Count > 0)
			{
				MessageBox.Show(string.Join("\n", errors), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.EmailAddress = email;
			register.Username = username;
			register.Password = password;

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
