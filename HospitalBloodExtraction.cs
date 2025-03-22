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
	public partial class HospitalBloodExtraction : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalBloodExtraction()
		{
			InitializeComponent();
		}

		private void HospitalBloodExtraction_Load(object sender, EventArgs e)
		{
			roundControls();
		}

		private void HospitalBloodExtraction_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			pQRCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pQRCode.Width, pQRCode.Height, 20, 20));
			pBarcode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pBarcode.Width, pBarcode.Height, 20, 20));

			if (pbxQRCode.Width > 0 && pbxQRCode.Height > 0)
			{
				pbxQRCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxQRCode.Width, pbxQRCode.Height, 20, 20));
			}

			if (pbxBarcode.Width > 0 && pbxBarcode.Height > 0)
			{
				pbxBarcode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxBarcode.Width, pbxBarcode.Height, 20, 20));
			}
		}
	}
}
