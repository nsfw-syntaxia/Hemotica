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
	public partial class HospitalDashboard : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalDashboard()
		{
			InitializeComponent();
		}

		private void HospitalDashboard_Load(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			pBloods.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pBloods.Width, pBloods.Height, 20, 20));
			flpBloods.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpBloods.Width, flpBloods.Height, 20, 20));
			pUrgent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pUrgent.Width, pUrgent.Height, 20, 20));
			flpUrgent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpUrgent.Width, flpUrgent.Height, 20, 20));
			pAppointments.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pAppointments.Width, pAppointments.Height, 20, 20));
			flpAppointments.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpAppointments.Width, flpAppointments.Height, 20, 20));
			pOperations.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pOperations.Width, pOperations.Height, 20, 20));
			flpOperations.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpOperations.Width, flpOperations.Height, 20, 20));
		}

		private void HospitalDashboard_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		private void lblUrgent_Click(object sender, EventArgs e)
		{
			// show patients that needs blood transfusion (and blood is out of stock)
		}

		private void lblAppointments_Click(object sender, EventArgs e)
		{
			// show list of donors appointments
		}
	}
}
