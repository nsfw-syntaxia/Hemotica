using System;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class ChangePassword : UserControl
	{
		private ForgetPassword forgetPassword;

		public ChangePassword(ForgetPassword parent)
		{
			InitializeComponent();
			this.forgetPassword = parent;
		}

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			forgetPassword.Opacity = 0;

			if (forgetPassword.Owner is Home home)
			{
				home.showLogin();
			}

			forgetPassword.Close();
		}
	}
}
