using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class DonorDonate : UserControl
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		private DateTime currentDate = DateTime.Now;

		public DonorDonate()
		{
			InitializeComponent();
		}

		private void DonorDonate_Load(object sender, EventArgs e)
		{
			calendar();
			lblDate.Focus();
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
			DashboardD donateCalendar = Application.OpenForms["DashboardD"] as DashboardD;

			if (donateCalendar != null)
			{
				donateCalendar.showAppointments();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			currentDate = currentDate.AddMonths(-1);
			calendar();
			lblDate.Focus();
		}

		private void btnToday_Click(object sender, EventArgs e)
		{
			currentDate = DateTime.Now;
			calendar();
			lblDate.Focus();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			currentDate = currentDate.AddMonths(1);
			calendar();
			lblDate.Focus();
		}

		private void calendar()
		{
			flpCalendar.Controls.Clear();

			DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
			int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
			int startDay = (int)firstDayOfMonth.DayOfWeek;
			startDay = (startDay == 0) ? 6 : startDay - 1;
			DateTime firstVisibleDay = firstDayOfMonth.AddDays(-startDay);

			int dayWidth = (flpCalendar.Width - 50) / 7;
			int dayHeight = (flpCalendar.Height - 40) / 6;

			for (int i = 0; i < 42; i++)
			{
				DateTime dayDate = firstVisibleDay.AddDays(i);

				Calendar calendar = new Calendar();
				calendar.days(dayDate, currentDate);

				calendar.Width = dayWidth;
				calendar.Height = dayHeight;

				flpCalendar.Controls.Add(calendar);
			}

			lblDate.Text = currentDate.ToString("MMMM yyyy");
		}

		private void DonorDonate_Resize(object sender, EventArgs e)
		{
			calendar();
			lblDate.Focus();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			DateTime dayDate = DateTime.Now;

			Appointments appointments = new Appointments(dayDate, "");
			appointments.ShowDialog();
		}
	}
}
