using System;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class ConfirmEmail : UserControl
	{
		private ForgetPassword forgetPassword;

		public ConfirmEmail(ForgetPassword parent)
		{
			InitializeComponent();
			this.forgetPassword = parent;
		}

		private void btnSendCode_Click(object sender, EventArgs e)
		{
			forgetPassword.showFP2();
		}
	}
}
