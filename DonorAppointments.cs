using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace Hemotica
{
	public partial class DonorAppointments : UserControl
	{
		private Database db = new Database();

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
			loadAppointments();
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

		private void loadAppointments()
		{
			DataTable appointments = db.executeQuery($"SELECT [Appointment Date], [Hospital], [Status] FROM Appointments WHERE [Donor Username] = '{UserLogs.Username}'");

			if (appointments != null)
			{
				foreach (DataRow row in appointments.Rows)
				{
					string appointmentDate = Convert.ToDateTime(row["Appointment Date"]).ToString("MMMM dd, yyyy");
					string hospitalName = row["Hospital"].ToString();
					string status = row["Status"].ToString();

					System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel
					{
						BackColor = Color.FromArgb(244, 180, 180),
						Padding = new Padding(15),
						Size = new Size(1005, 165)
					};

					Label lblDate = new Label
					{
						Text = appointmentDate,
						Font = new Font("Bahnschrift", 17F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						AutoSize = true,
						Location = new Point(20, 20)
					};

					Label lblHospital = new Label
					{
						Text = hospitalName,
						Font = new Font("Bahnschrift", 13F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						AutoSize = true
					};

					Label lblStatus = new Label
					{
						Text = status,
						Font = new Font("Bahnschrift", 13F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						AutoSize = true
					};

					panel.Controls.Add(lblDate);
					panel.Controls.Add(lblHospital);
					panel.Controls.Add(lblStatus);

					lblHospital.Location = new Point(20, lblDate.Bottom + 10);
					lblStatus.Location = new Point(300, lblHospital.Top);

					if (status != "Denied" && status != "Cancelled")
					{
						FoxButton btnCancel = new FoxButton
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
							Text = "CANCEL",
							Cursor = Cursors.Hand
						};

						btnCancel.Location = new Point(20, lblHospital.Bottom + 15);
						btnCancel.Click += (s, e) =>
						{
							DialogResult result = MessageBox.Show("Are you sure you want to cancel this appointment?","", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

							if (result == DialogResult.Yes)
							{
								string query = "UPDATE Appointments SET [Status] = 'Cancelled' WHERE [Donor Username] = ? AND [Hospital] = ? AND [Appointment Date] = ?";
								OleDbParameter[] parameters = 
								{ 
									new OleDbParameter("?", UserLogs.Username), 
									new OleDbParameter("?", hospitalName),
									new OleDbParameter("?", appointmentDate)
								};

								if (db.executeNonQuery(query, parameters))
								{
									MessageBox.Show("Appointment cancelled successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
									loadAppointments();
								}
								else
								{
									MessageBox.Show("Appointment cancellation failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}
						};

						panel.Controls.Add(btnCancel);
					}
					else
					{
						panel.Size = new Size(1005, lblStatus.Bottom + 30);
					}

					panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));

					flpAppointments.Controls.Add(panel);
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			DateTime dayDate = DateTime.Now;

			Appointments appointments = new Appointments(dayDate);
			appointments.ShowDialog();
		}
	}
}
