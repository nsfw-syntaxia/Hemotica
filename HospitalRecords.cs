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
	public partial class HospitalRecords : UserControl
	{
		public HospitalRecords()
		{
			InitializeComponent();
		}

		private void lDonors_Click(object sender, EventArgs e)
		{
			flpInputs.Controls.Clear();
			flpInputs.Controls.Add(new RecordsDonor());
		}

		private void lPatients_Click(object sender, EventArgs e)
		{
			flpInputs.Controls.Clear();
			flpInputs.Controls.Add(new RecordsPatient());
		}

		private void lAppointments_Click(object sender, EventArgs e)
		{
			flpInputs.Controls.Clear();
		}
	}
}
