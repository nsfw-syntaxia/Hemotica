using System;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RegisterDP1 : UserControl
	{
		private Register register;

		public RegisterDP1(Register parent)
		{
			InitializeComponent();
			this.register = parent;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			Database db = new Database();
			string email = tbxEmailAddress.Text.Trim();
			string username = tbxUsername.Text.Trim();
			string password = tbxPassword.Text;
			string confirmPassword = tbxConfirmPassword.Text;

			if (db.search("[Email Address]", email, "Donors"))
			{
				MessageBox.Show("Email address already exists. Please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			if (db.search("[Username]", username, "Donors"))
			{
				MessageBox.Show("Username already exists. Please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (password != confirmPassword)
			{
				MessageBox.Show("Passwords do not match.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
