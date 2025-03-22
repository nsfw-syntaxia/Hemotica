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
	public partial class HospitalNotification : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalNotification()
		{
			InitializeComponent();
		}

		private void HospitalNotification_Load(object sender, EventArgs e)
		{
			roundControls();
		}

		private void HospitalNotification_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			flpNotifications.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpNotifications.Width, flpNotifications.Height, 20, 20));
		}
	}
}
