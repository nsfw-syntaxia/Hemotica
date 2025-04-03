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
			forgetPassword.showFP3();
		}
	}
}
