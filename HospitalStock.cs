using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Hemotica
{
	public partial class HospitalStock : UserControl
	{
		Database db = new Database();
		Hospital hospital = new Hospital();

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		private string title, description, date, time, city, barangay;
		private Image addPhoto;
		private byte[] imageBytes = null;

		public HospitalStock()
		{
			InitializeComponent();
		}

		private void HospitalStock_Load(object sender, EventArgs e)
		{
			loadStock();
			roundControls();

			pImage.Visible = false;
			addPhoto = pbxPhoto.Image;
		}

		private void loadStock()
		{
			dgvStock.Columns.Clear();
			dgvStock.Rows.Clear();

			dgvStock.Columns.Add("BloodType", "Blood Type");
			dgvStock.Columns.Add("Unit", "Blood Bag/s");

			string[] bloodTypes = { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" };

			foreach (string type in bloodTypes)
			{
				dgvStock.Rows.Add(type, "0");
			}

			DataTable dt = hospital.loadStock(db);

			if (dt != null)
			{
				foreach (DataRow row in dt.Rows)
				{
					string type = row["Blood Type"].ToString();
					int unit = Convert.ToInt32(row["Unit"]);

					foreach (DataGridViewRow dgvRow in dgvStock.Rows)
					{
						if (dgvRow.Cells["BloodType"].Value.ToString() == type)
						{
							dgvRow.Cells["Unit"].Value = unit.ToString();
							break;
						}
					}
				}
			}

			List<string> lowStock = new List<string>();
			foreach (DataGridViewRow row in dgvStock.Rows)
			{
				int unit = int.Parse(row.Cells["Unit"].Value.ToString());
				if (unit <= 3)
				{
					lowStock.Add(row.Cells["BloodType"].Value.ToString());
				}
			}

			if (lowStock.Count > 0)
			{
				lblWarning.Visible = true;
				lblNote.Visible = true;

				string bloodLowStock = string.Join(", ", lowStock);
				lblNote.Text = $"ATTENTION: Blood types {bloodLowStock} are low in stock or unavailable.\n\n" +
							   $"Kindly organize a blood donation drive to support the ongoing maintenance of the supply, readiness for emergencies, and the means to save lives.";

				lblNote.Width = 468;
				lblNote.MaximumSize = new Size(468, 0);
			}
			else
			{
				lblWarning.Visible = false;
				lblNote.Visible = false;
				lblWarning.Text = string.Empty;
			}
		}

		public void roundControls()
		{
			pPost.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pPost.Width, pPost.Height, 20, 20));
			pImage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pImage.Width, pImage.Height, 20, 20));
		}

		private void HospitalStock_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (!isValid())
				return;

			title = tbxTitle.Text.Trim();
			description = tbxDescription.Text.Replace(Environment.NewLine, " ").Trim();
			date = tbxDate.Text.Trim();
			time = tbxTime.Text.Trim();
			city = cmbxCity.SelectedItem?.ToString();
			barangay = cmbxBarangay.SelectedItem?.ToString();

			pPost.Visible = false;
			pImage.Visible = true;
		}

		private bool isValid()
		{
			List<string> errors = new List<string>();

			if (string.IsNullOrWhiteSpace(tbxTitle.Text) || string.IsNullOrWhiteSpace(tbxDate.Text) || string.IsNullOrWhiteSpace(tbxTime.Text) ||
				string.IsNullOrWhiteSpace(cmbxCity.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(cmbxBarangay.SelectedItem?.ToString()) ||
				cmbxCity.SelectedIndex == 0)
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (!DateTime.TryParseExact(tbxDate.Text.Trim(), "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
			{
				errors.Add("Invalid date.");
			}

			if (!TimeSpan.TryParseExact(tbxTime.Text.Trim(), "hh\\:mm", null, out TimeSpan time) || time.Hours > 23 || time.Minutes > 59)
			{
				errors.Add("Invalid time.");
			}

			if (errors.Count > 0)
			{
				MessageBox.Show(string.Join("\n", errors), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}


		private void btnBack_Click(object sender, EventArgs e)
		{
			pImage.Visible = false;
			pPost.Visible = true;

			tbxTitle.Text = title;
			tbxDescription.Text = description;
			tbxDate.Text = date;
			tbxTime.Text = time;
			cmbxCity.SelectedItem = city;

			if (!string.IsNullOrEmpty(city))
			{
				loadBarangays(city);
			}
		}

		private void tbxDescription_Enter(object sender, EventArgs e)
		{
			if (tbxDescription.Text == "Description")
				tbxDescription.Text = "";
		}

		private void tbxDescription_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxDescription.Text))
				tbxDescription.Text = "Description";
		}

		private void tbxDate_Enter(object sender, EventArgs e)
		{
			if (tbxDate.Text == "MM/DD/YYYY")
				tbxDate.Text = "";
		}

		private void tbxDate_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxDate.Text))
				tbxDate.Text = "MM/DD/YYYY";
		}

		private void tbxTime_Enter(object sender, EventArgs e)
		{
			if (tbxTime.Text == "HH:MM (24H FORMAT)")
				tbxTime.Text = "";
		}

		private void tbxTime_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbxTime.Text))
				tbxTime.Text = "HH:MM (24H FORMAT)";
		}

		private void cmbxCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedCity = cmbxCity.SelectedItem?.ToString();

			if (!string.IsNullOrEmpty(selectedCity))
			{
				loadBarangays(selectedCity);
			}
		}

		private void loadBarangays(string city)
		{
			if (string.IsNullOrWhiteSpace(city)) return;

			string query = "SELECT Barangay FROM Address WHERE City = ? ORDER BY Barangay ASC";

			OleDbParameter[] parameters = { new OleDbParameter("?", city) };
			DataTable barangayData = db.executeQuery(query, parameters);

			cmbxBarangay.Items.Clear();

			if (barangayData != null && barangayData.Rows.Count > 0)
			{
				foreach (DataRow row in barangayData.Rows)
				{
					cmbxBarangay.Items.Add(row["Barangay"].ToString());
				}

				if (barangay != null && cmbxBarangay.Items.Contains(barangay))
				{
					cmbxBarangay.SelectedItem = barangay;
				}
				else
				{
					cmbxBarangay.SelectedIndex = 0;
				}
			}
		}

		private void btnAttach_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files | *.jpg; *.jpeg; *.png";
				openFileDialog.Title = "";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						pbxPhoto.Image = new Bitmap(openFileDialog.FileName);

						using (MemoryStream ms = new MemoryStream())
						{
							pbxPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
							imageBytes = ms.ToArray();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			pbxPhoto.Image = addPhoto;
			imageBytes = null;
		}

		private void btnPost_Click(object sender, EventArgs e)
		{
			string datetime = $"{date} {time}:00";
			string province = "Cebu";

			string query = @"INSERT INTO [Blood Drives] ([Hospital], [Title], [Description], [Date and Time], [Barangay], [City], [Province], [Image]) 
							 VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

			try
			{
				using (OleDbConnection conn = db.getConnection())
				{
					using (OleDbCommand cmd = new OleDbCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("?", UserLogs.Username);
						cmd.Parameters.AddWithValue("?", title);
						cmd.Parameters.AddWithValue("?", description);
						cmd.Parameters.AddWithValue("?", datetime);
						cmd.Parameters.AddWithValue("?", barangay);
						cmd.Parameters.AddWithValue("?", city);
						cmd.Parameters.AddWithValue("?", province);

						if (imageBytes != null)
						{
							cmd.Parameters.Add("?", OleDbType.VarBinary).Value = imageBytes;
						}
						else
						{
							cmd.Parameters.Add("?", OleDbType.VarBinary).Value = DBNull.Value;
						}

						conn.Open();
						cmd.ExecuteNonQuery();
						conn.Close();

						MessageBox.Show("Blood donation drive successfully posted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// send an email notification to all donors within the baragay

						clearInputs();
						pImage.Visible = false;
						pPost.Visible = true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void clearInputs()
		{
			tbxTitle.Clear();
			tbxDescription.Text = "Description";
			tbxDate.Text = "MM/DD/YYYY";
			tbxTime.Text = "HH:MM (24H FORMAT)";
			cmbxCity.SelectedIndex = 0;
			cmbxBarangay.Items.Clear();
			pbxPhoto.Image = addPhoto;
			imageBytes = null;

			title = description = date = time = city = barangay = string.Empty;
		}
	}
}
