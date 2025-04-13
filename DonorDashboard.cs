using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace Hemotica
{
	public partial class DonorDashboard : UserControl
	{
		private Database db = new Database();

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DonorDashboard()
		{
			InitializeComponent();
		}

		private void DonorDashboard_Load(object sender, EventArgs e)
		{
			roundControls();
			loadHospitals();
		}

		private void DonorDashboard_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			pBloodDrives.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pBloodDrives.Width, pBloodDrives.Height, 20, 20));
			pHospitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHospitals.Width, pHospitals.Height, 20, 20));
			pAnalytics.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pAnalytics.Width, pAnalytics.Height, 20, 20));
			pLogs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pLogs.Width, pLogs.Height, 20, 20));

			if (pbxBloodDrives.Width > 0 && pbxBloodDrives.Height > 0)
			{
				pbxBloodDrives.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxBloodDrives.Width, pbxBloodDrives.Height, 20, 20));
			}

			flpHospitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpHospitals.Width, flpHospitals.Height, 20, 20));
			flpAnalytics.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpAnalytics.Width, flpAnalytics.Height, 20, 20));
			flpLogs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpLogs.Width, flpLogs.Height, 20, 20));
		}
		
		private void loadHospitals()
		{
			DataTable hospitals = db.executeQuery("SELECT [Hospital Name] FROM Hospitals");

			if (hospitals != null)
			{
				foreach (DataRow row in hospitals.Rows)
				{
					string hospitalName = row["Hospital Name"].ToString();

					System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel
					{
						Size = new Size(250, 165),
						BackColor = Color.FromArgb(244, 180, 180),
						Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 250, 165, 20, 20))
					};

					Label lblHospital = new Label
					{
						Text = hospitalName,
						Font = new Font("Bahnschrift", 14F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						TextAlign = ContentAlignment.MiddleCenter,
						AutoSize = false,
						Width = panel.Width - 20,
						MaximumSize = new Size(panel.Width - 20, 60),
						Height = 50
					};

					FoxButton btnDonate = new FoxButton
					{
						BackColor = Color.Transparent,
						BaseColor = Color.FromArgb(216, 85, 101),
						BorderColor = Color.FromArgb(216, 85, 101),
						DisabledBaseColor = Color.FromArgb(244, 148, 156),
						DisabledBorderColor = Color.FromArgb(244, 148, 156),
						DisabledTextColor = Color.FromArgb(244, 148, 156),
						DownColor = Color.FromArgb(236, 124, 132),
						EnabledCalc = true,
						Font = new Font("Arial Narrow", 13F, FontStyle.Bold),
						ForeColor = Color.FromArgb(241, 241, 241),
						OverColor = Color.FromArgb(216, 85, 101),
						Size = new Size(120, 40),
						Text = "DONATE",
						Cursor = Cursors.Hand
					};

					int gap = 10;
					int totalHeight = lblHospital.Height + btnDonate.Height + gap;
					int startY = (panel.Height - totalHeight) / 2;

					lblHospital.Location = new Point((panel.Width - lblHospital.Width) / 2, startY);
					btnDonate.Location = new Point((panel.Width - btnDonate.Width) / 2, startY + lblHospital.Height + gap);

					panel.Controls.Add(btnDonate);
					panel.Controls.Add(lblHospital);

					btnDonate.Click += (s, e) =>
					{
						DashboardD donateCalendar = Application.OpenForms["DashboardD"] as DashboardD;
						donateCalendar?.showCalendar();
					};

					flpHospitals.Controls.Add(panel);
				}
			}
		}
		
		private void lblLogs_Click(object sender, EventArgs e)
		{
			// show list of donation history
		}
	}
}
