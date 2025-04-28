using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Hemotica
{
	public partial class AdminDashboard : UserControl
	{
		private Admin admin = new Admin();
		private Database db = new Database();
		private Analytics analytics = new Analytics();

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		private List<Button> analyticsButtons = new List<Button>();
		private Button selectedButton = null;

		public AdminDashboard()
		{
			InitializeComponent();
		}

		private void HospitalDashboard_Load(object sender, EventArgs e)
		{
			roundControls();
			loadHospitals();
			loadDonors();
			totalDonors();
			totalHospitals();

			analyticsButtons.Add(btnBGAnalytics);
			analyticsButtons.Add(btnDAnalytics);
			analyticsButtons.Add(btnRAnalytics);
			analyticsButtons.Add(btnEAnalytics);

			foreach (var btn in analyticsButtons)
			{
				btn.BackColor = Color.FromArgb(252, 228, 228);
				btn.ForeColor = Color.FromArgb(216, 85, 101);
				btn.FlatStyle = FlatStyle.Flat;
				btn.FlatAppearance.BorderSize = 0;

				btn.MouseEnter += btnAnalytics_MouseEnter;
				btn.MouseLeave += btnAnalytics_MouseLeave;
				btn.Click += btnAnalytics_Click;
			}

			btnBGAnalytics.PerformClick();
		}

		public void roundControls()
		{
			pDashboard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pDashboard.Width, pDashboard.Height, 20, 20));
			pAnalytics.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pAnalytics.Width, pAnalytics.Height, 20, 20));
			pDonors.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pDonors.Width, pDonors.Height, 20, 20));
			flpDonors.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpDonors.Width, flpDonors.Height, 20, 20));
			pHospitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHospitals.Width, pHospitals.Height, 20, 20));
			flpHospitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpHospitals.Width, flpHospitals.Height, 20, 20));
			pUsers.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pUsers.Width, pUsers.Height, 20, 20));
			flpUsers.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpUsers.Width, flpUsers.Height, 20, 20));
			pDUsers.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pDUsers.Width, pDUsers.Height, 20, 20));
			pHUsers.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHUsers.Width, pHUsers.Height, 20, 20));
		}

		private void HospitalDashboard_Resize(object sender, EventArgs e)
		{
			roundControls();
			resizePanels();
		}

		private void totalDonors()
		{
			int donorCount = admin.totalDonors(db);
			lblDNumber.Text = formatCount(donorCount);
			lblDNumber.Location = new Point(
				(pDUsers.Width - lblDNumber.Width) / 2 + 66,
				(pDUsers.Height - lblDNumber.Height) / 2 + 18
			);
		}

		private void totalHospitals()
		{
			int hospitalCount = admin.totalHospitals(db);
			lblHNumber.Text = formatCount(hospitalCount);
			lblHNumber.Location = new Point(
				(pHUsers.Width - lblHNumber.Width) / 2 + 66,
				(pHUsers.Height - lblHNumber.Height) / 2 + 18
			);
		}

		private string formatCount(int count)
		{
			if (count >= 1000)
			{
				double value = count / 1000.0;

				string formatted;
				if (value % 1 == 0)
				{
					formatted = $"{value:0}";
				}
				else
				{
					formatted = $"{value:0.##}";
				}

				return $"{formatted}K";
			}
			else
			{
				return $"{count}";
			}
		}

		private void loadHospitals()
		{
			string query = "SELECT [Hospital Name], [Contact Number] FROM Hospitals ORDER BY [Hospital Name]";
			DataTable hospitals = db.executeQuery(query);

			flpHospitals.Controls.Clear();

			if (hospitals != null && hospitals.Rows.Count > 0)
			{
				foreach (DataRow row in hospitals.Rows)
				{
					string hospitalName = row["Hospital Name"].ToString();
					string contact = row["Contact Number"].ToString();

					int panelWidth = 297;

					Panel panel = new Panel
					{
						Size = new Size(panelWidth, 125),
						BackColor = Color.FromArgb(244, 180, 180),
						Margin = new Padding(5),
						Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelWidth, 125, 20, 20))
					};

					Label lblName = new Label
					{
						Text = hospitalName,
						Font = new Font("Bahnschrift", 15F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						AutoSize = false,
						TextAlign = ContentAlignment.MiddleLeft,
						MaximumSize = new Size(250, 0),
						Size = new Size(250, 0)
					};

					Size nameSize = TextRenderer.MeasureText(lblName.Text, lblName.Font, lblName.MaximumSize, TextFormatFlags.WordBreak);
					lblName.Height = nameSize.Height;

					Label lblContact = new Label
					{
						Text = contact,
						Font = new Font("Bahnschrift", 13F, FontStyle.Regular),
						ForeColor = Color.FromArgb(216, 85, 101),
						AutoSize = false,
						TextAlign = ContentAlignment.MiddleLeft,
						MaximumSize = new Size(250, 0),
						Size = new Size(250, 0)
					};

					Size contactSize = TextRenderer.MeasureText(lblContact.Text, lblContact.Font, lblContact.MaximumSize, TextFormatFlags.WordBreak);
					lblContact.Height = contactSize.Height;

					int gap = 5;
					int totalHeight = lblName.Height + gap + lblContact.Height;
					int startY = (panel.Height - totalHeight) / 2;

					lblName.Location = new Point(25, startY);
					lblContact.Location = new Point(25, lblName.Bottom + gap);

					panel.Controls.Add(lblName);
					panel.Controls.Add(lblContact);

					flpHospitals.Controls.Add(panel);
				}

				if (flpHospitals.VerticalScroll.Visible)
				{
					foreach (Control panel in flpHospitals.Controls)
					{
						panel.Width = flpHospitals.Width - 27;
						panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));
					}
				}
			}
			else
			{
				showNoHospitals();
			}
		}

		private void showNoHospitals()
		{
			if (!flpHospitals.Controls.Contains(pbxNoHospitals))
			{
				flpHospitals.Controls.Add(pbxNoHospitals);
			}

			pbxNoHospitals.Visible = true;
		}

		private void loadDonors()
		{
			string query = @"SELECT [First Name], [Middle Name], [Last Name], [Contact Number], [Blood Type] FROM Donors 
							 WHERE [Email Address] IS NOT NULL AND [Email Address] <> '' AND [Password] IS NOT NULL AND [Password] <> ''
							 ORDER BY [Last Name], [First Name]";
			DataTable donors = db.executeQuery(query);

			flpDonors.Controls.Clear();

			if (donors != null && donors.Rows.Count > 0)
			{
				foreach (DataRow row in donors.Rows)
				{
					string firstName = row["First Name"].ToString();
					string middleName = row["Middle Name"].ToString();
					string lastName = row["Last Name"].ToString();
					string contactNumber = row["Contact Number"].ToString();
					string bloodType = row["Blood Type"].ToString();

					string donorName = string.IsNullOrWhiteSpace(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

					int panelWidth = 290;

					System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel
					{
						Size = new Size(panelWidth, 165),
						BackColor = Color.FromArgb(244, 180, 180),
						Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelWidth, 165, 20, 20))
					};

					Label lblName = new Label
					{
						Text = donorName,
						Font = new Font("Bahnschrift", 14F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						TextAlign = ContentAlignment.MiddleCenter,
						AutoSize = false,
						Width = panel.Width - 20,
						MaximumSize = new Size(panel.Width - 20, 60),
						Height = 50
					};

					Label lblInformation = new Label
					{
						Text = $"Blood Type: {bloodType}\nContact Number: {contactNumber}",
						Font = new Font("Bahnschrift", 13F, FontStyle.Regular),
						ForeColor = Color.FromArgb(216, 85, 101),
						TextAlign = ContentAlignment.MiddleCenter,
						AutoSize = false,
						Width = panel.Width - 20,
						Height = 50
					};

					int gap = 5;
					int totalHeight = lblName.Height + lblInformation.Height + gap;
					int startY = (panel.Height - totalHeight) / 2;

					lblName.Location = new Point((panel.Width - lblName.Width) / 2, startY);
					lblInformation.Location = new Point((panel.Width - lblInformation.Width) / 2, startY + lblName.Height + gap);

					panel.Controls.Add(lblName);
					panel.Controls.Add(lblInformation);

					flpDonors.Controls.Add(panel);
				}

				if (flpDonors.HorizontalScroll.Visible)
				{
					foreach (Control panel in flpDonors.Controls)
					{
						panel.Height = flpDonors.Height - 27;
						panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));
					}
				}
			}
			else
			{
				showNoDonors();
			}
		}

		private void showNoDonors()
		{
			if (!flpDonors.Controls.Contains(pbxNoDonors))
			{
				flpDonors.Controls.Add(pbxNoDonors);
			}

			pbxNoDonors.Visible = true;
		}

		private void resizePanels()
		{
			foreach (Control panel in flpDonors.Controls)
			{
				panel.Height = flpDonors.Height - (flpDonors.HorizontalScroll.Visible ? 24 : 7);
				panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));
			}
		}

		private void btnAnalytics_MouseEnter(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (btn != selectedButton)
			{
				btn.BackColor = Color.FromArgb(216, 85, 101);
				btn.ForeColor = Color.FromArgb(252, 228, 228);
			}
		}

		private void btnAnalytics_MouseLeave(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (btn != selectedButton)
			{
				btn.BackColor = Color.FromArgb(252, 228, 228);
				btn.ForeColor = Color.FromArgb(216, 85, 101);
			}
		}

		private void btnAnalytics_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;

			if (selectedButton != null)
			{
				selectedButton.BackColor = Color.FromArgb(252, 228, 228);
				selectedButton.ForeColor = Color.FromArgb(216, 85, 101);
			}

			clickedButton.BackColor = Color.FromArgb(216, 85, 101);
			clickedButton.ForeColor = Color.FromArgb(252, 228, 228);
			selectedButton = clickedButton;

			if (clickedButton == btnBGAnalytics)
			{
				analytics.adminBloodGroups(pvOxyplot);
			}
			else if (clickedButton == btnDAnalytics)
			{
				analytics.adminDonors(pvOxyplot);
			}
			else if (clickedButton == btnRAnalytics)
			{
				analytics.adminBloodRequest(pvOxyplot);
			}
			else if (clickedButton == btnEAnalytics)
			{
				analytics.adminExtractions(pvOxyplot);
			}
		}

		private void btnBGAnalytics_Click(object sender, EventArgs e)
		{
			pvOxyplot.Model = null;
			pvOxyplot.InvalidatePlot(true);

			analytics.adminBloodGroups(pvOxyplot);
		}

		private void btnPAnalytics_Click(object sender, EventArgs e)
		{
			pvOxyplot.Model = null;
			pvOxyplot.InvalidatePlot(true);

			analytics.adminDonors(pvOxyplot);
		}

		private void btnEAnalytics_Click(object sender, EventArgs e)
		{
			pvOxyplot.Model = null;
			pvOxyplot.InvalidatePlot(true);

			analytics.adminBloodRequest(pvOxyplot);
		}

		private void btnTAnalytics_Click(object sender, EventArgs e)
		{
			pvOxyplot.Model = null;
			pvOxyplot.InvalidatePlot(true);

			analytics.adminExtractions(pvOxyplot);
		}

		private void pDUsers_Click(object sender, EventArgs e)
		{
			DashboardA parentForm = this.FindForm() as DashboardA;

			if (parentForm != null)
			{
				parentForm.showManagementDonors();
			}
		}

		private void pbxDUsers_Click(object sender, EventArgs e)
		{
			DashboardA parentForm = this.FindForm() as DashboardA;

			if (parentForm != null)
			{
				parentForm.showManagementDonors();
			}
		}

		private void pHUsers_Click(object sender, EventArgs e)
		{
			DashboardA parentForm = this.FindForm() as DashboardA;

			if (parentForm != null)
			{
				parentForm.showManagementHospitals();
			}
		}

		private void pbxHUsers_Click(object sender, EventArgs e)
		{
			DashboardA parentForm = this.FindForm() as DashboardA;

			if (parentForm != null)
			{
				parentForm.showManagementHospitals();
			}
		}

		private void lblVAD_Click(object sender, EventArgs e)
		{
			DashboardA parentForm = this.FindForm() as DashboardA;

			if (parentForm != null)
			{
				parentForm.showManagementDonors();
			}
		}

		private void lblVAH_Click(object sender, EventArgs e)
		{
			DashboardA parentForm = this.FindForm() as DashboardA;

			if (parentForm != null)
			{
				parentForm.showManagementHospitals();
			}
		}
	}
}
