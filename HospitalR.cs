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
	public partial class HospitalR : UserControl
	{
		public HospitalR()
		{
			InitializeComponent();
		}

		private void lDonors_Click(object sender, EventArgs e)
		{
			flpInputs.Controls.Clear();
			flpInputs.Controls.Add(new Donors());
		}

		private void lPatients_Click(object sender, EventArgs e)
		{
			flpInputs.Controls.Clear();
			flpInputs.Controls.Add(new Patients());
		}
	}
}
