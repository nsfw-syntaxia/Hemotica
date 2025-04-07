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
				tbxOHours.Size = new Size(349, 66);
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

		private void btnEdit_Click(object sender, EventArgs e)
		{
			tbxEmail.Enabled = true;
			tbxPassword.Enabled = true;
			tbxAddress.Enabled = true;
			tbxNumber.Enabled = true;
			tbxOHours.Enabled = true;

			anyChanges = false;
			btnSave.Enabled = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string email = tbxEmail.Text.Trim();
			string password = tbxPassword.Text.Trim();
			string address = tbxAddress.Text.Trim();
			string contactNumber = tbxNumber.Text.Trim();
			string operatingHours = tbxOHours.Text.Trim();

			if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(contactNumber) || 
				string.IsNullOrWhiteSpace(operatingHours))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int emailCount = db.countEmail(email);
			string currentEmail = db.userEmail(UserLogs.Username);

			List<string> errors = new List<string>();

			if (!ExceptionHandling.validEmailAddress(email))
				errors.Add("Invalid email address.");

			if (emailCount > 1 || (emailCount == 1 && !email.Equals(currentEmail, StringComparison.OrdinalIgnoreCase)))
				errors.Add("Email address already exists.");

			if (!ExceptionHandling.validContactNumber(contactNumber))
				errors.Add("Invalid contact number.");

			string weekdayStart, weekdayEnd, weekendStart, weekendEnd;
			if (!validateOperatingHours(operatingHours, out weekdayStart, out weekdayEnd, out weekendStart, out weekendEnd))
				errors.Add("Invalid operating hours.");

			if (errors.Count > 0)
			{
				MessageBox.Show(string.Join("\n", errors), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string hashedPassword = string.Empty;
			if (!password.Contains("●"))
			{
				hashedPassword = db.hashPassword(password);
			}

			string query;
			List<OleDbParameter> parameters = new List<OleDbParameter>();

			if (!string.IsNullOrEmpty(hashedPassword))
			{
				query = @"UPDATE Hospitals SET [Email Address] = ?, [Password] = ?, Address = ?, [Contact Number] = ?, [Operating Hours (Weekdays) Start] = ?, 
						  [Operating Hours (Weekdays) End] = ?, [Operating Hours (Weekend) Start] = ?, [Operating Hours (Weekend) End] = ? WHERE [Username] = ?";

				parameters.Add(new OleDbParameter("?", email));
				parameters.Add(new OleDbParameter("?", hashedPassword));
				parameters.Add(new OleDbParameter("?", address));
				parameters.Add(new OleDbParameter("?", contactNumber));
				parameters.Add(new OleDbParameter("?", weekdayStart));
				parameters.Add(new OleDbParameter("?", weekdayEnd));
				parameters.Add(new OleDbParameter("?", weekendStart));
				parameters.Add(new OleDbParameter("?", weekendEnd));
				parameters.Add(new OleDbParameter("?", UserLogs.Username));
			}
			else
			{
				query = @"UPDATE Hospitals SET [Email Address] = ?, Address = ?, [Contact Number] = ?, [Operating Hours (Weekdays) Start] = ?, 
						  [Operating Hours (Weekdays) End] = ?, [Operating Hours (Weekend) Start] = ?, [Operating Hours (Weekend) End] = ? WHERE [Username] = ?";

				parameters.Add(new OleDbParameter("?", email));
				parameters.Add(new OleDbParameter("?", address));
				parameters.Add(new OleDbParameter("?", contactNumber));
				parameters.Add(new OleDbParameter("?", weekdayStart));
				parameters.Add(new OleDbParameter("?", weekdayEnd));
				parameters.Add(new OleDbParameter("?", weekendStart));
				parameters.Add(new OleDbParameter("?", weekendEnd));
				parameters.Add(new OleDbParameter("?", UserLogs.Username));
			}

			if (db.executeNonQuery(query, parameters.ToArray()))
			{
				MessageBox.Show("Hospital information updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				tbxEmail.Enabled = false;
				tbxPassword.Enabled = false;
				tbxAddress.Enabled = false;
				tbxNumber.Enabled = false;
				tbxOHours.Enabled = false;

				btnSave.Enabled = false;
				pbxProfile.Focus();
			}
			else
			{
				MessageBox.Show("Hospital information update failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool validateOperatingHours(string operatingHours, out string weekdayStart, out string weekdayEnd, out string weekendStart, out string weekendEnd)
		{
			weekdayStart = weekdayEnd = weekendStart = weekendEnd = "";
			operatingHours = operatingHours.Trim();

			if (operatingHours.StartsWith("Daily:", StringComparison.OrdinalIgnoreCase))
			{
				string[] parts = operatingHours.Substring(6).Split('–');
				if (parts.Length != 2 || !DateTime.TryParse(parts[0].Trim(), out _) || !DateTime.TryParse(parts[1].Trim(), out _))
				{
					return false;
				}

				string start = convertTime(parts[0].Trim());
				string end = convertTime(parts[1].Trim());

				weekdayStart = weekendStart = start;
				weekdayEnd = weekendEnd = end;
				return true;
			}
			else if (operatingHours.StartsWith("Weekdays:", StringComparison.OrdinalIgnoreCase))
			{
				string[] lines = operatingHours.Split('\n');
				if (lines.Length < 2 || !lines[0].StartsWith("Weekdays:") || !lines[1].StartsWith("Weekends:"))
				{
					return false;
				}

				string[] wd = lines[0].Substring(9).Split('–');
				string[] we = lines[1].Substring(9).Split('–');

				if (wd.Length != 2 || we.Length != 2 || !DateTime.TryParse(wd[0].Trim(), out _) || !DateTime.TryParse(wd[1].Trim(), out _) || 
					!DateTime.TryParse(we[0].Trim(), out _) || !DateTime.TryParse(we[1].Trim(), out _))
				{
					return false;
				}

				weekdayStart = convertTime(wd[0].Trim());
				weekdayEnd = convertTime(wd[1].Trim());
				weekendStart = convertTime(we[0].Trim());
				weekendEnd = convertTime(we[1].Trim());
				return true;
			}
			else
			{
				return false;
			}
		}

		private string convertTime(string time)
		{
			if (DateTime.TryParse(time, out DateTime result))
			{
				return result.ToString("HH:mm:ss");
			}
			return "00:00:00";
		}

		private void btnProfile_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files | *.jpg; *.jpeg; *.png";
				openFileDialog.Title = "";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						pbxProfile.Image = new Bitmap(openFileDialog.FileName);

						byte[] imageBytes;
						using (MemoryStream ms = new MemoryStream())
						{
							pbxProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
							imageBytes = ms.ToArray();
						}

						string query = "UPDATE Hospitals SET Profile = ? WHERE [Username] = ?";
						OleDbParameter[] parameters =
						{
							new OleDbParameter("?", OleDbType.LongVarBinary) { Value = imageBytes },
							new OleDbParameter("?", UserLogs.Username)
						};

						if (db.executeNonQuery(query, parameters))
						{
							MessageBox.Show("Profile photo updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Hospital hospital = new Hospital();
			bool deleteAccount = hospital.deleteHospitalAccount(db);

			if (deleteAccount)
			{
				MessageBox.Show("Account deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				logout();
			}
			else
			{
				MessageBox.Show("Account deletion failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void logout()
		{
			UserLogs.LogoutUser(db);

			if (Application.OpenForms["DashboardD"] is DashboardD dashboard)
			{
				dashboard.Close();
			}

			if (Application.OpenForms["Home"] is Home home)
			{
				home.WindowState = FormWindowState.Normal;
				home.Show();
				home.Activate();
				await Task.Delay(1);
			}

			this.Parent?.Controls.Remove(this);
		}

		private void tbxEmail_TextChanged(object sender, EventArgs e)
		{
			anyChanges = true;
			btnSave.Enabled = true;
		}

		private void tbxPassword_TextChanged(object sender, EventArgs e)
		{
			anyChanges = true;
			btnSave.Enabled = true;
		}

		private void tbxAddress_TextChanged(object sender, EventArgs e)
		{
			anyChanges = true;
			btnSave.Enabled = true;
		}

		private void tbxNumber_TextChanged(object sender, EventArgs e)
		{
			anyChanges = true;
			btnSave.Enabled = true;
		}

		private void tbxOHours_TextChanged(object sender, EventArgs e)
		{
			anyChanges = true;
			btnSave.Enabled = true;
		}
	}
}
