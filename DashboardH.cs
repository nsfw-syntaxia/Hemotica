using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hemotica
{
	public partial class DashboardH : Form
	{
		bool sidebarExpand = false;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DashboardH()
		{
			InitializeComponent();
		}

		private void DashboardD_Load(object sender, EventArgs e)
		{
			btnSettings();
			flpSideBar.Width = flpSideBar.MinimumSize.Width;
			sidebarExpand = false;

			pHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHeader.Width, pHeader.Height, 20, 20));
			showHospitalDashboard();
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

		private void DashboardH_Resize(object sender, EventArgs e)
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

				if (ctrl is HospitalDashboard hospitalDashboard)
				{
					hospitalDashboard.roundControls();
				}
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
			showHospitalDashboard();
		}

		internal void showHospitalDashboard()
		{
			lblHeader.Text = "Dashboard";
			flpDashboard.Controls.Clear();
			HospitalDashboard hospitalDashboard = new HospitalDashboard();
			flpDashboard.Controls.Add(hospitalDashboard);
			adjustLayout();
		}

		private void btnRecords_Click(object sender, EventArgs e)
		{
			showHospitalRecords();

		}

		internal void showHospitalRecords()
		{
			lblHeader.Text = "Records";
			flpDashboard.Controls.Clear();
			HospitalRecords hospitalRecords = new HospitalRecords();
			flpDashboard.Controls.Add(hospitalRecords);
			adjustLayout();
		}

		private void btnNotification_Click(object sender, EventArgs e)
		{
			showHospitalNotification();
		}

		internal void showHospitalNotification()
		{
			lblHeader.Text = "Notifications";
			flpDashboard.Controls.Clear();
			HospitalNotification hospitalNotification = new HospitalNotification();
			flpDashboard.Controls.Add(hospitalNotification);
			adjustLayout();
		}

		private void btnExtraction_Click(object sender, EventArgs e)
		{
			showBloodExtraction();
		}

		internal void showBloodExtraction()
		{
			lblHeader.Text = "Blood Extraction";
			flpDashboard.Controls.Clear();
			HospitalExtraction hospitalExtraction = new HospitalExtraction();
			flpDashboard.Controls.Add(hospitalExtraction);
			adjustLayout();
		}

		private void btnStock_Click(object sender, EventArgs e)
		{
			showBloodStock();
		}

		internal void showBloodStock()
		{
			lblHeader.Text = "Blood Stock";
			flpDashboard.Controls.Clear();
			HospitalStock hospitalStock = new HospitalStock();
			flpDashboard.Controls.Add(hospitalStock);
			adjustLayout();
		}

		private void btnTransfer_Click(object sender, EventArgs e)
		{
			lblHeader.Text = "Blood Transfusion";
			flpDashboard.Controls.Clear();
			HospitalTransfusion hospitalTransfusion = new HospitalTransfusion();
			flpDashboard.Controls.Add(hospitalTransfusion);
			adjustLayout();
		}

		private void btnProfile_Click(object sender, EventArgs e)
		{
			showProfile();
		}

		internal void showProfile()
		{
			lblHeader.Text = "Profile";
			flpDashboard.Controls.Clear();
			HospitalProfile hospitalProfile = new HospitalProfile();
			flpDashboard.Controls.Add(hospitalProfile);
			adjustLayout();
		}
	}
}
