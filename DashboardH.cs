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
			showHospitalDB();
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
			showHospitalDB();
		}

		internal void showHospitalDB()
		{
			lblHeader.Text = "Dashboard";
			flpDashboard.Controls.Clear();
			HospitalDB hospitalDB = new HospitalDB();
			flpDashboard.Controls.Add(hospitalDB);
			adjustLayout();
		}

		private void btnRecords_Click(object sender, EventArgs e)
		{
			showHospitalDR();

		}

		internal void showHospitalDR()
		{
			lblHeader.Text = "Records";
			flpDashboard.Controls.Clear();
			HospitalR hospitalR = new HospitalR();
			flpDashboard.Controls.Add(hospitalR);
			adjustLayout();
		}

		private void btnNotification_Click(object sender, EventArgs e)
		{
			showHospitalN();
		}

		internal void showHospitalN()
		{
			lblHeader.Text = "Notifications";
			flpDashboard.Controls.Clear();
			HospitalN hospitalN = new HospitalN();
			flpDashboard.Controls.Add(hospitalN);
			adjustLayout();
		}

		private void btnExtraction_Click(object sender, EventArgs e)
		{
			showExtraction();
		}

		internal void showExtraction()
		{
			lblHeader.Text = "Blood Extraction";
			flpDashboard.Controls.Clear();
			HospitalE hospitalE = new HospitalE();
			flpDashboard.Controls.Add(hospitalE);
			adjustLayout();
		}

		private void btnStock_Click(object sender, EventArgs e)
		{
			showStock();
		}

		internal void showStock()
		{
			lblHeader.Text = "Blood Stock";
			flpDashboard.Controls.Clear();
			HospitalBS hospitalBS = new HospitalBS();
			flpDashboard.Controls.Add(hospitalBS);
			adjustLayout();
		}
	}
}
