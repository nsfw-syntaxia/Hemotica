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
	public partial class DonorDB : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DonorDB()
		{
			InitializeComponent();
		}

		private void DonorDB_Load(object sender, EventArgs e)
		{
			pDonation.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pDonation.Width, pDonation.Height, 20, 20));
			pbxDonation.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxDonation.Width, pbxDonation.Height, 20, 20));
			pCharts.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pCharts.Width, pCharts.Height, 20, 20));
			pbxCharts.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxCharts.Width, pbxCharts.Height, 20, 20));
			pHistory.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHistory.Width, pHistory.Height, 20, 20));
			pHospitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHospitals.Width, pHospitals.Height, 20, 20));
			lblDH1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lblDH1.Width, lblDH1.Height, 20, 20));
			lblDH2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lblDH2.Width, lblDH2.Height, 20, 20));
			pH1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pH1.Width, pH1.Height, 20, 20));
			pbxH1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxH1.Width, pbxH1.Height, 20, 20));
			pNext.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pNext.Width, pNext.Height, 20, 20));
		}

		private void btnDonate_Click(object sender, EventArgs e)
		{
			DashboardD dashboard = Application.OpenForms["DashboardD"] as DashboardD;

			if (dashboard == null)
			{
				dashboard = new DashboardD();
				dashboard.Show();
			}

			dashboard.showDonorD();
		}
	}
}
