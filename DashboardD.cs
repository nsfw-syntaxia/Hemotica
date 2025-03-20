using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hemotica
{
	public partial class DashboardD : Form
	{
		bool sidebarExpand = false;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DashboardD()
		{
			InitializeComponent();
		}

		private void DashboardD_Load(object sender, EventArgs e)
		{
			btnSettings();
			flpSideBar.Width = flpSideBar.MinimumSize.Width;
			sidebarExpand = false;

			pHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHeader.Width, pHeader.Height, 20, 20));
			showDonorDB();
		}

		private void btnEffects(Button button, Color highlightColor)
		{
			button.FlatAppearance.BorderSize = 0;

			button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(50, highlightColor);
			button.MouseLeave += (s, e) => button.BackColor = Color.Transparent;
		}

		private void btnSettings()
		{
			btnEffects(btnClose, Color.Red);
			btnEffects(btnMaximize, Color.Lime);
			btnEffects(btnMinimize, Color.Yellow);
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
				this.WindowState = FormWindowState.Normal;
			else
				this.WindowState = FormWindowState.Maximized;
			flpSideBar.Height = this.ClientSize.Height;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void tSidebar_Tick(object sender, EventArgs e)
		{
			int targetWidth = sidebarExpand ? flpSideBar.MinimumSize.Width : flpSideBar.MaximumSize.Width;
			int step = Math.Max(10, Math.Abs(flpSideBar.Width - targetWidth) / 3);

			if (flpSideBar.Width != targetWidth)
			{
				flpSideBar.Width += sidebarExpand ? -step : step;
			}

			if (Math.Abs(flpSideBar.Width - targetWidth) <= step)
			{
				flpSideBar.Width = targetWidth;
				sidebarExpand = !sidebarExpand;
				tSidebar.Stop();
			}

			adjustLayout();
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			tSidebar.Start();
		}

		private void DashboardD_Resize(object sender, EventArgs e)
		{
			flpSideBar.Height = this.ClientSize.Height;
			flpSideBar.MaximumSize = new Size(flpSideBar.MaximumSize.Width, this.ClientSize.Height);
			adjustLayout();
		}

		private void adjustLayout()
		{
			int sidebarWidth = flpSideBar.Width;

			pHeader.Left = sidebarWidth + 10;
			pHeader.Width = this.ClientSize.Width - sidebarWidth - 20;

			pHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHeader.Width, pHeader.Height, 20, 20));

			flpDashboard.Left = sidebarWidth + 10;
			flpDashboard.Width = this.ClientSize.Width - sidebarWidth - 20;

			foreach (Control ctrl in flpDashboard.Controls)
			{
				ctrl.Width = flpDashboard.Width;
			}
		}

		private async void btnLogout_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["Home"] is Home home)
			{
				home.WindowState = FormWindowState.Normal;
				home.Show();
				home.Activate();
				await Task.Delay(1);
			}

			this.Hide();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			showDonorDB();
		}

		internal void showDonorDB()
		{
			lblHeader.Text = "Dashboard";
			flpDashboard.Controls.Clear();
			DonorDB donorDB = new DonorDB();
			flpDashboard.Controls.Add(donorDB);
			adjustLayout();
		}

		private void btnDonate_Click(object sender, EventArgs e)
		{
			showDonorD();
		}

		internal void showDonorD()
		{
			lblHeader.Text = "Donate";
			flpDashboard.Controls.Clear();
			DonorD donorD = new DonorD();
			flpDashboard.Controls.Add(donorD);
			adjustLayout();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			showAppointments();
		}

		internal void showAppointments()
		{
			lblHeader.Text = "Donate";
			flpDashboard.Controls.Clear();
			Appointments appointmentsList = new Appointments();
			flpDashboard.Controls.Add(appointmentsList);
			adjustLayout();
		}

		private void btnNotification_Click(object sender, EventArgs e)
		{
			showDonorN();
		}

		internal void showDonorN()
		{
			lblHeader.Text = "Notifications";
			flpDashboard.Controls.Clear();
			DonorN donorN = new DonorN();
			flpDashboard.Controls.Add(donorN);
			adjustLayout();
		}
	}
}
