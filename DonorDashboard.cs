using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace Hemotica
{
	public partial class DonorDashboard : UserControl
	{
		private Database db = new Database();
		private List<Image> slideshowImages = new List<Image>();
		private int imageIndex = 0;

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
			pbDonation.Percentage = 0;
			lblNumber.Text = "0";

			slideshow();
			roundControls();
			totalDonations();
			loadHospitals();
			loadDonationHistory();
		}

		private void DonorDashboard_Resize(object sender, EventArgs e)
		{
			roundControls();
			resizePanels();
		}

		public void roundControls()
		{
			pBloodDrives.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pBloodDrives.Width, pBloodDrives.Height, 20, 20));
			pHospitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pHospitals.Width, pHospitals.Height, 20, 20));
			pAnalytics.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pAnalytics.Width, pAnalytics.Height, 20, 20));
			pDonations.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pDonations.Width, pDonations.Height, 20, 20));
			pLogs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pLogs.Width, pLogs.Height, 20, 20));

			if (pbxBloodDrives.Width > 0 && pbxBloodDrives.Height > 0)
			{
				pbxBloodDrives.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxBloodDrives.Width, pbxBloodDrives.Height, 20, 20));
			}

			flpHospitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpHospitals.Width, flpHospitals.Height, 20, 20));
			flpLogs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpLogs.Width, flpLogs.Height, 20, 20));
		}

		private void slideshow()
		{
			slideshowImages.Clear();

			slideshowImages.Add(Image.FromFile(@"C:\Users\Trixie\Downloads\CPE262\Hemotica\Resources\banner.png"));
			slideshowImages.Add(Image.FromFile(@"C:\Users\Trixie\Downloads\CPE262\Hemotica\Resources\blood_donation.png"));

			string query = @"SELECT [Image] FROM [Blood Drives]";
			DataTable dt = db.executeQuery(query);

			foreach (DataRow row in dt.Rows)
			{
				if (row["Image"] != DBNull.Value)
				{
					byte[] imageBytes = (byte[])row["Image"];
					using (MemoryStream ms = new MemoryStream(imageBytes))
					{
						try
						{
							Image img = Image.FromStream(ms);
							slideshowImages.Add(img);
						}
						catch (Exception ex)
						{
							MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}

			if (slideshowImages.Count > 0)
			{
				imageIndex = 0;
				pbxBloodDrives.Image = slideshowImages[imageIndex];

				tSlideshow.Start();
			}
		}

		private void totalDonations()
		{
			string query = @"SELECT Extraction.[Extraction Date], Extraction.Hospital FROM Donors INNER JOIN Extraction ON Donors.Username = Extraction.[Donor Username]
							 WHERE Extraction.[Donor Username] = ? ORDER BY Extraction.[Extraction Date] DESC";

			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			DataTable dt = db.executeQuery(query, parameters);

			int donationCount = dt.Rows.Count;

			lblNumber.Text = donationCount.ToString();
			lblNumber.Location = new Point(
				(pDonations.Width - lblNumber.Width) / 2,
				(pDonations.Height - lblNumber.Height) / 2 + 18
			);

			pbDonation.Percentage = Math.Min(donationCount, 100);
		}

		private void loadHospitals()
		{
			DataTable hospitals = db.executeQuery("SELECT [Hospital Name] FROM Hospitals ORDER BY [Hospital Name] ASC");

			flpHospitals.Controls.Clear();

			if (hospitals != null && hospitals.Rows.Count > 0)
			{
				foreach (DataRow row in hospitals.Rows)
				{
					string hospitalName = row["Hospital Name"].ToString();

					int panelWidth = 290;

					System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel
					{
						Size = new Size(panelWidth, 165),
						BackColor = Color.FromArgb(244, 180, 180),
						Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelWidth, 165, 20, 20))
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
						string selectedHospital = hospitalName;

						DashboardD donateDashboard = Application.OpenForms["DashboardD"] as DashboardD;
						if (donateDashboard != null)
						{
							DateTime dayDate = DateTime.Now;

							donateDashboard.showCalendar();
							Appointments appointments = new Appointments(dayDate, selectedHospital);
							appointments.ShowDialog();
						}
					};

					flpHospitals.Controls.Add(panel);
				}

				if (flpHospitals.HorizontalScroll.Visible)
				{
					foreach (Control panel in flpHospitals.Controls)
					{
						panel.Height = flpHospitals.Height - 27;
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

		private void loadDonationHistory()
		{
			string query = @"SELECT Extraction.[Extraction Date], Extraction.Hospital FROM Donors INNER JOIN Extraction ON Donors.Username = Extraction.[Donor Username]
							 WHERE Extraction.[Donor Username] = ? ORDER BY Extraction.[Extraction Date] DESC";

			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			DataTable donationHistory = db.executeQuery(query, parameters);

			flpLogs.Controls.Clear();

			if (donationHistory != null && donationHistory.Rows.Count > 0)
			{
				foreach (DataRow row in donationHistory.Rows)
				{
					string extractionDate = Convert.ToDateTime(row["Extraction Date"]).ToString("MM/dd/yyyy");
					string hospital = row["Hospital"].ToString();

					int panelWidth = 367;

					System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel
					{
						Size = new Size(panelWidth, 125),
						BackColor = Color.FromArgb(244, 180, 180),
						Margin = new Padding(5),
						Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelWidth, 125, 20, 20))
					};

					Label lblDate = new Label
					{
						Text = extractionDate,
						Font = new Font("Bahnschrift", 17F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						TextAlign = ContentAlignment.MiddleLeft,
						AutoSize = false,
						Width = 240,
						Height = 30
					};

					Label lblHospital = new Label
					{
						Text = hospital,
						Font = new Font("Bahnschrift", 13F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						TextAlign = ContentAlignment.MiddleLeft,
						AutoSize = false,
						Width = 240,
						MaximumSize = new Size(240, 0)
					};

					Size textSize = TextRenderer.MeasureText(lblHospital.Text, lblHospital.Font, lblHospital.MaximumSize, TextFormatFlags.WordBreak);
					lblHospital.Height = textSize.Height;

					int gap = 10;
					int totalHeight = lblDate.Height + gap + lblHospital.Height;
					int startY = (panel.Height - totalHeight) / 2 - 3;

					lblDate.Location = new Point(25, startY);
					lblHospital.Location = new Point(25, lblDate.Bottom + gap);

					panel.Controls.Add(lblDate);
					panel.Controls.Add(lblHospital);

					flpLogs.Controls.Add(panel);
				}

				if (flpLogs.VerticalScroll.Visible)
				{
					foreach (Control panel in flpLogs.Controls)
					{
						panel.Width = flpLogs.Width - 27;
						panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));
					}
				}
			}
			else
			{
				showNoDonations();
			}
		}

		private void showNoDonations()
		{
			if (!flpLogs.Controls.Contains(pbxNoDonations))
			{
				flpLogs.Controls.Add(pbxNoDonations);
			}

			pbxNoDonations.Visible = true;
		}

		private void resizePanels()
		{
			foreach (Control panel in flpHospitals.Controls)
			{
				panel.Height = flpHospitals.Height - (flpHospitals.HorizontalScroll.Visible ? 24 : 7);
				panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));
			}

			foreach (Control panel in flpLogs.Controls)
			{
				panel.Width = flpLogs.Width - (flpLogs.VerticalScroll.Visible ? 27 : 10);
				panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));
			}
		}

		private void tSlideshow_Tick(object sender, EventArgs e)
		{
			imageIndex = (imageIndex + 1) % slideshowImages.Count;
			pbxBloodDrives.Image = slideshowImages[imageIndex];
		}
	}
}
