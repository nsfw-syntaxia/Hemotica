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
	public partial class DonorProfile : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DonorProfile()
		{
			InitializeComponent();
		}

		private void DonorP_Load(object sender, EventArgs e)
		{
			roundControls();
		}

		private void DonorProfile_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			pProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pProfile.Width, pProfile.Height, 20, 20));
			pbxProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxProfile.Width, pbxProfile.Height, 20, 20));
		}
	}
}
