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
	public partial class DonorNotification : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DonorNotification()
		{
			InitializeComponent();
		}

		private void DonorN_Load(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			flpNotifications.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpNotifications.Width, flpNotifications.Height, 20, 20));
		}

		private void DonorN_Resize(object sender, EventArgs e)
		{
			roundControls();
		}
	}
}
