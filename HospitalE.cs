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
	public partial class HospitalE : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalE()
		{
			InitializeComponent();
		}

		private void HospitalE_Load(object sender, EventArgs e)
		{
			pQR.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pQR.Width, pQR.Height, 20, 20));
			flpBar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpBar.Width, flpBar.Height, 20, 20));
		}
	}
}
