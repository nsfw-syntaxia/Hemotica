using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hemotica
{
	public partial class HospitalExtraction : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalExtraction()
		{
			InitializeComponent();
		}

		private void HospitalExtraction_Load(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			pExtraction.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pExtraction.Width, pExtraction.Height, 20, 20));
			pDonate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pDonate.Width, pDonate.Height, 20, 20));
			pBarCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pBarCode.Width, pBarCode.Height, 20, 20));

			if (pbxBarCode.Width > 0 && pbxBarCode.Height > 0)
			{
				pbxBarCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxBarCode.Width, pbxBarCode.Height, 20, 20));
			}
		}

		private void HospitalExtraction_Resize(object sender, EventArgs e)
		{
			roundControls();
		}
	}
}
