using System;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class DonorProfile : UserControl
	{
		private Database db = new Database();
		private string donorEmail;
		private bool anyChanges = false;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public DonorProfile()
		{
			InitializeComponent();
		}

		private void DonorP_Load(object sender, EventArgs e)
		{
			roundControls();
			loadDonors();

			btnSave.Enabled = false;
			pbxProfile.Focus();
		}

		private void DonorProfile_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		public void roundControls()
		{
			pProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pProfile.Width, pProfile.Height, 20, 20));
			pbxProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxProfile.Width, pbxProfile.Height, 20, 20));
		}

		private void loadDonors()
		{
			string query = @"SELECT [Email Address], Password, [First Name], [Middle Name], [Last Name], Gender, Age, Barangay, City, Province, [Contact Number], [Blood Type], Profile 
							 FROM Donors WHERE [Username] = ?";
			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			DataTable dt = db.executeQuery(query, parameters);

			DataRow row = dt.Rows[0];
			donorEmail = dt.Rows[0]["Email Address"].ToString();
			tbxEmail.Text = donorEmail;
			tbxPassword.Text = "●●●●●●●●";
			tbxName.Text = string.IsNullOrEmpty(row["Middle Name"].ToString()) ? $"{row["First Name"]} {row["Last Name"]}" : $"{row["First Name"]} {row["Middle Name"]} {row["Last Name"]}";
			tbxGender.Text = row["Gender"].ToString();
			tbxAge.Text = row["Age"].ToString();
			tbxHomeAddress.Text = $"{row["Barangay"]}, {row["City"]}, {row["Province"]}";
			tbxNumber.Text = row["Contact Number"].ToString();
			tbxBType.Text = row["Blood Type"].ToString();

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
			tbxGender.Enabled = true;
			tbxAge.Enabled = true;
			tbxHomeAddress.Enabled = true;
			tbxNumber.Enabled = true;

			anyChanges = false;
			btnSave.Enabled = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string email = tbxEmail.Text.Trim();
			string password = tbxPassword.Text.Trim();
			string gender = tbxGender.Text.Trim();
			string ageDonor = tbxAge.Text.Trim();
			string contactNumber = tbxNumber.Text.Trim();
			string[] addressParts = tbxHomeAddress.Text.Split(',');

			if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(ageDonor) || string.IsNullOrWhiteSpace(contactNumber) ||
				string.IsNullOrWhiteSpace(tbxHomeAddress.Text))
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

			if (gender.ToLower() != "male" && gender.ToLower() != "female")
				errors.Add("Sex must be Male or Female.");

			if (!ExceptionHandling.validAge(ageDonor, out int age))
				errors.Add("Invalid age.");

			if (!ExceptionHandling.validContactNumber(contactNumber))
				errors.Add("Invalid contact number.");

			if (addressParts.Length < 3)
				errors.Add("Invalid address (Barangay, City, Province).");

			if (errors.Count > 0)
			{
				MessageBox.Show(string.Join("\n", errors), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string barangay = addressParts[0].Trim();
			string city = addressParts[1].Trim();
			string province = addressParts[2].Trim();

			string hashedPassword = string.Empty;
			if (!password.Contains("●"))
			{
				hashedPassword = db.hashPassword(password);
			}

			string query = @"UPDATE Donors SET [Email Address] = ?, [Gender] = ?, [Age] = ?, Barangay = ?, City = ?, Province = ?, [Contact Number] = ?";

			if (!string.IsNullOrEmpty(hashedPassword))
			{
				query += ", [Password] = ?";
			}
			query += " WHERE [Username] = ?";

			List<OleDbParameter> parameters = new List<OleDbParameter>
			{
				new OleDbParameter("?", email),
				new OleDbParameter("?", gender),
				new OleDbParameter("?", age),
				new OleDbParameter("?", barangay),
				new OleDbParameter("?", city),
				new OleDbParameter("?", province),
				new OleDbParameter("?", contactNumber),
				new OleDbParameter("?", UserLogs.Username)
			};

			if (!string.IsNullOrEmpty(hashedPassword))
			{
				parameters.Insert(1, new OleDbParameter("?", hashedPassword));
			}

			if (db.executeNonQuery(query, parameters.ToArray()))
			{
				MessageBox.Show("Donor information updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				tbxEmail.Enabled = false;
				tbxPassword.Enabled = false;
				tbxGender.Enabled = false;
				tbxAge.Enabled = false;
				tbxHomeAddress.Enabled = false;
				tbxNumber.Enabled = false;

				btnSave.Enabled = false;
				pbxProfile.Focus();
			}
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

						string query = "UPDATE Donors SET Profile = ? WHERE [Username] = ?";
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
			Donor donor = new Donor();
			bool deleteAccount = donor.deleteDonorAccount(db);

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

		private void tbxGender_TextChanged(object sender, EventArgs e)
		{
			anyChanges = true;
			btnSave.Enabled = true;
		}

		private void tbxAge_TextChanged(object sender, EventArgs e)
		{
			anyChanges = true;
			btnSave.Enabled = true;
		}

		private void tbxHomeAddress_TextChanged(object sender, EventArgs e)
		{
			anyChanges = true;
			btnSave.Enabled = true;
		}

		private void tbxNumber_TextChanged(object sender, EventArgs e)
		{
			anyChanges = true;
			btnSave.Enabled = true;
		}
	}
}
