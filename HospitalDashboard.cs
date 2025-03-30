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
		private Database db = new Database();

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
			loadAppointments();
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

		private void loadAppointments()
		{
			string queryHospital = $"SELECT [Hospital Name] FROM Hospitals WHERE [Username] = '{Accounts.Username}'";
			DataTable hospitalData = db.executeQuery(queryHospital);

			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string queryAppointments = $@"SELECT Appointments.[Appointment Date], Donors.[First Name], Donors.[Middle Name], Donors.[Last Name] FROM Hospitals 
										  INNER JOIN (Donors INNER JOIN Appointments ON Donors.Username = Appointments.[Donor Username]) ON Hospitals.[Hospital Name] = Appointments.Hospital 
										  WHERE Appointments.[Status] = 'Approved' AND Appointments.[Hospital] = '{hospitalName}' ORDER BY Appointments.[Appointment Date] ASC";

			DataTable appointments = db.executeQuery(queryAppointments);

			if (appointments != null)
			{
				foreach (DataRow row in appointments.Rows)
				{
					string appointmentDate = Convert.ToDateTime(row["Appointment Date"]).ToString("MMMM dd, yyyy");
					string firstName = row["First Name"].ToString();
					string middleName = row["Middle Name"].ToString();
					string lastName = row["Last Name"].ToString();

					string donorName = string.IsNullOrWhiteSpace(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

					Panel panel = new Panel
					{
						Size = new Size(280, 125),
						BackColor = Color.FromArgb(244, 180, 180),
						Margin = new Padding(5),
						Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 280, 125, 20, 20))
					};

					Label lblDate = new Label
					{
						Text = appointmentDate,
						Font = new Font("Bahnschrift", 17F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						AutoSize = true,
						Location = new Point(20, 30)
					};

					Label lblDonor = new Label
					{
						Text = donorName,
						Font = new Font("Bahnschrift", 13F, FontStyle.Bold),
						ForeColor = Color.FromArgb(216, 85, 101),
						AutoSize = true,
						Location = new Point(20, lblDate.Bottom + 15)
					};

					panel.Controls.Add(lblDate);
					panel.Controls.Add(lblDonor);

					flpAppointments.Controls.Add(panel);
				}
			}
		}
	}
}
