using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Hemotica
{
	public partial class HospitalProfile : UserControl
	{
		private Database db = new Database();
		private bool anyChanges = false;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalProfile()
		{
			InitializeComponent();
		}

		private void HospitalProfile_Load(object sender, EventArgs e)
		{
			roundControls();
			loadHospitals();

			btnSave.Enabled = false;
			pbxProfile.Focus();
		}

		public void roundControls()
		{
			pProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pProfile.Width, pProfile.Height, 20, 20));
			pbxProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxProfile.Width, pbxProfile.Height, 20, 20));
		}

		private void HospitalProfile_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		private void loadHospitals()
		{
			string query = @"SELECT [Email Address], Password, [Hospital Name], [License Number], Classification, Address, [Contact Number], [Operating Hours (Weekdays) Start], 
							 [Operating Hours (Weekdays) End], [Operating Hours (Weekend) Start], [Operating Hours (Weekend) End], Profile FROM Hospitals WHERE [Username] = ?";
			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			DataTable dt = db.executeQuery(query, parameters);

			DataRow row = dt.Rows[0];
			tbxEmail.Text = dt.Rows[0]["Email Address"].ToString();
			tbxPassword.Text = "●●●●●●●●";
			tbxName.Text = row["Hospital Name"].ToString();
			tbxLicense.Text = row["License Number"].ToString();
			tbxClassification.Text = row["Classification"].ToString();
			tbxAddress.Text = row["Address"].ToString();
			tbxNumber.Text = row["Contact Number"].ToString();

			DateTime weekdayStart = Convert.ToDateTime(row["Operating Hours (Weekdays) Start"]);
			DateTime weekdayEnd = Convert.ToDateTime(row["Operating Hours (Weekdays) End"]);
			DateTime weekendStart = Convert.ToDateTime(row["Operating Hours (Weekend) Start"]);
			DateTime weekendEnd = Convert.ToDateTime(row["Operating Hours (Weekend) End"]);

			string formattedWeekdayStart = weekdayStart.ToString("h:mmtt");
			string formattedWeekdayEnd = weekdayEnd.ToString("h:mmtt");
			string formattedWeekendStart = weekendStart.ToString("h:mmtt");
			string formattedWeekendEnd = weekendEnd.ToString("h:mmtt");

			if (weekdayStart == weekendStart && weekdayEnd == weekendEnd)
			{
				tbxOHours.Text = $"Daily: {formattedWeekdayStart}–{formattedWeekdayEnd}";
				tbxOHours.Size = new Size(349, 41);
			}
			else
			{
				tbxOHours.Text = $"Weekdays: {formattedWeekdayStart}–{formattedWeekdayEnd}\nWeekends: {formattedWeekendStart}–{formattedWeekendEnd}";
				tbxOHours.Size = new Size(349, 67);
			}

			if (row.Table.Columns.Contains("Profile") && row["Profile"] != DBNull.Value)
			{
				byte[] imageBytes = (byte[])row["Profile"];
				using (MemoryStream ms = new MemoryStream(imageBytes))
				{
					pbxProfile.Image = Image.FromStream(ms);
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}
	}
}
