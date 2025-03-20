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
	public partial class HospitalDB : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalDB()
		{
			InitializeComponent();
		}

		private void HospitalDB_Load(object sender, EventArgs e)
		{
			pbxDonors.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxDonors.Width, pbxDonors.Height, 20, 20));
			pbxPatients.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxPatients.Width, pbxPatients.Height, 20, 20));
			pbxExtractions.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxExtractions.Width, pbxExtractions.Height, 20, 20));
			pbxTransfusions.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxTransfusions.Width, pbxTransfusions.Height, 20, 20));
			pbxAP.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxAP.Width, pbxAP.Height, 20, 20));
			pbxAN.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxAN.Width, pbxAN.Height, 20, 20));
			pbxBP.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxBP.Width, pbxBP.Height, 20, 20));
			pbxBN.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxBN.Width, pbxBN.Height, 20, 20));
			pbxOP.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxOP.Width, pbxOP.Height, 20, 20));
			pbxON.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxON.Width, pbxON.Height, 20, 20));
			pbxABP.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxABP.Width, pbxABP.Height, 20, 20));
			pbxABN.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxABN.Width, pbxABN.Height, 20, 20));
			pbxPieChart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxPieChart.Width, pbxPieChart.Height, 20, 20));
			pbxLineGraph.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxLineGraph.Width, pbxLineGraph.Height, 20, 20));
		}
	}
}
