using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hemotica
{
	public partial class DonorDashboard : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DonorDashboard()
		{
			InitializeComponent();
		}

		private void DonorDashboard_Load(object sender, EventArgs e)
		{
			roundControls();
		}

		private void DonorDashboard_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			pBloodDrives.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pBloodDrives.Width, pBloodDrives.Height, 20, 20));
			pHospitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHospitals.Width, pHospitals.Height, 20, 20));
			pAnalytics.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pAnalytics.Width, pAnalytics.Height, 20, 20));
			pLogs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pLogs.Width, pLogs.Height, 20, 20));

			if (pbxBloodDrives.Width > 0 && pbxBloodDrives.Height > 0)
			{
				pbxBloodDrives.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxBloodDrives.Width, pbxBloodDrives.Height, 20, 20));
			}

			flpHospitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpHospitals.Width, flpHospitals.Height, 20, 20));
			flpAnalytics.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpAnalytics.Width, flpAnalytics.Height, 20, 20));
			flpLogs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpLogs.Width, flpLogs.Height, 20, 20));
		}

		private void lblHospitals_Click(object sender, EventArgs e)
		{
			// show list of registered hospitals to donate
		}

		private void lblLogs_Click(object sender, EventArgs e)
		{
			// show list of donation history
		}
	}
}
