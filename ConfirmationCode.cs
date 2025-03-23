using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class ConfirmationCode : UserControl
	{
		private ForgetPassword forgetPassword;

		public ConfirmationCode(ForgetPassword parent)
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
