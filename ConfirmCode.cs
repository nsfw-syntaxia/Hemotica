using System;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class ConfirmCode : UserControl
	{
		private ForgetPassword forgetPassword;

		public ConfirmCode(ForgetPassword parent)
		{
			InitializeComponent();
			this.forgetPassword = parent;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			forgetPassword.showFP1();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string inputCode = tbxCode.Text.Trim();

			if (string.IsNullOrWhiteSpace(inputCode))
			{
				MessageBox.Show("Please enter the verification code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (inputCode != forgetPassword.code)
			{
				MessageBox.Show("Incorrect verification code. Please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			forgetPassword.showFP3();
		}
	}
}
