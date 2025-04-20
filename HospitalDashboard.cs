using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Hemotica
{
	public partial class HospitalDashboard : UserControl
	{
		private Database db = new Database();
		private Hospital hospital = new Hospital();
		private Analytics analytics = new Analytics();

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		private List<Button> analyticsButtons = new List<Button>();
		private Button selectedButton = null;

		public HospitalDashboard()
		{
			InitializeComponent();
		}

		private void HospitalDashboard_Load(object sender, EventArgs e)
		{
			roundControls();
			loadAppointments();
			loadPatients();
			totalExtractions();
			totalTransfusions();

			analyticsButtons.Add(btnBGAnalytics);
			analyticsButtons.Add(btnPAnalytics);
			analyticsButtons.Add(btnEAnalytics);
			analyticsButtons.Add(btnTAnalytics);

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
			pPatients.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pPatients.Width, pPatients.Height, 20, 20));
			flpPatients.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpPatients.Width, flpPatients.Height, 20, 20));
			pAppointments.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pAppointments.Width, pAppointments.Height, 20, 20));
			flpAppointments.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpAppointments.Width, flpAppointments.Height, 20, 20));
			pOperations.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pOperations.Width, pOperations.Height, 20, 20));
			flpOperations.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpOperations.Width, flpOperations.Height, 20, 20));
			pExtraction.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pExtraction.Width, pExtraction.Height, 20, 20));
			pTransfusion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pTransfusion.Width, pTransfusion.Height, 20, 20));
		}

		private void HospitalDashboard_Resize(object sender, EventArgs e)
		{
			roundControls();
			resizePanels();
		}

		private void totalExtractions()
		{
			DataTable dt = hospital.loadExtraction(db);
			int extractionCount = dt.Rows.Count;

			lblENumber.Text = formatCount(extractionCount);
			lblENumber.Location = new Point(
				(pExtraction.Width - lblENumber.Width) / 2 + 66,
				(pExtraction.Height - lblENumber.Height) / 2 + 28
			);
		}

		private void totalTransfusions()
		{
			DataTable dt = hospital.loadTransfusion(db);
			int transfusionCount = dt.Rows.Count;

			lblTNumber.Text = formatCount(transfusionCount);
			lblTNumber.Location = new Point(
				(pTransfusion.Width - lblTNumber.Width) / 2 + 66,
				(pTransfusion.Height - lblTNumber.Height) / 2 + 28
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

		private void loadAppointments()
		{
			updateAppointments();

			string queryHospital = "SELECT [Hospital Name] FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			DataTable hospitalData = db.executeQuery(queryHospital, parameters);

			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string queryAppointments = @"SELECT Appointments.[Appointment Date], Donors.[First Name], Donors.[Middle Name], Donors.[Last Name] FROM Hospitals 
										 INNER JOIN (Donors INNER JOIN Appointments ON Donors.Username = Appointments.[Donor Username]) ON Hospitals.[Hospital Name] = Appointments.Hospital 
										 WHERE Appointments.[Status] = ? AND Appointments.[Hospital] = ? ORDER BY Appointments.[Appointment Date] ASC";

			OleDbParameter[] appointmentParameters =
			{
				new OleDbParameter("?", "Scheduled"),
				new OleDbParameter("?", hospitalName)
			};
			DataTable appointments = db.executeQuery(queryAppointments, appointmentParameters);

			flpAppointments.Controls.Clear();

			if (appointments != null && appointments.Rows.Count > 0)
			{
				foreach (DataRow row in appointments.Rows)
				{
					string appointmentDate = Convert.ToDateTime(row["Appointment Date"]).ToString("MMMM dd, yyyy");
					string firstName = row["First Name"].ToString();
					string middleName = row["Middle Name"].ToString();
					string lastName = row["Last Name"].ToString();

					string donorName = string.IsNullOrWhiteSpace(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

					int panelWidth = 297;

					Panel panel = new Panel
					{
						Size = new Size(panelWidth, 125),
						BackColor = Color.FromArgb(244, 180, 180),
						Margin = new Padding(5),
						Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelWidth, 125, 20, 20))
					};

					Label lblDate = new Label
					{
						Text = appointmentDate,
						Font = new Font("Bahnschrift", 17F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						TextAlign = ContentAlignment.MiddleLeft,
						AutoSize = false,
						Width = 240,
						Height = 30
					};

					Label lblDonor = new Label
					{
						Text = donorName,
						Font = new Font("Bahnschrift", 13F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						TextAlign = ContentAlignment.MiddleLeft,
						AutoSize = false,
						Width = 240,
						MaximumSize = new Size(240, 0)
					};

					Size textSize = TextRenderer.MeasureText(lblDonor.Text, lblDonor.Font, lblDonor.MaximumSize, TextFormatFlags.WordBreak);
					lblDonor.Height = textSize.Height;

					int gap = 10;
					int totalHeight = lblDate.Height + gap + lblDonor.Height;
					int startY = (panel.Height - totalHeight) / 2 - 3;

					lblDate.Location = new Point(25, startY);
					lblDonor.Location = new Point(25, lblDate.Bottom + gap);

					panel.Controls.Add(lblDate);
					panel.Controls.Add(lblDonor);

					flpAppointments.Controls.Add(panel);
				}

				if (flpAppointments.VerticalScroll.Visible)
				{
					foreach (Control panel in flpAppointments.Controls)
					{
						panel.Width = flpAppointments.Width - 27;
						panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));
					}
				}
			}
			else
			{
				showNoAppointments();
			}
		}

		private void updateAppointments()
		{
			string cancelAppointmentsQuery = @"UPDATE Appointments SET Status = 'Cancelled' WHERE [Appointment Date] < ? AND Status = 'Scheduled'";
			string format = DateTime.Now.Date.ToString("MM/dd/yyyy");
			OleDbParameter[] appointmentParameter = { new OleDbParameter("?", format) };
			db.executeNonQuery(cancelAppointmentsQuery, appointmentParameter);
		}

		private void showNoAppointments()
		{
			if (!flpAppointments.Controls.Contains(pbxNoAppointments))
			{
				flpAppointments.Controls.Add(pbxNoAppointments);
			}

			pbxNoAppointments.Visible = true;
		}

		private void loadPatients()
		{
			string queryPatients = @"SELECT [First Name], [Middle Name], [Last Name], [Blood Type], Priority, [Hospital Username] FROM Patients 
									 WHERE [Hospital Username] = ? AND Priority <> ?";

			OleDbParameter[] patientParameters =
			{
				new OleDbParameter("?", UserLogs.Username),
				new OleDbParameter("?", "Resolved")
			};
			DataTable patients = db.executeQuery(queryPatients, patientParameters);

			flpPatients.Controls.Clear();

			if (patients != null && patients.Rows.Count > 0)
			{
				var filteredRows = patients.AsEnumerable().Where(row => row["Priority"].ToString() != "Resolved");

				DataTable filteredPatients = filteredRows.CopyToDataTable();
				filteredPatients.Columns.Add("SortOrder", typeof(int));

				foreach (DataRow row in filteredPatients.Rows)
				{
					string priority = row["Priority"].ToString();
					int sortOrder = 4;

					switch (priority)
					{
						case "Critical": sortOrder = 0; break;
						case "High": sortOrder = 1; break;
						case "Medium": sortOrder = 2; break;
						case "Low": sortOrder = 3; break;
					}

					row["SortOrder"] = sortOrder;
				}

				DataView sortedView = filteredPatients.DefaultView;
				sortedView.Sort = "SortOrder ASC";
				DataTable sortedPatients = sortedView.ToTable();

				foreach (DataRow row in sortedPatients.Rows)
				{
					string firstName = row["First Name"].ToString();
					string middleName = row["Middle Name"].ToString();
					string lastName = row["Last Name"].ToString();
					string bloodType = row["Blood Type"].ToString();
					string priority = row["Priority"].ToString();
					string patientName = string.IsNullOrWhiteSpace(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

					int panelWidth = 290;

					System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel
					{
						Size = new Size(panelWidth, 165),
						BackColor = Color.FromArgb(244, 180, 180),
						Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelWidth, 165, 20, 20))
					};

					Label lblName = new Label
					{
						Text = patientName,
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
						Text = $"{bloodType} ({priority})",
						Font = new Font("Bahnschrift", 13F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						TextAlign = ContentAlignment.MiddleCenter,
						AutoSize = false,
						Width = panel.Width - 20,
						Height = 30
					};

					int gap = 5;
					int totalHeight = lblName.Height + lblInformation.Height + gap;
					int startY = (panel.Height - totalHeight) / 2;

					lblName.Location = new Point((panel.Width - lblName.Width) / 2, startY);
					lblInformation.Location = new Point((panel.Width - lblInformation.Width) / 2, startY + lblName.Height + gap);

					panel.Controls.Add(lblName);
					panel.Controls.Add(lblInformation);

					flpPatients.Controls.Add(panel);
				}

				if (flpPatients.HorizontalScroll.Visible)
				{
					foreach (Control panel in flpPatients.Controls)
					{
						panel.Height = flpPatients.Height - 27;
						panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));
					}
				}
			}
			else
			{
				showNoPatients();
			}
		}

		private void showNoPatients()
		{
			if (!flpPatients.Controls.Contains(pbxNoPatients))
			{
				flpPatients.Controls.Add(pbxNoPatients);
			}

			pbxNoPatients.Visible = true;
		}

		private void resizePanels()
		{
			foreach (Control panel in flpPatients.Controls)
			{
				panel.Height = flpPatients.Height - (flpPatients.HorizontalScroll.Visible ? 24 : 7);
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
			clickedButton.ForeColor = Color.White;
			selectedButton = clickedButton;

			if (clickedButton == btnBGAnalytics)
			{
				analytics.displayBloodGroups(pvOxyplot);
			}
			else if (clickedButton == btnPAnalytics)
			{
				analytics.displayPatients(pvOxyplot);
			}
			else if (clickedButton == btnEAnalytics)
			{
				analytics.displayExtractions(pvOxyplot);
			}
			else if (clickedButton == btnTAnalytics)
			{
				analytics.displayTransfusions(pvOxyplot);
			}
		}

		private void btnBGAnalytics_Click(object sender, EventArgs e)
		{
			pvOxyplot.Model = null;
			pvOxyplot.InvalidatePlot(true);

			analytics.displayBloodGroups(pvOxyplot);
		}

		private void btnPAnalytics_Click(object sender, EventArgs e)
		{
			pvOxyplot.Model = null;
			pvOxyplot.InvalidatePlot(true);

			analytics.displayPatients(pvOxyplot);
		}

		private void btnEAnalytics_Click(object sender, EventArgs e)
		{
			pvOxyplot.Model = null;
			pvOxyplot.InvalidatePlot(true);

			analytics.displayExtractions(pvOxyplot);
		}

		private void btnTAnalytics_Click(object sender, EventArgs e)
		{
			pvOxyplot.Model = null;
			pvOxyplot.InvalidatePlot(true);

			analytics.displayTransfusions(pvOxyplot);
		}
	}
}
