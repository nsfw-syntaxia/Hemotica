using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Hemotica
{
	public partial class DashboardA : Form
	{
		private Database db = new Database();

		bool sidebarExpand = true;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DashboardA(string username)
		{
			InitializeComponent();

			lblUsername.Text = username;
		}

		private void DashboardA_Load(object sender, EventArgs e)
		{
			btnSettings();
			flpSideBar.Width = flpSideBar.MaximumSize.Width;
			sidebarExpand = true;

			pHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHeader.Width, pHeader.Height, 20, 20));
			adjustLayout();
			showAdminDashboard();
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
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			UserLogs.LogoutUser(db);
			Application.Exit();
		}

		private void tSidebar_Tick(object sender, EventArgs e)
		{
			int targetWidth = sidebarExpand ? flpSideBar.MinimumSize.Width : flpSideBar.MaximumSize.Width;
			int step = 30;

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

		private void DashboardA_Resize(object sender, EventArgs e)
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
				ctrl.Height = flpDashboard.Height;

				if (ctrl is DonorDashboard donorDashboard)
				{
					donorDashboard.roundControls();
				}
			}
		}

		private async void btnLogout_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(UserLogs.Username))
			{
				UserLogs.setLogout();
				string logoutSession = UserLogs.Logout;

				string logoutQuery = @"UPDATE UserLogs SET [Logout Session] = ? WHERE [Username] = ? AND [User Type] = ? AND [Logout Session] IS NULL";
				OleDbParameter[] logoutParameters =
				{
					new OleDbParameter("?", logoutSession),
					new OleDbParameter("?", UserLogs.Username),
					new OleDbParameter("?", UserLogs.UserType)
				};

				db.executeNonQuery(logoutQuery, logoutParameters);
				UserLogs.endSession();
			}

			if (Application.OpenForms["Home"] is Home home)
			{
				home.WindowState = FormWindowState.Normal;
				home.Show();
				home.Activate();
				await Task.Delay(1);
			}

			this.Close();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			showAdminDashboard();
		}

		internal void showAdminDashboard()
		{
			lblHeader.Text = "Dashboard";
			flpDashboard.Controls.Clear();
			AdminDashboard adminDashboard = new AdminDashboard();
			flpDashboard.Controls.Add(adminDashboard);
			adjustLayout();
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			showSettings();
		}

		internal void showSettings()
		{
			AdminSettings adminSettings = new AdminSettings();
			adminSettings.ShowDialog();
		}

		private void btnManagement_Click(object sender, EventArgs e)
		{
			showManagementDonors();
		}

		internal void showManagementDonors()
		{
			lblHeader.Text = "Management";
			flpDashboard.Controls.Clear();
			AdminRecords adminRecords = new AdminRecords();
			flpDashboard.Controls.Add(adminRecords);
			adminRecords.donors();
			adjustLayout();
		}

		internal void showManagementHospitals()
		{
			lblHeader.Text = "Management";
			flpDashboard.Controls.Clear();
			AdminRecords adminRecords = new AdminRecords();
			flpDashboard.Controls.Add(adminRecords);
			adminRecords.hospitals();
			adjustLayout();
		}
	}
}
