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
	public partial class DonorAppointments : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DonorAppointments()
		{
			InitializeComponent();
		}

		private void DonorAppointments_Load(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			flpAppointments.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpAppointments.Width, flpAppointments.Height, 20, 20));
		}

		private void btnCalendar_Click(object sender, EventArgs e)
		{
			DashboardD donateCalendar = Application.OpenForms["DashboardD"] as DashboardD;

			if (donateCalendar != null)
			{
				donateCalendar.showCalendar();
			}
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			DashboardD donateAppointments = Application.OpenForms["DashboardD"] as DashboardD;

			if (donateAppointments != null)
			{
				donateAppointments.showAppointments();
			}
		}

		private void DonorAppointments_Resize(object sender, EventArgs e)
		{
			roundControls();
		}
	}
}
