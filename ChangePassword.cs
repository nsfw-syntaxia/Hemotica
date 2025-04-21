using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hemotica
{
	public partial class ChangePassword : UserControl
	{
		private ForgetPassword forgetPassword;
		private Database db = new Database();

		public ChangePassword(ForgetPassword parent)
		{
			InitializeComponent();
			this.forgetPassword = parent;
		}

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			string password = tbxPassword.Text.Trim();
			string newPassword = tbxNewPassword.Text.Trim();

			if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(newPassword))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (password != newPassword)
			{
				MessageBox.Show("Passwords do not match.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string email = forgetPassword.email;
			string userType = forgetPassword.getUserType(email);

			if (string.IsNullOrEmpty(userType))
			{
				return;
			}

			bool updated = forgetPassword.updatePassword(email, newPassword, userType);

			if (updated)
			{
				MessageBox.Show("Password updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				forgetPassword.Opacity = 0;

				if (forgetPassword.Owner is Home home)
				{
					home.showLogin();
				}

				forgetPassword.Close();
			}
			else
			{
				MessageBox.Show("Password update failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cbxSPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (cbxSPassword.Checked)
			{
				tbxPassword.UseSystemPasswordChar = false;
				tbxPassword.PasswordChar = '\0';
				tbxNewPassword.UseSystemPasswordChar = false;
				tbxNewPassword.PasswordChar = '\0';
			}
			else
			{
				tbxPassword.UseSystemPasswordChar = true;
				tbxNewPassword.UseSystemPasswordChar = true;
			}
		}
	}
}
