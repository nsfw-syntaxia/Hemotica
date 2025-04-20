using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class AdminSettings : Form
	{
		Admin admin = new Admin();
		Database db = new Database();

		public AdminSettings()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
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

			bool updated  = admin.updatePassword(db, newPassword);

			if (updated)
			{
				MessageBox.Show("Password updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				this.Close();
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
