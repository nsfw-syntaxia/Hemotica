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
							 FROM Donors WHERE [Username] = @Username";
			OleDbParameter[] parameters = { new OleDbParameter("@Username", Accounts.Username) };
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
			tbxAge.Enabled = true;
			tbxHomeAddress.Enabled = true;
			tbxNumber.Enabled = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string email = tbxEmail.Text.Trim();
			string password = tbxPassword.Text.Trim();
			string ageDonor = tbxAge.Text.Trim();
			string contactNumber = tbxNumber.Text.Trim();
			string[] addressParts = tbxHomeAddress.Text.Split(',');

			if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(ageDonor) || string.IsNullOrWhiteSpace(contactNumber) || string.IsNullOrWhiteSpace(tbxHomeAddress.Text))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			List<string> errors = new List<string>();

			if (!validEmail(email))
				errors.Add("Invalid email address.");

			if (db.userExists("EmailAddress", email))
				errors.Add("Email address already exists.");

			if (!int.TryParse(ageDonor, out int age) || age < 1 || age > 120)
				errors.Add("Invalid age.");

			if (!validPhoneNumber(contactNumber))
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
			string hashedPassword = db.hashPassword(password);

			string query = @"UPDATE Donors SET [Email Address] = ?, [Password] = ?, Age = ?, Barangay = ?, City = ?, Province = ?, [Contact Number] = ? WHERE [Username] = ?";

			OleDbParameter[] parameters =
			{
				new OleDbParameter("?", email),
				new OleDbParameter("?", hashedPassword),
				new OleDbParameter("?", age),
				new OleDbParameter("?", barangay),
				new OleDbParameter("?", city),
				new OleDbParameter("?", province),
				new OleDbParameter("?", contactNumber),
				new OleDbParameter("?", Accounts.Username)
			};

			if (db.executeNonQuery(query, parameters))
			{
				MessageBox.Show("Donor information updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbxEmail.Enabled = false;
				tbxPassword.Enabled = false;
				tbxAge.Enabled = false;
				tbxHomeAddress.Enabled = false;
				tbxNumber.Enabled = false;
			}
		}

		private bool validEmail(string email)
		{
			string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
			return Regex.IsMatch(email, pattern);
		}

		private bool validPhoneNumber(string number)
		{
			return Regex.IsMatch(number, @"^(\(\d{3}\) \d{3}-\d{4}|\d{10,15})$");
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
							new OleDbParameter("?", Accounts.Username)
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
	}
}
